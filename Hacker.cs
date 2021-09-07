using System;

namespace PlanYourHeist2
{
    public class Hacker : IRobber
    {

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }


        public void PerformSkill(bank Bank)
        {
            bank.AlarmScore -= SkillLevel
            Console.WriteLine($"{Name} is hacking the alarm system! It is decreased by {SkillLevel} points!");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}