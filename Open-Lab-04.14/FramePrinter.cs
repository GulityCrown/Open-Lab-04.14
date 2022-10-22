using System;
using System.Linq;



namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int longest = 0;
            foreach (string str in strings)
            {
                if (str.Length > longest)
                    longest = str.Length;
            }
            char[] A = new char[longest + 4];
            char a = '*';
            for(int i = 0; i < A.Length; i++)
            {
                A[i] += a;
            }
            Console.WriteLine(A);
            for (int i = 0; i < strings.Length; i++)
            {

                if (strings[i].Length == A.Length - 4)
                {
                    Console.WriteLine("* " + strings[i] + " *");
                }
                else if (strings[i].Length != A.Length - 4)
                {
                    Console.WriteLine("* "+ strings[i]+PocetMedzier(A.Length - strings[i].Length - 4) + " *");
                }

            }
                Console.WriteLine(A);
        }
        public string PocetMedzier(int i)
        {
            string medzeri = "";
            char c = ' ';

            for(int j = 0; j< i; j++)
            {
                medzeri += c; 
            }
            return medzeri;
            
            
        }

    }
}
