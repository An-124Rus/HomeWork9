internal class Program
{
    private static void Main(string[] args)
    {
        string userMessage;
        string wordForExit;
        string password = "exit";
        bool isWorking = true;

        Console.Write("Введите сообщение для повторения: ");
        userMessage = Console.ReadLine();

        while (isWorking)
        {
            if (isWorking = true)
            {
                Console.WriteLine(userMessage);
            }
            else
            {
                Console.Write($"Введите слово exit для выхода: ");
                wordForExit = Console.ReadLine();

                if (wordForExit == password)
                {
                    break;
                }
            }
        }
    }
}