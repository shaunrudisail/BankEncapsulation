namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();

            bool continueLoop = true;
            do
            {
                Console.WriteLine(
                    "Hello! Would you like to deposit money or view your balance? Press D for deposit, B to view your balance, or E to exit:");
                var userInput = Console.ReadLine();

                if (userInput == "D")
                {
                    bool continueLoop2 = true;
                    do
                    {
                        Console.WriteLine("How much would you like to deposit? Press E to exit.");
                        var userInputD = Console.ReadLine();

                        if (double.TryParse(userInputD, out double deposit) && deposit > 0)
                        {
                            Console.WriteLine("Thank you for your deposit. You deposited:");
                            Console.WriteLine(bankAccount.Deposit(deposit));
                            continueLoop2 = false;
                        }
                        else if (userInputD == "E")
                        {
                            continueLoop2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid. Please try again.");
                            continueLoop = true;
                            continueLoop2 = true;
                        }
                    } while (continueLoop2);
                }
                else if (userInput == "B")
                {
                    Console.WriteLine("Here is your balance:");
                    Console.WriteLine(bankAccount.GetBalance());
                }
                else if (userInput == "E")
                {
                    Console.WriteLine("Goodbye!");
                    continueLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid. Please try again.");
                    continueLoop = true;
                }
            } while (continueLoop);
        }
    }
}