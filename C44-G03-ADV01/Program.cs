using System.Collections;

namespace C44_G03_ADV01
{
    internal class Program
    {
        

        public static void MyReverse(ArrayList arr)
        {
            
            if (arr is null)
            {
                Console.WriteLine("the Array List Is Null");
                return;
            }
            
            int Length = arr.Count;

            for (int i = 0; i < Length / 2; i++)
            {
                object temp = arr[i];
                arr[i] = arr[Length - i - 1];
                arr[Length - i - 1] = temp;
            }
        }

        public static List<int> PrintEvenInNumbers(List<int> numbers)
        {
            if (numbers is null)
            {
                Console.WriteLine("the List Is Null");
                return new List<int>();
            }
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                    
                }
            }
            return evenNumbers;
        }

        static void Main(string[] args)
        {
            #region Q1

            //Range<int> IntRange = new Range<int>(10, 5);
            //Console.WriteLine($"6 is in Range => {IntRange.IsInRange(6)}");
            //Console.WriteLine($"11 is in Range => {IntRange.IsInRange(11)}");
            //Console.WriteLine($"the Range is {IntRange.length()}");

            //Console.WriteLine();

            //Range<double> DoubleRange = new Range<double>(10.3, 5.4);
            //Console.WriteLine($"6.5 is in Range => {DoubleRange.IsInRange(6.5)}");
            //Console.WriteLine($"11.5 is in Range => {DoubleRange.IsInRange(11.5)}");
            //Console.WriteLine($"the Range is {DoubleRange.length()}");



            #endregion

            #region Q2
            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 5.5 ,"Ahmed"};

            //foreach (object i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            //MyReverse(arrayList);
            //Console.WriteLine("After Reverse");

            //foreach (object i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q3

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //List<int> EvenNumbers = PrintEvenInNumbers(Numbers);

            //foreach (int i in EvenNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q4

            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(3);

            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(3);


            //for (int i = 0; i < fixedSizeList.Capacity; i++)
            //{
            //    Console.WriteLine(fixedSizeList.Get(i));
            //}

            #endregion
        }
    }
}
