using System;

namespace PlanYourHeist2
{
    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }


        void PerformSkill(bank Bank);
    }
}