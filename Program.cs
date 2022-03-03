using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            Console.Write("Введите диаметр цилиндра, м: ");
            cylinder.D = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите высоту цилиндра, м: ");
            cylinder.H = Convert.ToUInt32(Console.ReadLine());
            cylinder.V = Math.PI / 4 * cylinder.D * cylinder.D * cylinder.H;
            Console.WriteLine($"Объем цилиндрического резервуара: {cylinder.V} м^3.");
            Console.ReadKey();
        }
    }
}
