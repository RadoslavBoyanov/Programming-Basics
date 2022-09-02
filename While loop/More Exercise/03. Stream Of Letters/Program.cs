using System;

namespace _03._Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int readText = 0;
            string word = string.Empty;
            string emty = string.Empty;
            string text;
            while ((text = Console.ReadLine()) != "End")
            {
                readText++;

               
                if (text == "n" || text == "o" || text == "c")
                {
                    if (readText % 1 == 0)
                    {
                        continue;  
                    }
                }
                
                if (text == "n" || text == "o" || text == "c")
                {
                    emty = " "; 
                }
                word += text + emty;
            }
            Console.WriteLine(word);
        }
    }
}
