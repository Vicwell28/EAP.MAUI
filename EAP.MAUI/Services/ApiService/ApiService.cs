using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EAP.MAUI.Services.ApiService
{
	public class ApiService : IApiService
	{
		private readonly HttpClient _httpClient;

		public ApiService(HttpClient httpClient)
		{
			_httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
		}

		public async Task<T> IndexAsync<T>(string uri)
		{
			try
			{
				var response = await _httpClient.GetAsync(uri);

				if (response.IsSuccessStatusCode)
				{
					var json = await response.Content.ReadAsStringAsync();
					return JsonSerializer.Deserialize<T>(json);
				}

				// Manejar casos en los que la respuesta no es exitosa
				throw new HttpRequestException($"Error en la solicitud GET: {response.StatusCode}");
			}
			catch (Exception ex)
			{
				// Manejar excepciones de red, timeouts, etc.
				throw new Exception($"Error al realizar la solicitud GET: {ex.Message}");
			}
		}

		public async Task<T> StoreAsync<T>(string uri, T data)
		{
			try
			{
				var json = JsonSerializer.Serialize(data);
				var content = new StringContent(json, Encoding.UTF8, "application/json");

				var response = await _httpClient.PostAsync(uri, content);
				if (response.IsSuccessStatusCode)
				{
					var jsonResponse = await response.Content.ReadAsStringAsync();
					return JsonSerializer.Deserialize<T>(jsonResponse);
				}

				// Manejar casos en los que la respuesta no es exitosa
				throw new HttpRequestException($"Error en la solicitud POST: {response.StatusCode}");
			}
			catch (Exception ex)
			{
				// Manejar excepciones de red, timeouts, etc.
				throw new Exception($"Error al realizar la solicitud POST: {ex.Message}");
			}
		}

		public async Task<T> ShowAsync<T>(string uri, string id)
		{
			try
			{
				var response = await _httpClient.GetAsync($"{uri}/{id}");

				if (response.IsSuccessStatusCode)
				{
					var json = await response.Content.ReadAsStringAsync();
					return JsonSerializer.Deserialize<T>(json);
				}

				// Manejar casos en los que la respuesta no es exitosa
				throw new HttpRequestException($"Error en la solicitud GET: {response.StatusCode}");
			}
			catch (Exception ex)
			{
				// Manejar excepciones de red, timeouts, etc.
				throw new Exception($"Error al realizar la solicitud GET: {ex.Message}");
			}
		}

		public async Task<T> UpdateAsync<T>(string uri, string id, T obj)
		{
			try
			{
				var json = JsonSerializer.Serialize(obj);
				var content = new StringContent(json, Encoding.UTF8, "application/json");

				var response = await _httpClient.PutAsync($"{uri}/{id}", content);
				if (response.IsSuccessStatusCode)
				{
					var jsonResponse = await response.Content.ReadAsStringAsync();
					return JsonSerializer.Deserialize<T>(jsonResponse);
				}

				// Manejar casos en los que la respuesta no es exitosa
				throw new HttpRequestException($"Error en la solicitud PUT: {response.StatusCode}");
			}
			catch (Exception ex)
			{
				// Manejar excepciones de red, timeouts, etc.
				throw new Exception($"Error al realizar la solicitud PUT: {ex.Message}");
			}
		}

		public async Task<T> DeleteAsync<T>(string uri, string id)
		{
			try
			{
				var response = await _httpClient.DeleteAsync($"{uri}/{id}");

				if (response.IsSuccessStatusCode)
				{
					var json = await response.Content.ReadAsStringAsync();
					return JsonSerializer.Deserialize<T>(json);
				}

				// Manejar casos en los que la respuesta no es exitosa
				throw new HttpRequestException($"Error en la solicitud DELETE: {response.StatusCode}");
			}
			catch (Exception ex)
			{
				// Manejar excepciones de red, timeouts, etc.
				throw new Exception($"Error al realizar la solicitud DELETE: {ex.Message}");
			}
		}
	}
}
