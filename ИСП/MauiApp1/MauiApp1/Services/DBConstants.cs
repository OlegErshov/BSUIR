using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    internal class DBConstants
    {
        public const string HeroDatabaseFilename = "HeroSQLite.db3";
        public const string SuperPowersDatabaseFilename = "SuperPowersSQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string HeroDatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, HeroDatabaseFilename);

        public static string SuperPowersDatabasePath =>
           Path.Combine(FileSystem.AppDataDirectory, SuperPowersDatabaseFilename);
    }
}
