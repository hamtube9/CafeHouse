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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var tapped =new TapGestureRecognizer();
            tapped.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new LoginPage());
            };
            lblLogin.GestureRecognizers.Add(tapped);
        }
    }
}