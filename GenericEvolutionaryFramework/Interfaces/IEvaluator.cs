namespace GenericEvolutionaryFramework
{
    interface IEvaluator
    {
        F EvaluateFitness<F>(IPopulationMember member);
    }
}
