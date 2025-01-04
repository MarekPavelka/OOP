namespace OOP_Zadanie_1.Services
{
    public class ConsoleInputService
    {
        public string GetValidString(string consoleMsg)
        {
            Console.Write(consoleMsg);
            var consoleInput = Console.ReadLine();
            if (consoleInput == null)
            {
                return string.Empty;
            }

            return consoleInput.Trim();
        }

        public int GetValidInteger(string consoleMsg)
        {
            while (true)
            {
                Console.Write("Enter student number: ");
                var consoleInput = Console.ReadLine();

                if (int.TryParse(consoleInput, out int validInteger))
                {
                    return validInteger;
                }

                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
