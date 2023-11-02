using Newtonsoft.Json;

namespace MauiAppEjemplo;

public partial class EarthC137Page : ContentPage
{
    public EarthC137Page()
    {
        InitializeComponent();
        listaDatos();

    }
    public async Task listaDatos()
    {

        List<Character> personajesOrigenEC137 = new List<Character>();

        try
        {
            using (var httpClient = new HttpClient())
            {
                var urlApi = "https://rickandmortyapi.com/api/character";
                var respuesta = await httpClient.GetStringAsync(urlApi);
                var respuestaApi = JsonConvert.DeserializeObject<RespuestaApi>(respuesta);
                personajesOrigenEC137 = respuestaApi.Results.Where(personaje => personaje.Origin.name.Equals("Earth (C-137)")).ToList();
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("Error en el link de la API");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error diferente");
        }
        listaEarthC137.ItemsSource = personajesOrigenEC137;
    }

    public class RespuestaApi
    {
        public List<Character> Results { get; set; }
    }

    public class Character
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public Origin Origin { get; set; }
        public string Image { get; set; }
    }

    public class Origin
    {
        public string name { get; set; }
    }
}