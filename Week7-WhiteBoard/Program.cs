using System;
using System.Text;

namespace Week7_WhiteBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenBinary(10));
        }


        public static string GenBinary(int N)
        {
            StringBuilder str1 = new StringBuilder("");
            for (int i=1; i<=N; i++)
            {
                str1.Append(Con2Binary(i)).Append(" ");   
            }
            return str1.ToString().TrimEnd();
        }

        public static string Con2Binary(int K)
        {
            StringBuilder str = new StringBuilder("");
            while (K>0)
            {
                str.Append(K%2);
                K = K / 2;
            }
            string result =  str.ToString();
            char[] stringArray = result.ToCharArray();
            Array.Reverse(stringArray);
            string reverseBinary = new string(stringArray);

            return reverseBinary;
        }
    }
}
