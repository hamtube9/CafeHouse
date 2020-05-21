using CafeHouse.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
    class TestViewModel : BindableObject
    {


        private ObservableCollection<ModelTest> listTest { get; set; }
        public ObservableCollection<ModelTest> ListTest
        {
            get { return listTest; }
            set { listTest = value; }
        }
       public List<ModelTest> List = new List<ModelTest>();
      



        public TestViewModel()
        {
            ListTest = new ObservableCollection<ModelTest>();




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
    }
    
}
