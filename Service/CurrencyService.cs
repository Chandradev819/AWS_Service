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
        public async Task<object> GetConveryValue(string fsym, string tsyms)
        {
            string apiURL = $"https://min-api.cryptocompare.com/data/price?fsym={fsym}&tsyms={tsyms}";
            var result = await httpClient.GetFromJsonAsync<object>(apiURL);
            return result;
        }


    }
}
