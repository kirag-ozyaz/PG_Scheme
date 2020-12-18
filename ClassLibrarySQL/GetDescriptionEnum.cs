using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace Library
{
    /// <summary>
    /// Приведение значения перечисления в удобочитаемый формат.
    /// </summary>
    /// <remarks>
    /// Для корректной работы необходимо использовать атрибут [Description("Name")] для каждого элемента перечисления.
    /// </remarks>
    /// <param name="enumElement">Элемент перечисления</param>
    /// <returns>Название элемента</returns>
    public static string GetDescription(this Enum enumElement)
    {
        Type type = enumElement.GetType();

        MemberInfo[] memInfo = type.GetMember(enumElement.ToString());
        if (memInfo != null && memInfo.Length > 0)
        {
            object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attrs != null && attrs.Length > 0)
                return ((DescriptionAttribute)attrs[0]).Description;
        }

        return enumElement.ToString();
    }
    //public static string GetEnumDescription<TEnum>(int value)
    //{
    //    return GetEnumDescription((Enum)(object)((TEnum)(object)value));  
    //}
}
