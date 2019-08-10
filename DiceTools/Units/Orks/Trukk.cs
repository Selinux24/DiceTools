using System.Collections.Generic;

namespace DiceTools.Units.Orks
{
    public class Trukk : OrkUnit
    {
        public static Trukk Create()
        {
            return new Trukk()
            {
                Name = "Trukk",
                Soldiers = new List<Model>() { CreateTruck() }
            };
        }

        public static Model CreateTruck()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponBigShoota(),
            };

            return new Model()
            {
                Name = "Trukk",
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

        public Trukk() : base(true)
        {
            
        }
    }
}
