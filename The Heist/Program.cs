//Phase 1:
using The_Heist;



Roster roster = new Roster();

string name;

do
{
Console.WriteLine("Please enter your name.");
    name = Console.ReadLine();
    if (String.IsNullOrWhiteSpace(name))
     {
        continue;
    }
    TeamMember currentMember = new TeamMember();
    currentMember.Name = name;

    Console.WriteLine("Please enter your skill level.");

    currentMember.SkillLevel = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter your courage level.");

    currentMember.CourageLevel = double.Parse(Console.ReadLine());

    Console.Clear();
    roster.members.Add(currentMember);

    string welcome = @$"Name: {currentMember.Name}
Skill Level: {currentMember.SkillLevel}
Courage Level: {currentMember.CourageLevel}";
        Console.WriteLine(welcome);
}
while (!String.IsNullOrWhiteSpace(name));

Console.Clear();
foreach (var member in roster.members)
{
    Console.WriteLine($"Name: {member.Name}, skill level: {member.SkillLevel}");
   
}

Console.ReadLine();
//Phase 2:

//Create a way to store several team members. 

string whatever = null;

int length = whatever.Length;