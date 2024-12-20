namespace unit_4_4_assignment_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        NumberInput();
        ColourChooser();
        Add();

    }

    static void Add()
    {
        bool correctInput = false;
        int numTimes = 0;

        while (correctInput == false)
        {
            Console.WriteLine("How many times do you want to add?");
            numTimes = Convert.ToInt32(Console.ReadLine());

            if (numTimes < 1)
            {
                Console.WriteLine("Sorry! that's an invalid input. Try again!");
            }
            else
            {
                correctInput = true;
            }
        }
            
        for(int i = 1; i > numTimes;)
        {
            Console.WriteLine("5");
        }


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
