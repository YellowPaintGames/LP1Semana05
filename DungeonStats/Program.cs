using System;
namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CriticalHit(Damage(8, 4)));
            Console.WriteLine(Damage(8, 4));
        }
        private static int Damage(int attack, int defense)
        {
            if (attack - defense > 0)
                return attack - defense;
            else return 0;
        }
        private static int Damage(int attack)
        {
            return attack;
        }
        private static int CriticalHit(int damage)
        {
            if (damage <= 0)
            {
                return 0;
            }
            else
            {
                CriticalHit(damage - 1);
                return damage + 1;
            }
        }
    }
}
