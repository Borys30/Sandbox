using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.SortingAlgorithms
{
    public class Sorting
    { 
        public void BubbleSort()
        {
            Console.WriteLine("Enter differrent numbers:");
            var numbersInString = Console.ReadLine(); 
            if (numbersInString == null) return;
            Console.WriteLine("You entered those numbers:{0}.", numbersInString); 
            var splittedNumbersInString = numbersInString.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var inputArray = new List<int>();
            splittedNumbersInString.ForEach(n => inputArray.Add(int.Parse(n)));
            for (int i = 0; i < inputArray.Count; i++)
            {
                for (int j = i + 1; j < inputArray.Count; j++)
                {
                    if (inputArray[i] > inputArray[j])
                    {
                        var temp = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp; 
                    }
                }
            } 
            Console.WriteLine("Your sorted array is:"); 
            inputArray.ForEach(n => Console.Write("{0} ", n));
            Console.ReadLine(); 
        }
    }
}
