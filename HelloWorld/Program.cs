using System;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            const float pi = 3.14f;
            Console.WriteLine(pi);
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            Console.WriteLine(b);
            var john = new Person();
            Math.Calculator calculator = new Math.Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            Console.WriteLine(numbers[1]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);

            var names = new string[3] { "jack", "jan", "joe" };
            Console.WriteLine(names[0]);
        }
    }

}
