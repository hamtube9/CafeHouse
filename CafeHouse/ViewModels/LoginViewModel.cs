using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CafeHouse.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        INavigationService _navigation;
        IPageDialogService dialog;

        private ICommand _userLoginCommand;
        public ICommand UerLoginCommand
        {
            get { return _userLoginCommand ?? new DelegateCommand(UserLoginAction); }
            set { SetProperty(ref _userLoginCommand, value); }
        }

        private ICommand _gotoRegisterCommand;
        public ICommand GotoRegisterCommand
        {
            get { return _gotoRegisterCommand ?? new DelegateCommand(GotoRegister); }
        }

        private void GotoRegister()
        {
            _navigation.NavigateAsync(Routes.Register);
        }

        private void UserLoginAction()
        {
            _navigation.NavigateAsync(Routes.Main);
        }

        public LoginViewModel(INavigationService navigation, IPageDialogService _dialog)
        {
            dialog = _dialog;
            _navigation = navigation;
        }
    }
}
