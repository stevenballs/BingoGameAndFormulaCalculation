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
                Console.WriteLine("Values Example > 3,4,8,13,18,19,23");
                Console.WriteLine("Input Values >");
                values = Console.ReadLine();
                input = Array.ConvertAll(values.Split(','), s => int.Parse(s));
                Boolean result = bingoGame(input);
                if (result)
                {
                    Console.WriteLine("You Bingo.");
                }
                else
                {
                    Console.WriteLine("You Lose.");
                }
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

            bool bingo = false;

            var row1Count = 0;
            var row2Count = 0;
            var row3Count = 0;
            var row4Count = 0;
            var row5Count = 0;
            int[] row1 = { 1, 2, 3, 4, 5 };
            int[] row2 = { 6, 7, 8, 9, 10 };
            int[] row3 = { 11, 12, 13, 14, 15 };
            int[] row4 = { 16, 17, 18, 19, 20 };
            int[] row5 = { 21, 22, 23, 24, 25 };

            var col1Count = 0;
            var col2Count = 0;
            var col3Count = 0;
            var col4Count = 0;
            var col5Count = 0;
            int[] col1 = { 1, 6, 11, 16, 21 };
            int[] col2 = { 2, 7, 12, 17, 22 };
            int[] col3 = { 3, 8, 13, 18, 23 };
            int[] col4 = { 4, 9, 14, 19, 24 };
            int[] col5 = { 5, 10, 15, 20, 25 };

            var x1Count = 0;
            var x2Count = 0;
            int[] x1 = { 1, 7, 13, 19, 25 };
            int[] x2 = { 5, 9, 13, 17, 21 };

            foreach (var bingoRow in input)
            {
                if (row1.Contains(bingoRow))
                {
                    row1Count++;
                    if (row1Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (row2.Contains(bingoRow))
                {
                    row2Count++;
                    if (row2Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (row3.Contains(bingoRow))
                {
                    row3Count++;
                    if (row3Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (row4.Contains(bingoRow))
                {
                    row4Count++;
                    if (row4Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (row5.Contains(bingoRow))
                {
                    row5Count++;
                    if (row5Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (col1.Contains(bingoRow))
                {
                    col1Count++;
                    if (col1Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (col2.Contains(bingoRow))
                {
                    col2Count++;
                    if (col2Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (col3.Contains(bingoRow))
                {
                    col3Count++;
                    if (col3Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (col4.Contains(bingoRow))
                {
                    col4Count++;
                    if (col4Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (col5.Contains(bingoRow))
                {
                    col5Count++;
                    if (col5Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (x1.Contains(bingoRow))
                {
                    x1Count++;
                    if (x1Count == 5)
                    {
                        bingo = true;
                    }
                }

                if (x2.Contains(bingoRow))
                {
                    x2Count++;
                    if (x2Count == 5)
                    {
                        bingo = true;
                    }
                }
            }

            return bingo;
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
