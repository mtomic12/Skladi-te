using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Skladište.Shared.BindingModel;

public class KategorijaBM
{
    public long? Id { get; set; }
    public string? Naziv { get; set; }
    public string? Opis { get; set; }
    public string? Kreirao { get; set; }
    public DateTime DatumKreiranja { get; set; }

    public long? NadkategorijaId { get; set; }
    public string? NadkategorijaNaziv { get; set; }

}
