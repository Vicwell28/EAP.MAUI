namespace EAP.MAUI.Views.LoginView;

public partial class Ultima : ContentPage
{
	public Ultima()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///DetailDos"); 
	}
}