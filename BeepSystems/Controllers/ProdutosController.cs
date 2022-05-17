using BeepSystems.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BeepSystems.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ContextoP _contextoP;

        public ProdutosController(ContextoP contextoP)
        {
            _contextoP = contextoP;
        }
        public async Task<IActionResult> Produto()
        {
            return View(await _contextoP.Produtos.ToListAsync());
        }
        [HttpGet]
        public IActionResult CriarProduto()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CriarProduto(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _contextoP.Add(produto);
                await _contextoP.SaveChangesAsync();
                return RedirectToAction(nameof(Produto));
            }
            else return View(produto);
        }
        [HttpGet]
        public IActionResult AtualizarProduto(int? id)
        {
            if (id != null)
            {
                Produto produto = _contextoP.Produtos.Find(id);
                return View(produto);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AtualizarProduto(int? id, Produto produto)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contextoP.Update(produto);
                    await _contextoP.SaveChangesAsync();
                    return RedirectToAction(nameof(Produto));
                }
                else return View(produto);
            }
            else return NotFound();
        }
        [HttpGet]
        public IActionResult ExcluirProduto(int? id)
        {
            if (id != null)
            {
                Produto produto = _contextoP.Produtos.Find(id);
                return View(produto);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> ExcluirProduto(int? id, Produto produto)
        {
            if (id != null)
            {
                _contextoP.Remove(produto);
                await _contextoP.SaveChangesAsync();
                return RedirectToAction(nameof(Produto));
            }
            else return NotFound();
        }
    }
}
