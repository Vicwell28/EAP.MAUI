using System;
using System.Text.Json.Serialization;


namespace EAP.MAUI.Models
{
	public partial class ApiResponse<T>
	{
		[JsonPropertyName("message")]
		public string Message { get; set; }

		[JsonPropertyName("data")]
		public List<T> Data { get; set; }
	}

	public partial class Product
	{
		[JsonPropertyName("id")]
		public long Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("price")]
		public double Price { get; set; }

		[JsonPropertyName("url_image")]
		public string UrlImage { get; set; }

		[JsonPropertyName("status")]
		public long Status { get; set; }

		[JsonPropertyName("created_at")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonPropertyName("updated_at")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}
