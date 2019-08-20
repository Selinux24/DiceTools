using System.Collections.Generic;

namespace DiceTools.Units.Orks
{
    public class BigMek : OrkUnit
    {
        public static BigMek Create(bool soupedUpShokka)
        {
            Weapon weapon = soupedUpShokka ? 
                Armory.CreateWeaponDaSoupedUpShokka() : 
                Armory.CreateWeaponShokkAttackGun();

            string name = soupedUpShokka ? 
                "Big Mek with Da Souped-up Shokka" : 
                "Big Mek with Shokk Attack Gun";

            List<Weapon> weapons = new List<Weapon>
            {
                weapon,
            };

            return new BigMek()
            {
                Name = name,
                Soldiers = new List<Model>() { CreateBigMek(weapons) }
            };
        }

        public static Model CreateBigMek(List<Weapon> weapons)
        {
            return new Model()
            {
                Name = "Big Mek",
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
