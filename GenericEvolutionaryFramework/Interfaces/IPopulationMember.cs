namespace GenericEvolutionaryFramework
{
    interface IPopulationMember
    {
        T[] Genome<T>();
        F Fitness<F>();
    }
}
