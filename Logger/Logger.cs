using System;
using System.IO;

namespace Logger
{
    public class Loger
    {
        private static string Date_format;
        private static string TM_format;
        private static string U_format;
        private static string M_format;
        public static void LogIn(Info info)
        {
            if (info == null)
            {
                return;
            }
            StreamWriter sw = new StreamWriter("log.txt");
            string line = info.Date.ToString(Date_format) + ", " + info.Type_message.ToString() + ", Пользователь " + 
                info.Name_user.ToString() + ", " + info.Message.ToString();
            sw.WriteLine(line);
            sw.Close();
            sw.Dispose();
        }
        public static void Config(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            string[] configs = line.Split(',');
            Date_format = configs[0];
            TM_format = configs[1];
            U_format = configs[2];
            M_format = configs[3];
            string line2 = Date_format + ", " + TM_format + ", Пользователь " +
                U_format + ", " + M_format;
            StreamWriter sw = new StreamWriter("log2.txt");
        }
    }
    public class Info
    {
        private DateTime date_time;
        private string type_message = null;
        private string name_user = null;
        private string message = null;

        public DateTime Date { get => date_time; set => date_time = value; }
        public string Type_message { get => type_message; set => type_message = value; }
        public string Name_user { get => name_user; set => name_user = value; }
        public string Message { get => message; set => message = value; }
        
    }
}
