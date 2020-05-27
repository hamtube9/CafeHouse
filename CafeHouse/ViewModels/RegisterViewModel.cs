using Prism.Commands;
using Prism.Navigation;
using System;
using System.Text;
using System.Windows.Input;

namespace CafeHouse.ViewModels
{
  public  class RegisterViewModel : ViewModelBase
    {
        INavigationService navigation;

        private ICommand _registerActionCommand;
        public ICommand RegisterActionCommand
        {
            get { return _registerActionCommand ?? new DelegateCommand(UserRegiserAction); }
            set { SetProperty(ref _registerActionCommand, value); }

        }

        public ICommand _backToLoginCmd;
        public ICommand BackToLoginCmd
        {
            get { return _backToLoginCmd ?? new DelegateCommand(BackToLoginAction); }
            set { SetProperty(ref _backToLoginCmd, value); }
        }

        private void BackToLoginAction()
        {
            navigation.NavigateAsync(Routes.Login);
        }

        private void UserRegiserAction()
        {
            navigation.NavigateAsync(Routes.Login);
        }

        public RegisterViewModel(INavigationService navigationService)
        {
            navigation = navigationService;
        }
    }
}
