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
    public partial class ChoixPokemonWindow : Window
    {
        public Pokemon PokemonSelectionne { get; private set; }

        public ChoixPokemonWindow(List<Pokemon> pokemons, string titre = "Choisissez un Pokémon :", string action = "Valider")
        {
            InitializeComponent();
            PokemonsList.ItemsSource = pokemons;
            TitreText.Text = titre;
            BtnAction.Content = action;
        }

        private void Action_Click(object sender, RoutedEventArgs e)
        {
            if (PokemonsList.SelectedItem is Pokemon p)
            {
                PokemonSelectionne = p;
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Sélectionnez un Pokémon.");
            }
        }
    }
}
