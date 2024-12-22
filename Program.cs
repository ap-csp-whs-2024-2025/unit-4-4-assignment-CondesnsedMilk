namespace unit_4_4_assignment_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        NumberInput();
        ColourChooser();
        InputAdd();

    }
    static void ColourChooser()
    {
        bool isCorrect = false;
        int numAttempts = 0;

        Console.WriteLine("What's my favourite Colour?: ");
        string input = Console.ReadLine()!;

        while (isCorrect == false)
        {
            if(input == "Yellow" || input == "yellow")
            {
                Console.Write("Nice work friend! ");
                Console.WriteLine($"You did this in {numAttempts} attempts!");
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Wrong. You're a fool.");
                numAttempts++;
                Console.WriteLine("TELL me my favourite Colour.: ");
                input = Console.ReadLine()!;
            }


        }

    }

    static void InputAdd()
    {
        bool correctInput = false;
        int numTimes = 0;

        do
        {
            Console.WriteLine("How many times would you like to add?");
            numTimes = Convert.ToInt32(Console.ReadLine());

            if (numTimes < 1)
            {
                Console.WriteLine("Sorry! Wrong amount of times! Try again.");
            }
            else
            {
                correctInput = true;
            }
        }while(correctInput == false);
            
        int num = 0;
        int inputNum = 0;

        for(int i = 1; i < numTimes + 1; i++)
        {
            Console.WriteLine($"What's your number {i}?");
            inputNum = Convert.ToInt32(Console.ReadLine());
            num = num + inputNum;
            
        }

        Console.WriteLine($"Your final number is {num}!");


    }

    static void NumberInput()
    {
        bool done = false;

        while (done != true)
        {
            Console.WriteLine("Pick a random number from 1-100");
            float numPick = Convert.ToSingle(Console.ReadLine());

            if (numPick <= 100 && numPick >= 1)
            {
                Console.WriteLine("Thanks for your input! Onto the next challenge");
                done = true;
            }
            else
            {
                Console.WriteLine("Invalid. Please try again.");
            }
        }
    }
}
