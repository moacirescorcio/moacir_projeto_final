#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using democsharp.Models;
using projeto_final.Models;

namespace projeto_final.Controllers
{
    public class PagamentoComChequeController : Controller
    {
        private readonly MyDbContext _context;

        public PagamentoComChequeController(MyDbContext context)
        {
            _context = context;
        }

        // GET: PagamentoComCheque
        public async Task<IActionResult> Index()
        {
            return View(await _context.PagamentoComChque.ToListAsync());
        }

        // GET: PagamentoComCheque/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamentoComCheque = await _context.PagamentoComChque
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (pagamentoComCheque == null)
            {
                return NotFound();
            }

            return View(pagamentoComCheque);
        }

        // GET: PagamentoComCheque/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PagamentoComCheque/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Banco,NomeDoBanco,ProdutoId,NomeDoCobrado,InformacoesAdicionais")] PagamentoComCheque pagamentoComCheque)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pagamentoComCheque);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pagamentoComCheque);
        }

        // GET: PagamentoComCheque/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamentoComCheque = await _context.PagamentoComChque.FindAsync(id);
            if (pagamentoComCheque == null)
            {
                return NotFound();
            }
            return View(pagamentoComCheque);
        }

        // POST: PagamentoComCheque/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Banco,NomeDoBanco,ProdutoId,NomeDoCobrado,InformacoesAdicionais")] PagamentoComCheque pagamentoComCheque)
        {
            if (id != pagamentoComCheque.ProdutoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pagamentoComCheque);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PagamentoComChequeExists(pagamentoComCheque.ProdutoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pagamentoComCheque);
        }

        // GET: PagamentoComCheque/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamentoComCheque = await _context.PagamentoComChque
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (pagamentoComCheque == null)
            {
                return NotFound();
            }

            return View(pagamentoComCheque);
        }

        // POST: PagamentoComCheque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pagamentoComCheque = await _context.PagamentoComChque.FindAsync(id);
            _context.PagamentoComChque.Remove(pagamentoComCheque);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PagamentoComChequeExists(int id)
        {
            return _context.PagamentoComChque.Any(e => e.ProdutoId == id);
        }
    }
}
