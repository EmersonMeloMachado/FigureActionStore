using FigureActionStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureActionStore.Model
{
    public class Category : BaseViewModel
    {
        public string name { get; set; }

        private string _backgroundColor;
        public string backgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }
    }
}
