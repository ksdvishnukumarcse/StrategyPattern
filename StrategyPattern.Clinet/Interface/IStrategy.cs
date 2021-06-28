using StrategyPattern.Clinet.Models;
using System.Collections.Generic;

namespace StrategyPattern.Clinet.Interface
{
    public interface IStrategy
    {
        List<Candidate> GetSelectedCandiates(List<Candidate> candidates);
    }
}
