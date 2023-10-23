using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EAP.MAUI.ViewModels.HomeViewModels
{
    public class TemViewModel
    {
        private TemViewModel() 
        {
            this.BackCommand = new Command(Regresar); 
        }

        private void Regresar()
        {

        }

        public ICommand BackCommand { get; private set; }

	}
}
