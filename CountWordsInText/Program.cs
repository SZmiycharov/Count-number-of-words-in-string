using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordsInText
{
    class Program
    {
        static bool IsAllUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsUpper(input[i]))
                    return false;
            }

            return true;
        }
        static bool IsAllLower(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLower(input[i]))
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int UpperCaseWords = 0;
            int LowerCaseWords = 0;
            int allWords = 0;
            string currentWord;

            string str =
     "Добре дошли на вашия първи изпит по програмиране! Можете ли да измислите и напишете решение на тази задача? УСПЕХ!";
            StringBuilder str1 = new StringBuilder();
            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    str1.Append(c);
                }
                else
                {
                    if (!String.IsNullOrEmpty(str1.ToString()))
                    {
                        currentWord = str1.ToString();
                        {

                            allWords++;
                            if (IsAllUpper(currentWord)) UpperCaseWords++;
                            else if (IsAllLower(currentWord)) LowerCaseWords++;
                        }
                        str1.Clear();
                    }
                }
            }

            Console.Write("Upper case words: {0} ; Lower case words: {1} ; All words: {2}",
                UpperCaseWords, LowerCaseWords, allWords);
            Console.ReadKey();

        }
    }
}
