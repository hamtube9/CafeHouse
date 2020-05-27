using CafeHouse.Models;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
    class ReviewsViewModel : ViewModelBase, INavigatedAware
    {
        IDialogService dialog;
        INavigationService navigation;
        private ObservableCollection<Reviews> _reviews;
        public ObservableCollection<Reviews> Reviews { get { return _reviews; } set { SetProperty(ref _reviews, value); } }


        public ICommand GoBack => new DelegateCommand(BackAsync);

        public ICommand OnShowDialog => new DelegateCommand(ShowDialog);

 



        public ReviewsViewModel(INavigationService _service, IDialogService _dialog)
        {
            dialog = _dialog;
            navigation = _service;

            Reviews = new ObservableCollection<Reviews>();
            Reviews.Add(new Reviews()
            {
                Avatar = "Woman.png",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempo incididunt ut labore et dolore magma aliqua.",
                ListImage = null,
                NameUser = "Cris Stankovic",
                Rate = 4
            });

            var listImage = new List<ImageReview>();
            listImage.Add(new ImageReview()
            {
                ImageContent = "review1.png"
            });
            listImage.Add(new ImageReview()
            {
                ImageContent = "review2.png"
            });

            listImage.Add(new ImageReview()
            {
                ImageContent = "review3.png"
            });

            Reviews.Add(new Reviews()
            {
                Avatar = "Man.png",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magma aliqua. Ui enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo conse-quat.",
                ListImage = listImage,
                NameUser = "John Doe",
                Rate = 5
            }); ;

            Reviews.Add(new Reviews()
            {
                Avatar = "Woman.png",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempo incididunt ut labore et dolore magma aliqua.",
                ListImage = null,
                NameUser = "Matina",
                Rate = 4.5
            });
        }

        private void BackAsync()
        {
            navigation.GoBackAsync();
        }

        private void ShowDialog()
        {
                  dialog.ShowDialog("ReviewsDialog",(result)=> {
                     var reviewsItem= result.Parameters.GetValue<Reviews>("reviews");
                      if(reviewsItem != null)
                      {
                          Reviews.Insert(0, reviewsItem);
                      }
                  });
        }

    

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
  
        }


      
    }
}
