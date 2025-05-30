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
        private Frame _mainFrame;
        private List<string> avatars = new()
            {
                "pack://application:,,,/view/image/Caractere/Amarylis.png",
                "pack://application:,,,/view/image/Caractere/Cynthia.png",
                "pack://application:,,,/view/image/Caractere/N.png",
                "pack://application:,,,/view/image/Caractere/Pierre.png",
                "pack://application:,,,/view/image/Caractere/Tiplouf.png"
            };
        public ChoixAvatar(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            AvatarList.ItemsSource = avatars;
        }

        private void Avatar_Click(object sender, RoutedEventArgs e)
        {
            var bouton = sender as Button;
            var avatarPath = bouton?.Tag as string;
            AppData.Joueur.Avatar = avatarPath ?? avatars[0];
            _mainFrame.Navigate(new Menu(_mainFrame));
        }
    }
}
