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
        [PrimaryKey,AutoIncrement,Indexed]
        public string Name { get; set; }
        [Indexed]
        public int HeroId { get; set; }

        public SuperPower(string name, int heroId)
        {
            Name = name;
            HeroId = heroId;
        }

        public SuperPower() { }
    }
}
