using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House kv1 = new House("Адрес 1", 2 ,3, 63);
            House kv2 = new House("Адрес 2", 4, 2, 46);
            House kv3 = new House("Адрес 3", 5, 4 , 100);
            House[] houses = { kv1, kv2, kv3 };
            Console.WriteLine("Введите число комнат");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите этаж");
            int floor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите площадь");
            int S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Список квартир с заданным числом комнат");
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i].count == num)
                {
                    Console.WriteLine($"Номер квартиры {i}");
                }
            }
            Console.WriteLine("Список квартир с заданным чилом комнат и на заданном этаже");
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i].count == num || houses[i].floor == floor)
                {
                    Console.WriteLine($"Номер квартиры {i}");
                }
            }
            Console.WriteLine("Список квартир с площадью более указанной");
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i].area < S)
                {
                    Console.WriteLine($"Номер квартиры {i}");
                }
            }

        }
    }
}
public class House
{
    public string adress;
    public int floor;
    public int count;
    public double area;
    public House(string adress, int floor, int count, double area)
    {
        this.adress = adress;
        this.floor = floor;
        this.count = count;
        this.area = area;
    }

}

