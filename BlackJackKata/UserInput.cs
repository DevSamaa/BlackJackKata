using System;
namespace BlackJackKata
{
    public class UserInput
    {
        public UserInput()
        {
        }

        public string UserSelection()
        {
            while (true)
            {
                    var savedUserInput = UserPrompt();

                    var isValid = ValidateInput(savedUserInput);

                    if (isValid)
                    {
                    return savedUserInput;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid selection. Please try again.");
                    }
            }

        }



        public string UserPrompt()
        {
            Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0)");
            return Console.ReadLine();
        }



        //where this method is called, you'll need to add an if statment and based on the result either hit or stay
        public bool ValidateInput(string incomingString)
        {
            if (incomingString == "1" || incomingString == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
