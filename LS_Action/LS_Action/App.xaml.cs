using LS_Action.Services;
using LS_Action.ViewModels;
using LS_Action.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace LS_Action
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Shapes_Experimental", "MediaElement_Experimental" });

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<MainFunctionPage, MainFunctionPageViewModel>();
            containerRegistry.RegisterForNavigation<MachineStatusPage, MachineStatusPageViewModel>();
            containerRegistry.RegisterForNavigation<IssueListViewPage, IssueListViewPageViewModel>();

            #region Register Service

#if DEBUG
            containerRegistry.RegisterSingleton<IMachineService, MockMachineService>();
            containerRegistry.RegisterSingleton<IIssueService, MockIssueService>();
            containerRegistry.RegisterSingleton<IUserService, MockUserService>();
#else
#endif

            #endregion
            containerRegistry.RegisterForNavigation<IssueDetailViewPage, IssueDetailViewPageViewModel>();
            containerRegistry.RegisterForNavigation<SupporterListViewPage, SupporterListViewPageViewModel>();
        }
    }
}
