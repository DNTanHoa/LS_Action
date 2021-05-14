using LS_Action.Models;
using LS_Action.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LS_Action.ViewModels
{
    public class SupporterListViewPageViewModel : ViewModelBase
    {
        private readonly IUserService userService;

        public SupporterListViewPageViewModel(INavigationService navigationService,
            IUserService userService)
            :base(navigationService)
        {
            this.userService = userService;

            Title = "Supporters";
            this.Supporters = new ObservableCollection<Users>(userService.GetSupporters());
        }

        private ObservableCollection<Users> supporters;
        public ObservableCollection<Users> Supporters
        {
            get => supporters;
            set
            {
                SetProperty(ref supporters, value);
                RaisePropertyChanged(nameof(Supporters));
            }
        }
    }
}
