namespace EAP.MAUI.Views.HomeView;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///Detail");
	}
}