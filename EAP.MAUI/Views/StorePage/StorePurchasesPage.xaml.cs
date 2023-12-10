using EAP.MAUI.ViewModels.ShopViewModels;

namespace EAP.MAUI.Views.StorePage;

public partial class StorePurchasesPage : ContentPage
{
	public IViewModelBase ViewModelBase { get; set; }
	public StorePurchasesPage(StorePurchasesViewModel StorePurchasesViewModel)
	{
		InitializeComponent();
		this.ViewModelBase = StorePurchasesViewModel;
		this.BindingContext = this.ViewModelBase;
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