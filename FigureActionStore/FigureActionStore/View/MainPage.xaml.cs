using Xamarin.Forms;
using System.ComponentModel;
using FigureActionStore.ViewModel;

namespace FigureActionStore.View
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(Navigation);
        }
    }
}
