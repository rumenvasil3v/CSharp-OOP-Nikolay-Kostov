using PlayersAndMonsters.Heroes;
using PlayersAndMonsters.Heroes.ElfHeroes;
using PlayersAndMonsters.Heroes.WizardHeroes;
using PlayersAndMonsters.Heroes.KnightHeroes;
using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());

            var hero = new Hero(username, level);
            Console.WriteLine(hero.ToString());

            var elf = new Elf(username, level);
            Console.WriteLine(elf.ToString());

            var museElf = new MuseElf(username, level);
            Console.WriteLine(museElf.ToString());

            var wizard = new Wizard(username, level);
            Console.WriteLine(wizard.ToString());

            var darkWizard = new DarkWizard(username, level);
            Console.WriteLine(darkWizard.ToString());

            var soulMaster = new SoulMaster(username, level);
            Console.WriteLine(soulMaster.ToString());
        }
    }
}