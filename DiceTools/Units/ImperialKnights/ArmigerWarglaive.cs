using System.Collections.Generic;

namespace DiceTools.Units.ImperialKnights
{
    public class ArmigerWarglaive : Unit
    {
        public static ArmigerWarglaive Create(ArmigerWarglaiveTypes type)
        {
            List<Weapon> weapons = new List<Weapon>();

            if (type == ArmigerWarglaiveTypes.Default)
            {
                weapons.AddRange(new[]
                {
                    Armory.CreateWeaponThermalSpear(),
                    Armory.CreateWeaponHeavyStubber(),
                });
            }
            else if (type == ArmigerWarglaiveTypes.Meltagun)
            {
                weapons.AddRange(new[]
                {
                    Armory.CreateWeaponThermalSpear(),
                    Armory.CreateWeaponMeltagun(),
                });
            }

            return new ArmigerWarglaive()
            {
                Name = "Armiger Warglaive",
                Soldiers = new List<Model>() { CreateArmigerWarglaive(weapons) }
            };
        }

        public static Model CreateArmigerWarglaive(List<Weapon> weapons)
        {
            return new Model()
            {
                Name = "Armiger Warglaive",
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

    public enum ArmigerWarglaiveTypes
    {
        Default,
        Meltagun,
    }
}
