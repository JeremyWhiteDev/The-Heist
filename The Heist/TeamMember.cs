namespace The_Heist;

public class TeamMember
{
    public string? Name { get; set; }
    public int SkillLevel { get; set; }
    public double CourageLevel { get; set;}
   
    public override string ToString()
    {
        return $"Name: {Name}, skill level: {SkillLevel}, Courage Level: {CourageLevel}";
    }
}
