namespace The_Heist;

public class Bank
{
    public int? Difficulty { get; set; }

    public int? Luck { get => GetRandomNumber();}

    private int GetRandomNumber()
    {
        Random rnd = new Random();

        return rnd.Next(-10, 10);
    }
}
