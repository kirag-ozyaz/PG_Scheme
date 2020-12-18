using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    /// <summary>
    /// получаем значение по умолчанию в классе
    /// </summary>
    public static class Classes
    {

        public static T getDefault<T>()
        {
            return default(T);
        }

        public static bool IsDefault(object o)
        {
            if (o == null) return true; // условно
            object cmp = typeof(Classes).GetMethod("getDefault")
            .MakeGenericMethod(new Type[] { o.GetType() }).Invoke(null, null);
            // теперь cmp содержит "дефолтное" значение
            bool equal = o.Equals(cmp); // дефолтное значение может быть null
            return equal;
        }
    }
}
