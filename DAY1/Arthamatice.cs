using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAY1
{
    public class Arthamatice
    {
       public static int add(int a, int b){
          return a+b;
       }
        public static int substract(int a, int b){
          return a-b;
       }
        public static int multiply(int a, int b){
          return a*b;
       }
        public static int devide(int a, int b){
          return a/b;
       }


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            String number1 = Console.ReadLine();
            int a = int.Parse(number1);
            Console.WriteLine("Enter second number:");
            String number2 = Console.ReadLine();
            int b = int.Parse(number2);

            int sum = add(a,b);
            Console.WriteLine(sum);
            int subtr = substract(a,b);
            Console.WriteLine(subtr);
            int mlt = multiply(a,b);
            Console.WriteLine(mlt);
            int dvd = devide(a,b);
            Console.WriteLine(dvd);


      

        }
    }
}