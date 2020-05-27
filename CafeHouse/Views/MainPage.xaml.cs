using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using System.ComponentModel;

namespace CafeHouse
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        [System.Obsolete]
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           
            //On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom)
            //       .SetBarItemColor(Color.Black)
            //       .SetBarSelectedItemColor(Color.Red);
            this.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);

        }
    }
}
