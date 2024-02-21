using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett heltal");
        int svar = int.Parse(Console.ReadLine());
        Console.WriteLine(Primtal(svar)+" tal");
    }
    static int Primtal(int svar)
    {
        int gånger = 0;
        for(int i = svar-1; i>0;  i--)
        {
            if(i%2 != 0)
            {
                gånger++;
            }
        }
        return gånger;
    }
}
