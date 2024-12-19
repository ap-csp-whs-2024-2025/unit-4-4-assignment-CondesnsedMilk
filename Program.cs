namespace unit_4_4_assignment_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;

        while (done != true)
        {
            Console.WriteLine("Pick a random number from 1-100");
            float numPick = Convert.ToSingle(Console.ReadLine());

            if (numPick < 100 && numPick > 1)
            {
                Console.WriteLine("Thanks for your input!");
                done = true;
            }
            else
            {
                Console.WriteLine("Invalid. Please try again.");
            }
        }

    }
}
