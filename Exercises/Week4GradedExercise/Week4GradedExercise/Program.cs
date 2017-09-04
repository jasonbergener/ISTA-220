using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4GradedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoStuff();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void DoStuff()
        {
            InfPlatoonLeader pl = new InfPlatoonLeader("PL", "1LT", new M4Carbine());
            InfPlatoonSergeant psg = new InfPlatoonSergeant("PSG", "SFC", new M4Carbine(), pl);
            InfSquadLeader sl = new InfSquadLeader("Squad Leader", "SSG", supervisor: psg);
            InfTeamLeader atl = new InfTeamLeader("Alpha Team Leader", "SGT", supervisor: sl);
            InfTeamLeader btl = new InfTeamLeader("Bravo Team Leader", "SGT", supervisor: sl);
            btl.Team = "Bravo Team";
            Rifleman grunt1 = new Rifleman("Alpha Team, Rifleman", "SPC", supervisor: atl);
            Rifleman grunt2 = new Rifleman("Bravo Team, Rifleman", "SPC", supervisor: btl);
            Grenedier grunt3 = new Grenedier("Alpha Team, Grenedier", "PFC", supervisor: atl);
            Grenedier grunt4 = new Grenedier("Bravo Team, Grenedier", "PFC", supervisor: btl);
            AutomaticRifleman grunt5 = new AutomaticRifleman("Alpha Team, SAW Gunner", "PV2", supervisor: atl);
            AutomaticRifleman grunt6 = new AutomaticRifleman("Bravo Team, SAW Gunner", "PV2", supervisor: btl);
            Infantry[] firstSquad = new Infantry[9] { sl, atl, btl, grunt1, grunt2, grunt3, grunt4, grunt5, grunt6};
            GetWeapons(firstSquad);
            grunt1.AddEquip.Add(new Rucksack());
            grunt2.AddEquip.Add(new Rucksack());
            pl.BattleDrillOneA();
            SquadAssault(firstSquad);
            psg.BattleDrillOneA();
            Console.WriteLine($"\nAfter training, {psg.Rank} {psg.Name} orders the squad to clean their equipment.");
            CleanEquip(firstSquad);
        }
        static void SquadAssault(Infantry[] i)
        {
            foreach (Infantry soldier in i)
            {
                if (i[0].Weapon is null)
                {
                    Console.WriteLine("The unit is not equipped to complete the mission.");
                    return;
                }
            }
            foreach (Infantry soldier in i)
            {
                if (soldier.Team is null)
                    soldier.BattleDrillOneA();
            }
            foreach (Infantry soldier in i)
            {
                if (soldier.Team is "Alpha Team")
                    soldier.BattleDrillOneA();
            }
            foreach (Infantry soldier in i)
            {
                if (soldier.Team is "Bravo Team")
                    soldier.BattleDrillOneA();
            }
        }
        static void GetWeapons(Infantry[] i)
        {
            foreach (Infantry soldier in i)
            {
                if (soldier.GetType().Name is "AutomaticRifleman")
                {
                    soldier.Weapon = new M249();
                }
                else if (soldier.GetType().Name is "Grenedier")
                {
                    soldier.Weapon = new M4with203();
                }
                else
                {
                    soldier.Weapon = new M4Carbine();
                }
            }
        }
        static void CleanEquip(Infantry[] i)
        {
            foreach (Infantry soldier in i)
            {
                Console.WriteLine($"{soldier.Rank} {soldier.Name} cleans his equipment:");
                soldier.Weapon.Clean();
                foreach (Equipment e in soldier.AddEquip)
                {
                    e.Clean();
                }
            }
        }
    }
}
