namespace TestForBankProject
{
    internal class Program
    {
        static void Main(string[] args)
        {


            RunApp();

        }
        public static void RunApp()
        {
            Console.WriteLine("Välkommen till inloggningen!");
            string LoginOK = "adminPassed";
            if (TryLogin() == "adminPassed")
            {
                Console.WriteLine("Inloggning lyckades för admin!");
                // Här lägger vi in admins vägar till åtgärder.
            }
            else if (TryLogin() == "customerPassed")
            {
                Console.WriteLine("Inloggningen lyckades för customer");
                //Här kan vi lägga in customers alla val sen
            }
            else
            {
                Console.WriteLine("Du har använt dina 3 inloggnings försök, programet avslutas.");
            }
        }
        public static int GetInputNumber()
        {
            int userInput;
            while (true)
            {
                
                string inputNumber = Console.ReadLine();
                
                if (int.TryParse(inputNumber, out userInput))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Du gjorde en felaktig inmatning!");
                }
                
            }
            return userInput;
        }
        static string TryLogin()
        {
            int maxAttempts = 3;
            string adminUsername = "admin"; string adminPassword = "admin123";
            string customerUsername = "customer"; string customerPassword = "customer123";

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write($"Ange användarnamn: ");
                string username = Console.ReadLine();

                Console.Write($"Ange lösenord: ");
                string password = Console.ReadLine();

                if (username == adminUsername && password == adminPassword)
                {
                    return "adminPassed";


                }
                else if (username == customerUsername && password == customerPassword)
                {
                    return "customerPassed";
                }
                else
                {
                    Console.WriteLine($"Inloggning misslyckades, antingen fel användarnamn eller fel lösenord. Försök {attempt}/{maxAttempts}.\n");
                }
            }

            return "LoginFailed";
        }
    }
    
}