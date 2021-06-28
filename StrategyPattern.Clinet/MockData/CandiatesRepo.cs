using StrategyPattern.Clinet.Models;
using System.Collections.Generic;

namespace StrategyPattern.Clinet.MockData
{
    public class CandiatesRepo
    {
        public static List<Candidate> GetCandidatesList()
        {
            List<Candidate> candidates = new List<Candidate>
            {
                new Candidate()
                {
                    Name = "Vishnu",
                    Experience = 6,
                    IsReferral = false,
                    NoofSkilSet = 3
                },
                new Candidate()
                {
                    Name = "Annapoorani",
                    Experience = 4,
                    IsReferral = false,
                    NoofSkilSet = 4
                },
                new Candidate()
                {
                    Name = "Vinoth",
                    Experience = 5,
                    IsReferral = true,
                    NoofSkilSet = 2
                },
                new Candidate()
                {
                    Name = "Abhishek",
                    Experience = 7,
                    IsReferral = false,
                    NoofSkilSet = 4
                },
                new Candidate()
                {
                    Name = "Haja",
                    Experience = 5,
                    IsReferral = true,
                    NoofSkilSet = 2
                },
            };
            return candidates;
        }
    }
}
