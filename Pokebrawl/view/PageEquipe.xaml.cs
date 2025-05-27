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
    public partial class PageEquipe : Page
    {
        private Frame _mainFrame;
        private List<Pokemon> starters = new()
        {
            new Pokemon { Nom = "Bulbizarre", ImageFace = "/view/image/Pokemon_Asset/Front/001.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Salamèche", ImageFace = "/view/image/Pokemon_Asset/Front/salameche_face.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Carapuce", ImageFace = "/view/image/Pokemon_Asset/Front/carapuce_face.png", CoutEquipe = 2 }
        };

        public PageEquipe(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            StartersList.ItemsSource = starters;
            EquipeList.ItemsSource = AppData.Joueur.Equipe.Pokemons;
            PointsText.Text = $"Points utilisés : {AppData.Joueur.Equipe.PointsUtilises}/{Equipe.MaxPoints}";
            StartersList.SelectionChanged += StartersList_SelectionChanged;
        }

        private void StartersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StartersList.SelectedItem is Pokemon p)
            {
                if (AppData.Joueur.Equipe.Pokemons.Count < Equipe.MaxPokemons &&
                    AppData.Joueur.Equipe.PointsUtilises + p.CoutEquipe <= Equipe.MaxPoints)
                {
                    AppData.Joueur.Equipe.Pokemons.Add(new Pokemon
                    {
                        Nom = p.Nom,
                        ImageFace = p.ImageFace,
                        CoutEquipe = p.CoutEquipe
                    });
                    EquipeList.Items.Refresh();
                    PointsText.Text = $"Points utilisés : {AppData.Joueur.Equipe.PointsUtilises}/{Equipe.MaxPoints}";
                }
            }
        }

        private void Retirer_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button)?.DataContext is Pokemon p)
            {
                AppData.Joueur.Equipe.Pokemons.Remove(p);
                EquipeList.Items.Refresh();
                PointsText.Text = $"Points utilisés : {AppData.Joueur.Equipe.PointsUtilises}/{Equipe.MaxPoints}";
            }
        }

        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new Menu(_mainFrame));
        }
    }
}
