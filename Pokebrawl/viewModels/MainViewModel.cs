using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Pokebrawl.model;

namespace Pokebrawl.viewModels
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        private Joueur _joueur;
        public Joueur Joueur
        {
            get => _joueur;
            set { _joueur = value; OnPropertyChanged(nameof(Joueur)); }
        }

        public ICommand OuvrirEquipeCommand { get; set; }
        public ICommand JouerCommand { get; set; }

        public bool PeutJouer => Joueur?.Equipe?.Pokemons?.Count > 0;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MenuViewModel(Joueur joueur, Action ouvrirEquipe, Action jouer)
        {
            Joueur = joueur;
            OuvrirEquipeCommand = new RelayCommand(_ => ouvrirEquipe?.Invoke());
            JouerCommand = new RelayCommand(_ =>
            {
                if (PeutJouer) jouer?.Invoke();
            });
        }

        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
