using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> { 1, 2, 3, 4,5, 5 }; 

        HashSet<int> set = new HashSet<int>(list); 

        bool Unique = set.Count == list.Count; 

        Console.WriteLine("Всі елементи унікальні: " + Unique);
        Console.ReadLine();
    }
}
