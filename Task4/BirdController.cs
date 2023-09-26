using Task3;

namespace Task4;
// I have choosen method injection to solve Task 4
// My idea with interfaces was to force developer to not develop method he dont need (Interface segregation principle)
// And developer cant pass wrong object(bird)
public class BirdController
{
    public void Feed(IBird bird)
    {
        bird.Eat();
    }

    public void ReleaseFromCliff(IFlyingBird bird)
    {
        bird.Fly();
    }

    public void RunFrom(IRunningBird bird)
    {
        bird.Run();
    }

    public void Walk(IBird bird)
    {
        bird.Walk();
    }
}
