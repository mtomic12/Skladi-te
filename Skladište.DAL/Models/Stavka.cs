using Skladište.DAL.Models.Bazno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skladište.DAL.Models;

public class Stavka : BazniModel
{
    public string? Ime { get; set; }
    public string? Opis { get; set; }
    public int Količina { get; set; }

    public virtual Kategorija? Kategorija { get; set; }
    public long KategorijaId { get; set; }
}
