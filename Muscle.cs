using System;

namespace PlanYourHeist2
{
    public class Muscle : IRobber
    {

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }


        public void PerformSkill(bank Bank)
        {
            bank.SecurityGuardScore -= SkillLevel
            Console.WriteLine($"{Name} is fighting with the securiy guards! It is decreased by {SkillLevel} points!");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has defeated the security guards!");
            }
    }
}