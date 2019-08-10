
namespace DiceTools.Units.SpaceWolves
{
    static class Armory
    {
        public static Weapon CreateWeaponBoltGun()
        {
            return new Weapon()
            {
                Name = "Boltgun",
                Range = 24,
                Type = WeaponTypes.RapidFire,
                Attacks = 1,
                Strength = 4,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponBoltRifle()
        {
            return new Weapon()
            {
                Name = "Bolt rifle",
                Range = 30,
                Type = WeaponTypes.RapidFire,
                Attacks = 1,
                Strength = 4,
                AP = -1,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponHeavyBolter()
        {
            return new Weapon()
            {
                Name = "Heavy Bolter",
                Range = 36,
                Type = WeaponTypes.Heavy,
                Attacks = 3,
                Strength = 5,
                AP = -1,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponTwinHeavyBolter()
        {
            return new Weapon()
            {
                Name = "Twin Heavy Bolter",
                Range = 36,
                Type = WeaponTypes.Heavy,
                Attacks = 6,
                Strength = 5,
                AP = -1,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponAssaultCannon()
        {
            return new Weapon()
            {
                Name = "Assault Cannon",
                Range = 24,
                Type = WeaponTypes.Heavy,
                Attacks = 6,
                Strength = 6,
                AP = -1,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponTwinAssaultCannon()
        {
            return new Weapon()
            {
                Name = "Twin Assault Cannon",
                Range = 24,
                Type = WeaponTypes.Heavy,
                Attacks = 12,
                Strength = 6,
                AP = -1,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponLassCannon()
        {
            return new Weapon()
            {
                Name = "Lass Cannon",
                Range = 48,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                Strength = 9,
                AP = -3,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponTyphoonMissileLauncher()
        {
            return new Weapon()
            {
                Name = "Typhoon Missile Launcher Frag",
                Range = 48,
                Type = WeaponTypes.Heavy,
                Attacks = 2,
                StrengthDice = 6,
                Strength = 4,
                AP = 0,
                Damage = 1,
                SuperchargeProfile = new Weapon()
                {
                    Name = "Typhoon Missile Launcher Krak",
                    Range = 48,
                    Type = WeaponTypes.Heavy,
                    Attacks = 2,
                    Strength = 8,
                    AP = -2,
                    Damage = 1,
                    DamageDice = 6,
                }
            };
        }
        public static Weapon CreateWeaponTwinLassCannon()
        {
            return new Weapon()
            {
                Name = "Twin Lass Cannon",
                Range = 48,
                Type = WeaponTypes.Heavy,
                Attacks = 2,
                Strength = 9,
                AP = -3,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponPredatorAutocannon()
        {
            return new Weapon()
            {
                Name = "Autocannon",
                Range = 48,
                Type = WeaponTypes.Heavy,
                Attacks = 2,
                AttackDice = 3,
                Strength = 7,
                AP = -1,
                Damage = 3,
            };
        }
        public static Weapon CreateWeaponPlasmaGun()
        {
            return new Weapon()
            {
                Name = "Plasma Gun",
                Range = 24,
                Type = WeaponTypes.RapidFire,
                Attacks = 1,
                Strength = 7,
                AP = -3,
                Damage = 1,
                SuperchargeProfile = new PlasmaSupercharge()
                {
                    Name = "Plasma Gun Supercharge",
                    Range = 24,
                    Type = WeaponTypes.RapidFire,
                    Attacks = 1,
                    Strength = 8,
                    AP = -3,
                    Damage = 2,
                },
            };
        }
        public static Weapon CreateWeaponTwinPlasmaGun()
        {
            return new Weapon()
            {
                Name = "Twin Plasma Gun",
                Range = 24,
                Type = WeaponTypes.RapidFire,
                Attacks = 2,
                Strength = 7,
                AP = -3,
                Damage = 1,
                SuperchargeProfile = new PlasmaSupercharge()
                {
                    Name = "Twin Plasma Gun Supercharge",
                    Range = 24,
                    Type = WeaponTypes.RapidFire,
                    Attacks = 2,
                    Strength = 8,
                    AP = -3,
                    Damage = 2,
                },
            };
        }
        public static Weapon CreateWeaponPlasmaIncinerator()
        {
            return new Weapon()
            {
                Name = "Plasma Incinerator",
                Range = 30,
                Type = WeaponTypes.RapidFire,
                Attacks = 1,
                Strength = 7,
                AP = -4,
                Damage = 1,
                SuperchargeProfile = new PlasmaSupercharge()
                {
                    Name = "Plasma Incinerator Supercharge",
                    Range = 30,
                    Type = WeaponTypes.RapidFire,
                    Attacks = 1,
                    Strength = 8,
                    AP = -4,
                    Damage = 2,
                },
            };
        }
        public static Weapon CreateWeaponMeltaGun()
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
        public static Weapon CreateWeaponMeltaCannon()
        {
            return new Melta()
            {
                Name = "Melta Cannon",
                Range = 24,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                Strength = 8,
                AP = -4,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponBoltPistol()
        {
            return new Weapon()
            {
                Name = "Bolt Pistol",
                Range = 12,
                Type = WeaponTypes.Pistol,
                Attacks = 1,
                Strength = 4,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponStormBolter()
        {
            return new Weapon()
            {
                Name = "Storm Bolter",
                Range = 24,
                Type = WeaponTypes.RapidFire,
                Attacks = 2,
                Strength = 4,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponFragGrenade()
        {
            return new Weapon()
            {
                Name = "Frag Grenade",
                Range = 6,
                Type = WeaponTypes.Grenade,
                Attacks = 1,
                AttackDice = 6,
                Strength = 3,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponKrakGrenade()
        {
            return new Weapon()
            {
                Name = "Krak Grenade",
                Range = 6,
                Type = WeaponTypes.Grenade,
                Attacks = 1,
                Strength = 6,
                AP = -1,
                Damage = 1,
                DamageDice = 3,
            };
        }
        public static Weapon CreateWeaponHunterKillerMissile()
        {
            return new Weapon()
            {
                Name = "Hunter-Killer Missile",
                Range = 48,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                Strength = 8,
                AP = -2,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponHeavyFlammer()
        {
            return new Flammer()
            {
                Name = "Heavy Flammer",
                Range = 8,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                AttackDice = 6,
                Strength = 5,
                AP = -1,
                Damage = 1,
            };
        }
    }
}
