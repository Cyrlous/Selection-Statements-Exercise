namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNumber = r.Next(1, 1000);

            int userGuess = 0;
            bool wrongNumber = true;
            
            //Primary loop.  Allows the user to continue to guess numbers until the correct number
            //is found
            while (wrongNumber)
            {
                Console.WriteLine("Please enter a number between 1 and 999: ");
                
                //Rilters user input to verify that it is a number
                while (!int.TryParse(Console.ReadLine(), out userGuess))
                {
                    Console.WriteLine("Invalid input.  Please enter a number between 1 and 999:");
                }
                
                //Utilizes if-else if statements to determine whether user has guessed the number
                //correctly and outputs appropriate message
                if (userGuess == favNumber)
                {
                    Console.WriteLine("Congratulations!  You guessed the number!");
                    wrongNumber = false;
                }
                else if (userGuess > favNumber)
                {
                    Console.WriteLine("Your guess is too high, please try again.");
                }
                else if (userGuess < favNumber)
                {
                    Console.WriteLine("Your guess is too low, please try again.");
                }
            }
        }
    }
}
