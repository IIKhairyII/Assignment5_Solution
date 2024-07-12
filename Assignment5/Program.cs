using System.Text;

namespace Assignment5
{
    internal class Program
    {
        #region Value type swapping functions
        public static void SwapByValue(int x, int y)
        {
            int temp = y; y = x; x = temp;
        }
        public static void SwapByRef(ref int x, ref int y)
        {
            int temp = y; y = x; x = temp;
        }
        #endregion
        #region Refernce type swapping functions
        public static void ReferenceTypeByValue(Employee emp)
        {
            emp.Salary = 25000;
            emp.Name = "Karim";
            emp = new()
            {
                Id = 2,
                Name = "Ahmed",
                Salary = 8000,
                HiringDate = DateTime.Now,
            };
        }
        public static void ReferenceTypeByRef(ref Employee emp)
        {
            emp.Salary = 25000;
            emp.Name = "Karim";
            emp = new()
            {
                Id = 2,
                Name = "Ahmed",
                Salary = 8000,
                HiringDate = DateTime.Now,
            };
        }
        #endregion

        #region Problem 3 function
        public static int Summation(int num1, int num2, int num3, int num4)
        {
            int sum = 0;
            Console.WriteLine("Choose which group of numbers to add first two or second two numbers (f/s)");
            string choice = Console.ReadLine();
            if (choice.ToLower().Equals("f"))
                sum = num1 + num2 + (num3 - num4);
            else
                sum = num1 - num2 + num3 + num4;

            return sum;
        }
        #endregion
        #region Problem 4 function
        public static int SumDigits(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
                sum += int.Parse(input[i].ToString());
            return sum;
        }
        #endregion
        #region Problem 5 function
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;
            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) return false;
            }
            return true;
        }
        #endregion
        #region Problem 6 function
        public static Tuple<int, int> MinMaxArray(int[] arr)
        {
            int min = arr[0], max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            return Tuple.Create(max, min);
        }
        #endregion
        #region Problem 7 function
        public static long Factorial(long num)
        {
            if (num == 0 || num == 1)
                return 1;
            long result = 1;
            while (num > 0)
            {
                if (result < 0)
                {
                    Console.WriteLine("Factorial calculation resulted in overflow for the given number and the result will not be correct");
                    break;
                }

                result *= num;
                num--;
            }
            return result;
        }
        #endregion
        #region Problem 8 function
        public static StringBuilder ChangeChar(StringBuilder input, int index, char newChar)
        {
            if (index > input.Length)
                return new("Invalid Index");
            input[index] = newChar;
            return input;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Problem 1
            ///*Using value type parametes:
            // *- If we passed value type var by value then we will not change the variable itself
            // *Instead, we will create a copy from this var to use it in the function then this copy will be deleted
            // *- If we passed value type by reference then any change or operation done in this var the variable will 
            // *be affected by changes as we passed a pointer to the variable by passing var's address*/
            //int num1 = 10;
            //int num2 = 50;
            //SwapByValue(num1, num2);
            //Console.WriteLine("Swapping by value");
            //Console.WriteLine($"num1 = {num1}, num2 = {num2}");
            //Console.WriteLine("<=======================================>");
            //SwapByRef(ref num1, ref num2);
            //Console.WriteLine("Swapping by reference");
            //Console.WriteLine($"num1 = {num1}, num2 = {num2}");
            #endregion
            #region Problem 2
            ///*using reference types
            // * -If we passed by value then we pass a copy from the var but it points to the value of the copied
            // * variable in the heap so now I have two instances points to the same address so any 
            // * change in the copy will affect the value of the copied value
            // * - If we pass by ref it has the same effect as by value but in addition if we created a new 
            // * instance of the var then it will neglect the old object and poinits to new one and the old
            // * object will be unreachable object
            // */
            //Employee emp = new()
            //{
            //    Id = 1,
            //    Name = "Khairy",
            //    Salary = 5000,
            //    HiringDate = DateTime.Now,
            //};
            //Console.WriteLine($"ID = {emp.Id} ,Name = {emp.Name}, Salary = {emp.Salary}");
            //Console.WriteLine(emp.GetHashCode());
            //Console.WriteLine("<============================================>");
            //ReferenceTypeByValue(emp);
            //Console.WriteLine("Changed Data but hashcode didn't change");
            //Console.WriteLine($"ID = {emp.Id} ,Name = {emp.Name}, Salary = {emp.Salary}");
            //Console.WriteLine(emp.GetHashCode());
            //Console.WriteLine("<============================================>");
            //ReferenceTypeByRef(ref emp);
            //Console.WriteLine("Changed Data and different hashcode");
            //Console.WriteLine($"ID = {emp.Id} ,Name = {emp.Name}, Salary = {emp.Salary}");
            //Console.WriteLine(emp.GetHashCode());
            #endregion
            #region Problem 3
            //Console.WriteLine("Enter four numbers");
            //int count = 0;
            //int[] nums = new int[4];
            //while (count < 4)
            //{
            //    nums[count] = int.Parse(Console.ReadLine());
            //    count++;
            //}
            //int sum = Summation(nums[0], nums[1], nums[2], nums[3]);
            //Console.WriteLine($"Result = {sum}");
            #endregion
            #region Problem 4
            //Console.Write("Enter any number of your choice: ");
            //int result = SumDigits(Console.ReadLine());
            //Console.WriteLine($"Result = {result}");
            #endregion
            #region Problem 5
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //bool isPrime = IsPrime(num);
            //Console.WriteLine($"{num} is {(isPrime ? "a" : "not a")} prime number");
            #endregion
            #region Problem 6
            //int[] arr = new int[] { 20, -50, 100, 950, 600, 710 };
            //var maxAndMin = MinMaxArray(arr);
            //Console.WriteLine($"Max = {maxAndMin.Item1}, Min = {maxAndMin.Item2}");
            #endregion
            #region Problem 7
            //Console.Write("Enter number to calaulate factorial:  ");
            //long number = long.Parse(Console.ReadLine());
            //long fac = Factorial(number);
            //Console.WriteLine($"{number}! = {fac}");
            #endregion
            #region Problem 8
            //StringBuilder input = new("My Very Lons STRING");
            //Console.WriteLine($"The old string is {input}, The new one is {ChangeChar(input, 11, 'g')}");
            #endregion
        }
    }
}