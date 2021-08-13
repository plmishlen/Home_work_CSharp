using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;


namespace Delegate
{
    static class Program
    {
        class Person
        {
            public delegate void OnPropertyChanged<T>(T oldValue, T newValue);
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public event OnPropertyChanged<string> onNameChanged = null;
            public event OnPropertyChanged<int> onAgeChanged = null;
           
            private string _name;
            private int _age;
           
            public string Name
            {
                get => _name;
                set
                {
                    string oldName = _name;
                    _name = value;
                    onNameChanged?.Invoke(oldName, value);
                }
            }
            public int Age
            {
                get => _age;
                set
                {
                    int oldAge = _age;
                    _age = value;
                    onAgeChanged?.Invoke(oldAge, value);
                }
            }
            
            /*public bool Work
            {
                get => _work;
                set
                {
                    bool oldWork = _work;
                  //  _work = true;
                    if(_work==true)
                    {
                        WriteLine("Отсутствует на работе");
                    }
                    else
                    {
                        WriteLine("Находится на работе");
                    }
                    onWorkChanged?.Invoke(oldWork, true);
                }
            }*/
        }
        class Inspector
        {
            public delegate void OnPropertyChanged<T>(T oldValue, T newValue);
            public event OnPropertyChanged<string> onWorkChanged = null;
            public Inspector (string work)
            {
                Work = work;
            }
            Person persons;
            private string _work;
            public string Work
            {
                get => _work;
                set
                {
                    string persons = null;
                    string oldWork = _work;
                    _work = value;
                    onWorkChanged?.Invoke(persons + oldWork, value);
                }
            }
          /*  public void Count()
            {
                int count = 0;
                for (int i = 0; i < count; i++)
                {
                    if ()
                    {
                        count++;
                    }
                }
                WriteLine($"На работе находятся:", count);
            }*/
        }
       


        static void Main(string[] args)
        {
            Person person;
            Inspector inspector;
            
            person = new Person("Alex", 25);
            inspector = new Inspector("Сотрудник отсутствует на работе");
            WriteLine(person.Name + " " + person.Age + " " + inspector.Work);
            person.Name = "Michael";
            person.Age = 34;
            inspector.Work = "Сотрудник отсутствует на работе";
            person.onNameChanged += (string oldName, string newName) =>
            {
                WriteLine($"Имя изменилось: {oldName} => {newName}");
            };
            person.onAgeChanged += (int oldAge, int newAge) =>
            {
                WriteLine($"Возраст изменился: {oldAge} => {newAge}");
            };
            inspector.onWorkChanged += (string oldWork, string newWork) =>
            {
                WriteLine($"Статус работника изменился: {oldWork} => {newWork}");
            };
            person.Name = "John";
            person.Age = 42;
            inspector.Work = "Сотрудник пришел на работу";

            Person
            p1 = new Person("Иванов Иван Иванович", 33),
            p2 = new Person("Петров Петр Петрович", 44),
            p3 = new Person("Сергеев Сергей Сергеевич", 55),
            p4 = new Person("Андреев Андрей Андреевич", 66),
            p5 = new Person("Алексеев Алексей Алексеевич", 77);

            
            List<Person> Persons = new List<Person>() { p1, p2, p3, p4, p5 };

            WriteLine($"Список: " + Persons);

            ReadKey();
        }

    }
}
