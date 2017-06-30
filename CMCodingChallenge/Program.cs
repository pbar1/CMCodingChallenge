using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizz;

namespace CMCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Default FizzBuzzer ===");
            var defaultBuzzer = new FizzBuzzer();
            foreach (var s in defaultBuzzer.Run())
                Console.WriteLine(s);

            Console.WriteLine("\n=== Default FizzBuzzer, updated parameters ===");
            var updatedDivisors = new Dictionary<int, string>();
            updatedDivisors.Add(10, "Taco");
            defaultBuzzer.SetDivisors(updatedDivisors);
            defaultBuzzer.SetUpperBound(40);
            foreach (var s in defaultBuzzer.Run())
                Console.WriteLine(s);

            Console.WriteLine("\n=== New FizzBuzzer, all new parameters ===");
            var newDivisors = new Dictionary<int, string>();
            newDivisors.Add(4, "Ash");
            newDivisors.Add(7, "Brock");
            newDivisors.Add(8, "Misty");
            var newBuzzer = new FizzBuzzer(newDivisors, 56);
            foreach (var s in newBuzzer.Run())
                Console.WriteLine(s);
        }
    }
}
