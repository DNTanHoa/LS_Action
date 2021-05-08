using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LS_Action.ViewModels
{
    public class MainFunctionPageViewModel : ViewModelBase
    {
        public MainFunctionPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            Title = "Menu";

            FunctionTappedCommand = new DelegateCommand(async () => await FunctionTappedExecute());
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        #region Properties

        #endregion

        #region Commands

        public DelegateCommand FunctionTappedCommand { get; private set; }

        public async Task FunctionTappedExecute()
        {
            await NavigationService.NavigateAsync("IssueListViewPage");
        }

        #endregion

        #region Events

        #endregion
    }
}
