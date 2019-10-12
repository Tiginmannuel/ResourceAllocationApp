using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAllocation.Common
{
    public class RESTClient
    {
        HttpClient client = new HttpClient();
        private static readonly string baseUri;

        static RESTClient()
        {
            baseUri = ConfigurationManager.AppSettings["formBaseUrl"];
        }

        public async Task<T> PostAsync<T, T1>(string uri, T1 obj) where T : class where T1 : class
        {
            string url = baseUri + uri;
            var Content = JsonConvert.SerializeObject(obj);
            StringContent httpContent = new StringContent(Content, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, httpContent);
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            return null;
        }

        public async Task<T> GetAsync<T>(string uri) where T : class
        {
            HttpResponseMessage response = await client.GetAsync(baseUri + uri);
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            return null;
        }
    }
}
