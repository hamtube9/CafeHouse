using CafeHouse.Dialog;
using CafeHouse.ViewModels;
using CafeHouse.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CafeHouse
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer =null):base(initializer)
        {
            InitializeComponent();
            //  MainPage = new NavigationPage(new LandingPage());
        }
        protected override  void OnInitialized()
        {
            Plugin.Media.CrossMedia.Current.Initialize();

              NavigationService.NavigateAsync(Routes.Landing);
          //  MainPage = new LandingPage();
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            RegisterForNavigation(containerRegistry);

        }

        void RegisterForNavigation(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<MainPage,MainPageViewModel>();
            
            containerRegistry.RegisterForNavigation<MenuPage, MenuViewModel>();
            containerRegistry.RegisterForNavigation<MorePage, MoreItemViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
            containerRegistry.RegisterForNavigation<ReservationPage, ReservationViewModel>();
            containerRegistry.RegisterForNavigation<ServicePage, ServicesViewModel>();


            containerRegistry.RegisterForNavigation<AboutUsPage, AboutUsViewModel>();
            containerRegistry.RegisterForNavigation<OfferPage, OfferViewModel>();
            containerRegistry.RegisterForNavigation<ReviewsPage, ReviewsViewModel>();
            containerRegistry.RegisterForNavigation<OurStaffPage, StaffViewModel>();
            containerRegistry.RegisterForNavigation<LandingPage, LandingViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterViewModel>();
            containerRegistry.RegisterForNavigation<GalleryPage, GalleryViewModel>();
            containerRegistry.RegisterForNavigation<ViewImagePage, ViewImageViewModel>();

            //dialog
            containerRegistry.RegisterDialog<ReviewsDialog, DialogViewModel>();
        }

    }
    public sealed partial class Routes
    {
       public static readonly string navigation = nameof(NavigationPage);

        //Views
        public static readonly Uri Landing = new Uri($"CafeHouse:///{navigation}/{nameof(LandingPage)}", UriKind.Absolute);

        public static readonly Uri Login = new Uri($"CafeHouse:///{navigation}/{nameof(LoginPage)}", UriKind.Absolute);

        public static readonly Uri Register = new Uri($"{nameof(RegisterPage)}", UriKind.Relative);

        public static readonly Uri Main = new Uri($"CafeHouse:///{navigation}/{nameof(MainPage)}",UriKind.Absolute);

        public static readonly Uri AboutUs = new Uri($"{nameof(AboutUsPage)}", UriKind.Relative);

        public static readonly Uri Gallery = new Uri($"{nameof(GalleryPage)}", UriKind.Relative);

        public static readonly Uri Offers = new Uri($"{nameof(OfferPage)}",UriKind.Relative);

        public static readonly Uri Staffs = new Uri($"{nameof(OurStaffPage)}", UriKind.Relative);

        public static readonly Uri Reviews = new Uri($"{nameof(ReviewsPage)}", UriKind.Relative);

        public static readonly Uri Booking = new Uri($"{nameof(BookingPage)}", UriKind.Relative);

        public static readonly Uri Home = new Uri($"{nameof(HomePage)}", UriKind.Relative);
        public static readonly Uri Reservation = new Uri($"{nameof(ReservationPage)}", UriKind.Relative);
        public static readonly Uri Menu = new Uri($"{nameof(MenuPage)}", UriKind.Relative);
        public static readonly Uri Services = new Uri($"{nameof(ServicePage)}", UriKind.Relative);
        public static readonly Uri ViewImage = new Uri($"{nameof(ViewImagePage)}", UriKind.Relative);
    }
}
