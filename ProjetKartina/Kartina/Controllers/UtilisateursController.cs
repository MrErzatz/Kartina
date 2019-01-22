using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kartina.Models;

namespace Kartina.Controllers
{
    public class UtilisateursController : Controller
    {
        private readonly Kartina_V2Context _context;

        public UtilisateursController(Kartina_V2Context context)
        {
            _context = context;
        }

        // GET: Utilisateurs
        public async Task<IActionResult> Index()
        {
            //var kartina_V2Context = _context.Utilisateur.Include(u => u.IdAdresseNavigation).Include(u => u.IdProfilUtilisateurNavigation);
            return View();
        }

        // GET: Utilisateurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilisateur = await _context.Utilisateur
                .Include(u => u.IdAdresseNavigation)
                .Include(u => u.IdProfilUtilisateurNavigation)
                .FirstOrDefaultAsync(m => m.IdUtilisateur == id);
            if (utilisateur == null)
            {
                return NotFound();
            }

            return View(utilisateur);
        }

        // GET: Utilisateurs/Create
        public IActionResult Create()
        {
            ViewData["IdAdresse"] = new SelectList(_context.Adresse, "IdAdresse", "IdAdresse");
            ViewData["IdProfilUtilisateur"] = new SelectList(_context.ProfilUtilisateur, "IdProfilUtilisateur", "TypeProfil");
            return View();
        }

        // POST: Utilisateurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUtilisateur,Nom,Prenom,Description,Email,MotPass,Civilité,Telephone,IdProfilUtilisateur,IdAdresse")] Utilisateur utilisateur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utilisateur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAdresse"] = new SelectList(_context.Adresse, "IdAdresse", "IdAdresse", utilisateur.IdAdresse);
            ViewData["IdProfilUtilisateur"] = new SelectList(_context.ProfilUtilisateur, "IdProfilUtilisateur", "TypeProfil", utilisateur.IdProfilUtilisateur);
            return View(utilisateur);
        }

        // GET: Utilisateurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilisateur = await _context.Utilisateur.FindAsync(id);
            if (utilisateur == null)
            {
                return NotFound();
            }
            ViewData["IdAdresse"] = new SelectList(_context.Adresse, "IdAdresse", "IdAdresse", utilisateur.IdAdresse);
            ViewData["IdProfilUtilisateur"] = new SelectList(_context.ProfilUtilisateur, "IdProfilUtilisateur", "TypeProfil", utilisateur.IdProfilUtilisateur);
            return View(utilisateur);
        }

        // POST: Utilisateurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUtilisateur,Nom,Prenom,Description,Email,MotPass,Civilité,Telephone,IdProfilUtilisateur,IdAdresse")] Utilisateur utilisateur)
        {
            if (id != utilisateur.IdUtilisateur)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utilisateur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtilisateurExists(utilisateur.IdUtilisateur))
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
            ViewData["IdAdresse"] = new SelectList(_context.Adresse, "IdAdresse", "IdAdresse", utilisateur.IdAdresse);
            ViewData["IdProfilUtilisateur"] = new SelectList(_context.ProfilUtilisateur, "IdProfilUtilisateur", "TypeProfil", utilisateur.IdProfilUtilisateur);
            return View(utilisateur);
        }

        // GET: Utilisateurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilisateur = await _context.Utilisateur
                .Include(u => u.IdAdresseNavigation)
                .Include(u => u.IdProfilUtilisateurNavigation)
                .FirstOrDefaultAsync(m => m.IdUtilisateur == id);
            if (utilisateur == null)
            {
                return NotFound();
            }

            return View(utilisateur);
        }

        // POST: Utilisateurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utilisateur = await _context.Utilisateur.FindAsync(id);
            _context.Utilisateur.Remove(utilisateur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtilisateurExists(int id)
        {
            return _context.Utilisateur.Any(e => e.IdUtilisateur == id);
        }

        // GET: Utilisateurs
        public IActionResult Utilisateurs()
        {
            //var kartina_V2Context = _context.Utilisateur.Include(u => u.IdAdresseNavigation).Include(u => u.IdProfilUtilisateurNavigation);
            return View();
        }

    }

}
