using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenght of rectangle: ");
            int lenght = ConvertNumberToInt(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            int width = ConvertNumberToInt(Console.ReadLine());
            Console.WriteLine($"Area of rectangle: {AreaOfRectangle(lenght, width)}");
            Console.Write("Type string: ");
            Console.WriteLine($"Number of spaces in string: {NumberOfSpaces(Console.ReadLine())}");
            Console.Write("Enter number: ");
            int number = ConvertNumberToInt(Console.ReadLine());
            Console.WriteLine($"Arithmetical sum of your number:{SumOfNumbers(number)}");
            int[] array = { 5, 8, 15, 19, 50, 8, 64, 14, 95, 6 };
            printArray(array);
            Console.WriteLine($"Maximum in array = {MaximumInArray(array)}");
            Console.WriteLine($"Grade of student is: {RandomNumber()} | {GradeOfStudent()}");
            Console.ReadLine();

        }
        static float AreaOfRectangle(float lenght, float width)
        {
            return lenght * width;
        }
        static int NumberOfSpaces(string str)
        {
            int count = 0;
            if(str != null)
            {
                for(int i = 0; i< str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static int SumOfNumbers(int number)
        {
            int sum = 0;
            for(int i = 0; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }
        static int MaximumInArray(int[] Array)
        {
            int max = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                }
            }
            return max;
        }
        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static int RandomNumber()
        {
            int maxRandNumber = 100;
            Random randomNumber = new Random();
            return randomNumber.Next(maxRandNumber);
        }
        static char GradeOfStudent()
        {
            int number = RandomNumber();
            char Grade = ' ';
            if (number > 91) { Grade = 'A'; }
            else if (number > 81 && number < 91) { Grade = 'B'; }
            else if (number > 71 && number < 81) { Grade = 'C'; }
            else if (number > 61 && number < 71) { Grade = 'D'; }
            else if (number > 51 && number < 61) { Grade = 'E'; }
            else Grade = 'F';
            return Grade;
        }
        static int ConvertNumberToInt(string toBeConvertedNumber)  
        {
            int convertInt;
            if (int.TryParse(toBeConvertedNumber, out convertInt) != false)
            {
                return convertInt;
            }
            else
            {
                Console.WriteLine($"{toBeConvertedNumber} is not a number");
                return 0;
            }
        }



    }
   
}
