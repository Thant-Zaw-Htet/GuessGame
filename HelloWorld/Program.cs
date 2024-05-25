using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Random random = new Random();
            int randomNum = random.Next(1,100);
            Console.WriteLine(randomNum);
            int count = 0;

            while (true)
            {
                Console.WriteLine("Enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                count++;
                if (num == randomNum)
                {
                    if (count == 1)
                    {
                        Console.WriteLine("You are genius"); break;
                    }
                    else if (count <= 5)
                    {
                        Console.WriteLine("Better next time..");break;
                    }
                    else if (count <= 10)
                    {
                        Console.WriteLine("You are so stupid");break;
                    }
                    else
                    {
                        Console.WriteLine("Emotional Damage!!");break;
                    }
                }else if (num > randomNum)
                {
                    Console.WriteLine("Your guess number is greater than random number");
                }
                else
                {
                    Console.WriteLine("Your guess number is less than random number");
                }
            }
        }
    }
}
