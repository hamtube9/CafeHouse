using CafeHouse.Models;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
  public  class ReservationViewModel : TabbedViewModelBase
    {
        private ObservableCollection<Datetime> _datetimes;
        public ObservableCollection<Datetime> Datetimes { get { return _datetimes; } set { SetProperty(ref _datetimes , value);  } }

        private ObservableCollection<string> _hours;
        public ObservableCollection<string> Hours { get { return _hours; } set {  SetProperty(ref _hours, value);  } }


        private ObservableCollection<Table> _bookings;
        public ObservableCollection<Table> Bookings { get { return _bookings; } set { SetProperty(ref _bookings, value); } }

        public ICommand BookingCommand => new DelegateCommand(BookingSuccessCommand);


        public ICommand PickDayCommand => new DelegateCommand<Datetime>(PickDay);

        public ICommand SelectedTableCommand => new DelegateCommand<Table>(SelectedTable);

        private void SelectedTable(Table obj)
        {
            if (obj == null || obj.IsSelected)
            {
                return;
            }

            var table = Bookings.FirstOrDefault(d => d.IsSelected);
            if (table != null)
            {
                table.IsSelected = false;
            }

            obj.IsSelected = true;
        }

        private void PickDay(Datetime obj)
        {
            if (obj.IsSelected)
            {
                return;
            }

            var datetimeSelected = Datetimes.Where(d => d.IsSelected).FirstOrDefault();
            if (datetimeSelected != null)
            {
                datetimeSelected.IsSelected = false;
            }
            obj.IsSelected = true;

        }

        private void BookingSuccessCommand()
        {
            var push = Application.Current.MainPage.Navigation;
            push.PushAsync(new CafeHouse.Views.BookingPage());
        }
      

        public ReservationViewModel()
        {
            Datetimes = new ObservableCollection<Datetime>();
          
        }

        public override void CurrentTabbedChanged()
        {
            if (IsActive) GetData();
        }

        private void GetData()
        {
            Datetimes.Add(new Datetime()
            {
                DateOfMonth = "1",
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

            Bookings = new ObservableCollection<Table>();
            Bookings.Add(new Table()
            {
                ImageTable = "dragonGray.png",
                People = 1
            });
            Bookings.Add(new Table()
            {
                ImageTable = "table2.png",
                People = 2
            });

            Bookings.Add(new Table()
            {
                ImageTable = "table2.png",
                People = 3
            });

            Bookings.Add(new Table()
            {
                ImageTable = "dragonGray.png",
                People = 4
            });

            Bookings.Add(new Table()
            {
                ImageTable = "table2.png",
                People = 5
            });

            Bookings.Add(new Table()
            {
                ImageTable = "table4.png",
                People = 6
            });

        }
    }
}
