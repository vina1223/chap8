using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace chap8.ViweModel
{
    public class SetNewPassword : INotifyPropertyChanged
    {
        private bool _newPassword;
        private bool _conformNewPassorwd;
        public bool NewPassword
        {
            get { return _newPassword; }
            set
            {
                _newPassword = value;
                OnPropertyChanged();
            }
        }

        public bool ConformNewPassword
        {
            get { return _conformNewPassorwd; }
            set
            {
                _conformNewPassorwd = value;
                OnPropertyChanged();
            }
        }

         public ICommand Clicked { get; private set; }

        public SetNewPassword()
        {
            Clicked = new Command (validation);
        }

        public void validation()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  
        }
    }
}
