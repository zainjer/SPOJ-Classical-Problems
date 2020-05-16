using System;
using System.Collections.Generic;

namespace Prototyping_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<int>();
            var input = 0;

            while (true)
            {
                input = int.Parse(Console.ReadLine());
                
                if (input != 42)
                {
                    if (input < 100)
                    {
                        inputList.Add(input);
                    }
                }
                else
                {
                    break;
                }
            }                        
            foreach(var x in inputList)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
