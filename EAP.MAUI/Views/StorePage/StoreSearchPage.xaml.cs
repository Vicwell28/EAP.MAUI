using EAP.MAUI.ViewModels.ShopViewModels;

namespace EAP.MAUI.Views.StorePage;

public partial class StoreSearchPage : ContentPage
{
	public IViewModelBase ViewModelBase { get; set; }
	public StoreSearchPage(StoreSearchViewModel StoreSearchViewModel)
	{
		InitializeComponent();
		this.ViewModelBase = StoreSearchViewModel;
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