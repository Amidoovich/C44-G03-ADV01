using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV01
{
    
    internal static class Helper<T>
    {
        
        public static void Print(T X)
        {
            Console.WriteLine(X);
        }

        // Passing Parameter Value Type by Ref
        // Generic method
        public static void SWAP(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        //public static void SWAP(ref decimal a, ref decimal b)
        //{
        //    decimal temp = a;
        //    a = b;
        //    b = temp;
        //}
        //public static void SWAP(ref Point a, ref Point b)
        //{
        //    Point temp = a;
        //    a = b;
        //    b = temp;
        //}
    }
}
