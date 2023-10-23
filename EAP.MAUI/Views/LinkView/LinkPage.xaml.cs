namespace EAP.MAUI.Views.LinkView;

public partial class LinkPage : ContentPage
{
	public LinkPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		var url = "https://utt.edu.mx";
		await Launcher.OpenAsync(url);
	}
}