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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pokebrawl.model;

namespace Pokebrawl.view
{
    /// <summary>
    /// Logique d'interaction pour PageVictoire.xaml
    /// </summary>
    public partial class PageVictoire : Page
    {
        private Frame _mainFrame;

        Joueur _joueur;
        public PageVictoire(Frame mainFrame, Joueur joueur)
        {
            InitializeComponent();
        }

        private void RetourMenu_Click(object sender, RoutedEventArgs e)
        {
            foreach (var pkmn in _joueur.Equipe.Pokemons)
            {
                pkmn.PV = pkmn.PVMax;

            }
            // Navigue vers la page de menu principal
            _mainFrame.Navigate(new Menu(_mainFrame));
        }
    }
}
