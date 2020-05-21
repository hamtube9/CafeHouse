using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CafeHouse.Util
{
    class PageUtil : IPageInterface
    {

        private Page MainPage
        {
            get { return Application.Current.MainPage; }
        }

        public Task DisplayAlert(string title, string messenger, string ok)
        {
            return MainPage.DisplayAlert(title, messenger, ok);

        }

        public Task<Page> PopAsync()
        {
            return MainPage.Navigation.PopAsync();
        }

        public Task PushAsync(Page page)
        {
            return MainPage.Navigation.PushAsync(page);
        }

        public void AddString(string key, string value)
        {
            Preferences.Set(key, value);
        }

        public string GetString(string key)
        {

            return Preferences.Get(key, "");
        }

        public void AddInt(string key, int value)
        {
            Preferences.Set(key, value);
        }

        public int GetInt(string key)
        {
            return Preferences.Get(key, 0);
        }

        public void AddBoolean(string key, Boolean b)
        {
            Preferences.Set(key, b);
        }

        public bool GetBoolean(string key)
        {
            return Preferences.Get(key, false);
        }
    }
}
