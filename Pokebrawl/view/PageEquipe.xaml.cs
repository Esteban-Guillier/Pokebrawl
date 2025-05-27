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
            new Pokemon { Nom = "Salamèche", ImageFace = "/view/image/Pokemon_Asset/Front/004.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Carapuce", ImageFace = "/view/image/Pokemon_Asset/Front/007.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Chenipan", ImageFace = "/view/image/Pokemon_Asset/Front/010.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Aspicot", ImageFace = "/view/image/Pokemon_Asset/Front/013.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Roucoul", ImageFace = "/view/image/Pokemon_Asset/Front/016.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Rattata", ImageFace = "/view/image/Pokemon_Asset/Front/019.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Piafabec", ImageFace = "/view/image/Pokemon_Asset/Front/021.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Abo", ImageFace = "/view/image/Pokemon_Asset/Front/023.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Pikachu", ImageFace = "/view/image/Pokemon_Asset/Front/025.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Sabelette", ImageFace = "/view/image/Pokemon_Asset/Front/027.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Nidoran ♀", ImageFace = "/view/image/Pokemon_Asset/Front/029.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Nidoran ♂", ImageFace = "/view/image/Pokemon_Asset/Front/032.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Mélofée", ImageFace = "/view/image/Pokemon_Asset/Front/035.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Goupix", ImageFace = "/view/image/Pokemon_Asset/Front/037.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Rondoudou", ImageFace = "/view/image/Pokemon_Asset/Front/039.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Nosferapti", ImageFace = "/view/image/Pokemon_Asset/Front/041.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Mystherbe", ImageFace = "/view/image/Pokemon_Asset/Front/043.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Paras", ImageFace = "/view/image/Pokemon_Asset/Front/046.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Mimitoss", ImageFace = "/view/image/Pokemon_Asset/Front/048.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Taupiqueur", ImageFace = "/view/image/Pokemon_Asset/Front/050.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Miaouss", ImageFace = "/view/image/Pokemon_Asset/Front/052.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Psykokwak", ImageFace = "/view/image/Pokemon_Asset/Front/054.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Férosinge", ImageFace = "/view/image/Pokemon_Asset/Front/056.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Caninos", ImageFace = "/view/image/Pokemon_Asset/Front/058.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Ptitard", ImageFace = "/view/image/Pokemon_Asset/Front/060.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Abra", ImageFace = "/view/image/Pokemon_Asset/Front/063.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Machoc", ImageFace = "/view/image/Pokemon_Asset/Front/066.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Chétiflor", ImageFace = "/view/image/Pokemon_Asset/Front/069.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Tentacool", ImageFace = "/view/image/Pokemon_Asset/Front/072.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Racaillou", ImageFace = "/view/image/Pokemon_Asset/Front/074.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Ponyta", ImageFace = "/view/image/Pokemon_Asset/Front/077.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Ramoloss", ImageFace = "/view/image/Pokemon_Asset/Front/079.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Magnéti", ImageFace = "/view/image/Pokemon_Asset/Front/081.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Canarticho", ImageFace = "/view/image/Pokemon_Asset/Front/083.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Doduo", ImageFace = "/view/image/Pokemon_Asset/Front/084.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Otaria", ImageFace = "/view/image/Pokemon_Asset/Front/086.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Tadmorv", ImageFace = "/view/image/Pokemon_Asset/Front/088.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Kokiyas", ImageFace = "/view/image/Pokemon_Asset/Front/090.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Fantominus", ImageFace = "/view/image/Pokemon_Asset/Front/092.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Onix", ImageFace = "/view/image/Pokemon_Asset/Front/095.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Soporifik", ImageFace = "/view/image/Pokemon_Asset/Front/096.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Krabby", ImageFace = "/view/image/Pokemon_Asset/Front/098.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Volotorbe", ImageFace = "/view/image/Pokemon_Asset/Front/100.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Noeunoeuf", ImageFace = "/view/image/Pokemon_Asset/Front/102.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Osselait", ImageFace = "/view/image/Pokemon_Asset/Front/104.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Kicklee", ImageFace = "/view/image/Pokemon_Asset/Front/106.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Tygnon", ImageFace = "/view/image/Pokemon_Asset/Front/107.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Excelangue", ImageFace = "/view/image/Pokemon_Asset/Front/108.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Smogo", ImageFace = "/view/image/Pokemon_Asset/Front/109.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Rhinocorne", ImageFace = "/view/image/Pokemon_Asset/Front/111.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Leveinard", ImageFace = "/view/image/Pokemon_Asset/Front/113.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Saquedeneu", ImageFace = "/view/image/Pokemon_Asset/Front/114.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Kangourex", ImageFace = "/view/image/Pokemon_Asset/Front/115.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Hypotrempe", ImageFace = "/view/image/Pokemon_Asset/Front/116.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Possirène", ImageFace = "/view/image/Pokemon_Asset/Front/118.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Poissoroy", ImageFace = "/view/image/Pokemon_Asset/Front/119.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Stari", ImageFace = "/view/image/Pokemon_Asset/Front/120.png", CoutEquipe = 2 },
            new Pokemon { Nom = "M.Mime", ImageFace = "/view/image/Pokemon_Asset/Front/122.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Insécateur", ImageFace = "/view/image/Pokemon_Asset/Front/123.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Lippouton", ImageFace = "/view/image/Pokemon_Asset/Front/124.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Élektek", ImageFace = "/view/image/Pokemon_Asset/Front/125.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Magmar", ImageFace = "/view/image/Pokemon_Asset/Front/126.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Scarabrute", ImageFace = "/view/image/Pokemon_Asset/Front/127.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Tauros", ImageFace = "/view/image/Pokemon_Asset/Front/128.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Magicarpe", ImageFace = "/view/image/Pokemon_Asset/Front/129.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Lokhlass", ImageFace = "/view/image/Pokemon_Asset/Front/131ng", CoutEquipe = 2 },
            new Pokemon { Nom = "Métamorph", ImageFace = "/view/image/Pokemon_Asset/Front/132.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Évoli", ImageFace = "/view/image/Pokemon_Asset/Front/133.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Porygon", ImageFace = "/view/image/Pokemon_Asset/Front/137.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Amonita", ImageFace = "/view/image/Pokemon_Asset/Front/138.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Kabuto", ImageFace = "/view/image/Pokemon_Asset/Front/140.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Ptéra", ImageFace = "/view/image/Pokemon_Asset/Front/142.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Ronflex", ImageFace = "/view/image/Pokemon_Asset/Front/143.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Artokodin", ImageFace = "/view/image/Pokemon_Asset/Front/144.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Électhor", ImageFace = "/view/image/Pokemon_Asset/Front/145.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Sulfura", ImageFace = "/view/image/Pokemon_Asset/Front/146.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Minidraco", ImageFace = "/view/image/Pokemon_Asset/Front/147.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Mewtwo", ImageFace = "/view/image/Pokemon_Asset/Front/150.png", CoutEquipe = 2 },
            new Pokemon { Nom = "Mew", ImageFace = "/view/image/Pokemon_Asset/Front/151.png", CoutEquipe = 2 }

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
