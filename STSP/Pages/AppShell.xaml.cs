namespace STSP.Pages;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    private void menuSeDeconnecter_Clicked(object sender, EventArgs e)
    {
        ((App)Application.Current!).SeDeconnecter();
    }
}