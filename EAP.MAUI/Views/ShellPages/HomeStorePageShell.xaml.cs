using EAP.MAUI.ViewModels.ShopViewModels;
using EAP.MAUI.Views.StorePage;

namespace EAP.MAUI.Views.ShellPages;

public partial class HomeStorePageShell : Shell
{
	public IViewModelBase ViewModelBase { get; set; }
	public HomeStorePageShell(HomeStoreShellViewModel HomeStoreShellViewModel)
	{
		InitializeComponent();
		this.ViewModelBase = HomeStoreShellViewModel;
		this.BindingContext = this.ViewModelBase;
		Routing.RegisterRoute("StoreProducDetailtPage", typeof(StoreProducDetailtPage));
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		this.ViewModelBase.OnAppearing();
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		this.ViewModelBase.OnDisappearing();
	}
}