using System.Drawing;

int trueCode = 13579;
int numGuesses = 0;
string y = "y";
string n = "n";
string yesNo;

Console.WriteLine("You stealthily make your way to the door. The only thing that stands between you and your" +
    "objective now is the keypad. It's a five digit number... but can you remember the code!?");

do
{
    string userInput = Console.ReadLine();
    bool goodCode = int.TryParse(userInput, out int userCode);

    if (goodCode == false)
    {
        Console.WriteLine("The keypad consists of only numbers.");
        Console.WriteLine();
    }
    else if (goodCode)
        numGuesses++;
    {
        if (userCode == trueCode)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Well done. Enjoy your reward!!!");
            Console.ResetColor();
            numGuesses = numGuesses + 6;
        }
        else if (numGuesses == 5)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*YOU'VE SET OFF THE ALARM!!!*");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Sorry to tell you this but you're on your own now. As per our arrangement" +
                ", 'we' cannot be involved in this affair!");
        }
        else
        {

            if (numGuesses == 1)
            {
                Console.WriteLine("Wrong code. You only have a limited number of tries. THINK!");
                Console.WriteLine();
            }
            else if (numGuesses == 2)
            {
                Console.WriteLine("Do you need a memory boost (y/n)? ");
                yesNo = Console.ReadLine();
                if (yesNo == y)
                {
                    string clue1 = "Try not to REPEAT";
                    string wordToColor = "REPEAT";

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(clue1.Replace(wordToColor, ""));
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(wordToColor);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" yourself!");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else if (yesNo == n)
                {
                    Console.WriteLine("I hope you know what you're doing...");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try to make some sense.");
                    Console.WriteLine();
                }
            }
            else if (numGuesses == 3)
            {
                Console.WriteLine("I could offer another hint! (y/n)? ");
                yesNo = Console.ReadLine();
                if (yesNo == y)
                {
                    string clue2 = "Something seems ODD";
                    string wordToColor = "ODD";

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(clue2.Replace(wordToColor, ""));
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(wordToColor);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("!");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else if (yesNo == n)
                {
                    Console.WriteLine("Boy, you're a stubborn one!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No one has time for your gibberish.");
                    Console.WriteLine();
                }

            }
            else if (numGuesses == 4)
            {
                Console.WriteLine("You're running out of chances! DO YOU WANT HELP OR NOT!!! (y/n)? ");
                yesNo = Console.ReadLine();
                if (yesNo == y)
                {
                    string clue3 = "You need to go back to the BEGINNING";
                    string wordToColor = "BEGINNING";

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(clue3.Replace(wordToColor, ""));
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(wordToColor);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("!");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else if (yesNo == n)
                {
                    Console.WriteLine("I'll leave you to your fate...");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("I think you're going mad.");
                    Console.WriteLine();
                }

            }
        }
    }
} while (numGuesses < 5);