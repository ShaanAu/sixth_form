using System;

namespace Stringmanip
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Enter a word");
			string word = Console.ReadLine();
            int length = word.Length;
			char last = word[length - 1];
			char first = word[0];

			string reverse = "";
			for (int i = word.Length - 1; i >= 0; i--)
			{
				reverse+= word[i];
			}

			Console.WriteLine("Length of the word is " + length);
			Console.WriteLine("First Character is " + first);
			Console.WriteLine("Last Character is " + last);
            Console.WriteLine(reverse);

			int vowel = 0;
			int con = 0;

            for (int i = 0; i < length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    vowel = vowel + 1;
                }
                else
                {
                    con = con + 1;
                }
            }
                Console.WriteLine("Number of vowels are " + vowel);
                Console.WriteLine("Number of consonants are " + con);

            if (reverse == word)
            {
                Console.WriteLine("the word is a palindrome");
            }
            
		}
    }
}
