using System;
using System.Linq;
using System.Collections.Generic;


public class Kata
{
    public static int PositiveSum(int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                sum += numbers[i];
            }
            else if (numbers[i] < 0)
            {
                numbers[i] = 0;
                sum += numbers[i];
            }
        }
        return 0;

    }

    /*   Test Results: 
    Tests
    ExampleTest
    ExampleTest([1, 2, 3, 4, 5])

   Test Failed
     Expected: 15
     But was:  0
   Completed in 66.8900ms
    ExampleTest([1, -2, 3, 4, 5])

   Test Failed
     Expected: 13
     But was:  0
   Completed in 0.6630ms
    ExampleTest([-1, 2, 3, 4, -5])

   Test Failed
     Expected: 9
     But was:  0
   Completed in 0.5280ms
    ExampleTest([])
    ExampleTest([-1, -2, -3, -4, -5])
   Completed in 76.1320ms
   Completed in 81.9970ms*/

    public class Swapper
    {
        public object[] Arguments { get; private set; }

        public Swapper(object[] args)
        {
            Arguments = args;

        }
        public void SwapValues()
        {
            object[] args = new[] { Arguments[0], Arguments[1] };

            object temp = args[0];
            args[0] = args[1];
        }
        args[1] = temp;
}
    /* using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
    {
        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            { 
                if ((listOfNumbers[i]) % 2 == 0)
                {
                    listOfNumbers.RemoveAt(i);
                }
            }
            return listOfNumbers;
        }
    }*/ ====FirstTest
/*
Test Failed
  Expected string length 7 but was 9. Strings differ at index 0.
  Expected: "1,3,5,7", ignoring case
  But was:  "2,2,3,5,7"
  -----------^
Completed in 72.4750ms
 SecondTest

Test Failed
  Expected string length 3 but was 5. Strings differ at index 0.
  Expected: "1,3", ignoring case
  But was:  "2,2,3"
  -----------^
Completed in 1.3710ms
Completed in 87.7260ms*/

random colors:
        Random randomGen = new Random();
    KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
    KnownColor randomColorName = names[randomGen.Next(names.Length)];
    Color randomColor = Color.FromKnownColor(randomColorName);
    /*
        using System;

    public class Person
    {
        // Constructor that takes no arguments:
        public Person()
        {
            Name = "unknown";
        }

        // Constructor that takes one argument:
        public Person(string name)
        {
            Name = name;
        }

        // Auto-implemented readonly property:
        public string Name { get; }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return Name;
        }
    }
    class TestPerson
    {
        static void Main()
        {
            // Call the constructor that has no parameters.
            var person1 = new Person();
            Console.WriteLine(person1.Name);

            // Call the constructor that has one parameter.
            var person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);
            // Get the string representation of the person2 instance.
            Console.WriteLine(person2);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

    }
    // Output:
    // unknown
    // Sarah Jones
    // Sarah Jones


       /* public class Kata
    {
      public static int SaleHotDogs(int n)
      {c
      }
    }*/
   /* WELL OF IDEAS
    * public class Kata
    {
        public static string Well(string[] x)
        {
            x = "good";

            return x <= 2 ? "Publish" : x > 2 ? "I smell a series" : "Fail";
        }
    }
    sean haughey github completed codewar challenges

    Select takes an action .Select (n => n*2).ToList();
    Where conditional