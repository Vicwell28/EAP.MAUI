using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAP.MAUI.Helpers.LogHelper
{
	public static class Log
	{
		public static void Info(string message)
		{
			System.Diagnostics.Debug.WriteLine("----------------------------------------------");
			System.Diagnostics.Debug.WriteLine(message);
			System.Diagnostics.Debug.WriteLine("----------------------------------------------\n\n");
			System.Diagnostics.Debug.WriteLine("\n\n");

		}

		public static void Info(object obj)
		{
			System.Diagnostics.Debug.WriteLine("----------------------------------------------");
			System.Diagnostics.Debug.WriteLine(obj.ToString());
			System.Diagnostics.Debug.WriteLine("----------------------------------------------\n\n");
			System.Diagnostics.Debug.WriteLine("\n\n");
		}
	}
}
