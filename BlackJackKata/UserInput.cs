using System;
namespace BlackJackKata
{
    public class UserInput
    {
        public UserInput()
        {
        }

     

        public string UserPrompt()
        {
            Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0)");
            return Console.ReadLine();
        }

        //where this method is called, you'll need to add an if statment and based on the result either hit or stay
        public int ValidateNumber(string incomingNumber)
        {
            if (incomingNumber == "1")
            {
                return 1;
            }
            else if (incomingNumber == "0")
            {
                return 0;
            }
            throw new Exception("Your input was invalid. Please just type 1 to hit, 0 to stay");
        }
    }
}
