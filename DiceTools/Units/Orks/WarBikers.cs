using System.Collections.Generic;

namespace DiceTools.Units.Orks
{
    public class WarBikers : OrkUnit
    {
        public static WarBikers Create(bool nob, int warbikers)
        {
            List<Model> soldiers = new List<Model>();

            if (nob)
            {
                soldiers.Add(CreateNob());
            }

            for (int i = 0; i < warbikers; i++)
            {
                soldiers.Add(CreateWarbiker());
            }

            return new WarBikers()
            {
                Name = "War Bikers",
                Soldiers = soldiers,
            };
        }

        public static Model CreateNob()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponDakkagun(),
                Armory.CreateWeaponDakkagun(),
                Armory.CreateWeaponStikkbombs(),
            };

            return new Model()
            {
                Name = "Nob",
                WS = 3,
                BS = 5,
                S = 5,
                T = 5,
                W = 3,
                A = 3,
                Sv = 4,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateWarbiker()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponDakkagun(),
                Armory.CreateWeaponDakkagun(),
                Armory.CreateWeaponStikkbombs(),
            };

            return new Model()
            {
                Name = "War Biker",
                WS = 3,
                BS = 5,
                S = 4,
                T = 5,
                W = 2,
                A = 2,
                Sv = 4,
                ISv = 0,
                Weapons = weapons,
            };
        }

        public WarBikers() : base(true)
        {
            
        }
    }
}
