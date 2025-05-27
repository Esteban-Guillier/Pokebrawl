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
    /// Logique d'interaction pour ChoixAvatar.xaml
    /// </summary>
    public partial class ChoixAvatar : Page
    {
        private int selectedAvatarId = -1;

        public ChoixAvatar()
        {
            InitializeComponent();
        }

        private void Avatar_Click(object sender, MouseButtonEventArgs e)
        {
            Image clickedImage = sender as Image;
            int avatarId = int.Parse(clickedImage.Tag.ToString());
            selectedAvatarId = avatarId;

            // Réinitialiser tous les bordures à Transparent
            Avatar1Border.BorderBrush = Brushes.Transparent;
            Avatar2Border.BorderBrush = Brushes.Transparent;
            Avatar3Border.BorderBrush = Brushes.Transparent;
            Avatar4Border.BorderBrush = Brushes.Transparent;
            Avatar5Border.BorderBrush = Brushes.Transparent;

            // Colorer la bordure de l'avatar sélectionné
            switch (avatarId)
            {
                case 1: Avatar1Border.BorderBrush = Brushes.Blue; break;
                case 2: Avatar2Border.BorderBrush = Brushes.Blue; break;
                case 3: Avatar3Border.BorderBrush = Brushes.Blue; break;
                case 4: Avatar4Border.BorderBrush = Brushes.Blue; break;
                case 5: Avatar5Border.BorderBrush = Brushes.Blue; break;
            }
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            if (selectedAvatarId == -1)
            {
                MessageBox.Show("Veuillez sélectionner un avatar.");
                return;
            }

            // Détermine le chemin de l’avatar choisi
            string avatarPath = selectedAvatarId switch
            {
                1 => "image/Caractere/Amarylis.png",
                2 => "image/Caractere/Cynthia.png",
                3 => "image/Caractere/N.png",
                4 => "image/Caractere/Pierre.png",
                5 => "image/Caractere/Tiplouf.png",
                _ => null
            };

            GameState.JoueurActuel.Avatar = avatarPath;
            // Liste factice de Pokémon pour le test (à remplacer par l’équipe réelle du joueur)
            List<string> equipe = new List<string>
    {
        "image/Pokemon_asset/Icon/001.png",
        "image/Pokemon_asset/Icon/004.png",
        "image/Pokemon_asset/Icon/151.png"
    };

            // Navigation vers la page Menu
            NavigationService?.Navigate(new Menu(avatarPath, equipe));
        }
    }
}
