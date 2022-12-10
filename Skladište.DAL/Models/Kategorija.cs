using Skladište.DAL.Models.Bazno;
using System.ComponentModel.DataAnnotations;

namespace Skladište.DAL.Models;

public class Kategorija : BazniModel
{
    [Required, StringLength(100)]
    public string? Ime { get; set; }

    [Required]
    public string? Opis { get; set; }

    public virtual Kategorija? NadKategorija { get; set; }
    public long? NadKategorijaId { get; set; }

    public virtual ICollection<Stavka>? Stavke { get; set; }

}
