using Prism;
using Prism.Ioc;
using OrderListPrism.ViewModels;
using OrderListPrism.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OrderListPrism.Services.Interfaces.DataBindingPrism.Services.Interfaces;
using OrderListdatabase;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace OrderListPrism
{
    public partial class App
    {
   
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IDatabase, OrderListDatabase>();
            
            
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<Page1, Page1ViewModel>();
            containerRegistry.RegisterForNavigation<Page2, Page2ViewModel>();
        }
    }
}
