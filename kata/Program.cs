using System;

namespace kata
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "{}[]()";
            var charArr = str.ToCharArray();
            //Console.WriteLine(String.Format("{0} change to int {1}", charArr[0], (int)charArr[0]));
            //Console.WriteLine(String.Format("{0} change to int {1}", charArr[1], (int)charArr[1]));
            //Console.WriteLine(String.Format("{0} change to int {1}", charArr[2], (int)charArr[2]));
            //Console.WriteLine(String.Format("{0} change to int {1}", charArr[3], (int)charArr[3]));
            //Console.WriteLine(String.Format("{0} change to int {1}", charArr[4], (int)charArr[4]));
            //Console.WriteLine(String.Format("{0} change to int {1}", charArr[5], (int)charArr[5]));
            Console.WriteLine(new ValidBraces().IsValidBraces("()"));
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
