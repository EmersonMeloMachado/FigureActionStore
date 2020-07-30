using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FigureActionStore.ViewModel;

namespace FigureActionStore.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel(Navigation);
        }
    }
}