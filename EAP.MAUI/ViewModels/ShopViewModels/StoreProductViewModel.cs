using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.Models;
using EAP.MAUI.Services.ApiService;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;

namespace EAP.MAUI.ViewModels.ShopViewModels
{
	public class StoreProductViewModel : ShopViewModelBase
	{
		#region Fields

		private readonly IApiService apiService;
		private ObservableCollection<Product> products;
		private Product selectedProduct;

		#endregion

		#region Properties

		public ObservableCollection<Product> Products
		{
			get => products;
			set
			{
				products = value;
				OnPropertyChanged();
			}
		}

		public Product SelectedProduct
		{
			get => selectedProduct;
			set
			{
				selectedProduct = value;
				OnPropertyChanged();
			}
		}

		#endregion

		#region Commands

		public ICommand SelectionChangedCommand { get; private set; }

		#endregion

		#region Constructor

		public StoreProductViewModel(IApiService apiService)
		{
			this.apiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
			SelectionChangedCommand = new Command(OnSelectionChanged);
		}

		#endregion

		#region Lifecycle Methods

		public override void Initialize()
		{
			Log.Info("StoreProductViewModel OnAppearing");
		}

		public override void SubscribeEvents()
		{
			Log.Info("StoreProductViewModel SubscribeEvents");
		}

		public override void UnSubscribeEvents()
		{
			Log.Info("StoreProductViewModel UnSubscribeEvents");
		}

		public async override void OnAppearing()
		{
			Log.Info("StoreProductViewModel OnAppearing");
			var response = await this.apiService.IndexAsync<ApiResponse<Product>>("http://192.168.1.14:8000/api/v1/product");
			Products = new ObservableCollection<Product>(response.Data);
			Log.Info(Products.Count);
			Log.Info(Products);
		}

		public override void OnDisappearing()
		{
			Log.Info("StoreProductViewModel OnDisappearing");
		}

		#endregion

		#region Private Methods

		private void OnSelectionChanged()
		{
			var productJson = JsonSerializer.Serialize(selectedProduct);
			Shell.Current.GoToAsync($"StoreProducDetailtPage?ProductItem={productJson}");
		}

		#endregion
	}
}
