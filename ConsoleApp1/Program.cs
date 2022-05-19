using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeWork3();
        }


        static void HomeWork3()
        {
            Console.WriteLine("Enter Surname");
            string Surname = Console.ReadLine();
            Console.WriteLine("Enter Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Weight");
            double Weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height (Metrs)");
            double Height = double.Parse(Console.ReadLine());
            double ИМТ = Weight / (Height*Height);
            Console.Clear();
            Console.WriteLine($"Your profile:" +
                $"\nFull Name:{Surname}, {Name}" +
                $"\nAge {age}" +
                $"\nWeight {Weight}" +
                $"\nHeight {Height}" +
                $"\nBody Mass Index:{Math.Round(ИМТ,3)}");



        }
        static void HomeWork2()
        {
            Console.WriteLine("Enter three sides of a triangle");
            double First = double.Parse(Console.ReadLine());
            Console.WriteLine($"Front side = {First}");
            double Second  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Front side = {Second}");
            double Third = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Third side = {Third}");

            double semi_perimeter = (First + Second + Third) / 2;
            Console.WriteLine($"semi_perimeter = {semi_perimeter}");
            double Herons_formula = Math.Sqrt(semi_perimeter*((semi_perimeter-First)*(semi_perimeter-Second)*(semi_perimeter-Third)));
            Console.WriteLine($"Sqaure of a triangle = {Math.Round(Herons_formula,3)}");// Ограничили до трех чисел полсе запятой
        }
        static void HomeWork1()
        {
            Console.WriteLine("-----------------------Задание_1-------------------------------");
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hello {Name}");
            Console.WriteLine("-----------------------Задание_2-------------------------------");
            Console.WriteLine("Enter two integers");
            Console.Write("Enter X:");
            int x =  Convert.ToInt32(Console.ReadLine());// Так можно вводить числа с консоли
            Console.Write("Enter Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"X = {x}\nY = {y}");
            int Change = x;
            x = y;
            y = Change;
            Console.WriteLine($"Change \nX = {x}\nY = {y}");
            Console.WriteLine("-----------------------Задание_3-------------------------------");
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your number = {number}");
            Console.WriteLine($"So many numbers in your number {number.ToString().Length}");


        }
        static void DateTimesIntro()
        {
            DateTime now = DateTime.Now;//Показать сегодняшнею дату 
            Console.WriteLine(now.ToString());

            Console.WriteLine($"It's {now.Date}:Year {now.Year}:Month {now.Month}:Day {now.Day}:Hour {now.Hour}:Minute {now.Minute}:Second {now.Second}:Millisecond {now.Millisecond}");

            DateTime dt = new DateTime(2022, 2, 24);//Так можно объявить свою дату 
            Console.WriteLine(dt);
            DateTime NewData = dt.AddDays(1);//Добавление одного дня 
            Console.WriteLine(NewData);

            TimeSpan ts = now - NewData;// Это тип представляет длительность времени.В TimeSpan будет записанна временная разница 
            //ts = now - NewData;// тоже самое что и TimeSpan

            Console.WriteLine("TimeSpan");
            Console.WriteLine(ts.Days);
        }
        static void IntroToArrays()
        {
            int[] a1;        //Задеклорировали переменуу а1 - массив
            a1 = new int[10];//Выделели память под этот массив, а имено под 10 элементов



            int[] a2 = new int[5];// Инецилизация массивов

            int[] a3 = new int[5] { 1, 3, 4, 5, 10 };//Заполнения массива

            int[] a4 = { 1, 2, 3, 4, 5 };//Краткая Инецилизация массива 

            Console.WriteLine(a4[0]);

            int number = a4[4];
            Console.WriteLine(number);

            a4[4] = 532;
            Console.WriteLine(a4[4]);

            Console.WriteLine(a4.Length);
            Console.WriteLine(a4[a4.Length - 1]);//Обратиться к последниму элементу массиву. Количесвто элементов - 1


            string s1 = "abcdefgh";
            char first = s1[0];// Так можно указать первый символ (string) строки
            char last = s1[s1.Length - 1];// а так можно указать Последний символ (string) строки

            Console.WriteLine($"First: {first}. Last:{last}");
        }
        static void MathDemo()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));

            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));//Округляет к числу удаленного от нуля
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));//Округляет к числу ближниму к четному

        }
        static void CastingAndParsing()
        {
            byte b = 3;// 0000 0011
            int i = b;//0000 0000 0000 0000 0000 0000 0000 0011
            long l = i;//0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            float f = i;//3.0

            b = (byte)i;// Явное приведение

            i = (int)f;
            Console.WriteLine(i);

            f = 3.1f;
            i = (int)f;
            Console.WriteLine(i);
            // Не совместимые типы 
            string str = "1";
            //i = (int)str;// Нуженметод parse
            i = int.Parse(str);
            Console.WriteLine($"Parsed i = {i}");

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result);

            // Так нужно чтобы не потерять точность
            double result2 = (double)x / 2;
        }
        static void ConsoleBasics()
        {
            Console.WriteLine("Hello, please tell me your name");
            string name = Console.ReadLine();
            string otvet = $"Your name : {name}";
            Console.WriteLine(otvet);

            Console.WriteLine("Tell me plaese youre age");
            string age2 = Console.ReadLine();

            int age = int.Parse(age2);
            Console.WriteLine($"Your age: {age}");
        }
        static void ComparingStrings()
        {
            string str1 = "abcde";
            string str2 = "abcde";
            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);//StringComparison.Ordinal это режим сравнения Определяет, равен ли указанный объект текущему объекту.
            Console.WriteLine(areEqual);
        }
        static void stringFormat()
        {
            string name = "Arthur";
            int age = 20;
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);// {} PlaceHolder или заполнитель - это те места куда в которе по порядку будут вставляться значения из переменых указнные после запятой, можно использовать литераллы. Пример вместо name или age Можно указать артур и 30
            string str2 = $"My name is {name} and I'm {age}";// Это называется интерполирования строк
            //string str2 = "My name is" + "and I'm +" + age;
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            string str3 = "My name is \n Arthur";//перенос на новую строку
            string str4 = "I'm \t 20";//Табулция

            str3 = $"My name is {Environment.NewLine} Arthur";//Это тоже самое, что и перенос на новую сторку, но для если прилодения кросс платформенное то нужно использовать это
            string str5 = "I'm Arthur and I'm \"good\" programer ";//Экранирования ковычек
            Console.WriteLine(str5);

            string str6 = "C:\\tmp\\test_file.txt";//Экранирования слешей
            Console.WriteLine(str6);

            str6 = @"C:\\tmp\\test_file.txt";//Экранирование не слешами
            Console.WriteLine(str6);

            int answer = 42;
            string result = string.Format("{0:d}", answer);//d используется для вывода целых чисел
            string resulr2 = string.Format("{0:d4}", answer);// число это показывает колтчество чисел
            Console.WriteLine(result);
            Console.WriteLine(resulr2);

            result = string.Format("{0:f}", answer);//f это флот
            resulr2 = string.Format("{0:f4}", answer);// если будет f1 то будет округления в большую сторону. Если будет 3.001 то выведит 3.1

            Console.WriteLine(result);
            Console.WriteLine(resulr2);

            Console.OutputEncoding = Encoding.UTF8;
            double money = 12.8;
            result = string.Format("{0:C}", money);
            resulr2 = string.Format("{0:C2}", money);
            Console.WriteLine(result);
            Console.WriteLine(resulr2);

            result = $"{money:C2}";
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");// Так можно поменть локаль с русского на англ
            Console.WriteLine(money.ToString("C2"));
        }
        static void StringBuilderL()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("May ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Arthur");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");

            string str = sb.ToString();
            Console.WriteLine(str);



            // Тип StringBuilder работает быстрей чем + и concat и join.
        }
        static void StringModifications()
        {
            string nameConncat = string.Concat("My ", "name ", "is ", "Arthur.");
            nameConncat = string.Join(" ", "My", "name", "is", "Arthur");//Первый элемент это что встваить между аргументами, напримиер: пробел, точка или запятую
            Console.WriteLine(nameConncat);

            nameConncat = nameConncat = "My " + "name " + "is " + "Arthur";
            Console.WriteLine(nameConncat);

            // string newName =
            nameConncat = nameConncat.Insert(2, "Hello ");// Для того что бы Insert сработал нужно заново присвоить эту же переменую или создать новую 
            Console.WriteLine(nameConncat);// Первый аргумент это после какого аргумента вставить слово

            nameConncat = nameConncat.Remove(0, 1);// Если указывать один аргумент, то он оставит это кол-во символов
            Console.WriteLine(nameConncat);// первый аргумент это с какого начать, а второй сколько удалить

            string replaced = nameConncat.Replace('l', '0');// Первый аргумент это какой символ заменить, а второй на какой
            Console.WriteLine(replaced);

            string data = "12;28;34;25";        //Для того чтобы разделить стринговую переменую                                                
            string[] splidata = data.Split(';');//Нужно 1) Создать массив 
            string first = splidata[2];         //      2) Использовать метод сплит
            Console.WriteLine(first);           //      3) Пердать методу сплит разделитель Split(;) или любой другой
                                                //      4) Вывести любой элемент массива

            Console.WriteLine("Substring");
            nameConncat = nameConncat.Substring(9);//Переданный аргумент он удалит 
            Console.WriteLine(nameConncat);

            char[] chats = nameConncat.ToCharArray();// ToCharArray препразует к массиву чаров
            Console.WriteLine(chats[5]);

            string lower = nameConncat.ToLower();
            Console.WriteLine(lower);//Преобразут к нижниму регистру
            string upper = nameConncat.ToUpper();// Преобразует у верхниму регистру
            Console.WriteLine(upper);

            string jonh = " My name is Atyhur ";// Метод Trim убирает прробелы справа и слева
            Console.WriteLine(jonh.Trim());

        }
        static void EmptyLines()
        {
            string str = string.Empty;//Тоже самое что ""
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = "b";
            string nullString = null;

            Console.WriteLine("IsNullorEmpty");//IsNullOrEmpty нужно для проверки стоки на Null
            bool IsNullorEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(IsNullorEmpty);

            IsNullorEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(IsNullorEmpty);

            IsNullorEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(IsNullorEmpty);

            IsNullorEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(IsNullorEmpty);

            Console.WriteLine();
            Console.WriteLine("IsNullOrwhiteSpace");

            bool IsNullOrwhiteSpace = string.IsNullOrWhiteSpace(nullString);// IsNullOrwhiteSpace Нужен для проверки пустых строк
            Console.WriteLine(IsNullOrwhiteSpace);

            IsNullOrwhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(IsNullOrwhiteSpace);

            IsNullOrwhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(IsNullOrwhiteSpace);

            IsNullOrwhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(IsNullOrwhiteSpace);
        }
        static void QueryingStrings()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsB = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsB);


            bool endWithAbra = name.EndsWith("abra");
            Console.WriteLine(endWithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int indexofA = name.IndexOf('a', 1);
            Console.WriteLine(indexofA);

            int lastIndexR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexR);


            Console.WriteLine(name.Length);


            string subsrFrom5 = name.Substring(5);// выводит после 5 индекса
            string subsrFrom2 = name.Substring(0, 3);// выводит с 0 до 3 индекса

            Console.WriteLine(subsrFrom5);
            Console.WriteLine(subsrFrom2);
        }
        static void StaticA()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsB = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsB);

            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.WriteLine(x);
        }
        static void MathBolsheMenshe()
        {
            int x = 1;
            int y = 2;

            bool areEqual = x == y;
            Console.WriteLine(areEqual);

            bool result = x > y;
            Console.WriteLine(result);

            result = x >= y;
            Console.WriteLine(result);

            result = x < y;
            Console.WriteLine(result);

            result = x <= y;
            Console.WriteLine(result);

            result = x != y;
            Console.WriteLine(result);
        }
        static void MathOperations()
        {
            int x = 1;
            int y = 1;

            int z = x + y;
            int f = x + y - z;
            Console.WriteLine(f);

            int b = z * 2;
            int c = z / 2;

            Console.WriteLine(b);
            Console.WriteLine(c);

            f = 4 % 2;
            b = 5 % 2;
            Console.WriteLine(f);
            Console.WriteLine(b);

            f = 3;
            f = f * f;

            f *= 2;
            // f = f * 2;
            f /= 2;
            // f = f/2;
        }
        static void IncrementDecrementDemo()
        {
            int x = 0;
            int y = 0;

            x += 2;
            // x = x + 2;
            x -= 2;
            // x = x - 2;
        }
        static void Perepol()
        {
            checked
            {
                uint x = uint.MaxValue;
                Console.WriteLine(x);
                x = x + 1;
                Console.WriteLine(x);
                x = x - 1;
                Console.WriteLine(x);
            }
        }
        static void Literals()
        {
            int x = 0b11;
            int y = 0b1001;
            int z = 0b10001001;
            Console.WriteLine(x);

            x = 0x1f;
            y = 0xff0d;
            z = 0x1fab30ef;

            Console.WriteLine();

            Console.WriteLine(x);

            Console.WriteLine(4.5e2);// это 4.5 * 10 во 2 степени

        }
        static void Variables()
        {

            // float f = 1.2f;

            int x2 = 0;
            int y2 = new int();

            var a = 2;

            decimal money = 3.0m;


            char @char = 'a';
            string name = "abc";

            bool canDrive = true;
            bool canMove = false;

            object objt = 1;
            object objt2 = "objt2";//Так делать не нужно 

            Console.WriteLine(x2);
            Console.WriteLine(name);
            Console.WriteLine("Привет!!!");
            Console.WriteLine(@char);
            Console.ReadKey();
        }
    }
}
