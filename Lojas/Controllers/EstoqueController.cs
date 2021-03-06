using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lojas.Data;
using Lojas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lojas.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly LojasContext _context;

        public EstoqueController (LojasContext context)
        {
            _context = context;
        }

        // GET: Estoque
        public async Task<IActionResult> Index ()
        {
            var lojasContext = _context.Estoque.Include (e => e.Loja).Include (e => e.Produto);
            return View (await lojasContext.ToListAsync ());
        }

        // GET: Estoque/Create
        public IActionResult Create ()
        {
            ViewData["LojaId"] = new SelectList (_context.Loja, "Id", "Nome");
            ViewData["ProdutoId"] = new SelectList (_context.Produto, "Id", "Nome");
            return View ();
        }

        // POST: Estoque/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind ("Id,Quantidade,LojaId,ProdutoId")] Estoque estoque)
        {
            if (ModelState.IsValid)
            {
                _context.Add (estoque);
                await _context.SaveChangesAsync ();
                return RedirectToAction (nameof (Index));
            }
            ViewData["LojaId"] = new SelectList (_context.Loja, "Id", "Nome", estoque.LojaId);
            ViewData["ProdutoId"] = new SelectList (_context.Produto, "Id", "Nome", estoque.ProdutoId);
            return View (estoque);
        }

        // GET: Estoque/Edit/5
        public async Task<IActionResult> Edit (int? id)
        {
            if (id == null)
            {
                return NotFound ();
            }

            var estoque = await _context.Estoque.FindAsync (id);
            if (estoque == null)
            {
                return NotFound ();
            }
            ViewData["LojaId"] = new SelectList (_context.Loja, "Id", "Nome", estoque.LojaId);
            ViewData["ProdutoId"] = new SelectList (_context.Produto, "Id", "Nome", estoque.ProdutoId);
            return View (estoque);
        }

        // POST: Estoque/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, [Bind ("Id,Quantidade,LojaId,ProdutoId")] Estoque estoque)
        {
            if (id != estoque.Id)
            {
                return NotFound ();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update (estoque);
                    await _context.SaveChangesAsync ();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstoqueExists (estoque.Id))
                    {
                        return NotFound ();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction (nameof (Index));
            }
            ViewData["LojaId"] = new SelectList (_context.Loja, "Id", "Nome", estoque.LojaId);
            ViewData["ProdutoId"] = new SelectList (_context.Produto, "Id", "Nome", estoque.ProdutoId);
            return View (estoque);
        }

        // GET: Estoque/Delete/5
        public async Task<IActionResult> Delete (int? id)
        {
            if (id == null)
            {
                return NotFound ();
            }

            var estoque = await _context.Estoque
                .Include (e => e.Loja)
                .Include (e => e.Produto)
                .FirstOrDefaultAsync (m => m.Id == id);
            if (estoque == null)
            {
                return NotFound ();
            }

            return View (estoque);
        }

        // POST: Estoque/Delete/5
        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (int id)
        {
            var estoque = await _context.Estoque.FindAsync (id);
            _context.Estoque.Remove (estoque);
            await _context.SaveChangesAsync ();
            return RedirectToAction (nameof (Index));
        }

        private bool EstoqueExists (int id)
        {
            return _context.Estoque.Any (e => e.Id == id);
        }
    }
}