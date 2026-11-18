using Microsoft.Extensions.DependencyInjection;
using STSP.Pages;

namespace STSP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Login()));
        }
    }
}