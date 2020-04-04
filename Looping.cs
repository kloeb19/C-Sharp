using System;
using System.Collections.Generic;
namespace Looping
{
    class Looping
    {
        public class myNumber
        {
            public int IntNum { get; set; }
      
        }
        static void Main()
        {
            myNumber newMyNum;
            int userNum; 
            
            Console.Write("How many numbers will you provide? ");
            int iteration = Convert.ToInt32(Console.ReadLine());

            List<myNumber> NumberList = new List<myNumber>();

            for (int index = 0; index < iteration; index++)
            {
                Console.WriteLine("Enter integer {0}:", index + 1);
                userNum = Convert.ToInt32(Console.ReadLine());
                newMyNum = new myNumber();
                newMyNum.IntNum = userNum;
                NumberList.Add(newMyNum);
            }
            foreach (var number in NumberList)
            {
                int quotientSum = 0;
                int x;
                for (x = 1; x < 25; x++)
                {
                    if (number.IntNum % x == 0)
                    {
                        quotientSum += x;
                        Console.WriteLine(number.IntNum.ToString() + "is divisible by " + x.ToString() + "\n");
                    }
                       
                }
                Console.WriteLine("The sum of quotients for " + number.IntNum.ToString() + "is " + quotientSum.ToString() + "\n");
            }
           
            }


        }
    }
