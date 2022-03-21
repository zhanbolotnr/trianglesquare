using System;

namespace LearnUdemy01
{
    class Program
    {
        static void Main(string[] args)
        {
            //The square of a triangle
            Console.WriteLine("Enter the Length of side AB: ");
            double ab = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Length of side BC: ");
            double bc = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Length of side AC: ");
            double ac = double.Parse(Console.ReadLine());

            double p = (ab + bc + ac) / 2;

            double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            Console.WriteLine($"Square of the triangle equals :{square}");

        }

    }
}
/*         //Обмен значения переменных
 *          Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"a = {a}, y = {y}");

            Console.WriteLine("obmen: ");
            int c = a;
            a = y;
            y = c;
            Console.WriteLine($"a = {a}, y = {y}");*/

/*      //Количество цифр в строке
        Console.WriteLine("Выведите 3 целое число: ");
        int nums = int.Parse(Console.ReadLine());
        Console.WriteLine(nums.ToString().Length);*/
