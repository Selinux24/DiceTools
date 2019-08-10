using System.Collections.Generic;

namespace DiceTools.Units.Orks
{
    public class Boyz : OrkUnit
    {
        public static Boyz Create(bool nobz, int boyz, int bigShootas, int rokkits)
        {
            List<Model> soldiers = new List<Model>();

            if (nobz)
            {
                soldiers.Add(CreateBossNob());
            }

            for (int i = 0; i < boyz; i++)
            {
                soldiers.Add(CreateOrkShoota());
            }

            for (int i = 0; i < bigShootas; i++)
            {
                soldiers.Add(CreateOrkBigShoota());
            }

            for (int i = 0; i < rokkits; i++)
            {
                soldiers.Add(CreateOrkRokkitLauncher());
            }

            return new Boyz()
            {
                Name = "Boyz",
                Soldiers = soldiers,
            };
        }

        public static Model CreateBossNob()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponShoota(),
                Armory.CreateWeaponStikkbombs()
            };

            return new Model()
            {
                Name = "Boss Nob",
                WS = 3,
                BS = 5,
                S = 5,
                T = 4,
                W = 2,
                A = 3,
                Sv = 6,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateOrkShoota()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponShoota(),
                Armory.CreateWeaponStikkbombs()
            };

            return new Model()
            {
                Name = "Boy",
                WS = 3,
                BS = 5,
                S = 4,
                T = 4,
                W = 1,
                A = 2,
                Sv = 6,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateOrkBigShoota()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponBigShoota(),
                Armory.CreateWeaponStikkbombs()
            };

            return new Model()
            {
                Name = "Boy Heavy",
                WS = 3,
                BS = 5,
                S = 4,
                T = 4,
                W = 1,
                A = 2,
                Sv = 6,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateOrkRokkitLauncher()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponRokkitLauncher(),
                Armory.CreateWeaponStikkbombs()
            };

            return new Model()
            {
                Name = "Boy Heavy",
                WS = 3,
                BS = 5,
                S = 4,
                T = 4,
                W = 1,
                A = 2,
                Sv = 6,
                ISv = 0,
                Weapons = weapons,
            };
        }

        public Boyz() : base(true)
        {

        }
    }
}
