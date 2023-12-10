using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.Models;
using EAP.MAUI.Services.ApiService;
using System.Text.Json;
using System.Windows.Input;
using System.Text.Json.Serialization;


namespace EAP.MAUI.ViewModels.ShopViewModels
{
	public class StoreProductDetailViewModel : ShopViewModelBase
	{
		#region Fields and Properties

		private Product selectedProduct;
		public Product SelectedProduct
		{
			get => selectedProduct;
			set
			{
				selectedProduct = value;
				OnPropertyChanged();
			}
		}

		private readonly IApiService apiService;

		#endregion

		#region Constructor

		public StoreProductDetailViewModel(IApiService apiService)
		{
			this.apiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
			CreateSalesOrderCommand = new Command(CreateSalesOrder);
		}

		#endregion

		#region Commands

		public ICommand CreateSalesOrderCommand { get; private set; }

		#endregion

		#region Lifecycle Methods

		public override void Initialize()
		{
			Log.Info("StoreProductDetailViewModel OnAppearing");
		}

		public override void SubscribeEvents()
		{
			Log.Info("StoreProductDetailViewModel SubscribeEvents");
		}

		public override void UnSubscribeEvents()
		{
			Log.Info("StoreProductDetailViewModel UnSubscribeEvents");
		}

		public override void OnAppearing()
		{
			Log.Info("StoreProductDetailViewModel OnAppearing");
		}

		public override void OnDisappearing()
		{
			Log.Info("StoreProductDetailViewModel OnDisappearing");
		}

		public override void ApplyQueryAttributes(IDictionary<string, object> query)
		{
			Log.Info("ApplyQueryAttributes");
			SelectedProduct = JsonSerializer.Deserialize<Product>(Uri.UnescapeDataString(query["ProductItem"] as string));
			Log.Info(SelectedProduct);
		}

		#endregion

		#region Private Methods

		private async void CreateSalesOrder()
		{
			var sale = new Sale
			{
				SaleId = new Random().Next(0, 10000000),
				Products = new List<ProductSale>
				{
					new ProductSale { ProductBrancheId = (int)SelectedProduct.Id, Quantity = 1 }
				},
				Status = true
			};

			var response = await this.apiService.StoreAsync("http://192.168.1.14:8000/api/v1/sales/detail", sale);
		}

		#endregion
	}

	#region Helper Classes

	public class Sale
	{
		[JsonPropertyName("sale_id")]
		public int SaleId { get; set; }

		[JsonPropertyName("products")]
		public List<ProductSale> Products { get; set; }

		[JsonPropertyName("status")]
		public bool Status { get; set; }
	}

	public class ProductSale
	{
		[JsonPropertyName("product_branche_id")]
		public int ProductBrancheId { get; set; }

		[JsonPropertyName("quantity")]
		public int Quantity { get; set; }
	}

	#endregion
}
