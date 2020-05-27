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
    class StaffViewModel : ViewModelBase
    {
        private ObservableCollection<Staff> _staffs;
        public ObservableCollection<Staff> Staffs { get { return _staffs; } set { SetProperty(ref _staffs , value); } }

        public ICommand BackPopupCommand => new Command(BackPopup);

        

        public StaffViewModel()
        {
            Staffs = new ObservableCollection<Staff>();

            Staffs.Add(new Staff()
            {
                Name = "Chef John",
                Image = "Man.png",
                TypeFood = "French, Western, Pastry, Desert"
            });

            Staffs.Add(new Staff()
            {
                Name = "Chef Kristen",
                Image = "Man.png",
                TypeFood = "BBQ, Western, Fast Food"
            });

            Staffs.Add(new Staff()
            {
                Name = "Chef Martin",
                Image = "Woman.png",
                TypeFood = "Italian, Pastry, Dessert"

            });

            Staffs.Add(new Staff()
            {
                Name = "Chef Gabriel",
                Image = "Woman.png",
                TypeFood = "BBQ, Western, Fast Food"
            });

            Staffs.Add(new Staff()
            {
                Name = "Chef Mike",
                Image = "Man.png",
                TypeFood = "French, Western, Pastry, Dessert"
            });
            Staffs.Add(new Staff()
            {
                Name = "Chef Cris",
                Image = "Woman.png",
                TypeFood = "BBQ, Western, Fast Food"
            });


            Staffs.Add(new Staff()
            {
                Name = "Chef Martin",
                Image = "Man.png",
                TypeFood = "Italian, Pastry, Dessert"
            });
            Staffs.Add(new Staff()
            {
                Name = "Chef Elliot",
                Image = "Woman.png",
                TypeFood = "BBQ, Western, Fast Food"
            });

            Staffs.Add(new Staff()
            {
                Name = "Chef George",
                Image = "Man.png",
                TypeFood = "Italian, Pastry, Dessert"
            });
            Staffs.Add(new Staff()
            {
                Name = "Chef Joana",
                Image = "Woman.png",
                TypeFood = "BBQ, Western, Fast Food"
            });
        }

        private void BackPopup(object obj)
        {
            var navigation = Application.Current.MainPage.Navigation;
            navigation.PopAsync();
        }
    }
}
