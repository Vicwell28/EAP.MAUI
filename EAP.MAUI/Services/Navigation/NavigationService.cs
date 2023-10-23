using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAP.MAUI.Services.Navigation
{
	public class NavigationService : INavigationService
	{
		public Task InitializeAsync() => NavigateToAsync("");

		public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
		{
			var shellNavigation = new ShellNavigationState(route);

			return routeParameters != null
				? Shell.Current.GoToAsync(shellNavigation, routeParameters)
				: Shell.Current.GoToAsync(shellNavigation);
		}

		public Task PopAsync() => Shell.Current.GoToAsync("..");
	}
}