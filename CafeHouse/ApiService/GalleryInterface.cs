using CafeHouse.Models.image;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CafeHouse.ApiService
{
  public  interface GalleryInterface
    {
        [Get("/images/latest")]
        Task<Gallery> GetAllImage();  

        [Get("/images/{id}")]
        Task<Data> GetImageById(string Id);


    }
}
