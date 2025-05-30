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
    public partial class Menu : Page
    {
        private Frame _mainFrame;
        public Menu(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            EquipeList.ItemsSource = AppData.Joueur.Equipe.Pokemons;
        }

        private void Equipe_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new PageEquipe(_mainFrame));
        }

        private void Jouer_Click(object sender, RoutedEventArgs e)
        {
            if (AppData.Joueur.Equipe.Pokemons.Count > 0)
                _mainFrame.Navigate(new PageCombat(_mainFrame, new GameSession()));
            else
                MessageBox.Show("Ajoutez au moins un Pokémon à votre équipe !");
        }
    }
}
