using CafeHouse.Models;
using CafeHouse.Views;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
  public  class MoreItemViewModel : TabbedViewModelBase
    { 
        private ObservableCollection<MoreItem> _mores;
        private readonly INavigationService navigationService;

        public ObservableCollection<MoreItem> Mores { get { return _mores; } set { SetProperty(ref _mores, value); } }

        public ICommand MoreItemCommand => new Prism.Commands.DelegateCommand<MoreItem>(SelectedPageItem);

      

        public MoreItemViewModel(INavigationService _navigationService)
        {
            navigationService = _navigationService;

            this.navigationService = navigationService;
        }

        public override void CurrentTabbedChanged()
        {
            if (IsActive) GetData();

        }

        private void GetData()
        {
            Mores = new ObservableCollection<MoreItem>();

            Mores.Add(new MoreItem()
            {
                Image = "About.png",
                Title = "About"
            });
            Mores.Add(new MoreItem()
            {
                Image = "Gallery.png",
                Title = "Gallery"
            });
            Mores.Add(new MoreItem()
            {
                Image = "Reviews.png",
                Title = "Reviews"
            });
            Mores.Add(new MoreItem()
            {
                Image = "Offer.png",
                Title = "Offers"
            });
            Mores.Add(new MoreItem()
            {
                Image = "OurStaff.png",
                Title = "Our Staff"
            });
            Mores.Add(new MoreItem()
            {
                Image = "Reservation.png",
                Title = "Reservations"
            });
            Mores.Add(new MoreItem()
            {
                Image = "Profile.png",
                Title = "Profile"
            });

            Mores.Add(new MoreItem()
            {
                Image = "Setting.png",
                Title = "Settings"
            });

        }


        private void SelectedPageItem(MoreItem obj)
        {
            var title = obj.Title;
            switch (title)
            {
                case "About":
                    navigationService.NavigateAsync(Routes.AboutUs);
                    break;
                case "Gallery":
                    navigationService.NavigateAsync(Routes.Gallery);
                    break;
                case "Reviews":
                    navigationService.NavigateAsync(Routes.Reviews);
                    break;
                case "Offers":
                    navigationService.NavigateAsync(Routes.Offers);
                    break;
                case "Our Staff":
                    navigationService.NavigateAsync(Routes.Staffs);
                    break;
                case "Reservations":
                    break;
                case "Profile":
                    break;
                case "Settings":
                    break;



            }
        }
    }
}
