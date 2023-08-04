using System;

public class Program
{
  

    public static void Main(string[] args)
    {
        string Sentence= "he, s";
        string Searchsentence= "He, ";

       if(Sentence.ToLower().CustomContains(Searchsentence.ToLower()))
        {
            Console.WriteLine("true");
        }
       else
        {
            Console.WriteLine("false");
        }
    }
}

