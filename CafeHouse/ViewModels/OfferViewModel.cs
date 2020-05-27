using CafeHouse.Models;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
   public class OfferViewModel :ViewModelBase
    {
        INavigationService navigation;
        IPageDialogService dialog;
        private ObservableCollection<Offer> _offers;
        public ObservableCollection<Offer> Offers { get { return _offers; } set { SetProperty(ref _offers , value); } }

        public ICommand GoBack => new Command(BackPopup);
        private void BackPopup(object obj)
        {
            navigation.GoBackAsync();
        }

        public ICommand OptionsStaffCommand => new DelegateCommand<Offer>(PickStaffCommand);

       

        private void PickStaffCommand(Offer obj)
        {
            IActionSheetButton Used = ActionSheetButton.CreateButton("Use Offer", new DelegateCommand(() => { }));
            IActionSheetButton Share = ActionSheetButton.CreateButton("Share Offer For Friend", new DelegateCommand<Offer>(ShareOffer));
            IActionSheetButton Cancel = ActionSheetButton.CreateCancelButton("Cancel", new DelegateCommand(() => { }));
            IActionSheetButton Delete = ActionSheetButton.CreateDestroyButton("Delete", new DelegateCommand(() => { }));

            var title = obj.NameOffer;
          dialog.DisplayActionSheetAsync("What do you want to do with : " + title, Cancel, Used, Share, Delete );
            
        }

        private void ShareOffer(Offer obj)
        {
            ShareOfferToFriend(obj);
        }

        public async Task ShareOfferToFriend(Offer offer)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = offer.NameOffer,
                Title = "Shared Offer"
            });
        }

        public OfferViewModel(INavigationService _navigation, IPageDialogService _dialog)
        {
            dialog = _dialog;
            navigation = _navigation;
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
