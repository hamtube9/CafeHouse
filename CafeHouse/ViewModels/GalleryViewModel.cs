using CafeHouse.ApiService;
using CafeHouse.Models.image;
using Prism.Commands;
using Prism.Navigation;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
    public class GalleryViewModel : ViewModelBase, INavigationAware
    {
        INavigationService navigation;

        private bool _isBusy;
        public bool IsBusy { get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }

        private ObservableCollection<Data> listGallery;
        public ObservableCollection<Data> ListGallery
        {
            get { return listGallery ?? new ObservableCollection<Data>(); }
            set { SetProperty(ref listGallery, value); }
        }

        public ICommand PickImageCommand => new DelegateCommand<Data>(PickImage);

        public ICommand GoBack => new DelegateCommand(BackAsync);

        private void BackAsync()
        {
            navigation.GoBackAsync();
        }

        private void PickImage(Data obj)
        {
            var param = new NavigationParameters();
            param.Add("IdImage", obj.Id.ToString());
            navigation.NavigateAsync(Routes.ViewImage,param);
        }

        public GalleryViewModel(INavigationService _navigation)
        {
            navigation = _navigation;
            ListGallery = new ObservableCollection<Data>();


        }




        public async Task GetAllImage()
        {
                var listImage = new List<Data>();

            var refit = RestService.For<GalleryInterface>("http://www.splashbase.co/api/v1");

                var images = refit.GetAllImage();

                 listImage = images.Result.Images;
                ListGallery = new ObservableCollection<Data>(listImage); 
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

            GetAllImage();

        }

    }
}
