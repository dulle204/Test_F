namespace Task3;
internal class Ostrich : Bird, IRunningBird
{
    public override string Gender { get; set; }

    public void Run()
    {
        Console.WriteLine("Run");
    }

    public override void Walk()
    {
        Console.WriteLine("Run");
    }
}
