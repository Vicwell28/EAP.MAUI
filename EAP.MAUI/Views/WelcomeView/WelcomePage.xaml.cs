namespace EAP.MAUI.Views.WelcomeView;

public partial class WelcomePage : ContentPage
{
	bool isAppearingLogin = true;
	public WelcomePage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		if (isAppearingLogin)
		{
			this.isAppearingLogin = false;
		}
	}
}