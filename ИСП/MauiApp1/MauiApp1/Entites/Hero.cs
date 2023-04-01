using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Entites
{
    [Table("Heroes")]
    public class Hero
    {
        public string Name { get; set; }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public Hero(string name,int id)
        {
            Name = name;    
            ID = id;
        }
        public Hero() { }
    }
}
