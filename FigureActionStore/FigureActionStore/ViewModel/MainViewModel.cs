using System;
using Xamarin.Forms;
using System.Windows.Input;
using FigureActionStore.View;

namespace FigureActionStore.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        public ICommand HomePageCommand => new Command(async () =>
        {
            try
            {
                await Navigation.PushAsync(new HomePage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }
}
