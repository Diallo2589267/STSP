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

        public void SeConnecter()
        {
            Current!.Windows[0].Page = new AppShell();
        }

        public void SeDeconnecter()
        {
            Current!.Windows[0].Page = new NavigationPage(new Login());
        }

    }
}