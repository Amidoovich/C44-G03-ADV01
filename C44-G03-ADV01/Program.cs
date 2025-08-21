namespace C44_G03_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SWAP
            //int a = 10, b = 20;
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            //Helper<int>.SWAP(ref a, ref b);
            //Console.WriteLine("After Swapping");
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            //decimal M = 10.10M, L = 20.20M;
            //Console.WriteLine($"M = {M}");
            //Console.WriteLine($"L = {L}");
            //Helper<decimal>.SWAP(ref M, ref L);
            //Console.WriteLine("After Swapping");
            //Console.WriteLine($"M = {M}");
            //Console.WriteLine($"L = {L}");

            //Point point01 = new Point(10, 20);
            //Point point02 = new Point(100, 200);
            //Console.WriteLine($"Point 01 = {point01} ");
            //Console.WriteLine($"Point 02 = {point02} ");
            //Helper<Point>.SWAP(ref point01, ref point02);
            //Console.WriteLine("After Swapping");
            //Console.WriteLine($"Point 01 = {point01} ");
            //Console.WriteLine($"Point 02 = {point02} "); 
            #endregion
            #region Linear Search
            //int[] numbers = { 9, 5, 7, 5, 6, 8, 3, 1, 2 };
            //int Result = Helper<>.LinearSearch(numbers, 4);
            //Console.WriteLine(Result);

            //Point[] points = 
            //{
            //    new Point(1, 2),
            //    new Point(10, 20),
            //    new Point(100, 200),
            //    new Point(1000, 2000)
            //};

            //Point point = new Point(10,20);

            //Console.WriteLine(points[0] == points[2]);

            //Helper<Point>.LinearSearch(points, point);

            //Employee E01 = new Employee(10, "Mona", 9000);
            //Employee E02 = new Employee(20, "Amr", 4000);

            //if(E01.Equals(E02))
            //    Console.WriteLine("Equals");
            //else
            //    Console.WriteLine("Not Equals");

            Employee[] employees =
            {
                new Employee(10, "Amr",4000),
                new Employee(20, "May",9000),
                new Employee(30, "Mona",3000),
                new Employee(40, "Omar",2000),
                new Employee(50, "Ahmed",10000)
            };
            Employee employee = new Employee(30, "Mona", 3000);
            int Result = Helper<Employee>.LinearSearch(employees, employee);

            Console.WriteLine(Result);
            #endregion



        }
    }
}
