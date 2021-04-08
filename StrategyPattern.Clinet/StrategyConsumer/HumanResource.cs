using StrategyPattern.Clinet.Interface;
using StrategyPattern.Clinet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Client.StrategyConsumer
{
    public class HumanResource
    {
        List<Candidate> candiates;
        private IStrategy _strategy;

        public HumanResource()
        {
            candiates = new List<Candidate>();
        }

        public void AddCandidate (List<Candidate> candidates)
        {
            candiates.AddRange(candidates);
        }

        public void AddRecruitedStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public List<Candidate> GetCandiatesByStrategy()
        {
            if(_strategy == null)
            {
                throw new Exception("Startegy not supplied");
            }

            return _strategy.GetSelectedCandiates(candiates);
        }
    }
}
