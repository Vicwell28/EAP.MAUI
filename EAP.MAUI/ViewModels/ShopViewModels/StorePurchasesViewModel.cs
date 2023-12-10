using EAP.MAUI.Helpers.LogHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAP.MAUI.ViewModels.ShopViewModels
{
    class StorePurchasesViewModel : ShopViewModelBase
	{
		public override void Initialize()
		{
			// Implementar lógica de inicialización aquí
			Log.Info("StorePurchasesViewModel OnAppearing");
		}

		public override void SubscribeEvents()
		{
			// Implementar suscripción a eventos aquí
			Log.Info("StorePurchasesViewModel SubscribeEvents");
		}

		public override void UnSubscribeEvents()
		{
			// Implementar anulación de suscripción a eventos aquí
			Log.Info("StorePurchasesViewModel UnSubscribeEvents");
		}

		public override void OnAppearing()
		{
			// Implementar lógica de inicialización aquí
			Log.Info("StorePurchasesViewModel OnAppearing");
		}

		public override void OnDisappearing()
		{
			// Implementar lógica de limpieza aquí
			Log.Info("StorePurchasesViewModel OnDisappearing");
		}
	}
}
