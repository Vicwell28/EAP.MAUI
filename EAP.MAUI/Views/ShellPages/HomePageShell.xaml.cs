using EAP.MAUI.Views.LinkView;
using EAP.MAUI.Views.LoginView;
using EAP.MAUI.Views;

namespace EAP.MAUI.Views.ShellPages;

public partial class HomePageShell : Shell
{
	public HomePageShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("paginaDetalle", typeof(MovieView.MovieView)); 
	}

	private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		FlyoutBehavior = FlyoutBehavior.Disabled;
		await Shell.Current.GoToAsync("//Login");
		FlyoutBehavior = FlyoutBehavior.Flyout;


	}
}