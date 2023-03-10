using EcoTravel_BLL.Entities;
using EcoTravel_Common.Repositories;
using EcoTravel_MVC.Handlers;
using EcoTravel_MVC.Models.ModelViews.Logement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Controllers
{
    public class LogementController : Controller
    {
        private readonly ILogementRepository<Logement, int> _service;
        private readonly ICategorieRepository<Categorie, int> _categorieService;
        private readonly IProprietaireRepository<Proprietaire, int> _proprietaireService;
        private readonly IClientRepository<Client, int> _clientService;
        private readonly SessionManager _sessionManager;
        public LogementController(ILogementRepository<Logement, int> service, ICategorieRepository<Categorie, int> categorieService, IProprietaireRepository<Proprietaire, int> proprietaireService, IClientRepository<Client, int> clientService, SessionManager sessionManager)
        {
            _service = service;
            _categorieService = categorieService;
            _proprietaireService = proprietaireService;
            _clientService = clientService;
            _sessionManager = sessionManager; 
        }

        // GET: LogementController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LogementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogementController/Create
        public ActionResult Create()
        {
            LogementCreateForm model = new LogementCreateForm();
            return View(model);
        }

        // POST: LogementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LogementCreateForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            else
            {
                // vérifier le role de l'user: si pas encore proprietaire, il faut le rendre proprietaire
                if (_sessionManager.CurrentUser.role == "Client")
                {
                    int idUser = _sessionManager.CurrentUser.idUser;
                    Client client = _clientService.Get(idUser);
                    //je dois créer un nouveau Proprietaire: appel service proprio insert (avec les infos du client)
                    _proprietaireService.Insert(client);
                    _sessionManager.CurrentUser.role = "Proprietaire";
                }
                form.idProprietaire = _sessionManager.CurrentUser.idUser;
                int id = _service.Insert(form.ToBLL());
                return RedirectToAction("Details", "Logement", new { id = id });
            }
        }

        // GET: LogementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
