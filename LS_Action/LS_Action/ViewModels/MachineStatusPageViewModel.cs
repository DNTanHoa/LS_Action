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
    public class MachineStatusPageViewModel : ViewModelBase
    {
        private readonly IMachineService machineService;

        public MachineStatusPageViewModel(INavigationService navigationService,
            IMachineService machineService)
            :base(navigationService)
        {
            Title = "Machine Status";
            this.machineService = machineService;
        }

        #region Properties

        private ObservableCollection<Machines> machines;
        public ObservableCollection<Machines> Machines
        {
            get => machines;
            set
            {
                SetProperty(ref machines, value);
                RaisePropertyChanged(nameof(Machines));
            }
        }

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                SetProperty(ref isBusy, value);
                RaisePropertyChanged(nameof(IsBusy));
            }
        }

        #endregion

        #region Commands

        public DelegateCommand ItemTappedCommand { get; private set; }

        public async Task ItemTappedExecute()
        {
            await NavigationService.NavigateAsync("");
        }

        #endregion

        #region Events

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            IsBusy = true;

            var machines = machineService.GetMachines();
            this.Machines = new ObservableCollection<Machines>(machines.Result);

            IsBusy = false;

            base.OnNavigatedTo(parameters);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        #endregion
    }
}
