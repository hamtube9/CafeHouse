using CafeHouse.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
 public   class HomeViewModel : TabbedViewModelBase
    {


        private ObservableCollection<ModelTest> listTest;
        public ObservableCollection<ModelTest> ListTest
        {
            get { return listTest ?? new ObservableCollection<ModelTest>(); }
            set { SetProperty(ref listTest , value) ; }
        }
       public List<ModelTest> List = new List<ModelTest>();
      
        public HomeViewModel()
        {
            ListTest = new ObservableCollection<ModelTest>();

        
           

        }
         
        private void GetData()
        {
            List.Add(new ModelTest()
            {
                Img = "dragonGray.png",
                Title = "For adult and kid",
                Content = "Hight Protein Breakfast"
            });


            List.Add(new ModelTest()
            {
                Img = "dragonGray.png",
                Title = "For adult and kid",
                Content = "Hight Protein Breakfast"
            });
            List.Add(new ModelTest()
            {
                Img = "dragonGray.png",
                Title = "For adult and kid",
                Content = "Hight Protein Breakfast"
            });

            List.Add(new ModelTest()
            {
                Img = "dragonGray.png",
                Title = "For adult and kid",
                Content = "Hight Protein Breakfast"
            });

            ListTest = new ObservableCollection<ModelTest>(List);
        }

        public override void CurrentTabbedChanged()
        {
           if(IsActive) GetData(); 
        }
    }
    
}
