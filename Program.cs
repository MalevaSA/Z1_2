using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace z_1_2
{
    class Program
{
    static void Main(string[] args)
{
    float x, y;
    string inside = "Точка внутри контура!";
    string outside = "Точка вне контура!"; 
    Console.Write("Введите действительное число х: ");
    x = float.Parse(Console.ReadLine());
    Console.Write("\nВведите действительное число у: ");
    y = float.Parse(Console.ReadLine());
    if (x >= -1 && x <= -0.5 && y > 0 && y < 1)
    Console.WriteLine(inside);
    else
{
    if (x >= -0.5 && x <= 0 && y > 0.5 && y < 1)
    Console.WriteLine(inside);
    else
{
    if (x > 0 && y < 0 && x * x + y * y <= 1)
    Console.WriteLine(inside);
    else
    Console.WriteLine(outside);
}
} 
        Console.ReadKey();
}
}
}
