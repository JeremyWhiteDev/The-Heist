//Phase 1:
using The_Heist;



Roster roster = new Roster();

string name;

do
{
Console.Write("Please enter the team member's name: ");
    name = Console.ReadLine();
    while (String.IsNullOrWhiteSpace(name) && name != "quit")
     {
        Console.Clear();
        Console.Write("Please enter the team member's name (or type 'quit': ");
        name = Console.ReadLine();
       
    }
    if (name == "quit")
    {
        break;
    }
    TeamMember currentMember = new TeamMember();
    currentMember.Name = name;

    Console.Write("Please enter the team member's skill level: ");

    int parsedSkill;

    bool skillWasParsed = int.TryParse(Console.ReadLine(), out parsedSkill);
   while ( !skillWasParsed || parsedSkill > 100 || parsedSkill <0)
    {
        Console.Write("Please enter the team member's skill level (0-100): ");
        skillWasParsed = int.TryParse(Console.ReadLine(), out parsedSkill);

    }

    currentMember.SkillLevel = parsedSkill;


    Console.Write("Please enter the team member's courage level: ");

    double parsedCourage;
    bool courageWasParsed = double.TryParse(Console.ReadLine(), out parsedCourage);
    while (!courageWasParsed || parsedCourage > 3 || parsedCourage < 0)
    {
        Console.Write("Please enter the team member's courage level (0-3.0): ");
        skillWasParsed = double.TryParse(Console.ReadLine(), out parsedCourage);

    }


    currentMember.CourageLevel = parsedCourage;

    Console.Clear();
    roster.members.Add(currentMember);

   
        Console.WriteLine($"{currentMember.Name} was added to the team");
    Console.WriteLine("Your team consists of: ");
    foreach (var member in roster.members)
    {
        Console.WriteLine(member.ToString());
    }
    Console.Write("do you have more members to add? (y/n)");
    string addMoreMembers = Console.ReadLine();
    if (addMoreMembers == "n")
    {
        break;
    }

}
while (!String.IsNullOrWhiteSpace(name));

Console.Clear();
Console.WriteLine("Your team consists of: ");
foreach (var member in roster.members)
{
    Console.WriteLine(member.ToString());
}

Console.ReadLine();
//Phase 2:

//Create a way to store several team members.

