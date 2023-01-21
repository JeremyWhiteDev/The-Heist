namespace The_Heist;

public class Crew
{
    public List<CrewMember> Members { get; set; } = new List<CrewMember>();

    public int CrewScore { get => GetCrewScore();}
public void PrintMyCrew()
    {
        Console.WriteLine("Your team consists of: ");
        foreach (var member in Members)
        {
            Console.WriteLine(member);
        }
    }
    private int GetCrewScore()
    {
        int score = 0;
     foreach (var member in Members) 
    {
            score += member.SkillLevel;
    }
     return score;
    }
    public void PrintCrewScore()
    {
        Console.WriteLine(GetCrewScore());  
    }

    
}
