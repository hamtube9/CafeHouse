using CafeHouse.Models;
using ImTools;
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
    public class MenuViewModel : TabbedViewModelBase
    {
        private ObservableCollection<Models.Menu> menus;
        public ObservableCollection<Models.Menu> Menus { get { return menus ?? new ObservableCollection<Models.Menu>(); ; } set { SetProperty(ref menus, value); } }

        //OptionMenuCategory option { set; get; } = OptionMenuCategory.Main;

        //public ICommand OptionMenuCommand => new DelegateCommand<OptionMenuCategory>(OptionMenuClick);

        //private void OptionMenuClick(OptionMenuCategory obj)
        //{
        //    option = obj;
        //}

          public ICommand MenuItemCommand => new DelegateCommand<CategoryModel>(SelectedItemMenu);

       private ObservableCollection<CategoryModel> _categorys;

      public ObservableCollection<CategoryModel> Categories
        {
            get => _categorys;
            set { SetProperty(ref _categorys, value); }
        }
        public MenuViewModel()
        {

            Categories = new ObservableCollection<CategoryModel>();
            Categories.Add(new CategoryModel()
            {
                NameCategory = "Main Course", 
            });

            
            Categories.Add(new CategoryModel()
            {
                NameCategory = "Desserts", 
            });

            Categories.Add(new CategoryModel()
            {
                NameCategory = "Soup", 
            });



            Menus = new ObservableCollection<Models.Menu>();


        }

        public override void CurrentTabbedChanged()
        {
         
                
        }

        private void GetData()
        {
            List<Models.Menu> list = new List<Models.Menu>();
            list.Add(new Models.Menu()
            {
                Image = "dragonGray.png",
                Title = "Baked sweet potatoes with kale, feta, chilli and onion",
                Price = "$7.00",
                Des = "This a very delicious Chinese dish with a spicy taste."
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


        private void SelectedItemMenu(CategoryModel obj)
        {

            if (obj == null|| obj.IsSelected)
            {
                return;
            } 
               var selectedCategory = Categories.FirstOrDefault(d => d.IsSelected);
            if (selectedCategory != null)
            {
                selectedCategory.IsSelected = false;
            }
             
            obj.IsSelected = true;
            GetData();
        }
    }
}
