using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataSql;
using System.Windows.Forms;
using PluginInterfaces;
using System.Runtime.CompilerServices;

public partial class SQLSettings : DataSql.SQLSettings
{
    //public extern FormConnect();
    //public extern FormConnect(SQLSettings sqlsettings_0);

    internal string get_ServerDB()
    {
        return ServerDB;
    }
    internal string get_DBName()
    {
        return DBName;
    }
    internal string get_Autentification()
    {
        return Autentification;
    }
    internal string get_SqlUserConnect()
    {
        return SqlUserConnect;
    }
    internal string get_SqlPasswConnect()
    {
        return SqlPasswConnect;
    }

    internal void set_ServerDB(string p)
    {
        ServerDB = p;
    }

    internal void set_DBName(string p)
    {
        DBName = p;
    }

    internal void set_Autentification(string p)
    {
        Autentification = p;
    }

    internal void set_SqlUserConnect(string p)
    {
        SqlUserConnect = p;
    }

    internal void set_SqlPasswConnect(string p)
    {
        SqlPasswConnect = p;
    }
}

//public interface IPlugin : PluginInterfaces.IPlugin
//{
//    //void get_Name();

// //  Предупреждение	1	"IPlugin.get_Name()" скрывает наследуемый член "PluginInterfaces.IPlugin.Name.get". Если предполагается скрытие, используйте ключевое слово new.	Z:\Ulges\Декомпилятор C#\Разбор_проекта\New_Project 20150128\EIS-cleaned\ClassPlug\EISClassPlug.cs	64	10	EIS-cleaned
//    //interface IGClass4
////{
////    void method_0(GClass5 gclass5_0);
////}
//    new object get_Name();
//}
//Ошибка	2	"PluginInterfaces.IPlugin.Name.get": явный вызов оператора или метода доступа невозможен	Z:\Ulges\Декомпилятор C#\Разбор_проекта\New_Project 20150128\EIS-cleaned\GClass4.cs	26	34	EIS-cleaned
