using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,flag=0;
            num = Convert.ToInt16(Console.ReadLine());
            for (int i = 2; i <= num/2; i++)
            {
               
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag==1)
                {
                    Console.WriteLine("Given no is not a prime no");
                }
                else if(flag==0)
                {
                    Console.WriteLine("given no is a prime no");
                }

            }
        }
    }
