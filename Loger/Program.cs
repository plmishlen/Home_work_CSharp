using System;

namespace Loger
{
    class Program
    {
        public class Loger
        {
            private string Date = null;
            private string Time = null;
            private string Type_Message = null;
            private string Name_User = null;
            private string Message = null;
            public Loger(string date, string time, string type_message, string name_user, string message )
            {
                Date = date;
                Time = time;
                Message = type_message;
                Name_User = name_user;
                Message = message;
            }

        }
        static void Main(string[] args)
        {

        }

    
}
