using System;
using System.Text;
using static System.Console;


namespace Arrays_Strings
{
    class Program
    {
        class Text
        {
            public Text(string one, string two, string three)
            {
                One = one;
                Two = two;
                Three = three;
            }
            public string One { get; set; }
            public string Two { get; set; }
            public string Three { get; set; }
        }

        static void Main(string[] args)
        {

            //1.	Дан массив с элементами «Привет, «, «мир» и «!».
            //Необходимо записать в переменную text фразу «Привет, мир!»
            //используя данные из массива, а затем вывести на экран содержимое этой переменной.

            Text t1 = new Text("Привет,", "мир", "!");
            var text = $"{t1.One} {t1.Two}{t1.Three}";
            WriteLine(text);
            WriteLine("-------------------------------------");

            //2.	Дана текстовая строка «Широкая электрификация южных губерний даст мощный
            //толчок подъёму сельского хозяйства». Разбить её на массив слов используя Split.
            //Вывести на экран количество слов в этой фразе и каждое слово из неё на отдельной строке.
            var text2 = "Широкая электрификация южных губерний даст мощный толчок подъёму сельского хозяйства";
            var array = text2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            WriteLine("Кол-во слов = {0}", array.Length);
            string[] words = text2.Split( ' ' );
            foreach (string word in words)
            {
                WriteLine($"{word}");
            }
            WriteLine("-------------------------------------");

            //3. Создайте массив arr с элементами 2, 5, 3, 9. Умножьте первый элемент массива на второй,
            //а третий элемент на четвертый. Результаты сложите, присвойте переменной result.
            //Выведите на экран значение этой переменной.

            int[] array2 = new int[] { 2, 5, 3, 9 };
            int n1 = array2[0];
            int n2 = array2[1];
            int n3 = array2[2];
            int n4 = array2[3];
            int result = n1 * n2 + n3 * n4;
            WriteLine(result);
            WriteLine("-------------------------------------");

            //4.	Создайте массив заработных плат arr. Выведите на экран зарплату Пети и Коли.
            //string[,] arr = {{«Коля», «1000$»}, {«Вася», «500$»}, {«Петя», «200$»}};

            

            //5.	В переменной min лежит число от 0 до 59. Определите в какую четверть часа попадает это число
            //(в первую, вторую, третью или четвертую).
            
            WriteLine("Введите число от 0 до 59: ");
            int num = Convert.ToInt32(ReadLine());
            if (num < 15)
            {
                WriteLine("Вы ввели число" + " " + num + ". " + "Число находится в первой четверти");
            }
            if (num >= 15 && num < 30)
            {
                WriteLine("Вы ввели число" + " " + num + ". " + "Число находится во второй четверти");
            }
            if (num >= 30 && num < 45)
            {
                WriteLine("Вы ввели число" + " " + num + ". " + "Число находится в третьей четверти");
            }
            if (num >= 45 && num <= 59)
            {
                WriteLine("Вы ввели число" + " " + num + ". " + "Число находится в четвертой четверти");
            }
            WriteLine("-------------------------------------");

            //6.	Переменная lang может принимать два значения: «ru» и «en».
            //Если она имеет значение «ru», то в переменную arr запишем массив дней недели на русском языке,
            // если имеет значение «en» – то на английском. Решите задачу через 2 if, через switch-case и
            // через многомерный массив без if и switch.
            WriteLine("Введите значение 'ru', либо 'en': ");
            string lang = ReadLine();
            switch (lang)
            {
                case "ru":
                    string[] arr1 = new string[] {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
                    WriteLine("Дни недели на русском языке: ");
                    Array.ForEach(arr1, WriteLine);
                    break;
                case "en":
                   
                    string[] arr2 = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
                    WriteLine("Дни недели на английском языке: ");
                    Array.ForEach(arr2, WriteLine);
                    break;
                default:
                    WriteLine("Вы ввели неверное значение");
                    break;
            }
            WriteLine("-------------------------------------");
           
            WriteLine("Введите значение 'ru', либо 'en': ");
            string lang2 = ReadLine();
            if (lang2 == "ru")
            {
                WriteLine("Дни недели на русском языке: ");
                string[] arr3 = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
                Array.ForEach(arr3, WriteLine);
            }
            if (lang2 == "en")
            {
                string[] arr3 = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
                Array.ForEach(arr3, WriteLine);
                WriteLine("Дни недели на английском языке: ");
            }
            if (lang2 != "ru" && lang2 != "en")
            {
                WriteLine("Вы ввели неверное значение");
            }
            WriteLine("-------------------------------------");



            //7.Дан массив с элементами 10, 20, 15, 17, 24, 35.Найдите сумму элементов этого массива. Запишите ее в переменную result.

            int[] arr_el = new int[6] { 10, 20, 15, 17, 24, 35 };
            int Sum = 0;
            for (int i = 0; i < 6; i++)
            {
                Sum = Sum + arr_el[i];
            }
            WriteLine("Сумма элементов массива равна = " + Sum);
          
            WriteLine("-------------------------------------");



            //8.Создайте массив из 100 случайных значений от 1 до 100.Выведите на экран количество четных и нечетных чисел в этом массиве.




            //9.Дан двумерный массив(массив пар) arr.С помощью цикла foreach запишите английские названия(первый элемент пары) в массив en, а русские(второй элемент пары) -в массив ru. string[,] arr = { {«green», «зеленый»}, {«red», «красный»}, {«blue», «голубой»} };
            //10.Дано число num(например, 1000). Определите, сколько раз его надо разделить на 2, чтобы результат деления стал меньше 50.Решите задачу сначала через цикл while, а потом через цикл for.
            //11.Дана строка с символами(только латиница) в нижнем регистре.Переведите все символы в верхний регистр.Например, «word» -> «WORD».
            //12.Переведите в строке из предыдущего примера все символы в нижний регистр.Функцию для перевода найдите самостоятельно.Например, «WORD» -> «word».
            //13.В строке из предыдущего примера переведите только первый символ в верхний регистр.Функцию для перевода найдите самостоятельно.Например, «word» -> «Word».
            //14.В строке "Привет, Иван!" замените слово "Привет" на слово "Пока".
            //15.В строке "qwe rty uio pas dfg hjk lzx cvb nmq" найдите позицию первого пробела.
            //16.В строке из предыдущего примера найдите позицию второго пробела.
            
            
            #region
         /*   WriteColoredLine("Task 6:");
            string lang = "";
            string ruDays = "Понедельник Вторник Среда Четверг Пятница Суббота Воскреcенье";
            string enDays = "Monday Tuesday Wednesday Thursday Friday Saturday Sunday";
            string[] arr6 = new string[7];
            while (lang != "ru" && lang != "en")
            {
                WriteLine("Введите значени lang (ru/en)");
                lang = ReadLine();
            }

            // Реализация с if
            if (lang == "ru")
            {
                lang = ruDays;
                arr6 = lang.Split(' ');
            }
            if (lang == "en")
            {
                lang = enDays;
                arr6 = lang.Split(' ');
            }

            //Реализация со Switch
            //switch (lang)
            //{
            //    case "ru":
            //        lang = ruDays;
            //        arr6 = lang.Split(' ');
            //        break;
            //    case "en":
            //        lang = enDays;
            //        arr6 = lang.Split(' ');
            //        break;
            //}

            foreach (var item in arr6)
            {
                WriteLine(item);
            }

            //Реализация с многомерным массивом. Но я без понятия, как можно сделать без if
            //string[,] days = { 
            //    { "Понедельник", "Monday" }, 
            //    { "Вторник", "Tuesday" },  
            //    { "Среда", "Wednesday" }, 
            //    { "Четверг", "Thursday" }, 
            //    { "Пятница", "Friday" }, 
            //    { "Суббота", "Saturday" }, 
            //    { "Воскресенье", "Sunday" } };

            //if (lang=="ru")
            //{

            //    for (int i = 0; i < 7; i++)
            //    {
            //        WriteLine(days[i, 0]);
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < 7; i++)
            //    {
            //        WriteLine(days[i, 1]);
            //    }
            //}

            ReadKey();*/
#endregion


            ReadKey();
        }
    }
}