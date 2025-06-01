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
    /// Logique d'interaction pour Magasin.xaml
    /// </summary>
    public partial class PageMagasin : Page
    {
        private Joueur _joueur;
        private Frame _mainFrame;
        public List<MagasinItem> Items = new()
        {
            new MagasinItem { Nom = "Potion", Image = "/view/image/objets/potion.png", Prix = 200, Type = ItemType.Potion },
            new MagasinItem { Nom = "Ball", Image = "/view/image/objets/ball.png", Prix = 150, Type = ItemType.Ball }
        };

        public PageMagasin(Frame mainFrame, Joueur joueur)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _joueur = joueur;
            ShopItemsList.ItemsSource = Items;
            UpdateArgent();
        }

        private void UpdateArgent()
        {
            ArgentText.Text = $"Argent : {_joueur.Argent} ₽";
        }

        private void Acheter_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var item = btn.Tag as MagasinItem;
            if (item == null) return;
            if (_joueur.Argent < item.Prix)
            {
                MessageBox.Show("Pas assez d'argent !");
                return;
            }

            // Achat d'une Potion => choisir le Pokémon à soigner
            if (item.Type == ItemType.Potion)
            {
                var choixPokemonWindow = new ChoixPokemonWindow(_joueur.Equipe.Pokemons);
                if (choixPokemonWindow.ShowDialog() == true)
                {
                    var pokemon = choixPokemonWindow.PokemonSelectionne;
                    if (pokemon != null)
                    {
                        // Soigner le Pokémon (exemple : PV max)
                        pokemon.PV = pokemon.PVMax;
                        _joueur.Argent -= item.Prix;
                        _joueur.Inventaire.Ajouter(item.Nom, 1);
                        UpdateArgent();
                        MessageBox.Show($"{pokemon.Nom} est soigné !");
                    }
                }
            }
            // Achat d'une Ball
            else if (item.Type == ItemType.Ball)
            {
                _joueur.Argent -= item.Prix;
                _joueur.Inventaire.Ajouter(item.Nom, 1);
                UpdateArgent();
                MessageBox.Show("Ball ajoutée à l'inventaire !");
            }
        }

        private void Continuer_Click(object sender, RoutedEventArgs e)
        {
            // On reprend la série de combats là où on en était
            _mainFrame.Navigate(new PageCombat(_mainFrame, _joueur));
        }
    }
}
