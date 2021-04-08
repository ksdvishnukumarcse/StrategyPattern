using StrategyPattern.Clinet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Clinet.Interface
{
    public interface IStrategy
    {
        List<Candidate> GetSelectedCandiates(List<Candidate> candidates);
    }
}
