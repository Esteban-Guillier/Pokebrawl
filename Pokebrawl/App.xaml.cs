using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Windows;
using Pokebrawl.model;
using Pokebrawl.view;

namespace Pokebrawl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Joueur JoueurActuel { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            JoueurActuel = new Joueur
            {
                Equipe = new ObservableCollection<Pokemon>()
                // Initialisez d'autres propriétés si nécessaire
            };
            // Démarrez votre application avec la première page
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }

}
