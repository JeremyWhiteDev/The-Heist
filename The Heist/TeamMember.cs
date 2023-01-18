using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
