namespace Task3;
internal class Eagle : Bird, IFlyingBird
{
    public override string Gender { get; set; }

    public void Fly()
    {
        Console.WriteLine("Fly");
    }

    public override void Walk()
    {
        Console.WriteLine("Fly");
    }
}
