using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace APILayer.DataHandlers
{
    public class DataHandler : IDataHandler
    {
        private readonly IHttpClientFactory _client;
        private readonly IConfiguration _config;
        public DataHandler(IHttpClientFactory client, IConfiguration config)
        {
            _client = client;
            _config = config;
        }

        public async Task<HttpResponseMessage> PostNewGame(BoardGameModel model)
        {
            try
            {
                var apiKey = _config.GetValue<string>("apiKey");

                using var dataClient = _client.CreateClient("rootApi");

                var postJson = await dataClient.PostAsJsonAsync("api/Main/CreateNewGame", model);

                return postJson;
            }
            catch (Exception ex)
            {
                throw;
            }




        }
    }
}
