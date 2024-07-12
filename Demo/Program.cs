namespace Demo
{
    internal class Program
    {
        #region Functions
        public static void Print()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("**");
        }
        public static void PrintPattern(string pattern = "*", int length = 10)
        {
            for (int i = 0; i < length; i++)
                Console.WriteLine(pattern);
        }
        #endregion
        static void Main(string[] args)
        {
            #region Functions
            Print();
            Console.WriteLine("<=========================================>");
            PrintPattern("mm");
            Console.WriteLine("<=========================================>");
            PrintPattern("mm", 10); // Passing by order
            Console.WriteLine("<=========================================>");
            PrintPattern(length: 20);  //Passing by name
            #endregion
            #region Nullable
            int? x = 0;
            Nullable<int> y; //Equivalent to int?x
            x = null; // not valid unless we say that x is nullable by adding ?

            decimal a = 5;
            decimal? b = null;
            //b = a; // Allowed as b accepts values and nulls
            //a = b; //Must be an unsafe casting to perform this operation
            //To perform a secured code
            if (b != null)
                a = (int)b;

            //Additional approches
            a = (b.HasValue) ? b.Value : a;
            a = b ?? 25;
            Console.WriteLine(a);
            #endregion
        }
    }
}