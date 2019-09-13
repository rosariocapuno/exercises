using System;

/// <summary>
/// 
/// Write a program that prints the numbers from 1 to 100--
/// with each number on its own line-
/// But for multiples of three print "Fun"-
/// instead of the number and for the multiples of five print "Bar"-
/// For numbers which are multiples of both three and five print "FunBar"--
/// </summary>
/// 

///
///What if instead of just 3 and 5, I want to put in 2 numbers of my choice as well as the type of outputs
// 3, "Fun", 5, "Bar"
// 3, "Cat", 5, "Dog"
// 5, "Fun", 7, "bar"
///

///
/// Prevent using modulus sign
///
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbersDecimal("4,Fun|7,Bar");
            //PrintNumbersNoModulus("3,Fun|5,Bar");
            //Console.WriteLine("---------------------------------");
            //PrintNumbers("3,Cat|5,Dog");
            //Console.WriteLine("---------------------------------");
            //PrintNumbers("5,Fun|7,bar");
            //Console.WriteLine("---------------------------------");

            Console.ReadKey();
        }

        private static bool IsMultiple(int current, int multipleOf)
        {
            if (current < multipleOf)
            {
                return false;
            }
            else if (current / multipleOf == 0)
            {
                return true;
            }
            else
            {
                int remainder = current / multipleOf;
                if (remainder * multipleOf == current)
                {
                    return true;
                }
            }

            return false;
        }

        private static void PrintNumbersDecimal(string combination)
        {
            var splitCombination = combination.Split('|');
            var firstKey = splitCombination[0].Split(',');
            var secondKey = splitCombination[1].Split(',');
            var firstValue = firstKey[1];
            var secondValue = secondKey[1];
            decimal firstNumber = Convert.ToDecimal(firstKey[0]);
            decimal secondNumber = Convert.ToDecimal(secondKey[0]);

            for (decimal i = 1; i < 101; i++)
            {
                bool isMultipleFirstNumber = (i / firstNumber).ToString().Contains('.') ? (i / firstNumber).ToString().Split('.')[1] == "0" : (i / firstNumber) * firstNumber == i;
                bool isMultipleSecondNumber = (i / secondNumber).ToString().Contains('.') ? (i / secondNumber).ToString().Split('.')[1] == "0" : (i / secondNumber) * secondNumber == i;

                if (isMultipleFirstNumber && isMultipleSecondNumber)
                {
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (isMultipleFirstNumber)
                {
                    Console.WriteLine(firstValue);
                }
                else if (isMultipleSecondNumber)
                {
                    Console.WriteLine(secondValue);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void PrintNumbersNoModulus(string combination)
        {
            var splitCombination = combination.Split('|');
            var firstKey = splitCombination[0].Split(',');
            var secondKey = splitCombination[1].Split(',');
            var firstValue = firstKey[1];
            var secondValue = secondKey[1];
            int firstNumber = Convert.ToInt32(firstKey[0]);
            int secondNumber = Convert.ToInt32(secondKey[0]);

            for (int i = 1; i < 101; i++)
            {

                bool multipleFirstNum = IsMultiple(i, firstNumber);
                bool multipleSecondNum = IsMultiple(i, secondNumber);

                if (multipleFirstNum && multipleSecondNum)
                {
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (multipleFirstNum)
                {
                    Console.WriteLine(firstValue);
                }
                else if (multipleSecondNum)
                {
                    Console.WriteLine(secondValue);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        private static void PrintNumbers(string combination)
        {
            var splitCombination = combination.Split('|');
            var firstKey = splitCombination[0].Split(',');
            var secondKey = splitCombination[1].Split(',');
            var firstValue = firstKey[1];
            var secondValue = secondKey[1];
            int firstNumber = Convert.ToInt32(firstKey[0]);
            int secondNumber = Convert.ToInt32(secondKey[0]);

            for (int i = 1; i < 101; i++)
            {
                if (i % firstNumber == 0 && i % secondNumber == 0)
                {
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (i % firstNumber == 0)
                {
                    Console.WriteLine(firstValue);
                }
                else if (i % secondNumber == 0)
                {
                    Console.WriteLine(secondValue);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
