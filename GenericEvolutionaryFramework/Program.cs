namespace GenericEvolutionaryFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            new EvolutionaryAlgorithm(
                new Population(),
                new Evaluator(),
                new Crossover(),
                new Selector(),
                new Mutator()).Run();
        }
    }
}
