internal class Program
{
    private static void Main(string[] args)
    {
        string userMessage;
        string answerForExit;
        string password = "exit";
        bool inUse = true;

        Console.Write("Введите сообщение для повторения: ");
        userMessage = Console.ReadLine();        

        while (inUse)
        {
            Console.Write("Введите пароль для выхода: ");
            answerForExit = Console.ReadLine();

            if (password == answerForExit)
            {
                inUse = false;
                Console.WriteLine("Вы успешно вышли");
            }
            else
            {
                Console.WriteLine("Попробуйте снова");
            }
        }
    }
}