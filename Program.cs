using System;
using System.Linq;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {

            int bankDifficulty = 0;
            int bankLuck = new Random().Next(-11, 11);
            int TrialRuns = 1;

            Console.WriteLine("Plan your heist!");
            Console.WriteLine("How many trial runs would you like to make?");
            TrialRuns = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Bank's difficulty level. 1-100");
            bankDifficulty = int.Parse(Console.ReadLine());
            int bankLuckDifficulty = bankLuck + bankDifficulty;
            Gang gang = new Gang("Delta");

            for (int i = 0; i < TrialRuns; i++)
            {
                Heist();
            }
            void Heist()
            {



                while (true)
                {
                    Console.WriteLine("Please enter your name: ");
                    string name = Console.ReadLine();
                    if (name == "")
                    {
                        break;
                    }

                    Member newMember = new Member();
                    newMember.Name = name;
                    Console.WriteLine("Please enter a positive interger (1-10) of your skill level:");
                    newMember.SkillLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter a positive decimal between 0.0-2.0 for your courage level: ");
                    newMember.Courage = double.Parse(Console.ReadLine());
                    gang.Members.Add(newMember);
                }

                Console.WriteLine($"Total members in gang: {gang.Members.Count}");


                foreach (Member member in gang.Members)
                {
                    gang.GangSkill += member.SkillLevel;
                }
                Console.WriteLine($"There are {gang.Members.Count} members in your gang with a total skill of {gang.GangSkill}.");
                Console.WriteLine($"The gang's total skill is {gang.GangSkill}");
                Console.WriteLine($"The Bank's state of the art security system is at level {bankLuckDifficulty}");

                if (gang.GangSkill >= bankLuckDifficulty)
                {
                    Console.WriteLine("$$$$$ Success! Your gang's skill was enought to trump the banks state of the art system! $$$$$$$$");
                }
                else
                {
                    Console.WriteLine("Epic Fail! Your gang is not skilled enough for this bank's state of the art security system!");
                }

            }


        }


    }

}

