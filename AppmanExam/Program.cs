using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppmanExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            string values;
            Console.WriteLine("You select below choice.");
            Console.WriteLine("1 is BingoGame Program");
            Console.WriteLine("2 is Formula Calculation Program");
            Console.WriteLine("You write 1 or 2 enter on keyboard.");
            type = Console.ReadLine();
  

            if (type == "1")
            {
                int[] input = new int[] { };
                Console.WriteLine("Values Example > 3, 4, 8, 13, 18, 19, 23");
                Console.WriteLine("Input Values >");
                values = Console.ReadLine();
                input = Array.ConvertAll(values.Split(','), s => int.Parse(s));
                Boolean result = bingoGame(input);

                Console.WriteLine("Result: " + result);
                Console.ReadKey();
            }
            else if (type == "2")
            {
                string input = "";
                Console.WriteLine("Values Example > '(22*2) + 50' ");
                Console.WriteLine("Input Values >");
                values = Console.ReadLine();
                input = values;
                double result = formulaCalculation(input);

                Console.WriteLine("Result: "+ result);
                Console.ReadKey();
            }

        }


        static Boolean bingoGame(int[] input)
        {
            int[,] bingoBroad = new int[,] {
                                        { 1 ,  2 ,  3 ,  4 ,  5 },
                                        { 6 ,  7 ,  8 ,  9 ,  10 } ,
                                        { 11 , 12,  13 , 14 , 15 } ,
                                        { 16 , 17 , 18 , 19 , 20 } ,
                                        { 21 , 22 , 23 , 24 , 25 }};

            return true;
        }

        static double formulaCalculation(string input)
        {
            double result = 0;
            String pattern = @"(\d+)([-+*/])(\d+)";
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    int value1 = Int32.Parse(m.Groups[1].Value);
                    int value2 = Int32.Parse(m.Groups[3].Value);
                    switch (m.Groups[2].Value)
                    {
                        case "+":
                            result = value1 + value2;
                            break;
                        case "-":
                            result = value1 - value2;
                            break;
                        case "*":
                            result = value1 * value2;
                            break;
                        case "/":
                            result = value1 / value2;
                            break;
                    }
                }
           
            return result;
        }
    }
}
