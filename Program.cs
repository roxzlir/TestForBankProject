using System.Runtime.Intrinsics.X86;

namespace TestForBankProject
{
    internal class Program
    {
        static void Main(string[] args)

          
        {
            User user1 = new User(1234,1234);
            //User user2 = new User(3333, 123);
            //Admin admin = new Admin();
              
            RunApp(user1.SecurityNumber, user1.Password);
            Console.WriteLine();
            //RunApp(admin.Username, admin.Password);
            //Console.WriteLine();
            //RunApp(user2.SecurityNumber, user2.Password);

        }
        public static void RunApp(int usernameInput, int passwordInput)
        {
            Console.WriteLine("Välkommen till inloggningen!");
            
            if (TryLogin(usernameInput,passwordInput) == "adminPassed")
            {
                Console.WriteLine("Inloggning lyckades för admin!");
                // Här lägger vi in admins vägar till åtgärder.
            }
            else if (TryLogin(usernameInput, passwordInput) == "customerPassed")
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
        static string TryLogin(int securityNumber, int userPassword)
        {
            int maxAttempts = 3;

            int adminUsername = 0000; int adminPassword = 9999;

            

            for (int attempt = 0; attempt <= maxAttempts; attempt++)
            {
                Console.Write($"Ange användarnamn: ");
                int username = GetInputNumber();

                Console.Write($"Ange lösenord: ");
                int password = GetInputNumber();

                if (username == adminUsername && password == adminPassword)
                {
                    return "adminPassed";
                    break;


                }
                if (username == securityNumber && password == userPassword)
                {
                    return "customerPassed";
                    break;
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