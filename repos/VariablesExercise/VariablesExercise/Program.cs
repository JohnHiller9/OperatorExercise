using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declared and initialized a variable
            //camelCase for variable name
            //Explicit typing
            string dogName = "Max";
            int dogAge = 10;
            char nickName = 'M';
            bool isHappy = true;
            double tennisBalls = 32;
            decimal weight = 70.3m;

            //String interpolation with the $ and {} around variables
            Console.WriteLine($"My dog's name is {dogName}. " +
                $"He is {dogAge} years old and has {tennisBalls} tennis balls. " +
                $"It is {isHappy} that he is very happy" +
                $" and is at a healthy weight of {weight}");

            if(isHappy = true)
            {
                Console.WriteLine($"{dogName} is very happy!");
            }
            else
            {
                Console.WriteLine($"{dogName} is really tired!");
            }


            Console.WriteLine("Hello World!");
        }
    }
}
