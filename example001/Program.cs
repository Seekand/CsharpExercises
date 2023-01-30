using System;

namespace sumtwonumbers{

    class SumTwoNumbers{

        static void Main(string[] args){
            int n1, n2;

            Console.WriteLine("Inform a number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inform a other number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            Console.Write($"The numbers reporte were {n1} and {n2}, result = {n1+n2}");
            Console.Read();
            Console.Clear();
        }
    }
}