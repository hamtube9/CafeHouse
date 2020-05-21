using CafeHouse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
    class ServicesViewModel :BindableObject
    {
        private ObservableCollection<Service> _services;
        public  ObservableCollection<Service> Services { get { return _services; } set { _services = value; OnPropertyChanged(); } }

        public ServicesViewModel()
        {
            Services = new ObservableCollection<Service>();
            Services.Add(new Service()
            {
                Image = "dragonGray.png",
                Title = "Wedding & Birthday Parties Arrangements"
            });

            Services.Add(new Service()
            {
                Image = "dragonGray.png",
                Title = "Bachelor & Office Parties Arrangements"
            });

            Services.Add(new Service()
            {
                Image = "dragonGray.png",
                Title = "Wedding & Birthday Parties Arrangements"
            });
        }
    }
}
