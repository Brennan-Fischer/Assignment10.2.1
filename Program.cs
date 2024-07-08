namespace Assignment10._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, -5, -7, 5, 6, -4, 3, 2, 1, };

            var query =
                from num in array
                where num>=0
                select num;
            foreach ( var item in query )
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
