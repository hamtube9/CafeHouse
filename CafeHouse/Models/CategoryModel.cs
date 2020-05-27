using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CafeHouse.Models
{
    public class CategoryModel : BindableBase
    {
        public string NameCategory { set; get; }
        public bool IsSelected { get; set; }

    }
}
