namespace GenericEvolutionaryFramework
{
    interface IEvolutionaryAlgorithm
    {
        void Run();
        IPopulationMember GetBest();
    }
}
