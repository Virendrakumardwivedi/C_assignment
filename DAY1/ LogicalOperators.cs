using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAY1
{
    public class  LogicalOperators
    {
        public static void Main(string[] args)
        {
             Console.WriteLine("Enter Number...!");
             String number = Console.ReadLine();
             int n = int.Parse(number);

             if(n%3==0 && n%5==0){
                Console.WriteLine("This is divisible by both 3 and 5");
             }
             else if(n%3==0 || n%5==0){
                Console.WriteLine("This is divisible by either 3 or 5.");
             }else{
                Console.WriteLine("this is not divisible with both number...!");
             }



           

        }
    }
}