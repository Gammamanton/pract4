using System;

namespace pract4
{
    class Progra
    {
        static void Main(string[] args)
        {
            //14. Обчислити число p з допомогою ряду 𝜋/4=1−1/3+1/5−⋯
            //Обчислення провести з простою та подвійною точністю.
            //, що дає значення числа 𝜋 з точністю до трьох знаків.

            
               
            static void ifpart(ref int i, ref int j, ref double Pi4, ref double dodanok){
                if (j % 2 == 0)
                {
                    Pi4 -= Convert.ToDouble(1) / Convert.ToDouble(i);
                    i++;
                    j++;
                }
                else
                {
                    Pi4 += Convert.ToDouble(1) / Convert.ToDouble(i);
                    i++;
                    j++;
                    dodanok++;
                }

            }


            double Pi, Pi4 = 1;
            int i = 3;
            int j = 2;
            double dodanok = 0;
            bool adfss = true;



            do
            {

                if (i % 2 != 0)
                {
                    ifpart(ref i, ref j, ref Pi4, ref dodanok);
                }
                else
                {
                    i++;
                }
                if (Pi4 * 4 > 3.14 && Pi4 * 4 < 3.15)
                {
                    adfss = false;
                }
            }
            while (adfss == true);









            Console.WriteLine("Kilkisty dodatkiv = " + dodanok);
            Console.WriteLine("pi= " + (Pi4 * 4));
            //Задача 2 Створити додаток з допомогою якого можна для ряду,
            //члени якого обчислюються по формулі підрахувати суму членів ряду з точністю до 0,000001
            //і суму перших 10 членів ряду. Якщо Ви вважаєте за необхідне, можете спростити або перетворити вираз.
            //picha


            int nbo;

            double n, mmm;

            Console.Write("ryad lenth: ");
            nbo = Convert.ToInt32(Console.ReadLine());
            
            static double findn(double n)
            {
                return Math.Round(Math.Pow(-1, n) * ((n + 1) / (n * n + 2 * n + 1)), 6);
            }


            double[] arr = new double[nbo];

            for (i = 0; i < nbo; i++)
            {
                n = Convert.ToDouble(i);
                arr[i] = findn(n);
            }
            Console.WriteLine("Array = ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            mmm = 0;
            Console.WriteLine();
            for (i = 0; i < arr.Length; i++)
            {
                mmm = mmm + arr[i];
            }
            Console.WriteLine("Sum = " + Math.Round(mmm, 6));
            mmm = 0;

            for (i = 0; i < 10; i++)
            {
                mmm = mmm + Math.Round(arr[i], 6);
            }
            Console.WriteLine("Sum first 10 = " + mmm);



            //Протабулювати функцію на проміжку з кроком 1.4 
            //Результати обчислень вивести у вигляді таблиці пар чисел та графіка.
            //Виконати завдання пошуку даних відповідно до вашого варіанта.
            //Якщо шуканих даних немає, то вивести про це повідомлення. Функція вказана у табл. 1
            //picha
            static double formulaf(double g)
            {
                return 7 * Math.Cos(g) * Math.Sin(7 + 2 * g);
            }




            double g = 0;
            i = 0;
            double[,] array = new double[11, 2];
            for (i = 0; g < 15; i++)
            {
                array[i, 0] = g;
                array[i, 1] = formulaf(g);
                g = g + 1.4;

            }

            Console.WriteLine();


            static void texert(int m, double[,] array)
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.Write(Math.Round(array[i, m], 2) + " ");
                }
                Console.WriteLine();
            }


            Console.Write("x= ");
            texert(0, array);

            Console.Write("y= ");
            texert(1, array);
            //f=7cos(x)*sin(7+2x)
            //7 * Math.Cos(g) * Math.Sin(7 + 2 * g
            //Обчислити добуток значень аргументна X для яких досягаються мінімальні та максимальні значення функції .




            double minn = array[0, 1], maxn = array[0, 1], sumn = 0;
            int tpmin = 0, tpmax = 0;

            for (i = 0; i < 10; i++)
            {
                if (maxn < array[i + 1, 1])
                {
                    maxn = array[i + 1, 1];
                    tpmax = i + 1;
                }
                if (minn > array[i + 1, 1])
                {
                    minn = array[i + 1, 1];
                    tpmin = i + 1;
                }


            }
            sumn = array[tpmax, 0] * array[tpmin, 0];
            Console.WriteLine();
            Console.WriteLine("dobutok= " + Math.Round(sumn, 3));
            Console.WriteLine();
            //14. Дано натуральне число 𝑔. Надрукувати розклад цього числа на прості множники. Реалізувати два варіанта:
            int ga, gb= 0;



            Console.WriteLine("natural number: ");
            ga = Convert.ToInt32(Console.ReadLine());


            static void dileite(int ha, ref int ga, ref int gb)
            {
                for (int i = 2; i <= ga / 2; i++)
                {
                    if ((ga % i) == 0 && i != ha)
                    {
                        gb = i;
                    }
                }
            }




            dileite(0,ref ga, ref gb);
            Console.WriteLine(gb + " " + ga/gb);
            int gc = gb;

            dileite(gc, ref ga, ref gb);
            Console.WriteLine(gb + " " + ga / gb);






        }


    }
}
