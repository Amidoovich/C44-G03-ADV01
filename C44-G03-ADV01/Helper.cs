using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV01
{
    
    internal static class Helper<T> where T : IEquatable<T>
    {
        
        
        public static int LinearSearch(T[] arr,T value)
        {
            // && => false => short-circuit evaluation
            // & => false => Long-circuit evaluation 
            //if (arr is not null && arr.Length > 0 && value is not null)
            if (arr?.Length > 0 && value is not null)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    //if (arr[i] == value)
                    //if (arr[i]?.Equals(value) ?? false)
                    if (value.Equals(arr[i]))
                        return i;
                }
            }
            return -1;
        }
        public static int LinearSearch(T[] arr,T value, IEqualityComparer<T> comparer)
        {
            // && => false => short-circuit evaluation
            // & => false => Long-circuit evaluation 
            //if (arr is not null && arr.Length > 0 && value is not null)
            if (arr?.Length > 0 && value is not null)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    if (comparer.Equals(value, arr[i]))
                        return i;
                }
            }
            return -1;
        }
        
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
