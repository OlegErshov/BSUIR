using MauiApp1.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    internal class RateService : IRateService
    {
        HttpClient _client;
        RateService() 
        {
            _client = new HttpClient();
        }

        public async Task<Rate> GetRates(DateTime date,Currency currency)
        {
            var result = _client.Send(new HttpRequestMessage(HttpMethod.Get, $"{currency.Cur_ID}?ondate={date:yyyy-M-d}"));
            var response = await HttpContentJsonExtensions.ReadFromJsonAsync<Rate>(result.Content);
            return response!;
        }
    }
}
