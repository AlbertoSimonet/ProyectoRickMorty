namespace MauiApp1;

public partial class Perros : ContentPage
{
    public Perros()
    {
        InitializeComponent();
        List<Perro> perros = new List<Perro>()
        {
            new Perro {Name = "Firulais", Description = "Lorem Ipsum", Image = "perro1.png"},
            new Perro {Name = "Tomate", Description = "Lorem Ipsum", Image = "perro2.jpg"},
            new Perro {Name = "Pepino", Description = "Lorem Ipsum", Image = "perro3.jpg"},
        };

        listaPerros.ItemsSource = perros;
        
    }
    public class Perro
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    private void OnCounterClicked(object sender, EventArgs e) => Shell.Current.GoToAsync("//MainPage");
}