using System;

namespace StringReversal_CodeAssesment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string you would like to reverse? ");
            String inputStr = Console.ReadLine();
           
            Console.WriteLine("\nInput string: " + inputStr);
           

            Console.WriteLine("Output string: " + ReverseString(inputStr).ToString());
        }


        public static string ReverseString(string inputStr)
        {

            char[] charArray = inputStr.ToCharArray();

            int end = charArray.Length - 1, start = 0;

            while (start < end)
            {
                if (!char.IsLetter(charArray[start]))
                    start++;
                else if (!char.IsLetter(charArray[end]))
                    end--;

                else
                {
                    char tempChar = charArray[start];
                    charArray[start] = charArray[end];
                    charArray[end] = tempChar;
                    start++;
                    end--;
                }
            }
            return new string(charArray);
        }
    }
}
