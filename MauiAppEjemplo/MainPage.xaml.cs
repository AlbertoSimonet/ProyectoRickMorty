using Newtonsoft.Json;

namespace MauiAppEjemplo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        listaDatos();

    }
    public async Task listaDatos()
    {

        List<Character> characters = new List<Character>();

        try
        {
            using (var httpClient = new HttpClient())
            {
                var urlApi = "https://rickandmortyapi.com/api/character";
                var respuesta = await httpClient.GetStringAsync(urlApi);
                var respuestaApi = JsonConvert.DeserializeObject<RespuestaApi>(respuesta);
                characters = respuestaApi.Results;
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
        listaPersonajes.ItemsSource = characters;
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
