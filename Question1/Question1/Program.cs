using System;


namespace ConsoleApp1
{

    class Program
    {
        public static string Oddoreven(int num1)
        {

            if (num1 % 2 == 0)
            {
                return("Even");
            }
            else
            {
               return("Odd");
            }
        }

  public static int  Sumofno(int num)
        {
            int sum = 0;
            for (int i = 0; num > 0; i++)
            {
                int temp = num % 10;
                sum = temp + sum;
                num = num / 10;
            }
            return sum;
           
        }
        
        public static void Divbysum( int num1, int num2)
        {
            if(num1 % num2 == 0)
            {
                Console.WriteLine("{0} is divisible by {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by {1}",num1,num2);
            }
        }

        public static void rank(int num)
        {
            int highest = 0;
            int lowest = Convert.ToInt32(num % 10);
            while (num > 0)
            {
                int rem = Convert.ToInt32(num % 10);
                if (rem > highest)
                {
                    highest = rem;
                }
                if (rem < lowest)
                {
                    lowest = rem;
                }
                num = num / 10;
            }
            Console.WriteLine("The highest digit in the provided number is {0} " , highest);
            Console.WriteLine("The lowest digit in the given number is {0} ", lowest);
        }
        public static void Main( )
        {
            int num;
            Console.WriteLine("Enter the number to do the operation on(max 10 digits): ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(".......................................................\n");
            Console.WriteLine("* whether the given number is odd or even");
            string result= Oddoreven(num);
            Console.WriteLine(result);
            Console.WriteLine(".......................................................\n");
            Console.WriteLine("* • Find the sum of the digits of the number.");
            int sum = (Sumofno(num));
            Console.WriteLine("The sum of the numbers is {0} ", sum);
            Console.WriteLine(".......................................................\n");
            Console.WriteLine("* • Check whether the number is divisible by the sum of the digit.");
            Divbysum(num,sum);
            Console.WriteLine(".......................................................\n");
            Console.WriteLine("* • Find the highest and the lowest digit in the number.");
            rank(num);
            Console.WriteLine(".......................................................\n");
            Console.Read();
        }
    }
}
