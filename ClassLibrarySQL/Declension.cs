using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    /// <summary>
    /// Склонние 
    /// </summary>
    public class Declension
    {
        /// <summary>
        /// склонение годов
        /// </summary>
        public static string GetYear(int n)
        {
            string res = "";
            if (!(n >= 0 & n < 100))
                return res;

            res = n.ToString() + " ";
            if (n <= 10 || n >= 15)
                switch (n % 10)
                {
                    case 1:
                        res += "год";
                        break;
                    case 2:
                        res += "года";
                        break;
                    case 3:
                        res += "года";
                        break;
                    case 4:
                        res += "года";
                        break;
                    default:
                        res += "лет";
                        break;
                }
            else
               res += "лет";
            return res;
        }
    }
}
