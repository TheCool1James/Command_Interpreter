﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterpreterEngine
{
    class Extract
    {
        public string extractString(string input)
        {
            //http://stackoverflow.com/questions/2148587/finding-quoted-strings-with-escaped-quotes-in-c-sharp-using-a-regular-expression
            //GODLY :)
            var reg = new Regex(@"""[^""\\]*(?:\\.[^""\\]*)*""");
            var matches = reg.Matches(input);
            foreach (var item in matches)
            {
                string o = item.ToString().Remove(item.ToString().Length - 1);
                string str = Regex.Unescape(o.Remove(0, 1));
                return str;
            }
            return null;
        }

        public void addTokenS(string[] identifier, string value, Dictionary<string ,string> sd)
        {

        }
    }
}
