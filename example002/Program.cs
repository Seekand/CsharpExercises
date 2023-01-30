using System;

namespace exercise02{

    class Program{

        static void Main(string[] args){

            Int32 number;
            Console.WriteLine("Inform a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < 11; i++){
                Console.WriteLine($"{i} X {number} = {i * number}");
            }
        }
    }
}
