using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileAndWhileLoopsTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Game rules:
                1. The hero and the monster will start with 10 health point.
                2. All attacks will be a value between 1 and 10.
                3. The hero will attack first.
                4. Print the amount of health the monster lost and their remain health.
                5. If the monster's health is greater than 0, it can attack the hero.
                6. Print the amount of health the hero lost and their remaining health.
                7. Continue this sequence of attacking until either the monster's health 
                    or hero's health is zero or less.
                8. Print the winner.

                Output:
                    Monster was damaged and lost 4 health and now has 6 health.
                    Hero was damaged and lost 5 health and now has 5 health.
                    Monster was damaged and lost 4 health and now has 2 health.
                    Hero was damaged and lost 7 health and now has -2 health.
                    Monster wins!
             */

            int monsterHealth = 10;
            int heroHealth = 10;
            Random dice = new Random();
            while ((monsterHealth > 0) && (heroHealth > 0))
            {

                int roll = dice.Next(1, 11);
                monsterHealth -= roll;
                Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth} health.");

                if (monsterHealth > 0)
                {
                    roll = dice.Next(1, 11);
                    heroHealth -= roll;
                    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHealth} health.");
                }
            }
            Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");
        }

        //static void Main(string[] args)
        //{
        //    /*
        //        Write a do-while statement to break when a certain
        //        random number is generated.
        //     */
        //    ///
        //    //Random random = new Random();
        //    //int randNumber = 0;
        //    //do
        //    //{
        //    //    randNumber = random.Next(1, 11);
        //    //    Console.WriteLine(randNumber);
        //    //} while (randNumber != 7);

        //    /*
        //        Write a while statement that iterates only
        //        while a random number is greater than some value
        //     */
        //    //Random random = new Random();
        //    //int randNumber = random.Next(1, 11);
        //    //while (randNumber > 3)
        //    //{
        //    //    Console.WriteLine(randNumber);
        //    //    randNumber = random.Next(1, 11);
        //    //}
        //    //Console.WriteLine($"Last number: {randNumber}");

        //    /*
        //        Use the continue statement to step directly
        //        to the Boolean expression  
        //     */
        //    Random random = new Random();
        //    int current = random.Next(1, 11);
        //    do
        //    {
        //        current = random.Next(1, 11);
        //        if (current >= 8)
        //        {
        //            continue;
        //        }
        //        Console.WriteLine(current);
        //    } while (current != 7);
        //}
    }
}
