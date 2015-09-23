using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace EventBinding
{
    public class MainPageViewModel
    {
        public async void Click1()
        {
            var d = new MessageDialog("Click1");
            await d.ShowAsync();
        }

        public async void Click2(object sender, object e)
        {
            var d = new MessageDialog("Click2");
            await d.ShowAsync();
        }

        public async void Click3(object sender, RoutedEventArgs e)
        {
            var d = new MessageDialog("Click3");
            await d.ShowAsync();
        }


    }
}
