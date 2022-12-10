using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Skladište.Shared.BindingModel;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace Skladište.Client.Pages;

public partial class KategorijaForm : ComponentBase
{
  

    public KategorijaBM KategorijaBM { get; set; } = new KategorijaBM();

    public List<KategorijaBM> kategorije { get; set; } = new List<KategorijaBM>();

    [Parameter]
    public string? Id { get; set; }

    [Inject]
    protected HttpClient httpClient { get; set; }

    protected async override Task OnInitializedAsync()
    {
        var kategorijeResponse = await httpClient.GetAsync("/api/Kategorija/DohvatiKategorije");
        var kategorijeJson = await kategorijeResponse.Content.ReadAsStringAsync();
        kategorije = JsonConvert.DeserializeObject<List<KategorijaBM>>(kategorijeJson);
    } 


    public async void PotvrdiFormu()
    {
        try
        {
            var kategorijaJson = JsonConvert.SerializeObject(KategorijaBM);
            ByteArrayContent content1 = new StringContent(kategorijaJson);
            content1.Headers.ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.Json);
            var result = await httpClient.PostAsync("/api/Kategorija/dodaj", content1);
        }
        catch(Exception ex)
        {

        }
    }


}



