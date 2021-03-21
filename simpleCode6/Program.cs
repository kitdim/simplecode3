using System;

namespace simpleCode6
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>Метод для ввода символа
            ///</summary>
            static char Text()
            {
                char b = Console.ReadKey().KeyChar; // после ОДНОГО нажатие на любую клавишу сразу сохраняет значение в переменную
                return b;
            }
            /// <summary> Метод вывода значенний в конслоль
            /// </summary>
            static void Cicle(int a, char d)
            {
                for (int i = 0; i < a; i++)
                {
                    Console.Write(d);
                }
            }
            /// <summary> Метод для задержки экрана консоли
            /// </summary>
            static void Pause()
            {
                Console.ReadKey();
            }
            /// <summary> Метод в котором в массив заносятся 
            /// рандомные значение, а далее вывод массива в консоль
            /// </summary>
            static void Array(int[] a)
            {
                Random rnd = new Random();

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = rnd.Next(5);
                }
                foreach (var item in a)
                {
                    Console.Write($"{item} ");
                }
            }
            /// <summary> Метод для поиска  в массиве заданного числа
            /// </summary>
            static void Fill(int[] a,int b)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i]==b)
                    {
                        Console.WriteLine("Число {0} найдено на позиции {1} в индексе",b,i);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Число {0} не найдено на позиции {1}", b,i);
                    }
                }
                Console.WriteLine();
            }
            /// <summary>Метод для создание отступа 
            /// </summary>
            static void Otstep()
            {
                Console.WriteLine();
            }
            /// <summary> Метод для ввода в консоль
            /// </summary>
            static int Input()
            {
                var a = int.Parse(Console.ReadLine());
                return a;
            }

            #region Задача 1. 
            //Написать функцию которая выводит на экран строку. 
            //Символы из которых состоит строка и их количество вводятся пользователем.
            #endregion
            Console.Write("Введите количество повторений: "); var x = Input();
            Console.Write("Введите строку для повтора: "); char stroka = Text();
            Otstep();
            Cicle(x, stroka);
            Pause();
            Otstep();

            #region Задача 2. 
            // Написать метод для поиска индекса элемента массива(тип элементов в массиве -int), 
            // метод должен вернуть индекс первого найденного элемента(если он будет найден).
            #endregion
            int[] arr = new int[5];
            Array(arr);
            Otstep();
            Console.Write("Введите число для поиска: "); var i = Input();
            Fill(arr, i);
            Pause();
        }
    }
}
