using System;
using System.Text;

namespace ЛБ1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////a
            //bool a = true;
            //byte b = 0;
            //sbyte c = -1;
            //char d = '#';
            //decimal e = 432432423;
            //double f = 3.45;
            //float g = -455;
            //int h = -10;
            //uint i = 10;
            //long j = -100;
            //ulong k = 100;
            //short l = -1000;
            //ushort m = 1000;
            //string n = "Hello";
            //dynamic o = 453;
            //object p = 234;

            //string q = Console.ReadLine();
            //Console.WriteLine(q);

            ////b
            //short a1 = 45;
            //byte b1 = (byte)a1;

            //string a2 = Console.ReadLine();
            //int b2 = Convert.ToInt32(a2);
            //Console.WriteLine(b2);

            //string a3 = "3.56";
            //double b3 = Convert.ToDouble(a3);
            //Console.WriteLine(b3);

            //string a4 = "3";
            //int b4 = int.Parse(a4);
            //Console.WriteLine(b4);

            //string a5 = "true";
            //bool b5 = bool.Parse(a5);
            //Console.WriteLine(b5);

            //byte a6 = 5;
            //short b6 = a6;
            //int b7 = a6;
            //long b8 = a6;
            //double a7= b8; // Преобразование long в double
            //float a8 = a6;

            ////c
            //int c1 = 5;
            //object obj = c1; // Явная упаковка
            //string c2 = c1.ToString(); // Неявная упаковка
            //c2 = (123.56).ToString();
            //int res = (int)obj; // Распаковка

            ////d
            //var s1 = 4.0;
            //var s2 = 5.0;
            //var hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            //Console.Write("Гипотенуза треугольника со сторонами " + s1 + " by " + s2 + " равна ");
            //Console.WriteLine("{0:#.###}.", hypot);

            ////e
            //int? nul1=null;
            //Nullable<int> nul2 = 5;
            //nul1 = nul2 + 1;
            //Console.WriteLine(nul1); 

            // //f
            // var mistake = 10;
            //// mistake = true; // данная переменная является строго типизированной, так же как если бы объявили её тип самостоятельно, 
            //                 // однако её тип определяет компилятор. 

            //// 2) 
            //// a
            //var line1 = "Hello World!";
            //var line2 = "Hello World!!";
            //int line3 = line1.CompareTo(line2);
            ////Console.Write(line1.CompareTo(line2));
            //if(line3<=-1)
            //    Console.WriteLine("Строка line1 не предшествует строке line2");
            //else
            //    Console.WriteLine("Строка line1 предшествует строке line2");

            ////b
            //string line21 = "Hello";
            //string line22 = "World";
            //string line23 = "!!!";
            //Console.WriteLine(line21+line22+line23);
            //string line25 = line21; // копирование
            //string line24 = line21.Substring(3, 1); // выделение подстроки
            //Console.WriteLine(line24);

            //string text = "И поэтому все так произошло";
            //string[] words = text.Split(new char[] { ' ' }); // разделение строки на слова
            //foreach (string s in words)
            //{
            //    Console.WriteLine(s);
            //}

            //string text1 = "Хороший день";
            //string subString = "замечательный ";
            //text1 = text1.Insert(8, subString); // вставка подстроки в заданную позицию
            //Console.WriteLine(text1);

            //text = text.Remove(17);   // вырезаем последнее слово
            //Console.WriteLine(text);


            //string name = "Mark";
            //var date = DateTime.Now;
            //// Составное форматирование:
            //Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            //// Интерполяция
            //Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
            ////$ идентифицирует строковый литерал как интерполированную строку.
            //// Интерполированная строка — это строковый литерал, который может содержать выражения интерполяции.


            ////c
            //string empty = ""; // пустая строка
            //string nullString = null; // null строка
            //Console.WriteLine("Строка nullString {0}.", Test(nullString)); // метод string.IsNullOrEmpty

            //String Test(string s)
            //{
            //    if (String.IsNullOrEmpty(s))
            //        return "является нулевой или пустой";
            //    else
            //        return String.Format("(\"{0}\") не является ни нулевой, ни пустой", s);
            //}


            ////d
            //StringBuilder sb = new StringBuilder("Привет мир");
            //Console.WriteLine($"Длина строки: {sb.Length}");
            //Console.WriteLine($"Емкость строки: {sb.Capacity}");
            //sb.Remove(3, 3);
            //Console.WriteLine(sb);
            //sb.Insert(0, "*** ");
            //sb.Insert(11, " ***");
            //Console.WriteLine(sb);


            ////3
            ////a
            //int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 } };

            //int rows = mas.GetUpperBound(0) + 1; // mas.GetUpperBound(0) + 1 получаем количество строк таблицы
            //int columns = mas.Length / rows; // mas.Length / rows получаем количество элементов в каждой строке:
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{mas[i, j]} \t");
            //    }
            //    Console.WriteLine();
            //}



            ////b
            //string[] line4 = { "Hello", "World", "!!!" };
            //int el = line4.Length;
            //for (int i=0; i<el; i++)
            //    Console.Write(" ["+i+"] "+line4[i]);
            //Console.WriteLine("\n"+"Длина строки " + el);

            //Console.WriteLine("Введите номер позиции");
            //string a21 = Console.ReadLine();
            //int b21 = Convert.ToInt32(a21);
            //while(b21>el-1)
            //{
            //    Console.WriteLine("Неверный номер позиции!");
            //    a21 = Console.ReadLine();
            //    b21 = Convert.ToInt32(a21);
            //}
            //while(b21 < 0)
            //{
            //    Console.WriteLine("Неверный номер позиции!");
            //    a21 = Console.ReadLine();
            //    b21 = Convert.ToInt32(a21);
            //}
            //b21 = Convert.ToInt32(a21);
            //Console.WriteLine("Введите значение");
            //string a22 = Console.ReadLine();
            //for (int i = 0; i < el; i++)
            //    if (i == b21 )
            //        line4[i] = a22;
            //for (int i = 0; i < el; i++)
            //    Console.Write(" [" + i + "] " + line4[i]+"  ");


            ////c
            //ulong[][] newA = new ulong[3][]; // объявление массива из 3-х строк, элементы которого имеют тип ulong
            //// выделение памяти для каждой строки
            //newA[0] = new ulong[2]; // в строке с индексом 0 есть 2 элементов
            //newA[1] = new ulong[3]; // в строке с индексом 1 есть 3 элемента
            //newA[2] = new ulong[4];

            //Console.WriteLine("Введите элементы ступенчатого массива:");
            //for (int i = 0; i < 3; i++)
            //{
            //    int columns1 = newA[i].Length;
            //    for (int j = 0; j < columns1; j++)
            //    {
            //        Console.Write("["+i+"]"+"["+j+"] - ");
            //        string a31 = Console.ReadLine();
            //        ulong b31 = Convert.ToUInt64(a31);
            //        newA[i][j] = b31;
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    int columns1 = newA[i].Length;
            //    for (int j = 0; j < columns1; j++)
            //    {
            //        Console.Write("[" + i + "]" + "[" + j + "] -  "+newA[i][j]+"  ");

            //    }
            //    Console.WriteLine();
            //}


            ////d
            //var array21 = new object[0];
            //var str21 = "";


            ////4
            ////a, b
            //(int, string, char, string, ulong) tuple = (35, "Привет", '!', "Мир", 345);
            //Console.WriteLine(tuple);
            //Console.Write(tuple.Item1);
            //Console.Write(tuple.Item3);
            //Console.Write(tuple.Item4 + "\n");


            ////c
            //(string first, long second, string middle, string last) LookupName(long id)
            //{
            //   string first="string" , middle= "hello", last = "world";
            //   return (first, id, middle, last);
            //}

            //var names = LookupName(1);
            //(string a41, long a44, string a42, string a43) = LookupName(1); // распаковка
            //var (a45, a48, a46, a47) = LookupName(2); // распаковка
            //string first1, middle1, last1; long id1;
            //(first1, id1, middle1, last1) = LookupName(2); // распаковка, когда переменные уже объявлены
            //Console.WriteLine(names);
            //Console.WriteLine($"найдены {a41} {a44}.");
            //int _ = 1;
            //Console.WriteLine(_);

            ////d
            //(int, string, char, string, ulong) tuple1 = (35, "Привет", '!', "Мир", 345);
            //(int, string, char, string, ulong) tuple2 = (35, "Привет", '!', "Мир", 345);
            //(int, string, char, string, ulong) tuple3 = (354, "Привет", '!', "Мир", 345);
            //Console.WriteLine(tuple1 == tuple2);
            //Console.WriteLine(tuple1 == tuple3);



            ////5
            //(int max, int min, int sum, string buk) function(int[] a, string b)
            //{
            //    int max = 0, min = 100, sum=0;
            //    string buk="";
            //    for (int i=0; i<5; i++)
            //    {
            //        if (a[i] > max)
            //            max = a[i];
            //        if (a[i] < min)
            //            min = a[i];
            //        sum = sum + a[i];
            //        buk = b.Remove(1);
            //    }
            //    return (max, min, sum, buk);
            //}

            //int[] a55 = { 44, 33, 55, 3, 1 };
            //string b55= "Hello";
            //function(a55, b55);
            //var (aa, bb, cc, dd) = function(a55, b55); // распаковка
            //Console.WriteLine("max="+aa+", min="+bb+", sum="+cc+", buk="+dd);



            ////6
            //void function1()
            //{
            //    checked
            //    {
            //        try
            //        {
            //            int a = 2147483647, b = 1;
            //            Console.WriteLine("checked a="+a);
            //            a = a + b;
            //            Console.WriteLine("a+1"+a);
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("checked a+1=Переполнение\n");
            //        }
            //    }

            //}
            //void function2()
            //{
            //    unchecked
            //    {
            //        try
            //        {
            //            int a = 2147483647, b = 1;
            //            Console.WriteLine("unchecked a=" + a);
            //            a = a + b;
            //            Console.WriteLine("unchecked a+1=" + a);
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("checked a+1=Переполнение\n");
            //        }

            //    }
            //}

            //function1();
            //function2();


        }
    }
}
