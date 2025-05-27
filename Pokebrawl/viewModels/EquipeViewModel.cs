using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokebrawl.model;
using System.Windows.Input;

namespace Pokebrawl.viewModels
{
    public class EquipeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Pokemon> Starters { get; }
        public Joueur Joueur { get; }
        public ICommand AjouterPokemonCommand { get; }
        public ICommand RetirerPokemonCommand { get; }
        public ICommand RetourCommand { get; }

        private Pokemon? _pokemonSelectionne;
        public Pokemon? PokemonSelectionne
        {
            get => _pokemonSelectionne;
            set { _pokemonSelectionne = value; OnPropertyChanged(nameof(PokemonSelectionne)); }
        }

        public EquipeViewModel(Joueur joueur, Action retour)
        {
            Joueur = joueur;
            Starters = new ObservableCollection<Pokemon>
            {
                new Pokemon { Nom = "Bulbizarre", ImageFace = "bulbizarre_face.png", CoutEquipe = 2, Numero = 1 },
                new Pokemon { Nom = "Salamèche", ImageFace = "salameche_face.png", CoutEquipe = 2, Numero = 4 },
                new Pokemon { Nom = "Carapuce", ImageFace = "carapuce_face.png", CoutEquipe = 2, Numero = 7 }
            };

            AjouterPokemonCommand = new RelayCommand(param =>
            {
                if (param is Pokemon p &&
                    Joueur.Equipe.Pokemons.Count < Equipe.MaxPokemons &&
                    Joueur.Equipe.PointsUtilises + p.CoutEquipe <= Equipe.MaxPoints &&
                    !Joueur.Equipe.Pokemons.Any(x => x.Nom == p.Nom))
                {
                    Joueur.Equipe.Pokemons.Add(new Pokemon
                    {
                        Numero = p.Numero,
                        Nom = p.Nom,
                        ImageFace = p.ImageFace,
                        CoutEquipe = p.CoutEquipe
                    });
                    OnPropertyChanged(nameof(Joueur));
                }
            });

            RetirerPokemonCommand = new RelayCommand(param =>
            {
                if (param is Pokemon p && Joueur.Equipe.Pokemons.Contains(p))
                {
                    Joueur.Equipe.Pokemons.Remove(p);
                    OnPropertyChanged(nameof(Joueur));
                }
            });

            RetourCommand = new RelayCommand(_ => retour?.Invoke());
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
