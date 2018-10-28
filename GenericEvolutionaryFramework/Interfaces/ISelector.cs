using System.Collections.Generic;

namespace GenericEvolutionaryFramework
{
    interface ISelector
    {
        IPopulationMember SelectMembersFromPopulation(List<IPopulationMember> population);
        List<IPopulationMember> SelectMembersFromPopulation(List<IPopulationMember> population, int number);
        void Sort(List<IPopulationMember> members);
        void Sort();
    }
}
