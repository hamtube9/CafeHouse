using CafeHouse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
   public class OfferViewModel :BindableObject
    {

        private ObservableCollection<Offer> _offers;
        public ObservableCollection<Offer> Offers { get { return _offers; } set { _offers = value; OnPropertyChanged(); } }

        public ICommand BackPopupCommand => new Command(BackPopup);
        private void BackPopup(object obj)
        {
            var navigation = Application.Current.MainPage.Navigation;
            navigation.PopAsync();
        }

        public OfferViewModel()
        {
            Offers = new ObservableCollection<Offer>();
            Offers.Add(new Offer()
            {
                Image = "dragonGray.png",
                NameOffer="Flat 25% off on Brithday Parties",
                DateTime = DateTime.Now.ToString("dd//MM/yyyy")

            });

            Offers.Add(new Offer()
            {
                Image = "https://www.berhampuriya.com/wp-content/uploads/2019/07/Offer-20-off-min-1.jpg",
                NameOffer = "Get 1 happy hour meal free by winning best selfie contest",
                DateTime = DateTime.Now.ToString("dd//MM/yyyy")

            });

            Offers.Add(new Offer()
            {
                Image = "https://images.freekaamaal.com/post_images/1574661089.png",
                NameOffer = "Buy 1 get 1 pizza free",
                DateTime = DateTime.Now.ToString("dd//MM/yyyy")

            });

            Offers.Add(new Offer()
            {
                Image = "dragonGray.png",
                NameOffer = "Flat 25% off on Brithday Parties",
                DateTime = DateTime.Now.ToString("dd//MM/yyyy")

            });
        }
    }
}
