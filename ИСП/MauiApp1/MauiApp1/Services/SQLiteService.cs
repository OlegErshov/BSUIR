
using MauiApp1.Entites;
using Microsoft.Maui.Controls.Internals;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1;


namespace MauiApp1.Services
{
    public class SQLiteService : IDbService
    {
        
        public IEnumerable<Hero> GetAllHeroes()
        {
            Init();
            return _conn.Table<Hero>();
        }

        public IEnumerable<SuperPower> GetHeroSuperPowers(int id)
        {
            Init();
            return _conn.Table<SuperPower>().Where(x => x.HeroId == id);
        }


        private string _dbPath;
        private SQLiteConnection _conn;
        public  void Init()
        {
            if(_conn != null)
            {
                return;
            }

            _dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "lab3.db");

            _conn = new SQLiteConnection(_dbPath);

            _conn.DropTable<Hero>();
            _conn.DropTable<SuperPower>();

            _conn.CreateTable<Hero>();
            _conn.CreateTable<SuperPower>();
            


            List<Hero> heroList = new List<Hero>() {

                new Hero {Name = "SpiderMan"},
                new Hero {Name = "IronMan"},
                new Hero {Name = "Thor"}

            };

            List<SuperPower> powersList = new List<SuperPower>()
            { 
                new SuperPower {PowerName = "Regeneration", HeroId= 1},
                new SuperPower {PowerName = "Phisical strength",HeroId = 1},
                new SuperPower {PowerName = "SpiderIntuition",HeroId = 1},

                new SuperPower {PowerName = "Intelegent",HeroId = 2},
                new SuperPower {PowerName = "Money", HeroId = 2},
                new SuperPower {PowerName = "AC/DC soundtreck", HeroId = 2},
                new SuperPower {PowerName = "Iron costume", HeroId = 2},

                new SuperPower {PowerName = "Thunder and lights", HeroId = 3},
                new SuperPower {PowerName = "Hummer", HeroId = 3},
                new SuperPower {PowerName = "Stamina", HeroId = 3 }

            };

            _conn.InsertAll(heroList);
            _conn.InsertAll(powersList);

            
        }
    }
}
