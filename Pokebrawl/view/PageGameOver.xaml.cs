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

        public PageGameOver(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
        }

        private void RetourMenu_Click(object sender, RoutedEventArgs e)
        {
            // Ouvre la page du menu principal dans le mainFrame puis ferme la fenêtre GameOver
            _mainFrame.Navigate(new Menu(_mainFrame));

        }
    }
}
