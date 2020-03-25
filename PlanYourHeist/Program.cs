using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.ReadLine();
            Console.WriteLine("What is the name of your first team member?");
            var memberName = Console.ReadLine();

            Console.WriteLine($"What is the skill level of {memberName}? (Please enter a positive integer.)");
            var skill = Console.ReadLine();
            var numberSkill = Int32.Parse(skill);

            while (numberSkill < 0)
            {
                Console.WriteLine("Your number cannot be a negative number. Please re-enter the number.");
                skill = Console.ReadLine();
                numberSkill = Int32.Parse(skill);
            }

            Console.WriteLine($"{numberSkill}! What an excellent choice!");


            Console.WriteLine($"Now, what is {memberName}'s courage factor? (Please enter a number between 0.0 and 2.0");
            var courage = Console.ReadLine();
            var courageNumber = Convert.ToDouble(courage);

            while (courageNumber < 0.0 || courageNumber > 2.0)
            {
                Console.WriteLine("The number you entered does not meet our criteria. Please enter a number between 0.0 and 2.0");
                courage = Console.ReadLine();
                courageNumber = Convert.ToDouble(courage);
            }

            Console.WriteLine($"With a courage factor of {courageNumber}, {memberName} is very brave!");
            Console.ReadLine();

            var memberMakeup = new TeamMember(memberName, numberSkill, courageNumber);

            Console.WriteLine($"Your team member, {memberName}, has a skill level of {numberSkill} and a courage factor of {courageNumber}.");
            Console.ReadLine();
        }
    }
}
