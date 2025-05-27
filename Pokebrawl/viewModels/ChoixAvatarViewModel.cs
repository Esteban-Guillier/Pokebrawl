using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pokebrawl.viewModels
{
    public class ChoixAvatarViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> Avatars { get; }
        public ICommand ChoisirAvatarCommand { get; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public ChoixAvatarViewModel(Action<string> onAvatarChoisi)
        {
            Avatars = new ObservableCollection<string>
            {
                "view/image/Caractere/Amarylis.png",
                "view/image/Caractere/Cynthia.png",
                "view/image/Caractere/N.png",
                "view/image/Caractere/Pierre.png",
                "view/image/Caractere/Tiplouf.png"
            };
            ChoisirAvatarCommand = new RelayCommand(param =>
            {
                if (param is string avatar)
                    onAvatarChoisi?.Invoke(avatar);
            });
        }
    }
}
