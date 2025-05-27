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
    public class MagasinViewModel : INotifyPropertyChanged
    {
        public Joueur Joueur { get; }
        public ObservableCollection<Objet> ObjetsDisponibles { get; }
        public ICommand AcheterObjetCommand { get; }
        public ICommand RetourCommand { get; }

        private Objet? _objetSelectionne;
        public Objet? ObjetSelectionne
        {
            get => _objetSelectionne;
            set { _objetSelectionne = value; OnPropertyChanged(nameof(ObjetSelectionne)); }
        }

        public MagasinViewModel(Joueur joueur, Action retour)
        {
            Joueur = joueur;
            ObjetsDisponibles = new ObservableCollection<Objet>
            {
                new Objet { Nom = "Potion", Effet = "Soigne 20 PV", Quantite = 0 },
                new Objet { Nom = "Antidote", Effet = "Soigne le poison", Quantite = 0 }
            };
            AcheterObjetCommand = new RelayCommand(param =>
            {
                if (param is Objet obj && Joueur.Argent >= 100)
                {
                    obj.Quantite++;
                    Joueur.Argent -= 100;
                    var objJoueur = Joueur.Objets.FirstOrDefault(o => o.Nom == obj.Nom);
                    if (objJoueur == null)
                        Joueur.Objets.Add(new Objet { Nom = obj.Nom, Effet = obj.Effet, Quantite = 1 });
                    else
                        objJoueur.Quantite++;
                    OnPropertyChanged(nameof(ObjetsDisponibles));
                    OnPropertyChanged(nameof(Joueur));
                }
            });
            RetourCommand = new RelayCommand(_ => retour?.Invoke());
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
