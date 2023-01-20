namespace The_Heist;

public class Heist
{
    
    public Crew? Crew { get; set; }

    public Bank? Bank { get; set; } = new Bank();
   
    public void Run()
    {
        TeamMemberBuilder TeamMemberBuilder = new TeamMemberBuilder();


       Crew = TeamMemberBuilder.Run();


        Crew.PrintMyCrew();
        Crew.PrintCrewScore();

        Bank.Difficulty = 100 + Bank.Luck;
        int CrewScore = Crew.CrewScore;

        Console.WriteLine($"The Bank's difficulty is {Bank.Difficulty} & Your Crew's Combined skill level is {CrewScore}");
        Console.WriteLine($"Press Enter to being the heist!");
        Console.ReadLine();
        if (CrewScore >= Bank.Difficulty) 
        {
            Console.WriteLine("Success!");
     
        }
        else
        {
            Console.WriteLine("Failure");
        }
        Console.ReadLine(); 






    }
}
