using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skladište.Shared.DataTransferObject;

public class KategorijaDTO
{
    public long? Id { get; set; }
    public string? Naziv { get; set; }
    public string? Opis { get; set; }

    public long? NadkategorijaId { get; set; }
}
