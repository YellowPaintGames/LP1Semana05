using System;
using Spectre.Console;
namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var dmg = 10;
            var def = 3;
            var table = new Table();
            table.Border(TableBorder.Rounded);
            table.AddColumn("Operation");
            table.AddColumn("Damage(" + dmg + ")");
            table.AddColumn("Damage(" + dmg + "," + def + ")");
            table.AddColumn("CriticalHit(" + Damage(dmg, def) + ")");
            table.AddRow("Result", Damage(dmg));
            AnsiConsole.Write(table);
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
                int D = damage + Damage(10, 3);
                CriticalHit(damage - 1);
                return D;
            }
        }
    }
}