using System;

namespace _28._10._2021tap2
{
    class Program
    {
        static void Main(string[] args) 
        {
            string sentence = "Salam Aztu uni";
            Console.WriteLine(GetNum(sentence));
        }
        static int GetNum(string str)
        {
            int length, count = 0;
             
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            length = str.Length - 1;
            if (str[length] != '.' || str[length] != '?' || str[length] != '!')
            {
                return count + 1;
            }
            return count;
        }
    }
}
