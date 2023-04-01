using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Entites
{
    [Table("SuperPowers")]
    public class SuperPower
    {
        public string PowerName { get; set; }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [Indexed]
        public int HeroId { get; set; }

        public SuperPower(string name, int heroId)
        {
            PowerName = name;
            HeroId = heroId;
        }

        public SuperPower() { }
    }
}
