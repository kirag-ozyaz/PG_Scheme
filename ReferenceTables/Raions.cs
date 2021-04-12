using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace References
{
    public class Raions
    {
        public static string GetNameRaion(string sr)
        {
            if (sr == "Сетевой район №1")
            {
                return "Ленинский район";
            }
            if (sr == "Сетевой район №2")
            {
                return "Засвияжский район";
            }
            if (sr == "Сетевой район №3")
            {
                return "Железнодорожный район";
            }
            if (sr == "Сетевой район №4")
            {
                return "Заволжский район";
            }
            return sr;

        }
    }
}
