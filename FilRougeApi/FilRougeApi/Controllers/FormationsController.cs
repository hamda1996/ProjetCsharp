using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FilRougeApi.Models;

namespace FilRougeApi.Controllers
{
    [Route("formation")]
    public class FormationsController : Controller
    {
        private readonly FilRougeContext _context;
        

        public FormationsController(FilRougeContext context)
        {
            _context = context;
        }

        // GET: Formations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Formations.ToListAsync());
        }

        // GET: Formations/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formation = await _context.Formations
                .FirstOrDefaultAsync(m => m.FormationID == id);
            if (formation == null)
            {
                return NotFound();
            }

            return View(formation);
        }

        // GET: Formations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personnes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FormationID,PersonneID,Titre,Duree,Date_Deb")] Formation formation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formation);
        }

        // GET: Formations/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formation = await _context.Formations.FindAsync(id);
            if (formation == null)
            {
                return NotFound();
            }
            return View(formation);
        }

        // POST: Personnes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEdit(long id, [Bind("FormationID,PersonneID,Titre,Duree,Date_Deb")] Formation formation)
        {
            if (id != formation.FormationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormationExists(formation.PersonneID))
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
            return View(formation);
        }

        // GET: Formations/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formation = await _context.Formations
                .FirstOrDefaultAsync(m => m.FormationID == id);
            if (formation == null)
            {
                return NotFound();
            }

            return View(formation);
        }

        // POST: Formations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var formation = await _context.Formations.FindAsync(id);
            _context.Formations.Remove(formation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormationExists(long id)
        {
            return _context.Formations.Any(e => e.FormationID == id);
        }
    }
}