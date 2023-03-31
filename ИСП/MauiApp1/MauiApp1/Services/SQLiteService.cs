
using MauiApp1.Entites;
using Microsoft.Maui.Controls.Internals;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public class SQLiteService : IDbService
    {
        SQLiteConnection HeroesDatabase = null;
        SQLiteConnection SuperPowersDatabase = null;

        public void AddHero(string name, int id)
        {
            Hero hero = new Hero(name,id);
            HeroesDatabase.Insert(hero);
        }

        public void AddSuperPower(string name, int Heroid)
        {
            SuperPower superPower = new SuperPower(name,Heroid);
            var alreadyExist = from p in SuperPowersDatabase.Table<SuperPower>()
                               where p.HeroId == Heroid
                               select p;
            if (alreadyExist == null)
            {
                SuperPowersDatabase.Insert(superPower);
            }
            else
            {
                SuperPowersDatabase.Update(superPower);
            }

            
        }

        public IEnumerable<Hero> GetAllHeroes()
        {
            Init();
            return HeroesDatabase.Table<Hero>();
        }

        public IEnumerable<SuperPower> GetHeroSuperPowers(int id)
        {
            Init();
           // List<SuperPower> HeroSuperPowers = new List<SuperPower>();
           // HeroSuperPowers =  SuperPowersDatabase.Table<SuperPower>().ToList<SuperPower>();
           var HeroSuperPowers = from k in SuperPowersDatabase.Table<SuperPower>().ToList<SuperPower>()
                              where k.HeroId == id
                              select k;
            return HeroSuperPowers.ToList<SuperPower>();
        }

        public  void Init()
        {
            if(HeroesDatabase != null)
            {
                return;
            }
            
            HeroesDatabase = new SQLiteConnection(DBConstants.HeroDatabasePath, DBConstants.Flags);
            var result1 =  HeroesDatabase.CreateTable<Hero>();
            SuperPowersDatabase = new SQLiteConnection(DBConstants.SuperPowersDatabasePath, DBConstants.Flags);
            var result2 =  SuperPowersDatabase.CreateTable<SuperPower>();

        }
    }
}
