using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiProyectogimnasio.Data;
using MiProyectogimnasio.Models;

namespace MiProyectogimnasio.Controllers
{
    public class ClasesController : Controller
    {
        private readonly ApplicationDBContext _context;
        public ClasesController(ApplicationDBContext context)
        {
            _context = context;
        }
        // GET: ClasesController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clases.ToListAsync());
        }

        // GET: ClasesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClasesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClasesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreClase,Profesor,Horario")] Clase clase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clase);
        }

        // GET: ClasesController/Edit/5
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clase = await _context.Clases.FindAsync(id);
            if (clase == null)
            {
                return NotFound();
            }
            return View(clase);
        }

        // POST: ClasesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,NombreClase,Profesor,Horario")] Clase clase)
        {
            if (id != clase.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClaseExists(clase.Id))
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
            return View(clase);
        }

        // GET: ClasesController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clase = await _context.Clases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clase == null)
            {
                return NotFound();
            }

            return View(clase);
        }

        // POST: ClasesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var clase = await _context.Clases.FindAsync(id);
            if (clase != null)
            {
                _context.Clases.Remove(clase);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ClaseExists(int id)
        {
            return _context.Clases.Any(e => e.Id == id);
        }
    }
}
