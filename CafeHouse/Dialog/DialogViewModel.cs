using CafeHouse.Models;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Prism.Services.Dialogs;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CafeHouse.Dialog
{
    public class DialogViewModel : BindableBase, IDialogAware, IAutoInitialize
    {
        INavigationService navigation;
        IPageDialogService dialog;
        public DelegateCommand CloseCommand { get; set; }

        public ICommand AddReviewCommand => new DelegateCommand(AddReview);

        public ICommand AddImageCommand => new DelegateCommand(AddImage);

        public ICommand DeleteImageCommand => new DelegateCommand<ImageSource>(DeleteImage);
        

        public ImageSource Source { get; set; }

        private bool _isVisible;
        public bool IsVisible { get { return _isVisible; } set { SetProperty(ref _isVisible, value); } }

        private bool _isInvisible;
        public bool IsInvisible { get { return _isInvisible; } set { SetProperty(ref _isInvisible, value); } }

  

        public string Content { set; get; }
        public double Rate { set; get; }
        private ObservableCollection<ImageSource> _listImage;
        public  ObservableCollection<ImageSource> ListImage { get { return _listImage; } set { SetProperty(ref _listImage, value); } }


        public Reviews ReviewItem { set; get; }


        public DialogViewModel(INavigationService _navigation, IPageDialogService _dialog)
        {
  
            dialog = _dialog;
            navigation = _navigation;
             CloseCommand = new DelegateCommand(() => RequestClose(null));
            ListImage = new ObservableCollection<ImageSource>();
            IsInvisible = false;
        }
        public event Action<IDialogParameters> RequestClose;

        public bool CanCloseDialog() => true;
      

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {

        }

        private void AddReview()
        {
            ReviewItem = new Reviews();
            ReviewItem.Rate = Rate;
            ReviewItem.Avatar = "dragonGray.png";
            ReviewItem.Content = Content;
            var listItem = new List<ImageReview>();
            foreach(var item in ListImage)
            {
                listItem.Add(new ImageReview()
                {
                    ImageContent = item
                });
            }
            ReviewItem.ListImage = listItem;
            var navigationParams = new DialogParameters();
            navigationParams.Add("reviews", ReviewItem); 

            RequestClose.Invoke(navigationParams);
            ListImage.Clear();
            IsInvisible = false;
            IsVisible = false;
        }

        [Obsolete]
        private void AddImage()
        {
            IActionSheetButton TakePicture = ActionSheetButton.CreateButton("Take Picture Form Camera", new DelegateCommand(ButtonTakePicter));
            IActionSheetButton GetPicture = ActionSheetButton.CreateButton("Get Picture From Gallery", new DelegateCommand(ButtonGetPicture));
            IActionSheetButton Cancel = ActionSheetButton.CreateCancelButton("Cancel", new DelegateCommand(() => { return; }));

            dialog.DisplayActionSheetAsync("What do you want to do with : ", Cancel, TakePicture, GetPicture);

        }

        private void ButtonGetPicture()
        {
            this.GetPhoto();

            if(ListImage.Count >=0 )
            {
                IsVisible = true;
            }
           


            if(ListImage.Count ==2)
            {
                IsInvisible = true;
            }

         
        }

        private void ButtonTakePicter()
        {
            this.TakePicture();
            if (ListImage.Count >= 0)
            {
                IsVisible = true;
            }
            if (ListImage.Count== 2)
            {
                IsInvisible = true;
            }

        }

        public async Task TakePicture()
        {
            if (!CrossMedia.Current.IsCameraAvailable ||
                    !CrossMedia.Current.IsTakePhotoSupported)
            {
                await Application.Current.MainPage.DisplayAlert("No Camera",
                            "Sorry! No camera available.", "OK");
                return ;
            } 

            var file = await CrossMedia.Current.TakePhotoAsync(new
                Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "TestPhotoFolder",
                SaveToAlbum = true,
                PhotoSize = PhotoSize.Medium,
            });

            if (file == null)
            {
                IsVisible = false;
                return;

            }

            this.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });
            ListImage.Add(Source);

            
  
        }


        public async Task GetPhoto()
        {
            if (!CrossMedia.Current.IsTakePhotoSupported)
            {
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
            {
                PhotoSize = PhotoSize.Medium,
            });
            if (file == null)
            {
                IsVisible = false;
                return;

            }
            this.Source = ImageSource.FromStream(() =>
           {
               var stream = file.GetStream();
               return stream;
           });
            ListImage.Add(Source);
        }

        private void DeleteImage(ImageSource obj)
        {
            var img = ListImage.Where(a => a == obj).FirstOrDefault();
            ListImage.Remove(img);

            if (ListImage.Count == 0)
            {
                IsVisible = false;
            }

            if (ListImage.Count > 0)
            {
                IsVisible = true;
            }

            if(ListImage.Count >1)
            {
                IsInvisible = false;
            }

           
        }

      

    }
}
