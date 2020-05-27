using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeHouse.Models
{
    public class Datetime : BindableBase
    {
        public string DateOfMonth { get; set; }
        public string DayOfWeek { get; set; }

        public bool IsSelected { get; set; }
    }
}
