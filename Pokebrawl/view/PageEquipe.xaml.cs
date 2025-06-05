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
        public static List<Pokemon> starters { get; set; } = new()
{
    new Pokemon { Nom = "Bulbizarre", ImageFace = "/view/image/Pokemon_Asset/Front/001.png", CoutEquipe = 2 },
    new Pokemon { Nom = "Salamèche", ImageFace = "/view/image/Pokemon_Asset/Front/004.png", CoutEquipe = 2 },
    new Pokemon { Nom = "Carapuce", ImageFace = "/view/image/Pokemon_Asset/Front/007.png", CoutEquipe = 2 },
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
                    // Clone profond à partir de la base de données pour garder les attaques, images, etc
                    var basePkmn = PokemonDatabase.GetData(p.Nom);
                    if (basePkmn != null)
                    {
                        var clone = new Pokemon
                        {
                            Numero = basePkmn.Numero,
                            Nom = basePkmn.Nom,
                            Niveau = basePkmn.Niveau,
                            Types = new List<TypePokemon>(basePkmn.Types),
                            PV = basePkmn.PV,
                            PVMax = basePkmn.PVMax,
                            Attaque = basePkmn.Attaque,
                            Defense = basePkmn.Defense,
                            AttaqueSpe = basePkmn.AttaqueSpe,
                            DefenseSpe = basePkmn.DefenseSpe,
                            Vitesse = basePkmn.Vitesse,
                            Stade = basePkmn.Stade,
                            ImageFace = basePkmn.ImageFace,
                            ImageDos = basePkmn.ImageDos,
                            Description = basePkmn.Description,
                            Exp = basePkmn.Exp,
                            ExpDonnee = basePkmn.ExpDonnee,
                            Espece = basePkmn.Espece,
                            NiveauEvolution = basePkmn.NiveauEvolution,
                            Evolution = basePkmn.Evolution,
                            CoutEquipe = basePkmn.CoutEquipe,
                            Attaques = basePkmn.Attaques.Select(a => new Attaque
                            {
                                Nom = a.Nom,
                                Type = a.Type,
                                Puissance = a.Puissance,
                                PP = a.PPMax,
                                PPMax = a.PPMax,
                                Description = a.Description
                            }).ToList(),
                            LevelUpMoves = basePkmn.LevelUpMoves?.Select(m => new Pokemon.LevelUpMove
                            {
                                Level = m.Level,
                                Move = new Attaque
                                {
                                    Nom = m.Move.Nom,
                                    Type = m.Move.Type,
                                    Puissance = m.Move.Puissance,
                                    PP = m.Move.PPMax,
                                    PPMax = m.Move.PPMax,
                                    Description = m.Move.Description
                                }
                            }).ToList() ?? new List<Pokemon.LevelUpMove>()
                        };
                        AppData.Joueur.Equipe.Pokemons.Add(clone);
                        EquipeList.Items.Refresh();
                        PointsText.Text = $"Points utilisés : {AppData.Joueur.Equipe.PointsUtilises}/{Equipe.MaxPoints}";
                    }
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
