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

        #region Value type swapping functions
        public static void Swap(int x, int y)
        {
            int temp = y; y = x; x = temp;
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = y; y = x; x = temp;
        }
        #endregion
        #region Refernce type functions
        public static void ReferenceType(int[] arr)
        {
            if (arr == null)
                return;
            for (int a = 0; a < arr.Length; a++)
            {
                arr[a] = a + 2;
            }
        }
        public static void ReferenceType(ref int[] arr)
        {
            if (arr == null)
                return;
            arr = new int[] { 1, 5, 6, 20 };
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr?.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Functions
            //Print();
            //Console.WriteLine("<=========================================>");
            //PrintPattern("mm");
            //Console.WriteLine("<=========================================>");
            //PrintPattern("mm", 10); // Passing by order
            //Console.WriteLine("<=========================================>");
            //PrintPattern(length: 20);  //Passing by name
            #endregion
            #region Nullable
            //int? x = 0;
            //Nullable<int> y; //Equivalent to int?x
            //x = null; // not valid unless we say that x is nullable by adding ?

            //decimal a = 5;
            //decimal? b = null;
            ////b = a; // Allowed as b accepts values and nulls
            ////a = b; //Must be an unsafe casting to perform this operation
            ////To perform a secured code
            //if (b != null)
            //    a = (int)b;

            ////Additional approches
            //a = (b.HasValue) ? b.Value : a;
            //a = b ?? 25;
            //Console.WriteLine(a);
            #endregion
            #region Null Propagation Operator
            //int[]? nums = default;
            ////in this case the array is null and the loop will not be executed
            //for (int i = 0; i < nums?.Length; i++)
            //{

            //}
            //int x = nums?.Length ?? 0; //if array is null lenfth =0
            //int?[]? nums2 = { null, null, 5, null };
            //for (int a = 0; a < nums2?.Length; a++)
            //{
            //    Console.WriteLine(nums2[a]);
            //}
            //int x2 = nums2?.Length ?? 0;
            #endregion
            #region Value types
            //int a = 10, b = 50;
            //Swap(a, b);
            //Console.WriteLine($"a = {a}, b = {b}");
            //Swap(ref a, ref b);
            //Console.WriteLine($"a = {a}, b = {b}");
            #endregion
            #region Refernece types
            int[] myArr = { 50, 60, 70, 80, 90, 100 };
            Console.WriteLine(myArr.GetHashCode());
            ReferenceType(myArr);
            PrintArray(myArr);
            Console.WriteLine("Same Hashcodes");
            Console.WriteLine(myArr.GetHashCode());
            Console.WriteLine("<=====================================>");
            ReferenceType(ref myArr);
            PrintArray(myArr);
            Console.WriteLine("Different Hashcodes");
            Console.WriteLine(myArr.GetHashCode());
            Console.WriteLine("<=====================================>");
            #endregion
        }
    }
}