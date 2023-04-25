using MauiApp1.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    internal class CurrencyService : ICurrencyService
    {
        private HttpClient _client;

        public CurrencyService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Currency>> GetCurrenciesAsync()
        {
            var result = _client.Send(new HttpRequestMessage(HttpMethod.Get, _client.BaseAddress));
            var response = await HttpContentJsonExtensions.ReadFromJsonAsync<IEnumerable<Currency>>(result.Content);
            return response.Where(currency => currency.Cur_DateEnd > DateTime.Today);
        }
    }
}
