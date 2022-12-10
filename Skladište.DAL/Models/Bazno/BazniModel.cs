using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Skladište.DAL.Models.Bazno;

public abstract class BazniModel
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    public DateTime DatumKreiranja { get; set; }

    [Required, StringLength(100)]
    public string? Kreirao { get; set; }

    public DateTime? DatumIzmjene { get; set; }

    [StringLength(100)]
    public string? Izmijenio { get; set; }

    public DateTime? DatumBrisanja { get; set; }

}
