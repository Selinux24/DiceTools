using System.Collections.Generic;

namespace DiceTools.Units.ImperialKnights
{
    public class KnightPreceptor : Unit
    {
        public static KnightPreceptor Create(KnightPreceptorTypes type)
        {
            List<Weapon> weapons = new List<Weapon>();

            if (type == KnightPreceptorTypes.Default)
            {
                weapons.AddRange(new[]
                {
                    Armory.CreateWeaponLasImpulsor(),
                    Armory.CreateWeaponHeavyStubber(),
                });
            }
            else if (type == KnightPreceptorTypes.Meltagun)
            {
                weapons.AddRange(new[]
                {
                    Armory.CreateWeaponLasImpulsor(),
                    Armory.CreateWeaponMeltagun(),
                });
            }

            return new KnightPreceptor()
            {
                Name = "Knight Preceptor",
                Soldiers = new List<Model>() { CreateKnightPreceptor(weapons) }
            };
        }

        public static Model CreateKnightPreceptor(List<Weapon> weapons)
        {
            return new Model()
            {
                Name = "Knight Preceptor",
                WS = 3,
                BS = 3,
                S = 8,
                T = 8,
                W = 24,
                A = 4,
                Sv = 3,
                ISv = 5,
                Weapons = weapons,
            };
        }
    }

    public enum KnightPreceptorTypes
    {
        Default,
        Meltagun,
    }
}
