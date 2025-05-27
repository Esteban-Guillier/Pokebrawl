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
using System.Windows.Navigation;

namespace Pokebrawl.view
{
    /// <summary>
    /// Logique d'interaction pour PageIntro.xaml
    /// </summary>
    public partial class PageIntro : Page
    {
        private Frame _mainFrame;
        public PageIntro(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
        }

        private void Jouer_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new ChoixAvatar(_mainFrame));
        }
    }
}
