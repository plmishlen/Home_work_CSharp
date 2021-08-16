//Задание 1. Программа «Loger».
//Реализовать программный модуль (класс Loger), позволяющий записывать информацию о работе программы в log-файл.
//Данный класс должен быть реализован в виде .dll.

using System;
using System.IO;
using Logger;


namespace Loger
{
    class Program
    {


        static void Main(string[] args)
        {
            Info info = new Info();
            info.Date = DateTime.Now;
            info.Type_message = "Предупреждение";
            info.Name_user = "Иванов";
            info.Message = "В файле допущена ошибка";
            Logger.Loger.Config("Config.ini");
            Logger.Loger.LogIn(info);

        }

    }
}
