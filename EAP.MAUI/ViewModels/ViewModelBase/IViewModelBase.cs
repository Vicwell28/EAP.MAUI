using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAP.MAUI.ViewModels.ViewModelBase
{
	public interface IViewModelBase
	{
		void OnAppearing() ;
		void OnDisappearing(); 
	}
}
