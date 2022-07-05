using System.Globalization;
namespace Exercicio3
{
     public class Exercicio3_udemy
     {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float valueHours = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float total = hours * valueHours;

            System.Console.WriteLine("NUMBER = "+ number);
            Console.WriteLine("SALARY = U$ "+ total.ToString("F2", CultureInfo.InvariantCulture));
        }
     }
}