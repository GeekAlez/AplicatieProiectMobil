using AplicatieProiectMobil.Models;
using System;
using System.Collections.Generic;

namespace AplicatieProiectMobil
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            var restaurants = new List<Restaurant>

        {
            new Restaurant { Nume = "Wonderland", ImageSource = "wonderland.jpg", Capacitate= "2500 locuri", Locatie = "Feleacu, jud.Cluj" },
            new Restaurant { Nume = "Sun Garden", ImageSource = "sungarden.jpg", Capacitate= "450 locuri", Locatie = "Poiana Cerbului 1000, Baciu" },
            new Restaurant { Nume = "Amiral Events & Style", ImageSource = "amiral.jpg", Capacitate= "600 locuri", Locatie = "Str. Câmpina nr.51-53, Cluj-Napoca" },
            new Restaurant { Nume = "Transilvania Events Hall", ImageSource = "transilvania.jpg", Capacitate= "300 persoane", Locatie = "Calea Turzii 203A, Cluj-Napoca" },
            new Restaurant { Nume = "Black Tulip ", ImageSource = "blacktulip.jpg", Capacitate= "450 locuri", Locatie = "Str. Libertății nr.1, Dej" },
            new Restaurant { Nume = "Crystal Events Ballroom", ImageSource = "crystal.jpg", Capacitate= "260 locuri", Locatie = "Str. Fabricii nr.71, Turda" } 
            };

            // Crearea și configurarea interfeței de utilizator pe baza listei 
            var stackLayout = new StackLayout();

            foreach (var Restaurant in restaurants)
            {
                var image = new Image
                {
                    Source = Restaurant.ImageSource, //cala catre imagine
                    HeightRequest = 400, // facem modificari ptr inaltimea imaginii
                    WidthRequest = 200, // facem modificari pt latimea imaginii
                    Aspect = Aspect.AspectFit, //modificam aspcetul imaginii
                    Margin = new Thickness(100), // Adaugăm margini
                };         
                var label = new Label
                { 
                    Text = $"{Restaurant.Nume}\n{Restaurant.Capacitate}\n{Restaurant.Locatie}", 
                    FontAttributes = FontAttributes.Bold
                 };
                
            }
            var scrollView = new ScrollView
            {
                Content = stackLayout
            };

            Content = scrollView;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}