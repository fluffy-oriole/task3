namespace task3
{
    public class Logic
    {
        public static string IsCharsInWord(string firstWord, string secondWord)
        {
            List<char> alredyUsedChars = new List<char>();
            string answer = "";
            for (int i = 0; i < firstWord.Length; i++)
            {
                char ch = firstWord[i];
                bool isCharAlredyUsed = false;
                for (int k = 0; k < alredyUsedChars.Count; k++)
                {
                    if (alredyUsedChars[k] == ch)
                    {
                        isCharAlredyUsed = true;
                        break;
                    }
                }

                if (!isCharAlredyUsed)
                {
                    bool isCharPresentInWord = false;
                    alredyUsedChars.Add(ch);
                    for (int j = 0; j < secondWord.Length; j++)
                    {
                        if (ch == secondWord[j])
                        {
                            isCharPresentInWord = true;
                            answer += "да ";
                            break;
                        }
                    }
                    if (!isCharPresentInWord)
                    {
                        answer += "нет ";
                    }
                }
            }
            if (answer != "")
            {
                return answer.Remove(answer.Length - 1);
            }
            else
            {
                return answer;
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое слово: ");
            string firstWord = Console.ReadLine();
            Console.Write("Введите второе слово: ");
            string secondWord = Console.ReadLine();
            Console.WriteLine(Logic.IsCharsInWord(firstWord, secondWord));

        }
    }
}