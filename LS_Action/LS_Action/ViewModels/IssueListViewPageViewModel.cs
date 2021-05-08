using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LS_Action.ViewModels
{
    public class IssueListViewPageViewModel : ViewModelBase
    {
        public IssueListViewPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            Title = "Issues";
        }
    }
}
