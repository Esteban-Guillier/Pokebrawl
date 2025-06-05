using Pokebrawl.model;
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

namespace Pokebrawl.view
{
    /// <summary>
    /// Logique d'interaction pour PageGameOver.xaml
    /// </summary>
    public partial class PageGameOver : Page
    {
        private Frame _mainFrame;

        Joueur _joueur;
        public PageGameOver(Frame mainFrame , Joueur joueur)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _joueur = joueur;
        }

        private void RetourMenu_Click(object sender, RoutedEventArgs e)
        {
            foreach (var pkmn in _joueur.Equipe.Pokemons)
            {
                    pkmn.PV = pkmn.PVMax;

            }
            _mainFrame.Navigate(new Menu(_mainFrame));

        }
    }
}
