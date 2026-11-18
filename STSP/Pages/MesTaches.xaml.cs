namespace STSP.Pages;

public partial class MesTaches : ContentPage
{
	public MesTaches()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PushAsync(new DemandeSupport());
    }
}