using LS_Action.Models;
using LS_Action.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace LS_Action.ViewModels
{
    public class IssueListViewPageViewModel : ViewModelBase
    {
        private readonly IIssueService issueService;

        public IssueListViewPageViewModel(INavigationService navigationService,
            IIssueService issueService)
            :base(navigationService)
        {
            Title = "Issues";
            this.issueService = issueService;

            AddNewCommand = new DelegateCommand(async () => await AddNewCommandExecute());

            this.Issues = new ObservableCollection<Issue>(issueService.GetIssues().Result);
        }

        #region Properties

        private ObservableCollection<Issue> issues;
        public ObservableCollection<Issue> Issues
        {
            get => issues;
            set
            {
                SetProperty(ref issues, value);
                RaisePropertyChanged(nameof(Issues));
            }
        }

        #endregion

        #region Commands

        public DelegateCommand AddNewCommand { get; private set; }

        public async Task AddNewCommandExecute()
        {
            await NavigationService.NavigateAsync("IssueDetailViewPage");
        }

        #endregion

        #region Events

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            
        }

        #endregion
    }
}
