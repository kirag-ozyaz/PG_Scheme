using System;
using System.Collections.Generic;

internal class СollectionDataValues
{
    internal СollectionDataValues(DateTime dateTime, string fio, Dictionary<string, List<string>> dictionary)
    {
        this.DateTime = dateTime;
        this.FIO = fio;
        this.Dictionary = dictionary;
    }
    internal DateTime DateTime = DateTime.Now;
    internal string FIO = "";
    internal Dictionary<string, List<string>> Dictionary = new Dictionary<string, List<string>>();
}
