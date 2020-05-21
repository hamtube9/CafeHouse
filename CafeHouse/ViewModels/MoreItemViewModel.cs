using CafeHouse.Models;
using CafeHouse.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
    class MoreItemViewModel : BindableObject
    {
        private ObservableCollection<MoreItem> _mores;
        public ObservableCollection<MoreItem> Mores { get { return _mores; } set { _mores = value; OnPropertyChanged(); } }

        public ICommand MoreItemCommand => new Command<MoreItem>(SelectedPageItem);

        private void SelectedPageItem(MoreItem obj)
        {
            var push = Application.Current.MainPage.Navigation;
            if (obj.Title == "About")
            {
                push.PushAsync(new AboutUsPage());
            }
            else if (obj.Title == "Gallery")
            {
                push.PushAsync(new GalleryPage());
            }
            else if (obj.Title == "Reviews")
            {
                push.PushAsync(new ReviewsPage());
            }
            else if (obj.Title == "Offers")
            {
                push.PushAsync(new OfferPage());
            }
            else if (obj.Title == "Our Staff")
            {
                push.PushAsync(new OurStaffPage());
            }
            else if (obj.Title == "Reservations")
            {

            }
            else if (obj.Title == "Profile")
            {

            }
            else if (obj.Title == "Settings")
            {

            }
        }

        public MoreItemViewModel()
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



    }
}
