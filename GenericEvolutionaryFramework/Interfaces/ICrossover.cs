namespace GenericEvolutionaryFramework
{
    interface ICrossover
    {
        C CrossoverMembers<C>(IPopulationMember member, IPopulationMember member2);
        C CrossoverMembers<C>(params IPopulationMember[] members);
    }
}
