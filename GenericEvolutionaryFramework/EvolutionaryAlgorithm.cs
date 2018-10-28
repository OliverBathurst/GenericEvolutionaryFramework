namespace GenericEvolutionaryFramework
{
    class EvolutionaryAlgorithm : IEvolutionaryAlgorithm
    {
        private IPopulation _population;
        private IEvaluator _evaluator;
        private ICrossover _crossover;
        private ISelector _selector;
        private IMutator _mutator;
               
        public EvolutionaryAlgorithm(
            IPopulation population,
            IEvaluator evaluator,
            ICrossover crossover,
            ISelector selector,
            IMutator mutator
            )
        {
            _population = population;
            _evaluator = evaluator;
            _crossover = crossover;
            _selector = selector;
            _mutator = mutator;
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public IPopulationMember GetBest()
        {
            throw new System.NotImplementedException();
        }
    }
}
