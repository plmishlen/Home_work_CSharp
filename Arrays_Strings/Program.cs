using System;
using System.Linq;
using System.Text;
using static System.Console;

using System.Globalization;


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
            WriteLine("---------------- I ---------------------");
            Text t1 = new Text("Привет,", "мир", "!");
            var text = $"{t1.One} {t1.Two}{t1.Three}";
            WriteLine(text);



            //2.	Дана текстовая строка «Широкая электрификация южных губерний даст мощный
            //толчок подъёму сельского хозяйства». Разбить её на массив слов используя Split.
            //Вывести на экран количество слов в этой фразе и каждое слово из неё на отдельной строке.
            WriteLine("---------------- II ---------------------");
            var text2 = "Широкая электрификация южных губерний даст мощный толчок подъёму сельского хозяйства";
            var array = text2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            WriteLine("Кол-во слов = {0}", array.Length);
            string[] words = text2.Split(' ');
            foreach (string word in words)
            {
                WriteLine($"{word}");
            }



            //3. Создайте массив arr с элементами 2, 5, 3, 9. Умножьте первый элемент массива на второй,
            //а третий элемент на четвертый. Результаты сложите, присвойте переменной result.
            //Выведите на экран значение этой переменной.
            WriteLine("---------------- III ---------------------");
            int[] array2 = new int[] { 2, 5, 3, 9 };
            int n1 = array2[0];
            int n2 = array2[1];
            int n3 = array2[2];
            int n4 = array2[3];
            int result = n1 * n2 + n3 * n4;
            WriteLine(result);



            //4.	Создайте массив заработных плат arr. Выведите на экран зарплату Пети и Коли.
            //string[,] arr = {{«Коля», «1000$»}, {«Вася», «500$»}, {«Петя», «200$»}};
            WriteLine("---------------- IV ---------------------");
            string[,] arr = {
            { "Коля", "1000$" },
            { "Вася", "500$" },
            { "Петя", "200$" }
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                }
                WriteLine("Заработная плата Пети - " + arr[2, 1] + "; Заработная плата Коли - " + arr[0, 1]);
            }


            //5.	В переменной min лежит число от 0 до 59. Определите в какую четверть часа попадает это число
            //(в первую, вторую, третью или четвертую).
            WriteLine("---------------- V ---------------------");
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


            //6.	Переменная lang может принимать два значения: «ru» и «en».
            //Если она имеет значение «ru», то в переменную arr запишем массив дней недели на русском языке,
            // если имеет значение «en» – то на английском. Решите задачу через 2 if, через switch-case и
            // через многомерный массив без if и switch.
            WriteLine("---------------- VI ---------------------");
            WriteLine("Введите значение 'ru', либо 'en': ");
            string lang = ReadLine();
            switch (lang)
            {
                case "ru":
                    string[] arr1 = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
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
                WriteLine("Дни недели на английском языке: ");
                string[] arr3 = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
                Array.ForEach(arr3, WriteLine);
            }
            if (lang2 != "ru" && lang2 != "en")
            {
                WriteLine("Вы ввели неверное значение");
            }
            WriteLine("-------------------------------------");


            //7.Дан массив с элементами 10, 20, 15, 17, 24, 35.Найдите сумму элементов этого массива. Запишите ее в переменную result.
            WriteLine("---------------- VII ---------------------");
            int[] arr_el = new int[6] { 10, 20, 15, 17, 24, 35 };
            int Sum = 0;
            for (int f = 0; f < 6; f++)
            {
                Sum = Sum + arr_el[f];
            }
            WriteLine("Сумма элементов массива равна = " + Sum);


            //8.Создайте массив из 100 случайных значений от 1 до 100.Выведите на экран количество четных и нечетных чисел в этом массиве.
            WriteLine("---------------- VIII ---------------------");
            int count = 0;
            int[] rnd = new int[100];
            Random rand = new Random();
            WriteLine("Массив случайных чисел от 1 до 100:");
            for (int m = 0; m < rnd.Length; m++)
            {
                rnd[m] = rand.Next(1, 100);
                Write(" " + rnd[m]);
            }
            WriteLine();
            foreach (int n in rnd)
            {
                if ((n % 2) == 0)
                {
                    count++;
                }
            }
            Write("Количество четных чисел в массиве: " + count);
            WriteLine();
            int z = 100 - count;
            WriteLine("Количество нечетных чисел в массиве: " + z);


            //9.Дан двумерный массив(массив пар) arr.С помощью цикла foreach запишите английские названия(первый элемент пары) в массив en,
            //а русские(второй элемент пары) -в массив ru. string[,] arr = { {«green», «зеленый»}, {«red», «красный»}, {«blue», «голубой»} };

            WriteLine("---------------- IX ---------------------");
            const int row = 3;
            const int col = 2;
            string[,] nap = new string[row, col] {
                {"green", "зеленый"},
                {"red", "красный"},
                {"blue", "голубой"}
                };
            
            string[] en = new string[3];
            string[] ru = new string[3];
            foreach (string p in nap)
            {
                for (int s = 0; s < row; s++)
                {
                    for (int t = 1; t < col; t++)
                    {
                      
                    }
                }  //WriteLine();
            }WriteLine(nap[1, 1]);


            //10.Дано число num(например, 1000). Определите, сколько раз его надо разделить на 2, чтобы результат деления стал меньше 50.
            //Решите задачу сначала через цикл while, а потом через цикл for.
            WriteLine("---------------- X ---------------------");
            Write("Введите любое число: ");
            int num2 = int.Parse(ReadLine());
            int count1 = 0;
            while (num2 > 50)
            {

                num2 /= 2;
                count1++;

            }
            WriteLine("While: число нужно разделить " + count1 + " раз, чтобы результат стал меньше 50");
            int count2 = 0;
            WriteLine("---------------------------------------");
            Write("Введите любое число: ");
            int num3 = int.Parse(ReadLine());
            for (; num3 >= 50; num3 /= 2, count2++) ;
            WriteLine("for: число нужно разделить " + count2 + " раз, чтобы результат стал меньше 50");


            //11.Дана строка с символами(только латиница) в нижнем регистре.Переведите все символы в верхний регистр.Например, «word» -> «WORD».
            WriteLine("---------------- XI ---------------------");
            Write("Введите слово (написание букв в нижнем регистре): ");
            string _text = ReadLine();
            WriteLine("\"Верхний регистр\": " + _text.ToUpper());


            //12.Переведите в строке из предыдущего примера все символы в нижний регистр.
            //Функцию для перевода найдите самостоятельно.Например, «WORD» -> «word».
            WriteLine("---------------- XII ---------------------");
            Write("Введите слово (написание букв в верхнем регистре): ");
            string text3 = ReadLine();
            WriteLine("\"Нижний регистр\": " + text3.ToLower());
           

            //13.В строке из предыдущего примера переведите только первый символ в верхний регистр.
            //Функцию для перевода найдите самостоятельно.Например, «word» -> «Word».
            WriteLine("---------------- XIII ---------------------");
            Write("Введите слово (написание букв в нижнем регистре): ");
            var text4 = ReadLine();
            if (text4.Length > 1)
            {
                WriteLine("\"Слово с заглавной буквы\": " + char.ToUpper(text4[0]) + text3.Substring(1));
            }


            //14.В строке "Привет, Иван!" замените слово "Привет" на слово "Пока".
            WriteLine("---------------- XIV ---------------------");
            string aa = "Привет, Иван!";
            WriteLine("Приветствие: {0}", aa);
            aa = aa.Replace("Привет", "Пока");
            WriteLine("Прощание: {0}", aa);


            //15.В строке "qwe rty uio pas dfg hjk lzx cvb nmq" найдите позицию первого пробела.
            WriteLine("---------------- XV ---------------------");
            string bb = "qwe rty uio pas dfg hjk lzx cvb nmq";
            WriteLine(bb);
            string bb2 = " ";
            int bb3 = bb.IndexOf(bb2);
            WriteLine("Позиция первого пробела - " + bb3);


            //16.В строке из предыдущего примера найдите позицию второго пробела.
            WriteLine("---------------- XVI ---------------------");
            WriteLine(bb);
            int bb4 = bb.IndexOf(bb2, bb3 + 1);
            WriteLine("Позиция второго пробела - " + bb4);
            WriteLine("----------------THE END------------------");



            ReadKey();
            
        }
    }
}
