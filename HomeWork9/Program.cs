internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfAttempt = 0;        
        string password = "exit";
        bool inUse = true;
        
        while (inUse)
        {
            Console.WriteLine("Вас зациклили!!!");
            numberOfAttempt++;
            Console.Write($"{numberOfAttempt} Введите пароль для выхода: ");
            string answerForExit = Console.ReadLine();

            if (password == answerForExit)
            {
                inUse = false;
                Console.WriteLine("Вы успешно вышли. Поздравляем!");
            }
            else
            {
                Console.WriteLine("Попробуйте снова");
            }
        }
    }
}