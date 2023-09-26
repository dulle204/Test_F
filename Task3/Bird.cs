namespace Task3;
public abstract class Bird : IBird
{
    public abstract string Gender { get; set; }

    public void Eat()
    {
        Console.WriteLine("Eat");
    }

    public abstract void Walk();
}
