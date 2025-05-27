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
        private List<string> avatars = new() { "avatar1.png", "avatar2.png", "avatar3.png", "avatar4.png", "avatar5.png" };

        public PageChoixAvatar(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            AvatarList.ItemsSource = avatars;
        }

        private void Avatar_Click(object sender, RoutedEventArgs e)
        {
            var img = (sender as Button)?.Content as Image;
            var src = img?.Source.ToString();
            // Stocker l'avatar du joueur dans un singleton ou navigation context
            AppData.Joueur.Avatar = src ?? avatars[0];
            _mainFrame.Navigate(new PageMenu(_mainFrame));
        }
    }
}
