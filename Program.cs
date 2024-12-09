using System;

class Program
{
    static void Main1()
    {
        
        Console.Write("Radiusni kiriting : ");

        double radius = double.Parse(Console.ReadLine());

        double pi = Math.PI;

        double S = pi * (radius * radius);

        double L = 2 * pi * radius;

        Console.WriteLine($" S = {S}, L = {L} ");
    }
    static void Main2()
    {
        Console.WriteLine("Valyuta qiymatini kiriting ");

        var ValyutaQiymati = int.Parse(Console.ReadLine());

        int obshiy = ValyutaQiymati * 12400;

        Console.WriteLine($"{obshiy} so'm");
    }
    static void Main()
    {
      
        Console.Write("Tug'ilgan yilLingizni kiriting: ");

        int yil = int.Parse(Console.ReadLine());

        int xozirgi = DateTime.Now.Year;// chatgpt dan foydalandim DateTime.Now,Year ni bilish uchun

        int kun = xozirgi - yil;
        int obshiy = kun * 365;

        // Natijani chiqarish
        Console.WriteLine($"Sizning yoshingiz {obshiy} kun.");
    }
}
