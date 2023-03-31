using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Entites;
//using static Android.Graphics.ImageDecoder;

namespace MauiApp1.Services
{
    public interface IDbService
    {
        IEnumerable<Hero> GetAllHeroes();
        IEnumerable<SuperPower> GetHeroSuperPowers(int id);

        void AddHero(string name, int id);

        void AddSuperPower(string name, int id);
        void Init();
    }
}
