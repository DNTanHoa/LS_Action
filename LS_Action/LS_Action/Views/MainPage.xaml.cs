
using Prism.Navigation;
using Xamarin.Forms;

namespace LS_Action.Views
{
    public partial class MainPage : TabbedPage, INavigatedAware
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() == NavigationMode.New)
            {
                if (Children.Count == 1)
                {
                    return;
                }
                for (var pageIndex = 1; pageIndex < Children.Count; pageIndex++)
                {
                    var page = Children[pageIndex];
                    (page?.BindingContext as INavigationAware)?.OnNavigatedTo(parameters);
                }
            }
        }
    }
}
