using System;
using System.Collections.Generic;
using System.Linq;

namespace HW7
{
    class Program
    {
        //    static void Main(string[] args)
        //    {
        //        var nums = UserIntegerList();
        //        if (nums.Count <= 1)
        //        {
        //            Console.WriteLine("Not enough numbers.");
        //        } else if (nums.Count == 2)
        //        {
        //            Console.WriteLine("GCD: " + Gcd(nums[0], nums[1]));
        //            Console.WriteLine("LCM: " + Lcm(nums[0], nums[1]));
        //            Console.WriteLine("Min: " + Min(nums));
        //            Console.WriteLine("Max: " + Max(nums));
        //        } else
        //        {
        //            Console.WriteLine("GCD: " + Gcd(nums));
        //            Console.WriteLine("LCM: " + Lcm(nums));
        //            Console.WriteLine("Min: " + Min(nums));
        //            Console.WriteLine("Max: " + Max(nums));
        //        }

        //    }

        //    // Prompt the user until a valid integer is provided and return it.
        //    static void PromptForNum(string msg, out int num)
        //    {
        //        while (true)
        //        {
        //            Console.Write(msg);
        //            if (int.TryParse(Console.ReadLine(), out num))
        //            {
        //                return;
        //            }
        //            Console.WriteLine("Invalid input!");
        //        }
        //    }

        //    static List<int> UserIntegerList()
        //    {
        //        int input;
        //        var nums = new List<int> { };
        //        PromptForNum("Enter the first number: ", out input);
        //        nums.Add(input);

        //        while (input != 0)
        //        {
        //            PromptForNum("Enter the next number (0 if no more): ", out input);
        //            if (input != 0)
        //            {
        //                nums.Add(input);
        //            }
        //        }

        //        return nums;
        //    }

        //    // Find the GCD of 2 integers num1 & num2, using Euclid Algorithm.
        //    static int Gcd(int num1, int num2)
        //    {
        //        int num3 = num1 % num2;
        //        while (num3 != 0)
        //        {
        //            num1 = num2;
        //            num2 = num3;
        //            num3 = num1 % num2;
        //        }
        //        return num2;
        //    }

        //    static int Gcd(List<int> nums)
        //    {
        //        int num1, num2, num3;
        //        num1 = nums[0];
        //        num2 = nums[1];
        //        num3 = num1 % num2;
        //        for (int i = 1; i <= nums.Count - 1; i++)
        //        {
        //            while (num3 != 0)
        //            {
        //                num1 = num2;
        //                num2 = num3;
        //                num3 = num1 % num2;
        //            }
        //        }
        //        return num2;
        //    }



        //    // Find the LCM of 2 integers num1 & num2, using the formula LCM * GCD = num1 * num2.
        //    static int Lcm(int num1, int num2)
        //    {
        //        return num1 * num2 / Gcd(num1, num2);
        //    }

        //    static int Lcm(List<int> nums)
        //    {
        //        int LCM = Lcm(nums[0], nums[1]);
        //        for (int i = 2; i <= nums.Count - 1; i++)
        //        {
        //            LCM = Lcm(LCM, nums[i]);
        //        }
        //        return LCM;
        //    }

        //    static int Min(List<int> nums)
        //    {
        //        int min = nums[0];
        //        foreach (int num in nums)
        //        {
        //            if (num < min)
        //            {
        //                min = num;
        //            }
        //        }
        //        return min;
        //    }
        //    static int Max(List<int> nums)
        //    {
        //        int max = nums[0];
        //        foreach (int num in nums)
        //        {
        //            if (num > max)
        //            {
        //                max = num;
        //            }
        //        }
        //        return max;
        //    }

        //----------------------------------------------------------------

        static void Main(string[] args)
        {
            Console.Write("Enter a mathematical expression: ");
            string expression = Console.ReadLine();
            var tokens = TokensFromString(expression);
            OutputTokens(tokens);
        }
        static List<string> TokensFromString(string expression)
        {
            var tokens = new List<string> { };
            string currentToken = "";
            for (int i = 0; i <= expression.Length - 1; i++)
            {
                if (new List<int> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' }.Contains(expression[i]))
                {
                    
                    currentToken += expression[i];
                    if (i == expression.Length - 1)
                    {
                        tokens.Add(currentToken);
                        currentToken = "";
                    }
                }
                else if (expression[i] != ' ')
                {
                    tokens.Add(currentToken);
                    tokens.Add(expression[i].ToString());
                    currentToken = "";
                }
            }
            return tokens;
        }
        static void OutputTokens(List<string> tokens)
        {
            foreach (string token in tokens)
            {
                Console.WriteLine(token);
            }
        }

    }

}
