using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EAP.MAUI.Models
{
	public class CategoryModel
    {
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("categoria")]
		public string Categoria { get; set; }
    }
}
