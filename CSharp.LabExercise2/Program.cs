using System;

namespace CSharp.LabExercise2
{
    internal class Program
    {
        static void Number1()
        {
            int[] arr = new int[5];
            int arrCounter = 0;
            while (arrCounter < arr.Length)
            {
                Console.Write("\nEnter Number : ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n");
                if (inputNumber >= 10 && inputNumber <= 100)
                {   
                    if (Array.Exists(arr, element => element == inputNumber))
                    {
                        Console.WriteLine("{0} has already been entered", inputNumber);
                    }
                    else
                    {
                        arr[arrCounter] = inputNumber;
                        arrCounter++;

                        foreach (int i in arr)
                        {
                            if (i > 0)
                            {
                                Console.Write("{0}  ", i);
                            }
                        }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("number must be between 10 and 100");
                }                
            }
        }
        public class Lasagna
        {
            public int ExpectedMinutesInOven()
            {
                return 40;
            }

            public int RemainingMinutesInOven(int minutes)
            {
                return 40 - minutes;
            }

            public int PreparationTimeInMinutes(int layers)
            {
                return 2 * layers;
            }

            public int ElapsedTimeinMinutes(int layers, int time)
            {
                return (2 * layers) + time;
            }
        }
        static void Number2()
        {
            var lasagna = new Lasagna();
            Console.WriteLine("Expected Oven Time in Minutes: {0}", lasagna.ExpectedMinutesInOven());
            Console.WriteLine("Remaining Oven Time in Minutes: {0}", lasagna.RemainingMinutesInOven(30));
            Console.WriteLine("Layer preparation in Minutes: {0}", lasagna.PreparationTimeInMinutes(2));
            Console.WriteLine("Total elapsed time in Minutes: {0}", lasagna.ElapsedTimeinMinutes(3, 20));
        }
        static void Main(string[] args)
        {
            //Number1();
            //Number2();
        }
    }
}
