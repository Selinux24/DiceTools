using System.Collections.Generic;

namespace DiceTools.Units.SpaceWolves
{
    public class Rhino : SpaceWolvesUnit
    {
        public static Rhino Create()
        {
            var rhino = CreateRhino();

            return new Rhino()
            {
                Name = "Rhino",
                Soldiers = new List<Model>() { rhino },
            };
        }

        public static Model CreateRhino()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponStormBolter(),
            };

            return new Model()
            {
                Name = "Rhino",
                WS = 6,
                BS = 3,
                S = 6,
                T = 7,
                W = 10,
                A = 3,
                Sv = 3,
                ISv = 0,
                Weapons = weapons,
            };
        }
    }
}
