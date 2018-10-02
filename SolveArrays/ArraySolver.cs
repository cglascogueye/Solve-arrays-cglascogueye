using System;
using System.Collections.Generic;
using System.Linq;

namespace SolveArrays
{
    public class ArraySolver
    {

        public int Sum(int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }


        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }


        

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum % 2 == 1 || sum % 2 == -1;
        }
    }
}



public static int PositiveSum(int[] numbers)
{
    int sum = 0;
    int x = 0;
    foreach (int number in numbers)
    {
        if (sum % 2 >= 0)
        {
            sum += x;
        }
        else
        {
            sum = 0;
        }
    }
}
    }


