using CafeHouse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CafeHouse.ViewModels
{
    class ReviewsViewModel : BindableObject

    {
        private ObservableCollection<Reviews> _reviews;
        public ObservableCollection<Reviews> Reviews { get { return _reviews; } set { _reviews = value; OnPropertyChanged("Reviews"); } }

        public ReviewsViewModel()
        {
            Reviews = new ObservableCollection<Reviews>();
            Reviews.Add(new Reviews()
            {
                Avatar = "Woman.png",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempo incididunt ut labore et dolore magma aliqua.",
                ListImage = null,
                NameUser = "Cris Stankovic",
                Rate = 4
            }) ;

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
    }
}
