using StrategyPattern.Client.StrategyConsumer;
using StrategyPattern.Clinet.MockData;
using StrategyPattern.Clinet.Startegies;
using System;

namespace StrategyPattern.Clinet
{
    class Program
    {
        static void Main(string[] args)
        {            
            HumanResource hr = new HumanResource();
            
            //Add Candiates to the Human Resource
            hr.AddCandidate(CandiatesRepo.GetCandidatesList());

            //Add the Strategy to get the candidates
            hr.AddRecruitedStrategy(new MinimumThreeSkilsset());

            var selectedCandidates = hr.GetCandiatesByStrategy();
            Console.WriteLine("MinimumThreeSkilsset");
            foreach (var candidate in selectedCandidates)
            {                
                Console.WriteLine($"Name of the Canidate {candidate.Name}");
            }

            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("ReferralStrategyWith2SkillSet");
            hr.AddRecruitedStrategy(new ReferralStrategyWith2SkillSet());
            selectedCandidates = hr.GetCandiatesByStrategy();

            foreach (var candidate in selectedCandidates)
            {                
                Console.WriteLine($"Name of the Canidate {candidate.Name}");
            }

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("ThreeYearsExperienceStrategy");
            hr.AddRecruitedStrategy(new ThreeYearsExperienceStrategy());
            selectedCandidates = hr.GetCandiatesByStrategy();

            foreach (var candidate in selectedCandidates)
            {                
                Console.WriteLine($"Name of the Canidate {candidate.Name}");
            }

            Console.ReadLine();
        }
    }
}
