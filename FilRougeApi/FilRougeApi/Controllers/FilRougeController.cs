using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilRougeApi.Models;

namespace FilRougeApi.Controllers
{
  [Route("api/FilRouge")]
    [ApiController]
    public class FilRougeController : ControllerBase
    {
        private readonly FilRougeContext _context;

        public FilRougeController(FilRougeContext context)
        {
            _context = context;

        }
        //GET: api/FilRouge
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personne>>> GetPersonnes()
        {
            return await _context.Personnes.Include(p => p.Formations).ToListAsync();
        }
        
        //GET: api/FilRouge/5 (obtenir a partir de l'id)
        [HttpGet("{id}")]
        public async Task<ActionResult<Personne>> GetPersonne(long id)
        {
            var personne = await _context.Personnes.FindAsync(id);

            if (personne == null)
            {
                return NotFound();
            }

            return personne;
        }
        //POST: api/FilRouge
        [HttpPost]
        public ActionResult<Personne> PostPersonne(Personne personne1)
        {
            _context.Personnes.Add(new Personne { Nom = "personne1"});
            _context.SaveChanges();
            // _context.Personnes.Add(personne1);
            //await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPersonne), new { id = personne1.PersonneID }, personne1);
        }
        // PUT: api/FilRouge/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonne(long id, Personne personne1)
        {
            if (id != personne1.PersonneID)
            {
                return BadRequest();
            }

            _context.Entry(personne1).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE: api/FilRouge/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var personne = await _context.Personnes.FindAsync(id);

            if (personne == null)
            {
                return NotFound();
            }
            if (_context.Personnes.Count() == 0)//retourne rien quand on a supprimé tous les éléments
            {
                
            }
                _context.Personnes.Remove(personne);
            await _context.SaveChangesAsync();

            return NoContent();

        }

    }
}
