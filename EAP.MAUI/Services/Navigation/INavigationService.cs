using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAP.MAUI.Services.Navigation
{
	public interface INavigationService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		Task InitializeAsync();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="route"></param>
		/// <param name="routeParameters"></param>
		/// <returns></returns>
		Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		Task PopAsync();
	}
}
