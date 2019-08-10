using System.Collections.Generic;

namespace DiceTools.Units.SpaceWolves
{
    public class Intercessors : SpaceWolvesUnit
    {
        public static Intercessors Create(bool packLeader, int intercessors)
        {
            List<Model> soldiers = new List<Model>();

            if (packLeader)
            {
                soldiers.Add(CreateIntercessorPackLeader());
            }

            for (int i = 0; i < intercessors; i++)
            {
                soldiers.Add(CreateIntercessorBolter());
            }

            return new Intercessors()
            {
                Name = "Intercessors",
                Soldiers = soldiers,
            };
        }

        public static Model CreateIntercessorPackLeader()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponBoltRifle(),
                Armory.CreateWeaponBoltPistol(),
                Armory.CreateWeaponFragGrenade(),
                Armory.CreateWeaponKrakGrenade(),
            };

            return new Model()
            {
                Name = "Intercessor Pack Leader",
                WS = 3,
                BS = 3,
                S = 4,
                T = 4,
                W = 2,
                A = 3,
                Sv = 3,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateIntercessorBolter()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponBoltRifle(),
                Armory.CreateWeaponBoltPistol(),
                Armory.CreateWeaponFragGrenade(),
                Armory.CreateWeaponKrakGrenade(),
            };

            return new Model()
            {
                Name = "Intercessor",
                WS = 3,
                BS = 3,
                S = 4,
                T = 4,
                W = 2,
                A = 2,
                Sv = 3,
                ISv = 0,
                Weapons = weapons,
            };
        }
    }
}
