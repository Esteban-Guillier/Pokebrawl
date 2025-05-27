using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Pokebrawl.model;

namespace Pokebrawl.view
{
    /// <summary>
    /// Logique d'interaction pour Equipe.xaml
    /// </summary>
    public partial class Equipe : Page
    {
        public class PokemonAffiche
        {
            public string Nom { get; set; }
            public string Niveau { get; set; }
            public BitmapImage Sprite { get; set; }
        }

        public Equipe(List<PokemonAffiche> equipe)
        {
            InitializeComponent();
            DataContext = App.JoueurActuel;
            List<PokemonAffiche> affichage = new List<PokemonAffiche>();
            foreach (var p in GameState.JoueurActuel.Equipe)
            {
                affichage.Add(new PokemonAffiche
                {
                    Nom = p.Nom,
                    Niveau = "Niv. " + p.Niveau,
                    Sprite = new BitmapImage(new Uri(p.Sprite, UriKind.RelativeOrAbsolute))
                });
            }

            PokemonList.ItemsSource = affichage;
        }

        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}
