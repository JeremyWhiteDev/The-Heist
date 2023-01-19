namespace The_Heist;

public class TeamMemberBuilder
{
    public Crew Crew = new Crew();

   
    public Crew Run()
    {
        Console.WriteLine("Plan Your Heist!");

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

         

            bool skillWasParsed = int.TryParse(Console.ReadLine(), out int parsedSkill);
            while (!skillWasParsed || parsedSkill > 100 || parsedSkill <= 0)
            {
                Console.Write("Please enter the team member's skill level (0-100): ");
                skillWasParsed = int.TryParse(Console.ReadLine(), out parsedSkill);

            }

            currentMember.SkillLevel = parsedSkill;


            Console.Write("Please enter the team member's courage level: ");

 
            bool courageWasParsed = double.TryParse(Console.ReadLine(), out double parsedCourage);
            while (!courageWasParsed || parsedCourage > 3.0 || parsedCourage < 0.0)
            {
                Console.Write("Please enter the team member's courage level (0-3.0): ");
                skillWasParsed = double.TryParse(Console.ReadLine(), out parsedCourage);

            }


            currentMember.CourageLevel = parsedCourage;

            Console.Clear();
            Crew.Members.Add(currentMember);


            Console.WriteLine($"{currentMember.Name} was added to the team");
            Console.WriteLine("Your team consists of: ");
            foreach (var member in Crew.Members)
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
        return Crew;
        
    }
}
