using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CafeHouse.ViewModels
{
    class AboutUsViewModel : ViewModelBase
    {
        INavigationService navigation;

        public ICommand GoBack => new DelegateCommand(BackAsync);
            private void BackAsync()
        {
            navigation.GoBackAsync();

        }

        public AboutUsViewModel(INavigationService _service)
        {
            navigation = _service;
        }
    }
}
