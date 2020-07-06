using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebCoreAPI.Services
{
    public class RestHttpService : IRestHttpService
    {

        private String BaseUrl = "http://localhost:8080/DictionaryEngine/api/englishToThai/";

        private readonly HttpClient _client;

        public RestHttpService(HttpClient client)
        {
            _client = client;
        }

        public void setBaseUrl(String baseUrl) {
            this.BaseUrl = baseUrl;
        }

        public async Task<String> GetAsync(String param)
        {

            var httpResponse = await _client.GetAsync($"{BaseUrl}{param}");

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve tasks");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
          //  var todoItem = JsonConvert.DeserializeObject<String>(content);

      

            return content;

            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(string dataJson)
        {
            var httpResponse = await _client.PostAsync(BaseUrl, new StringContent(dataJson, Encoding.Default, "application/json"));

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot add a todo task");
            }
            var content = await httpResponse.Content.ReadAsStringAsync();
            return content;

            throw new NotImplementedException();
        }

        public Task<string> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> PutAsync(int id, string dataJson)
        {  
            var httpResponse = await _client.PutAsync($"{BaseUrl}{id}", new StringContent(dataJson, Encoding.Default, "application/json"));

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot update todo task");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            return content;

            throw new NotImplementedException();
        }

        public async Task<string> DeleteAsync(int id)
        {

            var httpResponse = await _client.DeleteAsync($"{BaseUrl}{id}");

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot delete the todo item");
            }
         
            return httpResponse.StatusCode.ToString();

            throw new NotImplementedException();
        }
    }
}
