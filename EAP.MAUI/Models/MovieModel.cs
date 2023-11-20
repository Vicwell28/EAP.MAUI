using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EAP.MAUI.Models
{
	public class Movie
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("titulo")]
		public string Title { get; set; }

		[JsonPropertyName("imagen")]
		public string Imagen { get; set; }

		[JsonPropertyName("director")]
		public DirectorModel Director { get; set; }

		[JsonPropertyName("duracion")]
		public string Duracion { get; set; }

		[JsonPropertyName("categoria")]
		public CategoryModel Categoria { get; set; }

		[JsonPropertyName("sinopsis")]
		public string Sinopsis { get; set; }
	}
}
