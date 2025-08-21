namespace C44_G03_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Helper<int>.SWAP(ref a, ref b);
            Console.WriteLine("After Swapping");
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");

            decimal M = 10.10M, L = 20.20M;
            Console.WriteLine($"M = {M}");
            Console.WriteLine($"L = {L}");
            Helper<decimal>.SWAP(ref M, ref L);
            Console.WriteLine("After Swapping");
            Console.WriteLine($"M = {M}");
            Console.WriteLine($"L = {L}");

            Point point01 = new Point(10, 20);
            Point point02 = new Point(100, 200);
            Console.WriteLine($"Point 01 = {point01} ");
            Console.WriteLine($"Point 02 = {point02} ");
            Helper<Point>.SWAP(ref point01, ref point02);
            Console.WriteLine("After Swapping");
            Console.WriteLine($"Point 01 = {point01} ");
            Console.WriteLine($"Point 02 = {point02} ");


        }
    }
}
