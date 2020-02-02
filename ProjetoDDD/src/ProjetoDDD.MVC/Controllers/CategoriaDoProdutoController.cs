using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Models;
using ProjetoDDD.MVC.ViewModels;

namespace ProjetoDDD.MVC.Controllers
{
    public class CategoriaDoProdutoController : Controller
    {
        private readonly ICategoriaDoProdutoAppService _categoriaDoProdutoAppService;

        public CategoriaDoProdutoController(ICategoriaDoProdutoAppService categoriaDoProdutoAppService)
        {
            _categoriaDoProdutoAppService = categoriaDoProdutoAppService;
        }
        // GET: Clientes
        public ActionResult Index()
        {
            var categoriaDoProduto = _categoriaDoProdutoAppService.BuscarTodos();
            var categoriaDoProdutoViewModel = Mapper.Map<IList<CategoriaDoProduto>, IList<CategoriaDoProdutoViewModel>>(categoriaDoProduto);

            return View(categoriaDoProdutoViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(Guid id)
        {
            var categoriaDoProduto = _categoriaDoProdutoAppService.BuscaPorId(id);
            var categoriaDoProdutoViewModel = Mapper.Map<CategoriaDoProduto, CategoriaDoProdutoViewModel>(categoriaDoProduto);
            return View(categoriaDoProdutoViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaDoProdutoViewModel categoriaDoProdutoViewModel)
        {
            if (ModelState.IsValid)
            {
                var categoriaDoProduto = Mapper.Map<CategoriaDoProdutoViewModel, CategoriaDoProduto>(categoriaDoProdutoViewModel);
                _categoriaDoProdutoAppService.Incluir(categoriaDoProduto);
                _categoriaDoProdutoAppService.SaveChanges();
                _categoriaDoProdutoAppService.Dispose();

                return RedirectToAction("Index");
            }

            return View(categoriaDoProdutoViewModel);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(Guid id)
        {
            var categoriaDoProduto = _categoriaDoProdutoAppService.BuscaPorId(id);
            var categoriaDoProdutoViewModel = Mapper.Map<CategoriaDoProduto, CategoriaDoProdutoViewModel>(categoriaDoProduto);

            return View(categoriaDoProdutoViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaDoProdutoViewModel categoriaDoProdutoViewModel)
        {
            if (ModelState.IsValid)
            {
                var categoriaDoProduto = Mapper.Map<CategoriaDoProdutoViewModel, CategoriaDoProduto>(categoriaDoProdutoViewModel);
                _categoriaDoProdutoAppService.Atualizar(categoriaDoProduto);
                _categoriaDoProdutoAppService.SaveChanges();
                _categoriaDoProdutoAppService.Dispose();

                return RedirectToAction("Index");
            }

            return View(categoriaDoProdutoViewModel);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(Guid id)
        {
            var categoriaDoProduto = _categoriaDoProdutoAppService.BuscaPorId(id);
            var categoriaDoProdutoViewModel = Mapper.Map<CategoriaDoProduto, CategoriaDoProdutoViewModel>(categoriaDoProduto);

            return View(categoriaDoProdutoViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            var categoriaDoProduto = _categoriaDoProdutoAppService.BuscaPorId(id);
            _categoriaDoProdutoAppService.Excluir(categoriaDoProduto);
            _categoriaDoProdutoAppService.SaveChanges();
            _categoriaDoProdutoAppService.Dispose();

            return RedirectToAction("Index");
        }
    }
}
