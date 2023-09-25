namespace Task3;
internal abstract class Bird : IBird
{
    public abstract string Gender { get; set; }

    public void Eat()
    {
        Console.WriteLine("Eat");
    }

    public abstract void Walk();
}
