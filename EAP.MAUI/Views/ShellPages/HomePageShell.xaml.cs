using EAP.MAUI.Views.LinkView;
using EAP.MAUI.Views.LoginView;

namespace EAP.MAUI.Views.ShellPages;

public partial class HomePageShell : Shell
{
	public HomePageShell()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		FlyoutBehavior = FlyoutBehavior.Disabled;
		await Shell.Current.GoToAsync("//Login");
		FlyoutBehavior = FlyoutBehavior.Flyout;


	}
}