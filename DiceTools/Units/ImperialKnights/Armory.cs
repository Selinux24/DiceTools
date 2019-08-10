
namespace DiceTools.Units.ImperialKnights
{
    static class Armory
    {
        public static Weapon CreateWeaponArmigerAutocannon()
        {
            return new Weapon()
            {
                Name = "Armiger Autocannon",
                Range = 60,
                Type = WeaponTypes.Heavy,
                Attacks = 2,
                AttackDice = 3,
                Strength = 7,
                AP = -1,
                Damage = 3,
            };
        }
        public static Weapon CreateWeaponHeavyStubber()
        {
            return new Weapon()
            {
                Name = "Heavy Stubber",
                Range = 36,
                Type = WeaponTypes.Heavy,
                Attacks = 3,
                Strength = 4,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponMeltagun()
        {
            return new Melta()
            {
                Name = "Meltagun",
                Range = 12,
                Type = WeaponTypes.Assault,
                Attacks = 1,
                Strength = 8,
                AP = -4,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponThermalSpear()
        {
            return new Melta()
            {
                Name = "Thermal Spear",
                Range = 30,
                Type = WeaponTypes.Assault,
                Attacks = 1,
                AttackDice = 3,
                Strength = 8,
                AP = -4,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponLasImpulsor()
        {
            return new Weapon()
            {
                Name = "Las-impulsor Low intensity",
                Range = 36,
                Type = WeaponTypes.Heavy,
                Attacks = 2,
                AttackDice = 6,
                Strength = 6,
                AP = -2,
                Damage = 1,
                DamageDice = 3,
                SuperchargeProfile = new Weapon()
                {
                    Name = "Las-impulsor High intensity",
                    Range = 18,
                    Type = WeaponTypes.Heavy,
                    Attacks = 1,
                    AttackDice = 6,
                    Strength = 12,
                    AP = -4,
                    Damage = 1,
                    DamageDice = 6,
                }
            };
        }
    }
}
