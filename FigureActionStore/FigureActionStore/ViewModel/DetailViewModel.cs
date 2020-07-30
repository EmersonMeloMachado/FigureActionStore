using Xamarin.Forms;
using FigureActionStore.Model;
using System.Windows.Input;
using System;

namespace FigureActionStore.ViewModel
{
    public class DetailViewModel : BaseViewModel
    {
        public Figure figure { get; set; }
        public DetailViewModel(INavigation navigation)
        {
            Navigation = navigation;
            figure = new Figure();
        }
        public ICommand PopHomePageCommand => new Command(async () =>
        {
            try
            {
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }
}
