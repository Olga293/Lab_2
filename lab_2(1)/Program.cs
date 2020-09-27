using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Типы
            //a) Определите переменные всех возможных примитивных типов С# и проинициализируйте их
            //Console.WriteLine("1.a)*******************************");
            int a1 = 1; //хранит число от -2^31 до 2^31-1, 4 байта
            float a2 = 5.4f; //хранит число от 0 до 4294967295, 4 байта
            double a3 = 5.8; //вающая точка, 4 байта
            bool a4 = false; //true или false, 1 байт
            char a5 = 's'; //символ, 2 байта
            string a6 = "qwerty"; //массив символов
            byte a7 = 255; //хранит число от 0 до 255, 1 байт
            sbyte a8 = -128;  //хранит число от -128 до 127, 1 байт
            short a9 = -33; //хранит число от -32768 до 32767, 2 байта
            ushort a10 = 66; //хранит число от 0 до 65535, 2 байта
            uint a11 = 42; //хранит число от 0 до 65535, 4 байта
            long a12 = -9; //целое число, 8 байт
            ulong a13 = 18; //целое неотрицательное, 8 байт
            decimal a14 = 105.8m; //28 знаков после запятой, 16 байт
            object a15 = -5, a16 = "Hello World!", a17 = 3.9; //любой тип данных, 4 байта на 32-разрядной платформе и 8 байтов на 64-разрядной

          //b) Выполните 5 операций явного и 5 неявного приведения *operator ТИП() const
           //Явное преобразование:
            Console.WriteLine("1.b)*******************************");
            int b1 = 3;
            byte b2 = (byte)b1;
            Console.WriteLine(b1.GetType());
            double b3 = 1.0;
            decimal b4 = (decimal)b3;
            Console.WriteLine(b4.GetType());
            double b5 = (double)b1;
            Console.WriteLine(b5.GetType());
            int b6 = 2;
            double b7 = (double)b6;
            Console.WriteLine(b7.GetType());
            char b8 = 'a';
            int b9 = (int)b8;
            Console.WriteLine(b9.GetType());
            //Неявное преобразование: byte->short->int->long->decimal; int->double; short->float->double; char->int
            byte b10 = 255;
            short b11 = b10;
            Console.WriteLine(b11.GetType());
            int b12 = b11;
            Console.WriteLine(b12.GetType());
            long b13 = b12;
            Console.WriteLine(b13.GetType());
            decimal b14 = b13;
            Console.WriteLine(b14.GetType());
            double b15 = b12;
            Console.WriteLine(b15.GetType());

            //c) Выполните упаковку и распаковку значимых типов
            //Console.WriteLine("1.c)*******************************");
            int c1 = 12;
            object c2 = c1;//Упаковка-процесс преобразования типа значения в тип System.Object или в тип интерфейса, который реализуется данным типом-значением
            int c3 = (int)c2;//Распаковка-получение указателя на исходный значимый тип (поля данных), содержащийся в объекте
            byte c4 = 4;
            object c5 = c4;
            int c6 = (int)(byte)c5;

            //d) Продемонстрируйте работу с неявно типизированной переменной
            Console.WriteLine("1.d)*******************************");
            var d1 = 1;
            Console.WriteLine(d1.GetType());
            var d2 = 1.56;
            Console.WriteLine(d2.GetType());

            //e) Продемонстрируйте пример работы с Nullable переменной
            Console.WriteLine("1.e)*******************************");
            int? e1 = null;
            Nullable<int> e2 = 0;
            Console.WriteLine(e1 == e2);//Проверка на равенство
            int? e3 = 3;
            int e4 = (int)e3;//Явное преобразование
            Console.WriteLine(e4.GetType());
            Console.WriteLine(e1 ?? e2);//null-объединение



            //2) Строки
            //a) Объявите строковые литералы. Сравните их
            Console.WriteLine("2.a)*******************************");
            string aa1 = "Hello World!!!";
            string aa2 = "Hello world!!!";
            Console.WriteLine(String.Compare(aa1, aa2));
            //b) Создайте три строки на основе String. Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки
            Console.WriteLine("2.b)*******************************");
            string aa3 = "abc";
            string aa4 = "d e f";
            string aa5 = "ggg hhh iii";
            Console.WriteLine(String.Concat(aa3, aa4, aa5));
            string aa6 = String.Copy(aa5);
            Console.WriteLine(aa6);
            string aa7 = aa5.Substring(4, 3);
            Console.WriteLine(aa7);
            string[] aa8 = aa5.Split(' ');
            foreach (string i in aa8)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(aa5.Insert(3, aa3));
            Console.WriteLine(aa5.Remove(4, 3));
            //c) Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками
            Console.WriteLine("2.c)*******************************");
            string aa9 = "";
            Console.WriteLine(String.Compare(aa9, aa3));
            Console.WriteLine(String.Concat(aa9, aa3));
            //d) Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки
            Console.WriteLine("2.d)*******************************");
            StringBuilder aa10 = new StringBuilder("Hello World!!!", 50);
            Console.WriteLine(aa10);
            Console.WriteLine(aa10.Remove(11, 3));
            Console.WriteLine(aa10.Insert(0, "Say: "));
            Console.WriteLine(aa10.Append("!!!"));



            //3) Массивы
            //a. Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица).
            Console.WriteLine("3.a)*******************************");
            int[,] aaa1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", aaa1[i, j]);
                }
                Console.WriteLine();
            }
            //b. Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. Поменяйте произвольный элемент (пользователь определяет позицию и значение)
            Console.WriteLine("3.b)*******************************");
            string[] aaa2 = { "aaa", "bbb", "ccc", "ddd" };
            foreach (string s in aaa2)
            {
                Console.Write("\t" + s);
            }
            Console.WriteLine("\n" + "Lenth of array:" + aaa2.Length);
            /*Console.WriteLine("\n"+"Enter index of elemet:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + "Enter new elemet:");
            string aaa3 = Console.ReadLine();
            aaa2[x] = aaa3;
            foreach (string s in aaa2)
            {
                Console.Write("\t" + s);
            }*/
            //c. Создайте ступечатый (не выровненный) массив вещественных чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно.Значения массива введите с консоли.
            Console.WriteLine("3.c)*******************************");
            /*int[][] aaa4 = { new int[2], new int[3], new int[4] };
            for (int i = 0; i < aaa4.Length; i++)
            {
                Console.WriteLine("\n" + "Line " + (i + 1));
                for (int j = 0; j < aaa4[i].Length; j++)
                {
                    Console.WriteLine("Enter elemet:");
                    aaa4[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < aaa4.Length; i++)
            {
                for (int j = 0; j < aaa4[i].Length; j++)
                {
                    Console.Write("\t" + aaa4[i][j]);
                }
                Console.WriteLine();
            }*/
            //d. Создайте неявно типизированные переменные для хранения массива и строки.
            Console.WriteLine("3.d)*******************************");
            var ddd1 = "Hello World";
            Console.WriteLine(ddd1.GetType());
            var ddd2 = new []{ 'a', 'b', 'c' };
            Console.WriteLine(ddd2.GetType());



            //4) Кортежи
            //a. Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.
            Console.WriteLine("4.a)*******************************");
            ValueTuple<int, string, char, string, ulong> aaaa1 = (1, "Hello", '/', "world", 19);
            //b. Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4 элементы)
            Console.WriteLine("4.b)*******************************");
            Console.WriteLine(aaaa1.Item1.ToString() + aaaa1.Item3.ToString() + aaaa1.Item4.ToString());
            Console.WriteLine(aaaa1.ToString());
            //c. Выполните распаковку кортежа в переменные.
            Console.WriteLine("4.c)*******************************");
            var aaaa2 = aaaa1.Item1;
            var aaaa3 = aaaa1.Item2;
            var aaaa4 = aaaa1.Item3;
            var aaaa5 = aaaa1.Item4;
            var aaaa6 = aaaa1.Item5;
            Console.WriteLine(aaaa2);
            Console.WriteLine(aaaa3);
            Console.WriteLine(aaaa4);
            Console.WriteLine(aaaa5);
            Console.WriteLine(aaaa6);
            //d. Сравните два кортежа.
            Console.WriteLine("4.d)*******************************");
            ValueTuple<int, string, char, string, ulong> aaaa7 = (1, "Hello", '/', "World", 19);
            Console.WriteLine(aaaa1.CompareTo(aaaa7));



            //5) Создайте локальную функцию в main и вызовите ее.
            //Формальные параметры функции – массив целых и строка.
            //Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива сумму элементов массива и первую букву строки.
            Console.WriteLine("5*******************************");
            int[] f1 = { 1, 2, 3, 4, 5 };
            string f2 = "Hello world";
            (int, int, int, char) LocFunc(int[] f11, string f22)
            {
                return (f11.Min(), f11.Max(), f11.Sum(), f22.First());
            }
            Console.WriteLine(LocFunc(f1, f2));
        }
    }
}
