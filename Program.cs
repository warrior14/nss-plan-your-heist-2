using System;
using System.Collections.Generic;

namespace PlanYourHeist2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(rolodex.Count);
            Console.Write("Please enter a new crew member.")
            string userName = Console.ReadLine();

            Console.WriteLine(@"Please select a specialty for the new crew member!
            
            1. Hacker (Disables Alarms)
            2. Muscle (Disarm Guards)
            3. Lock Specialist (Cracks Vaults)
            ")

            int memberSpecialty = int.Parse(Console.ReadLine());

            Console.Write("Please enter a skill level between 1-100");
            int memberSkillLevel = int.Parse(Console.ReadLine());

            Console.Write("Please enter a percentage cut between 1-100 for the member");
            int memberPercentageCut = int.Parse(Console.ReadLine());


            // keep running until the user enters a name
   


            List<IRobber> rolodex = new List<IRobber>() 
            {
                new Hacker() {Name = "Luke", SkillLevel = 99, PercentageCut = 70};
                new Hacker() {Name = "Luz", SkillLevel = 21, PercentageCut = 5};
                new Muscle() {Name = "Aviva", SkillLevel = 14, PercentageCut = 5};
                new Muscle() {Name = "Gabriel", SkillLevel = 22, PercentageCut = 5};
                new LockSpecialList() {Name = "Stephanie", SkillLevel = 24, PercentageCut = 5};
                new LockSpecialList() {Name = "Zach", SkillLevel = 25, PercentageCut = 5};
            }
        }
    }
}
