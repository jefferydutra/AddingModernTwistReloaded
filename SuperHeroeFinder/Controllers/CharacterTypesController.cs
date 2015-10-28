using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MarvelCharacterService.Models;

namespace SuperHeroeFinder.Controllers
{
    public class CharacterTypesController : ApiController
    {
        private readonly SuperHeroContext _db = new SuperHeroContext();

        // GET: api/CharacterTypes
        public async Task<IHttpActionResult> GetCharacterTypes()
        {
            return Ok(_db.CharacterTypes);
        }

        // GET: api/CharacterTypes/5
        [ResponseType(typeof(CharacterType))]
        public async Task<IHttpActionResult> GetCharacterType(int id)
        {
            CharacterType characterType = await _db.CharacterTypes.FindAsync(id);
            if (characterType == null)
            {
                return NotFound();
            }

            return Ok(characterType);
        }

        // PUT: api/CharacterTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCharacterType(int id, CharacterType characterType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != characterType.Id)
            {
                return BadRequest();
            }

            _db.Entry(characterType).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CharacterTypes
        [ResponseType(typeof(CharacterType))]
        public async Task<IHttpActionResult> PostCharacterType(CharacterType characterType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.CharacterTypes.Add(characterType);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = characterType.Id }, characterType);
        }

        // DELETE: api/CharacterTypes/5
        [ResponseType(typeof(CharacterType))]
        public async Task<IHttpActionResult> DeleteCharacterType(int id)
        {
            CharacterType characterType = await _db.CharacterTypes.FindAsync(id);
            if (characterType == null)
            {
                return NotFound();
            }

            _db.CharacterTypes.Remove(characterType);
            await _db.SaveChangesAsync();

            return Ok(characterType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CharacterTypeExists(int id)
        {
            return _db.CharacterTypes.Count(e => e.Id == id) > 0;
        }
    }
}