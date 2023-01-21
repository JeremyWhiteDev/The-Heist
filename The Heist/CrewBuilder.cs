namespace The_Heist;

public class CrewBuilder
{
    //private Crew instance.
    private Crew Crew = new Crew();

    public Crew Build()
    {
        //initiate a blank name to have access to inside do and while condition


        bool building = true;
        //loop for entering and validating CrewMemberBuilder
        do
        {
            //method for getting and validating user
            CrewMember newMember = new CrewMember();
            newMember = newMember.Create();
            if (newMember == null)
            {
                building= false;
                continue;
            }
            Crew.Members.Add(newMember);
            Console.WriteLine($"{newMember.Name} was added to the team");
            DisplayTeam();
            
            Console.Write("do you have more members to add? (y/n)");
            string addMoreMembers = Console.ReadLine();
            if (addMoreMembers == "n")
            { building = false; }

        }
        while (building);

        return Crew;
        
    }
    
    private void DisplayTeam()
    {
        Console.WriteLine("Your team consists of: ");
        foreach (var member in Crew.Members)
        {
            Console.WriteLine(member.ToString());
        }
    }
}
