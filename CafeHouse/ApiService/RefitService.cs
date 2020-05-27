using CafeHouse.Models.image;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CafeHouse.ApiService
{
   public class RefitService
    {
        private readonly GalleryInterface gallery;

        public RefitService()
        {
     
        }

        public async Task<Gallery> GetAllImage()
        {
            return await gallery.GetAllImage().ConfigureAwait(false);
        }

    }
}
