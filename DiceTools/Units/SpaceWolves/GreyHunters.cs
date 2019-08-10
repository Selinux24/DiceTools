using System.Collections.Generic;

namespace DiceTools.Units.SpaceWolves
{
    public class GreyHunters : SpaceWolvesUnit
    {
        public static GreyHunters Create(bool wolfGuardTerm, bool wolfGuard, bool packLeader, int tacticals, int plasma, int melta)
        {
            List<Model> soldiers = new List<Model>();

            if (wolfGuardTerm)
            {
                soldiers.Add(CreateGreyHunterWorlfGuardTerm());
            }

            if (wolfGuard)
            {
                soldiers.Add(CreateGreyHunterWorlfGuard());
            }

            if (packLeader)
            {
                soldiers.Add(CreateGreyHunterPackLeader());
            }

            for (int i = 0; i < tacticals; i++)
            {
                soldiers.Add(CreateGreyHunterBolter());
            }

            for (int i = 0; i < plasma; i++)
            {
                soldiers.Add(CreateGreyHunterPlasmaGun());
            }

            for (int i = 0; i < melta; i++)
            {
                soldiers.Add(CreateGreyHunterMeltaGun());
            }

            return new GreyHunters()
            {
                Name = "Grey Hunters",
                Soldiers = soldiers,
            };
        }

        public static Model CreateGreyHunterWorlfGuardTerm()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponStormBolter(),
            };

            return new Model()
            {
                Name = "Wolf Guard Terminator",
                WS = 3,
                BS = 3,
                S = 4,
                T = 4,
                W = 2,
                A = 2,
                Sv = 2,
                ISv = 5,
                Weapons = weapons,
            };
        }
        public static Model CreateGreyHunterWorlfGuard()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponBoltPistol(),
                Armory.CreateWeaponFragGrenade(),
                Armory.CreateWeaponKrakGrenade(),
            };

            return new Model()
            {
                Name = "Wolf Guard Leader",
                WS = 3,
                BS = 3,
                S = 4,
                T = 4,
                W = 1,
                A = 2,
                Sv = 3,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateGreyHunterPackLeader()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponBoltGun(),
                Armory.CreateWeaponBoltPistol(),
                Armory.CreateWeaponFragGrenade(),
                Armory.CreateWeaponKrakGrenade(),
            };

            return new Model()
            {
                Name = "Grey Hunter Pack Leader",
                WS = 3,
                BS = 3,
                S = 4,
                T = 4,
                W = 1,
                A = 2,
                Sv = 3,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateGreyHunterBolter()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponBoltGun(),
                Armory.CreateWeaponBoltPistol(),
                Armory.CreateWeaponFragGrenade(),
                Armory.CreateWeaponKrakGrenade(),
            };

            return new Model()
            {
                Name = "Grey Hunter",
                WS = 3,
                BS = 3,
                S = 4,
                T = 4,
                W = 1,
                A = 1,
                Sv = 3,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateGreyHunterPlasmaGun()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponPlasmaGun(),
                Armory.CreateWeaponBoltPistol(),
                Armory.CreateWeaponFragGrenade(),
                Armory.CreateWeaponKrakGrenade(),
            };

            return new Model()
            {
                Name = "Grey Hunter Special Weapon",
                WS = 3,
                BS = 3,
                S = 4,
                T = 4,
                W = 1,
                A = 1,
                Sv = 3,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateGreyHunterMeltaGun()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponMeltaGun(),
                Armory.CreateWeaponBoltPistol(),
                Armory.CreateWeaponFragGrenade(),
                Armory.CreateWeaponKrakGrenade(),
            };

            return new Model()
            {
                Name = "Grey Hunter Special Weapon",
                WS = 3,
                BS = 3,
                S = 4,
                T = 4,
                W = 1,
                A = 1,
                Sv = 3,
                ISv = 0,
                Weapons = weapons,
            };
        }
    }
}
