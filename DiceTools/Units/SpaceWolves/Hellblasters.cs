using System.Collections.Generic;

namespace DiceTools.Units.SpaceWolves
{
    public class Hellblasters : SpaceWolvesUnit
    {
        public static Hellblasters Create(bool packLeader, int hellblasters)
        {
            List<Model> soldiers = new List<Model>();

            if (packLeader)
            {
                soldiers.Add(CreateHellblasterPackLeader());
            }

            for (int i = 0; i < hellblasters; i++)
            {
                soldiers.Add(CreateHellblaster());
            }

            return new Hellblasters()
            {
                Name = "Hellblasters",
                Soldiers = soldiers,
            };
        }

        public static Model CreateHellblasterPackLeader()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponPlasmaIncinerator(),
                Armory.CreateWeaponBoltPistol(),
                Armory.CreateWeaponFragGrenade(),
                Armory.CreateWeaponKrakGrenade(),
            };

            return new Model()
            {
                Name = "Hellblaster Pack Leader",
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
        public static Model CreateHellblaster()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponPlasmaIncinerator(),
                Armory.CreateWeaponBoltPistol(),
                Armory.CreateWeaponFragGrenade(),
                Armory.CreateWeaponKrakGrenade(),
            };

            return new Model()
            {
                Name = "Hellblaster",
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
