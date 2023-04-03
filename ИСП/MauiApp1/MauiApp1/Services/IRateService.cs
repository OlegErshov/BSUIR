using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Services.NbrbAPI.Models;

namespace MauiApp1.Services
{
    internal interface IRateService
    {
        IEnumerable<Rate> GetRates(DateTime date);
    }
}
