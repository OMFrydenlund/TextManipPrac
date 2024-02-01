namespace TextManipulation
{
    internal class Program
    {
        static void Main()
        {
            Console.Clear();
            bool reverse = false;
            bool replace = false;

            ChoicePrompt(ref reverse, ref replace);

            while (reverse)
            {
                ReverseMethod();
            }

            while (replace)
            {
                ReplaceMethod();
            }
        }

        static void ChoicePrompt(ref bool rev, ref bool rep)
        {
            Console.Clear();
            Console.WriteLine("Choose an action:\n1. Invert text\n2. Replace E's with A's ");
            string c = Console.ReadLine().ToUpper();
            if (c != "1" && c != "2")
            {
                Console.WriteLine("Get out.");
                return;
            }

            if (c == "1")
            {
                rev = true;
            }
            else if (c == "2")
            {
                rep = true;
            }
        }

        static void ReplaceMethod()
        {
            Console.Clear();
            Console.WriteLine("Write a word or sentence...");
            string s = Console.ReadLine();
            int n = s.Length;
            Console.Write("\nYou wrote " + s + ", all the E's will be replaced with an A. Here's your brand new sentence/string: ");
            for (int i = 0; i < n; i++)
            {
                if (char.ToLower(s[i]) == 'e')
                {
                    Console.Write("a");
                }
                else
                {
                    Console.Write(s[i]);
                }
            }
            MainMenuPrompt();
        }

        static void ReverseMethod()
        {
            Console.Clear();
            Console.WriteLine("Write a word or sentence to reverse...");
            string s = Console.ReadLine();
            int n = s.Length;
            Console.Write("\nYou wrote " + s + ", here is the word/sentence reversed: ");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            MainMenuPrompt();
        }

        private static void MainMenuPrompt()
        {
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Main();
        }
    }
}
