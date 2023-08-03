using System;

public class Program
{
  

    public static void Main(string[] args)
    {
        string b= "Hello, World!";
        string a= ", world";

        if (b.ToLower().Contains( a.ToLower()))
        {
            Console.WriteLine(" a is found in the b.");
        }
        else
        {
            Console.WriteLine("a is not found in the b.");
        }
    }
}

