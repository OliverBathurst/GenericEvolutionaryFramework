using System.Collections.Generic;

namespace GenericEvolutionaryFramework
{
    interface IPopulation
    {
        List<IPopulationMember> CreatePopulation();
        IPopulationMember CreateMember();
        List<IPopulationMember> GetPopulation();
        void Sort();
    }
}
