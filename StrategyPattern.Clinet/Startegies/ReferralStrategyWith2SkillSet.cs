using StrategyPattern.Clinet.Interface;
using StrategyPattern.Clinet.Models;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern.Clinet.Startegies
{
    public class ReferralStrategyWith2SkillSet : IStrategy
    {
        public List<Candidate> GetSelectedCandiates(List<Candidate> candidates)
        {
            return candidates.Where(c => c.IsReferral == true && c.NoofSkilSet >= 2).ToList();
        }
    }
}
