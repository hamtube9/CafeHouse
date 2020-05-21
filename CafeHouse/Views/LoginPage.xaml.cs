using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CafeHouse.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            var lblregisterTapper = new TapGestureRecognizer();
            lblregisterTapper.Tapped += (s, e) =>
             {
                 Navigation.PushAsync(new RegisterPage());

             };
            lblRegister.GestureRecognizers.Add(lblregisterTapper);
        }

        private void GradientButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}