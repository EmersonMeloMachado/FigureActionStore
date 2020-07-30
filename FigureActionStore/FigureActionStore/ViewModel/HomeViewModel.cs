using System;
using System.Linq;
using Xamarin.Forms;
using System.Windows.Input;
using FigureActionStore.Model;
using Xamarin.Forms.Internals;
using FigureActionStore.Service;
using System.Collections.ObjectModel;
using FigureActionStore.View;

namespace FigureActionStore.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        private Figure _itemSelected;
        public ObservableCollection<Figure> Figure { get; set; }
        public ObservableCollection<Category> Category { get; set; }

        public Figure ItemSelected
        {
            get { return _itemSelected; }
            set { SetProperty(ref _itemSelected, value); }
        }

        private int _selectedFigureActionId;
        public int SelectedFigureActionId
        {
            get { return _selectedFigureActionId; }
            set { SetProperty(ref _selectedFigureActionId, value); }
        }

        public HomeViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Figure = new ObservableCollection<Figure>();
            GetCategoryFigureAction();
        }

        private void GetCategoryFigureAction()
        {
            Category = new ObservableCollection<Category>(DataService.GetCategoryFigureAction());
            GetFigureAction("Game");
        }

        private void GetFigureAction(string type)
        {
            var figure = new ObservableCollection<Figure>(DataService.GetFigureAction());

            if (Figure.Count > 0)
                Figure.Clear();

            foreach (var item in figure)
            {
                if (item.type == type)
                    Figure.Add(item);
            }
        }

        public ICommand SelectedCommand => new Command<Figure>(async (figure) =>
        {
            try
            {
                if (IsBusy)
                    return;

                IsBusy = true;
                SelectedFigureActionId = figure.Id;
                await Navigation.PushAsync(new DetailPage(figure));

                IsBusy = false;
            }
            catch (Exception ex)
            {

                IsBusy = false;
                Console.WriteLine(ex.Message);
            }
        });

        public ICommand TypeFigureActionCommand => new Command(async (object obj) =>
        {
            try
            {
                if (IsBusy)
                    return;

                IsBusy = true;
                var category = obj as Category;

                var index = Category.ToList().FindIndex(w => w.name == category.name);

                if (index > -1)
                {
                    Unselect();
                    Category[index].backgroundColor = "#BF4A45";
                    GetFigureAction(category.name);
                }

                IsBusy = false;
            }
            catch (Exception ex)
            {
                IsBusy = false;
                Console.WriteLine(ex.Message);
            }
        });

        private void Unselect()
        {
            Category.ForEach((item) =>
            {
                item.backgroundColor = "#2E2F33";
            }); 
        }

        public ICommand PopMainPageCommand => new Command(async () =>
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
