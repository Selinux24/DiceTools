using System.Collections.Generic;

namespace DiceTools.Units.Orks
{
    public class BigMek : OrkUnit
    {
        public static BigMek Create(bool soupedShokka)
        {
            List<Weapon> weapons = new List<Weapon>
            {
                soupedShokka ?  Armory.CreateWeaponDaSoupedShockGun() : Armory.CreateWeaponShockGun(),
            };

            return new BigMek()
            {
                Name = soupedShokka ? "Big Mek with Da souped Shooka" : "Big Mek",
                Soldiers = new List<Model>() { CreateBigMek(weapons) }
            };
        }

        public static Model CreateBigMek(List<Weapon> weapons)
        {
            return new Model()
            {
                Name = "BigMek",
                WS = 5,
                BS = 5,
                S = 6,
                T = 6,
                W = 10,
                A = 3,
                Sv = 4,
                ISv = 0,
                Weapons = weapons,
            };
        }

        public BigMek() : base(true)
        {

        }
    }
}
