using EAP.MAUI.Helpers.LogHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAP.MAUI.ViewModels.ShopViewModels
{
    class LoginStoreShellViewModel : ShopViewModelBase
	{
		public override void Initialize()
		{
			// Implementar lógica de inicialización aquí
			Log.Info("LoginStoreShellViewModel OnAppearing");
		}

		public override void SubscribeEvents()
		{
			// Implementar suscripción a eventos aquí
			Log.Info("LoginStoreShellViewModel SubscribeEvents");
		}

		public override void UnSubscribeEvents()
		{
			// Implementar anulación de suscripción a eventos aquí
			Log.Info("LoginStoreShellViewModel UnSubscribeEvents");
		}

		public override void OnAppearing()
		{
			// Implementar lógica de inicialización aquí
			Log.Info("LoginStoreShellViewModel OnAppearing");
		}

		public override void OnDisappearing()
		{
			// Implementar lógica de limpieza aquí
			Log.Info("LoginStoreShellViewModel OnDisappearing");
		}
	}
}
