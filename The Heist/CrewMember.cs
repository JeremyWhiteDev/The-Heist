namespace The_Heist;

public class CrewMember
{
    public string? Name { get; set; }
    public int SkillLevel { get; set; }
    public double CourageLevel { get; set; }

    public CrewMember(string? name, int skillLevel, double courageLevel)
    {
        Name = name;
        SkillLevel = skillLevel;
        CourageLevel = courageLevel;
    }
    public CrewMember()
    {
      
    }
    public override string ToString()
    {
        return $"Name: {Name}, skill level: {SkillLevel}, Courage Level: {CourageLevel}";

    }

    public CrewMember Create()
    {
  
        string name = GetNameFromUser();
        //option to quit program
        if (name == "quit" || String.IsNullOrWhiteSpace(name))
        {
            return null;
        }
        //get skill and courage
        int skillLevel = GetSkillFromUser();
        double courageLevel = GetCourageFromUser();

        Console.Clear();

        //add Team Member and notify user of team member that was just added as well as the current team.
        CrewMember currentMember = new CrewMember(name, skillLevel, courageLevel);
        return currentMember;
    }

    private string GetNameFromUser()
    {
        //start by collecting name and validating. 
        Console.Write("Please enter the team member's name: ");
        string name = Console.ReadLine();
        while (String.IsNullOrWhiteSpace(name) && name != "quit")
        {
            Console.Clear();
            Console.Write("Please enter the team member's name (or type 'quit'): ");
            name = Console.ReadLine();

        }
        return name;
    }

    private int GetSkillFromUser()
    {
        Console.Write("Please enter the team member's skill level: ");
        bool skillWasParsed = int.TryParse(Console.ReadLine(), out int parsedSkill);
        while (!skillWasParsed || parsedSkill > 100 || parsedSkill <= 0)
        {
            Console.Write("Please enter the team member's skill level (0-100): ");
            skillWasParsed = int.TryParse(Console.ReadLine(), out parsedSkill);

        }
        return parsedSkill;

    }
    private double GetCourageFromUser()
    {
        Console.Write("Please enter the team member's courage level: ");
        bool courageWasParsed = double.TryParse(Console.ReadLine(), out double parsedCourage);
        while (!courageWasParsed || parsedCourage > 3.0 || parsedCourage < 0.0)
        {
            Console.Write("Please enter the team member's courage level (0-3.0): ");
            courageWasParsed = double.TryParse(Console.ReadLine(), out parsedCourage);

        }
        return parsedCourage;
    }


}

