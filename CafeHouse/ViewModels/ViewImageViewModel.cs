using CafeHouse.ApiService;
using CafeHouse.Models.image;
using Prism.Common;
using Prism.Navigation;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace CafeHouse.ViewModels
{
   public class ViewImageViewModel : ViewModelBase, INavigationAware
    {
        INavigationService navigation;

        private string urlImage;
        public string UrlImage { get { return urlImage; } set{ SetProperty(ref urlImage, value); } }
        public string IdImage { set; get; }

        public ViewImageViewModel(INavigationService _navigation)
        {
            navigation = _navigation;
          
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            IdImage = parameters.GetValue<string>("IdImage");
            GetImageById(IdImage);
        }

        public async Task GetImageById(string id)
        {
            var refit = RestService.For<GalleryInterface>("http://www.splashbase.co/api/v1");
            var response = refit.GetImageById(id);

            UrlImage = response.Result.Url.ToString();

        }

     
    }
}
