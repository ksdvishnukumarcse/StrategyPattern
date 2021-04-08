using StrategyPattern.Clinet.Interface;
using StrategyPattern.Clinet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Clinet.Startegies
{
    public class ThreeYearsExperienceStrategy : IStrategy
    {
        public List<Candidate> GetSelectedCandiates(List<Candidate> candidates)
        {
            return candidates.Where(c => c.Experience >= 3).ToList();
        }
    }
}
