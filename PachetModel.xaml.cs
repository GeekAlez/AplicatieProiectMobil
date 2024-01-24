using System;
using System.Collections.Generic;

using AplicatieProiectMobil.Models;

namespace AplicatieProiectMobil
{
    public partial class PachetModel : ContentPage
    {
        private string Eveniment;
        private string Restaurant;
        private string Pret;
        private string Informatii;
        private string Promotii;

        public PachetModel()
        {
            InitializeComponent();

            var pachets = new List<PachetModel>
            {
                new PachetModel { Eveniment = "Nunta", Restaurant = "Wonderland", Pret = "250/persoana", Informatii = "va urma", Promotii = "candy bar inclus pentru 150 de persoane, restul se plateste" },
                new PachetModel { Eveniment = "Revelion", Restaurant = "La Cina", Pret = "450/persoana", Informatii = "va urma", Promotii = "open bar, spectacol de lumini, dj inclus" }
                // Adăugați alte pachete aici
            };

            // Crearea și configurarea interfeței de utilizator pe baza listei de pachete
            var stackLayout = new StackLayout();

            foreach (var pachet in pachets)
            {
                var label = new Label { Text = $"{pachet.Eveniment}\n{pachet.Restaurant}\n{pachet.Pret}\n{pachet.Informatii}\n{pachet.Promotii}" };

                var pachetLayout = new StackLayout { Children = { label }, Margin = new Thickness(10) };
                stackLayout.Children.Add(pachetLayout);
            }

            Content = stackLayout;
        }
    }
}
