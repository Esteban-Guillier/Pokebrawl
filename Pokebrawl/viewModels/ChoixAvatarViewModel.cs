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
                "/Pokebrawl;component/view/image/Caractere/Amarylis.png",
                "/Pokebrawl;component/view/image/Caractere/Cynthia.png",
                "/Pokebrawl;component/view/image/Caractere/N.png",
                "/Pokebrawl;component/view/image/Caractere/Pierre.png",
                "/Pokebrawl;component/view/image/Caractere/Tiplouf.png"
            };
            ChoisirAvatarCommand = new RelayCommand(param =>
            {
                if (param is string avatar)
                    onAvatarChoisi?.Invoke(avatar);
            });
        }
    }
}
