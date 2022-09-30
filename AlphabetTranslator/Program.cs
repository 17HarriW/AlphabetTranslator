using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word to be pronounced phonetically (in french): ");
            string word = Console.ReadLine();

            FindLetter(word);

            Console.ReadLine();
        }

        private static void FindLetter(string word)
        {
            foreach(char letter in word)
            {
                string phonetic = MakePhonetic(letter);
                Console.Write($"{phonetic}-");
            }
        }

        private static string MakePhonetic(char letter)
        {
            int j = 0;
            List<string> pronounceList = new List<string>() { "ah", "bh", "kh", "dh", "eh", "ff", "gh", "h", "ee", "djuh", "kh", "l", "m", "nh", "oh", "ph", "kh", "rr", "ss", "t", "uh", "vh", "weh", "ks", "yuh", "zz", "ss", "ay", "ah", "eh", "ih", "owh", "oh", "ah", "eh", "ih", "oh", "uh", "ee", "ie", "yoo" };
            List<char> phoneticList = new List<char>() {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z', 'ç', 'é', 'â', 'ê', 'î', 'ô', 'û', 'à', 'è', 'ì', 'ò','ù', 'ë', 'ï', 'ü' };
            foreach (char i in phoneticList)
            {
                if (letter == i)
                {
                    return pronounceList[j];
                }
                j++;
            }
            return "N/A";
        }
    }
}
