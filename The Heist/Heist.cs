namespace The_Heist;

public class Heist
{
    //instantiate a crew class.
    private Crew? Crew { get; set; }

    //Instantiate a Bank class.
    private Bank? Bank { get; set; } = new Bank();
   
    public void Run()
    {
        Console.WriteLine("Plan Your Heist!");
        //crew class 
        CrewBuilder CrewMemberBuilder = new CrewBuilder();

        //TeamBuilder.Build returns a crew, which gets assigned to the Crew variable
       Crew = CrewMemberBuilder.Build();

        //Runs methods on the Crew instance.
        Crew.PrintMyCrew();
        Crew.PrintCrewScore();


        //initialiaze values for runtime
        int runtimes;
        bool runtimeParsed;

        //loop for collecting user input for runtimes and validate it.
        do
        {
            Console.WriteLine("Enter a whole number amount from 1-10 for the number of times to run the scenario");
            string runtimeInput = Console.ReadLine();
            runtimeParsed = int.TryParse(runtimeInput, out runtimes);
        } while (!runtimeParsed || runtimes <= 0 || runtimes > 10);

        // Initialize values for difficulty.
        int baseDifficulty;
        bool difficultyParsed;
        do
        {
            Console.WriteLine("Enter a whole number amount from 1-100 for the bank's difficulty level.");
            string difficultyInput = Console.ReadLine();
            difficultyParsed = int.TryParse(difficultyInput, out baseDifficulty);
        } while (!difficultyParsed || baseDifficulty <= 0 || baseDifficulty > 100);

        //Initialize values for running the sim.
        int CrewScore = Crew.CrewScore;
        Bank.Difficulty = baseDifficulty;
        int successfulRuns = 0;
        int failedRuns = 0;

        //Prepare User to run the sim
        Console.WriteLine($"The Bank's difficulty is {Bank.Difficulty} & Your Crew's Combined skill level is {CrewScore}");
        Console.WriteLine($"Press Enter to being the heist!");
        Console.ReadLine();
        
        //loop through runs, changing luck every time and conditionally incrementing success/failure.
        for (int i = 0; i < runtimes; i++)
        {
            int? currentDifficulty = Bank.Difficulty + Bank.Luck;

        if (CrewScore >= currentDifficulty) 
        {
                successfulRuns += 1;
        }
        else
        {
                failedRuns+= 1;
        }

        }

        //Notify user of success/failure rates.
        Console.WriteLine($"Your Crew successfully robbed the bank {successfulRuns} times and went to jail {failedRuns} times");
        //End of run.
        Console.ReadLine(); 








    }
}
