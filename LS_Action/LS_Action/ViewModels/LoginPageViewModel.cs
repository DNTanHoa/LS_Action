using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LS_Action.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;

        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.navigationService = navigationService;

            LoginCommand = new DelegateCommand(async () => await LoginCommandExecute());
        }

        #region Properties

        private string username;
        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        private string password;
        public string Password
        {
            get => username;
            set => SetProperty(ref password, value);
        }

        #endregion

        #region Commands
        public DelegateCommand LoginCommand { get; private set; }

        public async Task LoginCommandExecute()
        {
            await navigationService.NavigateAsync("MainPage");
        }
        #endregion
    }
}
