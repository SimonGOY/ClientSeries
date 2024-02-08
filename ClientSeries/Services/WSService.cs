using ClientSeries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClientSeries.Services
{
    internal class WSService : IService
    {
        private HttpClient client;

        public HttpClient Client
        {
            get { return client; }
            set { client = value; }
        }
        public WSService(string uri)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(uri);
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public WSService() : this("http://localhost:44356/api/") { }
        public async Task<List<Serie>> GetSeriesAsync(string nomControleur)
        {
            try
            {
                return await Client.GetFromJsonAsync<List<Serie>>(nomControleur);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
