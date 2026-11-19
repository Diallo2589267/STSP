namespace STSP.Pages;

public partial class Clients : ContentPage
{
	public Clients()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PushAsync(new NouveauClient());
    }
}