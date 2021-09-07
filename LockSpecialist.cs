using System;

namespace PlanYourHeist2
{
    public class LockSpecialist : IRobber
    {

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }


        public void PerformSkill(bank Bank)
        {
            bank.VaultScore -= SkillLevel
            Console.WriteLine($"{Name} is hacking the Vault System! It is decreased by {SkillLevel} points!");
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has cracked the vault!");
            }
    }
}