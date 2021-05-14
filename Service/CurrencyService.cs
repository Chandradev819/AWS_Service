using AWS_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AWS_Service.Service
{
    public class CurrencyService : ICurrency
    {
        private readonly HttpClient httpClient;
        public CurrencyService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Root> GetConveryValue() 
        {
            var result = await httpClient.GetFromJsonAsync<Root>("https://min-api.cryptocompare.com/data/price?fsym=ETH&tsyms=USD");
            return result;
        }
    }
}
