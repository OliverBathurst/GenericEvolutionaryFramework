namespace GenericEvolutionaryFramework
{
    interface IMutationCondition
    {
        bool IsMet();
        bool IsMet(IPopulationMember member);
    }
}
