using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public class EntryInputValidator
    {
        public static bool IsValid(string input)
        {
            string pattern = @"^[1-9]{1,7}(,\d{0,2})?$";
            return Regex.IsMatch(input, pattern);
        }
    }
}
