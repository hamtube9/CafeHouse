using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CafeHouse.ViewModels
{
   public class LandingViewModel: ViewModelBase
    {
        INavigationService _navigationService;

        private ICommand _registerCmd;
        public ICommand RegisterCommand
        {
            get { return _registerCmd ?? new DelegateCommand(RegisterAction); }
            set { SetProperty(ref _registerCmd, value); }
        }

        private void RegisterAction()
        {
            _navigationService.NavigateAsync(Routes.Register);
        }

        private ICommand _LoginCmd;
        public ICommand LoginCmd
        {
            get
            {
                return _LoginCmd ?? new DelegateCommand(LoginAction);
            }
            set { SetProperty(ref _LoginCmd, value); }
        }

        private void LoginAction()
        {
            _navigationService.NavigateAsync(Routes.Login);
        }

        public LandingViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
