namespace laundrytask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to laundry");
            Console.WriteLine("Enter the number of small rugs:");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of large rugs:");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the price of small rug is $25");
            Console.WriteLine("the price of large rug is $35");
            int ts = s * 25;
            int tl = l * 35;
            Console.WriteLine($"total price of small carpet:{ts} ");
            Console.WriteLine($"total price of large carpet:{tl} ");
            int tp = ts + tl;
            Console.WriteLine($"total price:{tp}");
            Console.WriteLine("the tax is 0.6%");
            double tt = tp * 0.06;
            Console.WriteLine($"total tax:{tt}");
            Console.WriteLine($"total price with tax:{tp+tt}");
            Console.WriteLine("This estimate is valid for 30 days");

        }


        
    }
}
