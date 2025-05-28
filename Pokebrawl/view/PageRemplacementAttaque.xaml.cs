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

namespace Pokebrawl.view
{
    public partial class PageRemplacementAttaque : Page
    {
        private Pokemon _pokemon;
        private Attaque _nouvelle;
        private Frame _mainFrame;
        public PageRemplacementAttaque(Frame mainFrame, Pokemon pokemon, Attaque nouvelle)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _pokemon = pokemon;
            _nouvelle = nouvelle;
            AttaquesList.ItemsSource = _pokemon.Attaques;
            NouvelleAttaqueName.Text = _nouvelle.Nom;
        }

        private void Remplacer_Click(object sender, RoutedEventArgs e)
        {
            var selected = AttaquesList.SelectedItem as Attaque;
            if (selected != null)
            {
                _pokemon.Attaques.Remove(selected);
                _pokemon.Attaques.Add(_nouvelle);
                // Retour au combat
                _mainFrame.GoBack();
            }
        }
    }
}
