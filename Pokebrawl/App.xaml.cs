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
        public static Joueur Joueur { get; set; } = new Joueur();
    }

}
