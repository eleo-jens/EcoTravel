using EcoTravel_BLL.Entities;
using EcoTravel_Common.Repositories;
using EcoTravel_MVC.Handlers;
using EcoTravel_MVC.Models.ModelViews.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository<Client, int> _service;
        private readonly IProprietaireRepository<Proprietaire, int> _proprietaireService;

        public ClientController(IClientRepository<Client, int> service, IProprietaireRepository<Proprietaire, int> proprietaireService)
        {
            _service = service;
            _proprietaireService = proprietaireService;
        }
        // GET: ClientController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            // tentative pour rediriger vers l'action proprietaire, si le client est un proprietaire (Erreur: mon Get du proprietaire service est configuré pour récupérer aussi la liste des logements, qui est vide lorsqu'il n'y a pas de propriétaire possédant cet id)

            /*
            if (_proprietaireService.Get(id).idClient == id)
            {
                return RedirectToAction("Details", "Proprietaire", new { id = id });
            }
            else
            { */
                ClientDetails model = _service.Get(id).ToDetails();
                return View(model);
            //}
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientCreateForm form)
        {
            if (!ModelState.IsValid)
            {
                form.password = null;
                form.confirmPassword = null;
                return View(form);
            }
            else
            {
                int id = _service.Insert(form.ToBLL());
                return RedirectToAction("Details", "Client", new { id = id });
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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
