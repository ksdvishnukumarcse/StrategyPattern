using StrategyPattern.Clinet.Interface;
using StrategyPattern.Clinet.MockData;
using StrategyPattern.Clinet.Models;
using System;
using System.Collections.Generic;

namespace StrategyPattern.Client.StrategyConsumer
{
    public class HumanResource
    {
        List<Candidate> candiates = new List<Candidate>();
        private IStrategy _strategy;

        public HumanResource()
        {
            candiates.AddRange(CandiatesRepo.GetCandidatesList());
        }

        //public void AddCandidate (List<Candidate> candidates)
        //{
        //    candiates.AddRange(candidates);
        //}

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
