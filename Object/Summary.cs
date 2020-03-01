using System;
namespace _2_Lab_Pairs
{
    class Sum
    {
        private static double res;
        public static double Summator(double a, double b){
            return res = a + b;
        }

        public static void Print(){
            Console.WriteLine(res);
        }
    
    }   
}