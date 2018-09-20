using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.rab._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определите переменные всех возможных примитивных типов
            //С# и проинициализируйте их. 
            bool flag = true;
            byte bit = 1; // занимает 1 байт.
            sbyte bit1 = -101;
            short sh = 1; // 2 байта.
            ushort ush = 10;
            int a = 20;
            uint b = 30; //uint: хранит целое число от 0 до 4294967295
            long c = -40; // занимает 8 байт.
            ulong d = 50; //
            decimal e = 60; //decimal: хранит десятичное дробное число занимает 16 байт.
            float fl = 30.5f; //занимает 4 байта
            double doub = 40.99; //занимает 8 байта
            char ch = 'A';
            string str = "string";
            object ob = 100; //object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.

            //Выполните 5 операций явного 

            a = (int)doub; //double to int.
            bit = (byte)a; //int to byte
            doub = (double)10f; //float to double
            a = (int)c; //long to int
            bit = (byte)d; //long to byte

            //и 5 неявного приведения.

            c = a; // long to int
            doub = 1f;// double to float 
            a = bit;//int to byte
            sh = bit; //short to byte
            doub = a; //double to int

            //Выполните упаковку и распаковку значимых типов.

            object o = a; // упаковки (boxing)
            int p = (int)o; // распаковки (unboxing)

            // Продемонстрируйте работу с неявно типизированной переменной.
            Console.WriteLine("Демонстрация работы с неявно типизированной переменной:");
            var _Char = 'A';
            var _String = "string";
            var _Int = 9999;
            var _Float = 1234.12345f;
            Console.WriteLine($"Char: {_Char.GetType()}");
            Console.WriteLine($"String: {_String.GetType()}");
            Console.WriteLine($"Int: {_Int.GetType()}");
            Console.WriteLine($"Float: {_Float.GetType()}");

            //Продемонстрируйте пример работы с Nullable переменной. 

            Nullable<int> nol = null;
            int? r = null; // краткая запись
            Console.WriteLine();
            Console.WriteLine(" HasValue которое возвращает true, если объект Nullable хранит некоторое значение и false в обратном случае:");
            Console.WriteLine(nol.HasValue);

            //Объявите строковые литералы.Сравните их. 
            Console.WriteLine("");
            Console.WriteLine("Сравнение строк: ");
            string str1 = "string_1";
            string str2 = "str_2";
            int result = String.Compare(str1, str2);
            if (result < 0)
            {
                Console.WriteLine("Строка str1 меньше строки str2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка str1 больше строки str2");
            }
            else
            {
                Console.WriteLine("Строки str1 и str2 равны");
            }

            // Создайте три строки на основе String. Выполните: сцепление, выделение подстроки, разделение строки на слова,
            //вставки подстроки в заданную позицию, удаление заданной подстроки. 
            string str_1 = "little kitten";
            string str_2 = "his dog";
            string str_3 = "my favorite house";

            Console.WriteLine("");
            Console.WriteLine("Объединение строк с помощью операции +");
            Console.WriteLine(str_1 + " " + str_2 + " " + str_3);

            Console.WriteLine("Объединение строк с помощью метода Concat:");
            Console.WriteLine(String.Concat(str_2, "+", str_3));

            Console.WriteLine("");
            Console.WriteLine("Выделение подстроки");
            Console.WriteLine(str_2.Substring(0, 6)); //Извлекает подстроку из данного экземпляра. Подстрока начинается с указанной позиции знака и имеет указанную длину. 
            Console.WriteLine(str_3.Substring(2, 10));

            Console.WriteLine("");
            Console.WriteLine("Разделение строки на слова:");
            string[] words = str_3.Split(new char[] { ' ' });
            //С помощью функции Split мы можем разделить строку на массив подстрок. В качестве параметра функция Split принимает массив символов или строк, которые и будут служить разделителями.
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
            Console.WriteLine("Вставка подстроки в заданную позицию");
            //Первым параметром в функции Insert является индекс, по которому надо вставлять подстроку, а второй параметр - собственно подстрока.
            Console.WriteLine(str_2.Insert(3, str_3));

            Console.WriteLine("");
            Console.WriteLine("Удаление заданной подстроки");
            // Возвращает новую строку, в которой было удалено указанное число символов в указанной позиции. 
            Console.WriteLine(str_3.Remove(2, 9));


            //Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками 
            string str_4 = " ";
            string str_5 = null;
            //Статический метод string.IsNullOrEmpty позволяет проверить является ли строка null или пустой.

            Console.WriteLine("");
            Console.WriteLine("Проверка является ли строка null или пустой");
            if (String.IsNullOrEmpty(str_4))
                Console.WriteLine("string 4 is null");
            else
                Console.WriteLine("string 4 is empty");//строка пустая\

            if (String.IsNullOrEmpty(str_5))
                Console.WriteLine("string 5 is null");
            else
                Console.WriteLine("string 5 is empty");

            //Создайте строку на основе StringBuilder.
            //Удалите определенные позиции и добавьте новые символы в начало и конец строки. 


            //выделяет больше памяти, чем нужно в данный момент. У вас, как разработчика, есть возможность указать, сколько именно памяти должен выделить StringBuilder,
            //Length, показывающее длину строки, содержащуюся в объекте в данный момент
            //capacity, указывающее максимальную длину строки, которая может поместиться в выделенную для объекта память
            StringBuilder SB = new StringBuilder("String_Builder", 50);
            Console.WriteLine();

            Console.WriteLine("");
            Console.WriteLine("Удаление определённых позиций:");
            SB.Remove(4, 1);//удаление
            SB.Remove(7, 1);
            Console.WriteLine(SB);
            Console.WriteLine("");
            Console.WriteLine("Добавление новых символов в конец и начало строки:");
            SB.Append("A");
            SB.Insert(0, "A");
            Console.WriteLine(SB);


            // Создайте целый двумерный массив и выведите его на консоль в отформатированном виде (матрица). 
            Console.WriteLine();
            int[,] arr = new int[7, 5];
            Random rd = new Random();
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    arr[x, y] = rd.Next(0, 10);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Вывод на консоль двумерного массива:");
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.Write(arr[x, y] + "   ");
                }
                Console.WriteLine();
            }

            //Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. Поменяйте произвольный элемент (пользователь определяет позицию и значение). 
            string[] PetNames = new string[] { "Rufus", "Bear", "Dakota", "Fido", "Samuel",
                                "Prince", "Olivia" };
            Console.WriteLine("");
            Console.WriteLine("Вывод на консоль одномерного массива:");
            foreach (string item in PetNames)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Длина массива: {PetNames.Length}");
            Console.WriteLine();
            int RandName = rd.Next(0, 5);
            Console.WriteLine($"Рандомный элемент масиива: {PetNames[RandName]}");
            Console.WriteLine($"Введите позицию: ");
            int position;
            string val;
            position = Convert.ToInt32(Console.ReadLine());
            string name = PetNames[position];
            Console.WriteLine($"Выбранный вами элемент: ");
            Console.WriteLine(PetNames[position]);
            Console.Write("Введите на что нужно заменить выбранный вами элемент: ");
            val = Convert.ToString(Console.ReadLine());
            PetNames[position] = val;
            foreach (string item in PetNames)
            {
                Console.Write(item + " ");
            }

            // Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли. 
            //Ступенчатый массив представляет собой массив массивов, в котором длина каждого массива может быть разной. 
            Console.WriteLine();
            Console.WriteLine("Введите ваш массив:");
            double[] array = new double[9];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            int a1 = 2, a2 = 0;
            Console.WriteLine("");
            Console.WriteLine("Вывод на консоль ступеньчатого массива:");
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < a1; y++)
                {
                    Console.Write(array[a2]+" ");
                    a2++;
                }
                Console.WriteLine();
                a1++;
            }


            //Создайте неявно типизированные переменные для хранения массива и строки. 
            Console.WriteLine();
            var list = new List<string>()
            {
                "cat",
                "dog"
            };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var Striiing = "string";
            Console.WriteLine("");
            Console.WriteLine("Вывод на консоль неявно типизированной переменной:");
            Console.WriteLine(Striiing);

            // a. Задайте кортеж из 5 элементов с типами int, string, char, string, ulong. 
            // Кортеж представляет набор значений, заключенных в круглые скобки

            var tuple = (10, "cat", 'q', "dog", 18446744073709551615);
            //Сделайте именованный кортеж. 
            var (_int, _string, _char, _string2, _ulong) = (10, "cat", 'q', "dog", 18446744073709551615);
            //Выведите кортеж на консоль целиком и выборочно(1, 3, 4  элементы)

            Console.WriteLine($"Кортеж Целиком: {tuple.Item1} {tuple.Item2} {tuple.Item3} {tuple.Item4} {tuple.Item5}");
            Console.WriteLine();
            Console.WriteLine($"Кортеж Выборочно: {tuple.Item1} {tuple.Item3} {tuple.Item4}");
            Console.WriteLine();

            //Выполните распаковку кортежа в переменные. 
            (int item1, string item2, char item3, string item4, ulong item5) = tuple;
            Console.WriteLine("распоковка: " + item1 + " " + item2 + " " + item3 + " " + item4 + " " + item5 + " ;");

            //Сравните два кортежа. 
            if (tuple.Item1 == _int && tuple.Item2 == _string && tuple.Item3 == _char && tuple.Item4 == _string2 && tuple.Item5 == _ulong)
                Console.WriteLine("Кортежи равны");
            else
                Console.WriteLine("Кортежи не равны");
            int[] mass = new int[] { 1, 3, 5, 2, 6, 10 };

            string st = "alala";

            Console.WriteLine();
            Console.WriteLine(" Вывод на консоль максимального и минимального элементов массива, сумму элементов массива и первую букву строки:");
            Console.WriteLine(ReturnTuple(mass, st));
        }

        //Создайте функцию вызовите ее. Формальные параметры функции – массив целых и строка. 
        //Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива, сумму элементов массива и первую букву строки .
            static (int, int, int, char) ReturnTuple(int[] mass, string st)
                {
            	    int maxEl = mass[0];
            	    int minEl = mass[0];
            	    int sum = 0;
            	    char firstLet = st[0];
            	    foreach (int item in mass)
                {
            	    if (item > maxEl)
            		    {
            		    maxEl = item;
            		    }
            		    if (item < minEl)
            		    {
            			    minEl = item;
            		    }
            		    sum += item;
            	    }

            	    return ValueTuple.Create<int, int, int, char>(
            		    maxEl,
            		    minEl,
            		    sum,
            		    firstLet
            	    );
        }
    }
}
