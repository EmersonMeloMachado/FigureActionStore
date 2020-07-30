using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FigureActionStore.ViewModel;
using FigureActionStore.Model;

namespace FigureActionStore.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        DetailViewModel viewModel = null;

        public DetailPage()
        {
            InitializeComponent();
            BindingContext = new DetailViewModel(Navigation);
        }

        public DetailPage(Figure figure)
        {
            InitializeComponent();

            viewModel = new DetailViewModel(Navigation);
            viewModel.figure = figure;
            BindingContext = viewModel;
        }
    }
}