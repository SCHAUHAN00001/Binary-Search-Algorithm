using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(Binary_S_Itrative(A,8,3));
            Console.WriteLine(Binary_S_Recursive(A, 3, 0, 9));
            Console.ReadLine();
        }
        public static int Binary_S_Itrative(int[] Array, int N, int Key)
        {
            int L = 0;
            int R = N - 1;
            while(L<= R)
            {
                int m = (L+R)/2;
                if (Array[m] == Key)
                {
                    return m;
                }
                else if(Key < Array[m])
                {
                    R = m - 1;

                }else if(Key > Array[m])
                {
                    L = m + 1;
                }

            }
            return -1;
        }
        public static int Binary_S_Recursive(int[] Array ,  int Key, int L, int R)
        {
            if (L > R)
            {
                return -1;
            }
            else
            {
                int m = (L+R) / 2;
                if (Key == Array[m])
                {
                    return m;
                }
                else if (Key < Array[m])
                {
                    return Binary_S_Recursive(Array,Key, L, m-1);
                }
                else if (Key > Array[m])
                {
                    return Binary_S_Recursive(Array, Key, m + 1, R);
                }
                


            }
            return -1;
            
            
        }
    }
}
