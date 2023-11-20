using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EAP.MAUI.Services.ApiService
{
    public interface IApiService
    {
		Task<T> IndexAsync<T>(string uri);
		Task<T> StoreAsync<T>(string uri, T data);
		Task<T> ShowAsync<T>(string uri, string id);
		Task<T> UpdateAsync<T>(string uri, string id, T obj);
		Task<T> DeleteAsync<T>(string uri, string id); 
	}
}