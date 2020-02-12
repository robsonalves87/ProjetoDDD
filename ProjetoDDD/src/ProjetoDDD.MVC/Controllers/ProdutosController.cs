using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Models;
using ProjetoDDD.MVC.ViewModels;

namespace ProjetoDDD.MVC.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoAppService _produtoAppService;
        private readonly ICategoriaDoProdutoAppService _categoriaDoProdutoAppService;

        public ProdutosController(IProdutoAppService produtoAppService, ICategoriaDoProdutoAppService categoriaDoProdutoAppService)
        {
            _produtoAppService = produtoAppService;
            _categoriaDoProdutoAppService = categoriaDoProdutoAppService;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var produto = _produtoAppService.BuscarTodos();
            var produtoViewModel = Mapper.Map<IList<Produto>, IList<ProdutoViewModel>>(produto);
            return View(produtoViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(Guid id)
        {
            var produto = _produtoAppService.BuscaPorId(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            return View(produtoViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaProdutoId = new SelectList(_categoriaDoProdutoAppService.ObterCategoriasDoProdutoAtivas(), "Id", "Nome");
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                var produto = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
                _produtoAppService.Incluir(produto);
                _produtoAppService.SaveChanges();
                _produtoAppService.Dispose();

                return RedirectToAction("Index");
            }

            ViewBag.CategoriaProdutoId = new SelectList(_categoriaDoProdutoAppService.ObterCategoriasDoProdutoAtivas(), "Id", "Nome");
            return View(produtoViewModel);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(Guid id)
        {
            var produto = _produtoAppService.BuscaPorId(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            ViewBag.CategoriaProdutoId = new SelectList(_categoriaDoProdutoAppService.ObterCategoriasDoProdutoAtivas(), "Id", "Nome");
            return View(produtoViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                var produto = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
                _produtoAppService.Atualizar(produto);
                _produtoAppService.SaveChanges();
                _produtoAppService.Dispose();

                return RedirectToAction("Index");
            }

            ViewBag.CategoriaProdutoId = new SelectList(_categoriaDoProdutoAppService.ObterCategoriasDoProdutoAtivas(), "Id", "Nome");
            return View(produtoViewModel);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(Guid id)
        {
            var produto = _produtoAppService.BuscaPorId(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            var produto = _produtoAppService.BuscaPorId(id);
            _produtoAppService.Excluir(produto);
            _produtoAppService.SaveChanges();
            _produtoAppService.Dispose();

            return RedirectToAction("Index");
        }
    }
}
