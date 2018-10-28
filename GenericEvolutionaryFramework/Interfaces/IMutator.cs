namespace GenericEvolutionaryFramework
{
    interface IMutator
    {
        IPopulationMember Mutate(IPopulationMember member);
        void SetMutationCondition(IMutationCondition condition);
    }
}
