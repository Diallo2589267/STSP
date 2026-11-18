namespace STSP.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnSeConnecter_Clicked(object sender, EventArgs e)
    {
        ((App)Application.Current!).SeConnecter();
    }

    private async void btnNouveauCompte_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NouveauCompte());
    }
}