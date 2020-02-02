using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Models;
using ProjetoDDD.MVC.ViewModels;

namespace ProjetoDDD.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteAppService;

        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var cliente = _clienteAppService.BuscarTodos();
            var clienteViewModel = Mapper.Map<IList<Cliente>, IList<ClienteViewModel>>(cliente);
            return View(clienteViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(Guid id)
        {
            var cliente = _clienteAppService.BuscaPorId(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
                _clienteAppService.Incluir(cliente);
                _clienteAppService.SaveChanges();
                _clienteAppService.Dispose();

                return RedirectToAction("Index");
            }
            return View(clienteViewModel);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(Guid id)
        {
            var cliente = _clienteAppService.BuscaPorId(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
                _clienteAppService.Atualizar(cliente);
                _clienteAppService.SaveChanges();
                _clienteAppService.Dispose();

                return RedirectToAction("Index");
            }

            return View(clienteViewModel);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(Guid id)
        {
            var cliente = _clienteAppService.BuscaPorId(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            var cliente = _clienteAppService.BuscaPorId(id);
            _clienteAppService.Excluir(cliente);
            _clienteAppService.SaveChanges();
            _clienteAppService.Dispose();

            return RedirectToAction("Index");
        }
    }
}
