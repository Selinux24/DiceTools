using System.Collections.Generic;

namespace DiceTools.Units.ImperialKnights
{
    public class ArmigerHelverin : Unit
    {
        public static ArmigerHelverin Create(ArmigerHelverinTypes type)
        {
            List<Weapon> weapons = new List<Weapon>();

            if (type == ArmigerHelverinTypes.Default)
            {
                weapons.AddRange(new[]
                {
                    Armory.CreateWeaponArmigerAutocannon(),
                    Armory.CreateWeaponArmigerAutocannon(),
                    Armory.CreateWeaponHeavyStubber(),
                });
            }
            else if (type == ArmigerHelverinTypes.Meltagun)
            {
                weapons.AddRange(new[]
                {
                    Armory.CreateWeaponArmigerAutocannon(),
                    Armory.CreateWeaponArmigerAutocannon(),
                    Armory.CreateWeaponMeltagun(),
                });
            }

            return new ArmigerHelverin()
            {
                Name = "Armiger Helverin",
                Soldiers = new List<Model>() { CreateArmigerHelverin(weapons) }
            };
        }

        public static Model CreateArmigerHelverin(List<Weapon> weapons)
        {
            return new Model()
            {
                Name = "Armiger Helverin",
                WS = 3,
                BS = 3,
                S = 6,
                T = 7,
                W = 12,
                A = 4,
                Sv = 3,
                ISv = 5,
                Weapons = weapons,
            };
        }
    }

    public enum ArmigerHelverinTypes
    {
        Default,
        Meltagun,
    }
}
