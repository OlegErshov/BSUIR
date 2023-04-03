using MauiApp1.Services.NbrbAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Rate> GetRates(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
