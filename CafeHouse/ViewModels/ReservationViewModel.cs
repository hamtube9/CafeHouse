using CafeHouse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
    class ReservationViewModel : BindableObject
    {
        private ObservableCollection<Datetime> _datetimes;
        public ObservableCollection<Datetime> Datetimes { get { return _datetimes; } set { _datetimes = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _hours;
        public ObservableCollection<string> Hours { get { return _hours; } set { _hours = value; OnPropertyChanged(); } }


        public ReservationViewModel()
        {
            Datetimes = new ObservableCollection<Datetime>();
            Datetimes.Add(new Datetime()
            {
                DateOfMonth ="1",
                DayOfWeek = "Mon"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "2",
                DayOfWeek = "Tues"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "3",
                DayOfWeek = "Wed"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "4",
                DayOfWeek = "Thrus"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "5",
                DayOfWeek = "Fri"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "6",
                DayOfWeek = "Sat"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "7",
                DayOfWeek = "Sun"
            });
            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "8",
                DayOfWeek = "Mon"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "9",
                DayOfWeek = "Tues"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "10",
                DayOfWeek = "Wed"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "11",
                DayOfWeek = "Thrus"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "12",
                DayOfWeek = "Fri"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "13",
                DayOfWeek = "Sat"
            });

            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "14",
                DayOfWeek = "Sun"
            });


            Hours = new ObservableCollection<string>();
            Hours.Add("1:00 AM");
            Hours.Add("2:00 AM");
            Hours.Add("3:00 AM");
            Hours.Add("4:00 AM");
            Hours.Add("5:00 AM");
            Hours.Add("6:00 AM");
            Hours.Add("7:00 AM");
            Hours.Add("8:00 AM");
            Hours.Add("9:00 AM");
            Hours.Add("10:00 AM");
            Hours.Add("11:00 AM");
            Hours.Add("00:00 AM");

            Hours.Add("1:00 PM");
            Hours.Add("2:00 PM");
            Hours.Add("3:00 PM");
            Hours.Add("4:00 PM");
            Hours.Add("5:00 PM");
            Hours.Add("6:00 PM");
            Hours.Add("7:00 PM");
            Hours.Add("8:00 PM");
            Hours.Add("9:00 PM");
            Hours.Add("10:00 PM");
            Hours.Add("11:00 PM");
            Hours.Add("00:00 PM");

        }
    }
}
