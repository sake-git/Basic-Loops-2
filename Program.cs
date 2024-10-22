namespace Basic_Loops_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool isdoorLocked = guessThePasscode(); //Call the function to guess passcode
                      
            if (isdoorLocked) // Door is still locked i.e. user exhausted the number of attempts. Display the error message
            {
                Console.WriteLine("Too many incorrect attempts");
            }
            else // User guessed the correct passcode. Access granted to Paradise.
            {
                Console.WriteLine("Welcome to the Paradise!");
            }

            Console.ReadKey();
        }


        public static bool guessThePasscode() // Function to guess passcode
        {
            const int passcode = 13579;  // Const passcode
            bool isdoorLocked = true;
            int count = 0;

            do // Continue untill door is unlocked
            {
                count++;
                Console.WriteLine("Enter a key code");
                int userPwd = Convert.ToInt32(Console.ReadLine());
                if (userPwd == passcode)
                {
                    isdoorLocked = false;    // Correct passcode, unlock the door
                    break;
                }
                else if (count >= 5) // All attempts exhausted, break from loop
                {
                    break;
                }

            } while (isdoorLocked);

            return isdoorLocked;
        }
    }
}
