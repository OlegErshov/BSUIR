﻿using MauiApp1.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiApp1.Services
{
    internal interface IRateService
    {
        Task<Rate> GetRates(DateTime date);
    }
}
