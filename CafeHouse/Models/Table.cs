using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeHouse.Models
{
    public class Table : BindableBase
    {
        public string ImageTable { set; get; }

        public int People { set; get; }

        public bool IsSelected { set; get; }
    }
}
