using System.Text;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sentence = "        EverytHing i   neeD,    is a CuP   of        CoFFee    ";
            Console.WriteLine(FormatSentence(sentence));
        }
        public static string FormatSentence(string sentence)
        {
            string[] words = sentence.Trim().Split(' ');
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (!string.IsNullOrWhiteSpace(word))
                {
                    result.Append(char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ");
                }
            }

            return result.ToString().Trim();
        }
    }
    }

