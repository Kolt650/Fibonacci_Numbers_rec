using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Реализуйте функцию вычисления числа Фибоначчи

namespace Fibonacci_Numbers
{
    public class Fibonacci_Test
    { 
        public int Recursion(int count)
        {
                if ((count == 0) || (count == 1))
                    return count;
                else
                    return (Recursion(count - 2) + Recursion(count - 1));
        }

        //Подаётся 1, ожидается 1 Результат работы : 1
        public void Do1_Return1() 
        {
            var result = 1;
            Console.WriteLine("Подаётся " + result + ", ожидается 1");
            Console.WriteLine("Результат работы : " + Recursion(result));
        }

        //Подаётся 0, ожидается 0 Результат работы : 0
        public void Do0_Return0()
        {
            var result = 0;
            Console.WriteLine("Подаётся " + result + ", ожидается 0");
            Console.WriteLine("Результат работы : " + Recursion(result));
        }

        //Подаётся 9, ожидается 34 Результат работы : 34
        public void Do9_Return34()
        {
            var result = 9;
            Console.WriteLine("Подаётся " + result + ", ожидается 34");
            Console.WriteLine("Результат работы : " + Recursion(result));
        }

        //Подаётся 15, ожидается 7 Результат работы : 7
        public void Do15_Return610()
        {
            var result = 15;
            Console.WriteLine("Подаётся " + result + ", ожидается 610");
            Console.WriteLine("Результат работы : " + Recursion(result));
        }


    }

    class Program
    {
        static void Main()
        {
            Fibonacci_Test TEST = new Fibonacci_Test();
            TEST.Do1_Return1();
            Console.WriteLine();
            TEST.Do0_Return0();
            Console.WriteLine();
            TEST.Do9_Return34();
            Console.WriteLine();
            TEST.Do15_Return610();
            Console.ReadKey();
        }
    }
}
