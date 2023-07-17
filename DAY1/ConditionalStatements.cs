using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAY1
{
    public class ConditionalStatements
    {

        public static int checkCondition(int n){
            return n;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number...!");
           // int number = Convert.ToInt32(Console.ReadLine());
             String number1 = Console.ReadLine();
            int number = int.Parse(number1);  
            if(number >0){
                Console.WriteLine("THis is positive number...!");
            }
            else if(number<0){
                Console.WriteLine("This is negative number...!");
            }
            else{
               Console.WriteLine("This is Zero ...");
            }
        }
    }
}