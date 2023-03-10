using EcoTravel_Common.Repositories;
using EcoTravel_DAL.Entities;
using EcoTravel_MVC.Handlers;
using EcoTravel_MVC.Models.ModelViews.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Controllers
{
    public class AuthController : Controller
    {
        private readonly SessionManager _sessionManager;
        private readonly IClientRepository<Client, int> _clientService;
        private readonly IProprietaireRepository<Proprietaire, int> _proprietaireService;
        public AuthController(IClientRepository<Client, int> clientService, IProprietaireRepository<Proprietaire, int> proprietaireService, SessionManager sessionManager)
        {
            _clientService = clientService;
            _proprietaireService = proprietaireService;
            _sessionManager = sessionManager;
        }

        // GET: AuthController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginForm form)
        {
            if (!ModelState.IsValid) return View();
            int? id = _clientService.CheckPassword(form.email, form.password);
            if (id is null)
            {
                ViewBag.ErrorMsg = "Les identifiants ne sont pas corrects ou l'utilisateur n'existe pas";
                return View();
            }

            // Vérification du rôle (si Client ou Proprietaire pour le stocker dans currentUser)
            string role = "Client";
            if (_proprietaireService.Get((int)id) != null)
            {
                role = "Proprietaire";
            }
            CurrentUser currentUser = new CurrentUser()
            {
                idUser = (int)id,
                email = form.email,
                lastConnexion = DateTime.Now,
                role = role
            };
            _sessionManager.CurrentUser = currentUser;
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            _sessionManager.CurrentUser = null;
            return RedirectToAction("Index", "Home");
        }
    }
}
