using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class Joueur : INotifyPropertyChanged
    {
        private ObservableCollection<Pokemon> _equipe;
        public ObservableCollection<Pokemon> Equipe
        {
            get => _equipe;
            set
            {
                _equipe = value;
                OnPropertyChanged(nameof(Equipe));
            }
        }

        private string avatar;
        public string Avatar
        {
            get => avatar;
            set
            {
                avatar = value;
                OnPropertyChanged(nameof(Avatar));
            }
        }
        public int PointsEquipe { get; set; } = 0;
        public int Argent { get; set; } = 0;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
