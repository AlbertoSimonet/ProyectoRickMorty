namespace MauiApp1;

public partial class Gatos : ContentPage
{
	public Gatos()
	{
		InitializeComponent();
        List<Gato> gatos = new List<Gato>()
        {
            new Gato {Name = "Firulais", Description = "Lorem Ipsum", Image = "gato1.jpg"},
            new Gato {Name = "Tomate", Description = "Lorem Ipsum", Image = "gato2.jpg"},
            new Gato {Name = "Pepino", Description = "Lorem Ipsum", Image = "gato3.jpg"},
        };

        listaGatos.ItemsSource = gatos;

    }
    public class Gato
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
