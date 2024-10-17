using Adapter_Pattern;
internal class Program
{
    private static void Main(string[] args)
    {
        ComputerGame computerGame = new ComputerGame(name:"Euro Truck Simulator 3",pegiAgeRating:PegiAgeRating.P18,budgetInMillionsOfDollars:100,minimumGpuMemoryInMegabytes:8000,diskSpaceNeededInGB:300,ramNeededInGB:32,coresNeeded:8,coreSpeedInGhz:6.4);
        ComputerGameAdapter adapter = new ComputerGameAdapter(computerGame);
        Console.WriteLine(adapter.getTitle());
        Console.WriteLine(adapter.getPegiAllowedAge());
        Console.WriteLine(adapter.getRequirements().ToString());
        if (adapter.isTripleAGame())
        {
            Console.WriteLine("TripleA game");
        }
        else
        {
            Console.WriteLine("Not tripleA game");
        }
    }
}