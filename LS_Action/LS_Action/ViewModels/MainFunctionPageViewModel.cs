using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LS_Action.ViewModels
{
    public class MainFunctionPageViewModel : ViewModelBase
    {
        public MainFunctionPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            Title = "Menu";
        }
    }
}
