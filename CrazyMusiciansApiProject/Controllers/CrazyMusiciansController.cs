using CrazyMusiciansApiProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusiciansApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrazyMusiciansController : ControllerBase
    {
        private static readonly List<Musician> CrazyMusicians = new List<Musician>()
        {
            new Musician(){ Id = 1, Name= "Ahmet Çalgı", Profession = "Famous Instrument Player", FunTrait = "Always plays the wrong note, but it's so much fun"},
            new Musician(){ Id = 2, Name = "Zeynep Melodi", Profession = "Popular Melody Writer", FunTrait = "Her songs are misunderstood but very popular"},
            new Musician(){ Id = 3, Name = "Cemil Akor", Profession = "Crazy Accordist", FunTrait = "Changes chords often, but surprisingly talented"},
            new Musician(){ Id = 4, Name = "Fatma Nota", Profession = "Surprise Note Generator", FunTrait = "Constantly prepares surprises while producing notes"},
            new Musician(){ Id = 5, Name = "Hasan Ritim", Profession = "Rhythm Monster", FunTrait = "He makes each beat in his own way, it never fits, but it's funny"},
            new Musician(){ Id = 6, Name = "Elif Armoni", Profession = "Master of Harmony", FunTrait = "She sometimes plays harmonies wrong, but he is very creative"},
            new Musician(){ Id = 7, Name = "Ali Perde", Profession = "Fret Applicator", FunTrait = "Plays every fret differently, always surprising"},
            new Musician(){ Id = 8, Name = "Ayşe Rezonans", Profession = "Resonance Expert", FunTrait = "Specializes in resonance, but sometimes makes a lot of noise"},
            new Musician(){ Id = 9, Name = "Murat Ton", Profession = "Intonation Enthusiast", FunTrait = "The differences in intonation are sometimes funny, but quite interesting"},
            new Musician(){ Id = 10, Name = "Selin Akor", Profession = "Chord Wizard", FunTrait = "When she change chords, sometimes it creates a magical atmosphere"}


        };

        [HttpGet]
        public ActionResult<IEnumerable<Musician>> Get()
        {
            return Ok(CrazyMusicians);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var musician = CrazyMusicians.FirstOrDefault(x => x.Id == id);
            if (musician is null)
            {
                return NotFound();

            }
            return Ok(musician);
        }

        [HttpGet("search")]
        public ActionResult<IEnumerable<Musician>> Search([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest();
            }
            var result = CrazyMusicians.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            if (!result.Any())
            {
                return NotFound();
            }
            return Ok();

        }

        [HttpPost]
        public ActionResult<Musician> Post([FromBody] Musician musician)
        {
            musician.Id = CrazyMusicians.Max(x => x.Id) + 1;
            CrazyMusicians.Add(musician);
            return CreatedAtAction(nameof(Get), new { id = musician.Id }, musician);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Musician updatedMusician)
        {
            var musician = CrazyMusicians.FirstOrDefault(x => x.Id == id);
            if (musician is null)
            {
                return NotFound();
            }
            musician.Name = updatedMusician.Name;
            musician.Profession = updatedMusician.Profession;
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var musician = CrazyMusicians.FirstOrDefault(x => x.Id == id);
            if (musician is null)
            {
                return NotFound();

            }
            CrazyMusicians.Remove(musician);
            return NoContent();
        }


    }
}