using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skladište.Business.Validatori;
using Skladište.DAL.Context;
using Skladište.DAL.Models;
using Skladište.Shared.BindingModel;

namespace Skladište.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorijaController : ControllerBase
    {
        private readonly SkladišteDbContext _dbContext;
        private KategorijaValidator _kategorijaValidator;
        public KategorijaController(SkladišteDbContext dbContext)
        {
            _kategorijaValidator= new KategorijaValidator();
            _dbContext = dbContext;
        }

        [HttpPost("dodaj")]
        public IActionResult Dodaj([FromBody]KategorijaBM kategorijaBM)
        {
            try 
            {
                _kategorijaValidator.Validate(kategorijaBM);

                var kategorija = new Kategorija
                {
                    Ime = kategorijaBM.Naziv,
                    Opis = kategorijaBM.Opis,
                    Kreirao = "abc",
                    DatumKreiranja = DateTime.Now,
                    NadKategorijaId = kategorijaBM.NadkategorijaId
                };

                _dbContext.Kategorija.Add(kategorija);
                _dbContext.SaveChanges();

                return Ok(kategorijaBM);
            }
            catch (Exception ex) 
            {
            return BadRequest(ex.Message);
            }
           
        }


        [HttpGet("DohvatiKategorije")]
        public IActionResult DohvatiKategorije()
        {
            try
            {
                var kategorije = _dbContext.Kategorija.Include(x => x.NadKategorija).ToList();
                var kategorijeBMs = kategorije.Select(x => new KategorijaBM
                {
                    Id = x.Id,
                    NadkategorijaId = x.NadKategorijaId,
                    Naziv = x.Ime,
                    Opis = x.Opis,
                    NadkategorijaNaziv = x.NadKategorija?.Ime,
                    DatumKreiranja = x.DatumKreiranja,
                    Kreirao = x.Kreirao
                }).ToList();

                return Ok(kategorijeBMs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
