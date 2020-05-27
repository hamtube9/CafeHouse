using CafeHouse.ViewModels;
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
    public partial class OurStaffPage : ContentPage
    {
        public OurStaffPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Handle_Text_Changed(Object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as StaffViewModel;
            ListStaff.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                ListStaff.ItemsSource = _container.Staffs;
            }
            else
            {
                ListStaff.ItemsSource = _container.Staffs.Where(staff => staff.Name.ToLower().Contains(e.NewTextValue));
            }
            ListStaff.EndRefresh();
        }
    }
}