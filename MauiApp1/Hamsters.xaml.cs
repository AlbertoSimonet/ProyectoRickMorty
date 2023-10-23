namespace MauiApp1;

public partial class Hamsters : ContentPage
{
    public Hamsters()
    {
        InitializeComponent();
        List<Hamster> hamsters = new List<Hamster>()
        {
            new Hamster {Name = "Firulais", Description = "Lorem Ipsum", Image = "hamster1.jpg"},
            new Hamster {Name = "Tomate", Description = "Lorem Ipsum", Image = "hamster2.jpg"},
            new Hamster {Name = "Pepino", Description = "Lorem Ipsum", Image = "hamster3.jpg"},
        };

        listaHamsters.ItemsSource = hamsters;

    }
    public class Hamster
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}