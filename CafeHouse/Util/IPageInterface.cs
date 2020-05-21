using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CafeHouse.Util
{
    interface IPageInterface
    {
        Task PushAsync(Page page);
        Task<Page> PopAsync();

        Task DisplayAlert(string title, string messenger, string ok);
    }
}
