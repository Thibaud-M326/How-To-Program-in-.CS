/*
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        MeetAlien();
        
        Console.WriteLine("------------------------------------");
        
        MeetAlien();

        Console.ReadKey();
    }
    
    static void MeetAlien()
    {
        Random numberGen = new Random();
        
        string name = "X-" + numberGen.Next(10, 9999);
        int age = numberGen.Next(10, 999);
        
        Console.WriteLine("Hi, I'm " + name);
        Console.WriteLine("I'm " + age + " years old.");
        Console.WriteLine("Oh, and I'm an Alien.");
    }
}
*/

/*
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int result = Multiply(3, 13);

        Console.WriteLine("The resutl is: " + result);

        if (result % 2 == 0)
        {
          Console.WriteLine(result + " is an even number");
        }
        else
        {
          Console.WriteLine(result + " is an odd number");
        }

        Console.ReadKey();
    }

    static int Multiply (int num01, int num02)
    {
      int result = num01 * num02;
      return result;
    }
}
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int result = WordCount("I love programming it's awesome!");

      Console.WriteLine("there is " + result + " words in this sentence");

      Console.ReadKey();
    }

    static int WordCount(string sentence)
    {
      int words = sentence.Split(' ').Length;

      return words;
    }
}