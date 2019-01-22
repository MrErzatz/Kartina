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
    public class PhotosController : Controller
    {
        private readonly Kartina_V2Context _context;

        public PhotosController(Kartina_V2Context context)
        {
            _context = context;
        }

        // GET: Photos
        public async Task<IActionResult> Index()
        {
            var kartina_V2Context = _context.Photo.Include(p => p.IdOrientationNavigation).Include(p => p.IdUtilisateurNavigation);
            return View(await kartina_V2Context.ToListAsync());
        }

        // GET: Photos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photo
                .Include(p => p.IdOrientationNavigation)
                .Include(p => p.IdUtilisateurNavigation)
                .FirstOrDefaultAsync(m => m.IdPhoto == id);
            if (photo == null)
            {
                return NotFound();
            }

            return View(photo);
        }

        // GET: Photos/Create
        public IActionResult Create()
        {
            ViewData["IdOrientation"] = new SelectList(_context.Orientation, "IdOrientation", "NomOrientation");
            ViewData["IdUtilisateur"] = new SelectList(_context.Utilisateur, "IdUtilisateur", "IdUtilisateur");
            return View();
        }

        // POST: Photos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPhoto,IdFormat,IdTheme,TitrePhoto,DescriptionPhoto,PrixPhoto,LargeurPhoto,HauteurPhoto,IdUtilisateur,IdOrientation,DateDepose")] Photo photo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(photo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdOrientation"] = new SelectList(_context.Orientation, "IdOrientation", "NomOrientation", photo.IdOrientation);
            ViewData["IdUtilisateur"] = new SelectList(_context.Utilisateur, "IdUtilisateur", "IdUtilisateur", photo.IdUtilisateur);
            return View(photo);
        }

        // GET: Photos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photo.FindAsync(id);
            if (photo == null)
            {
                return NotFound();
            }
            ViewData["IdOrientation"] = new SelectList(_context.Orientation, "IdOrientation", "NomOrientation", photo.IdOrientation);
            ViewData["IdUtilisateur"] = new SelectList(_context.Utilisateur, "IdUtilisateur", "IdUtilisateur", photo.IdUtilisateur);
            return View(photo);
        }

        // POST: Photos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPhoto,IdFormat,IdTheme,TitrePhoto,DescriptionPhoto,PrixPhoto,LargeurPhoto,HauteurPhoto,IdUtilisateur,IdOrientation,DateDepose")] Photo photo)
        {
            if (id != photo.IdPhoto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(photo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotoExists(photo.IdPhoto))
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
            ViewData["IdOrientation"] = new SelectList(_context.Orientation, "IdOrientation", "NomOrientation", photo.IdOrientation);
            ViewData["IdUtilisateur"] = new SelectList(_context.Utilisateur, "IdUtilisateur", "IdUtilisateur", photo.IdUtilisateur);
            return View(photo);
        }

        // GET: Photos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photo
                .Include(p => p.IdOrientationNavigation)
                .Include(p => p.IdUtilisateurNavigation)
                .FirstOrDefaultAsync(m => m.IdPhoto == id);
            if (photo == null)
            {
                return NotFound();
            }

            return View(photo);
        }

        // POST: Photos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var photo = await _context.Photo.FindAsync(id);
            _context.Photo.Remove(photo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotoExists(int id)
        {
            return _context.Photo.Any(e => e.IdPhoto == id);
        }
    }
}
