using CafeHouse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
    class MenuViewModel :BindableObject
    {
        private ObservableCollection<Models.Menu> menus;
        public ObservableCollection<Models.Menu> Menus { get { return menus; } set { menus = value; OnPropertyChanged(); } }

        public List<string> Category { get; set; }
        public MenuViewModel()
        {


            Category = new List<string>
            {
                "Main Course",
                "Appetizers",
                "Desserts",
                "Soup"
            };


            Menus = new ObservableCollection<Models.Menu>();

            List<Models.Menu> list = new List<Models.Menu>();
            list.Add(new Models.Menu()
            {
                Image ="dragonGray.png",
                Title= "Baked sweet potatoes with kale, feta, chilli and onion",
                Price = "$7.00",
                Des= "This a very delicious Chinese dish with a spicy taste."
            });

            list.Add(new Models.Menu()
            {
                Image = "dragonGray.png",
                Title = "Brown rice bibimbap bowls",
                Price = "$7.00",
                Des = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do"
            });

            list.Add(new Models.Menu()
            {
                Image = "dragonGray.png",
                Title = "Raw kale tabbouleh with fried halloumi",
                Price = "$7.00",
                Des = "This a very delicious Chinese dish with a spicy taste."
            });

            list.Add(new Models.Menu()
            {
                Image = "dragonGray.png",
                Title = "Mexican chilli beef with polenta",
                Price = "$7.00",
                Des = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do"
            });

            list.Add(new Models.Menu()
            {
                Image = "dragonGray.png",
                Title = "Pork chops with winter veg quinoa",
                Price = "$7.00",
                Des = "This a very delicious Chinese dish with a spicy taste filled wi"
            });

            Menus = new ObservableCollection<Models.Menu>(list);
        }
    }
}
