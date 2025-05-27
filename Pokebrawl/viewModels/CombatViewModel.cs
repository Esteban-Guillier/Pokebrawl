using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokebrawl.model;
using System.Windows.Input;

namespace Pokebrawl.viewModels
{
    public class CombatViewModel : INotifyPropertyChanged
    {
        public Combat Combat { get; }
        public Joueur Joueur { get; }
        public ICommand LancerAttaqueCommand { get; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public CombatViewModel(Joueur joueur, Pokemon adversaire, TypeCombat typeCombat, Action finCombat)
        {
            Joueur = joueur;
            Combat = new Combat
            {
                Joueur = joueur,
                PokemonJoueur = joueur.Equipe.Pokemons.Count > 0 ? joueur.Equipe.Pokemons[0] : null!,
                PokemonAdverse = adversaire,
                TypeCombat = typeCombat
            };

            LancerAttaqueCommand = new RelayCommand(param =>
            {
                if (param is Attaque atk && Combat.PokemonJoueur.PV > 0 && Combat.PokemonAdverse.PV > 0)
                {
                    // Logique d'attaque simplifiée :
                    int degats = atk.Puissance; // Tu peux compléter avec le calcul réel
                    Combat.PokemonAdverse.PV -= degats;
                    if (Combat.PokemonAdverse.PV < 0) Combat.PokemonAdverse.PV = 0;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combat)));

                    // Façon simple : fin de combat si l'adversaire est KO
                    if (Combat.PokemonAdverse.PV == 0)
                    {
                        Combat.Victoire = true;
                        finCombat?.Invoke();
                    }
                }
            });
        }

        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
