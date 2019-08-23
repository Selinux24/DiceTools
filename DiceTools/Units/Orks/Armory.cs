
using System.Collections.Generic;

namespace DiceTools.Units.Orks
{
    static class Armory
    {
        public static Weapon CreateWeaponShoota()
        {
            return new Weapon()
            {
                Name = "Shoota",
                Range = 18,
                Type = WeaponTypes.Assault,
                Attacks = 2,
                AttackDice = 0,
                Strength = 4,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponBigShoota()
        {
            return new Weapon()
            {
                Name = "Big Shoota",
                Range = 36,
                Type = WeaponTypes.Assault,
                Attacks = 3,
                AttackDice = 0,
                Strength = 5,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponRokkitLauncher()
        {
            return new Weapon()
            {
                Name = "Rokkit Launcher",
                Range = 24,
                Type = WeaponTypes.Assault,
                Attacks = 1,
                AttackDice = 0,
                Strength = 8,
                AP = -2,
                Damage = 3,
            };
        }
        public static Weapon CreateWeaponStikkbombs()
        {
            return new Weapon()
            {
                Name = "Stikkbombs",
                Range = 6,
                Type = WeaponTypes.Grenade,
                Attacks = 1,
                AttackDice = 3,
                Strength = 3,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponSnazzgun()
        {
            return new Weapon()
            {
                Name = "Snazzgun",
                Range = 24,
                Type = WeaponTypes.Heavy,
                Attacks = 3,
                AttackDice = 0,
                Strength = 6,
                AP = -2,
                Damage = 2,
            };
        }
        public static Weapon CreateWeaponGrotGun()
        {
            return new Weapon()
            {
                Name = "Grot Gun",
                Range = 12,
                Type = WeaponTypes.Pistol,
                Attacks = 1,
                Strength = 3,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponKustomMegaBlasta()
        {
            return new KustomMegaWeapon()
            {
                Name = "Kustom Mega-blasta",
                Range = 24,
                Type = WeaponTypes.Assault,
                Attacks = 1,
                Strength = 8,
                AP = -3,
                Damage = 1,
                DamageDice = 3,
            };
        }
        public static Weapon CreateWeaponDeffgun()
        {
            return new Weapon()
            {
                Name = "Deffgun",
                Range = 48,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                AttackDice = 3,
                Strength = 7,
                AP = -1,
                Damage = 2,
            };
        }
        public static Weapon CreateWeaponBurna()
        {
            return new Flammer()
            {
                Name = "Burna",
                Range = 8,
                Type = WeaponTypes.Assault,
                Attacks = 1,
                AttackDice = 3,
                Strength = 4,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponDakkagun()
        {
            return new Weapon()
            {
                Name = "Dakkagun",
                Range = 18,
                Type = WeaponTypes.Assault,
                Attacks = 3,
                Strength = 5,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponBubblechukka()
        {
            return new Weapon()
            {
                Name = "Bubblechukka",
                Range = 48,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                AttackDice = 6,
                Strength = 1,
                StrengthDice = 6,
                AP = 1,
                APDice = 6,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponKustomMegaKannon()
        {
            return new KustomMegaWeapon()
            {
                Name = "Kustom Mega Kannon",
                Range = 36,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                AttackDice = 6,
                Strength = 8,
                AP = -3,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponSmashaGun()
        {
            return new SmashaGun()
            {
                Name = "Smasha Gun",
                Range = 48,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                AttackDice = 3,
                Strength = 2,
                StrengthDice = 6,
                AP = -4,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponTraktorKannon()
        {
            return new TraktorKannon()
            {
                Name = "Traktor Kannon",
                Range = 48,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                Strength = 8,
                AP = -2,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponKannon()
        {
            return new Weapon()
            {
                Name = "Kannon Frag",
                Range = 36,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                AttackDice = 6,
                Strength = 4,
                AP = 0,
                Damage = 1,
                SuperchargeProfile = new Weapon()
                {
                    Name = "Kannon Shell",
                    Range = 36,
                    Type = WeaponTypes.Heavy,
                    Attacks = 1,
                    Strength = 8,
                    AP = -1,
                    Damage = 1,
                    DamageDice = 6,
                }
            };
        }
        public static Weapon CreateWeaponKillKannon()
        {
            return new Weapon()
            {
                Name = "Kill Kannon",
                Range = 24,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                AttackDice = 6,
                Strength = 8,
                AP = -2,
                Damage = 2,
            };
        }
        public static Weapon CreateWeaponZzapGun()
        {
            return new ZzapGun()
            {
                Name = "Zzap Gun",
                Range = 24,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                Strength = 2,
                StrengthDice = 6,
                AP = -3,
                Damage = 3,
            };
        }
        public static Weapon CreateWeaponShokkAttackGun()
        {
            return new ShokkAttackGun()
            {
                Name = "Shock Gun",
                Range = 60,
                Type = WeaponTypes.Heavy,
                Attacks = 1,
                AttackDice = 6,
                Strength = 2,
                StrengthDice = 6,
                AP = -5,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponDaSoupedUpShokka()
        {
            return new ShokkAttackGun()
            {
                Name = "Da Souped-up Shokka",
                Range = 60,
                Type = WeaponTypes.Heavy,
                Attacks = 2,
                AttackDice = 6,
                Strength = 2,
                StrengthDice = 6,
                AP = -5,
                Damage = 1,
                DamageDice = 6,
            };
        }
        public static Weapon CreateWeaponKillaJet()
        {
            return new Flammer()
            {
                Name = "Killa Jet (Burna)",
                Range = 8,
                Type = WeaponTypes.Assault,
                Attacks = 1,
                AttackDice = 6,
                Strength = 5,
                AP = -1,
                Damage = 1,
                SuperchargeProfile = new Melta()
                {
                    Name = "Killa Jet (Cutta)",
                    Range = 8,
                    Type = WeaponTypes.Assault,
                    Attacks = 2,
                    Strength = 8,
                    AP = -4,
                    Damage = 1,
                    DamageDice = 6,
                }
            };
        }
        public static Weapon CreateWeaponTwinBoomstick()
        {
            return new Shotgun()
            {
                Name = "Twin Boomstick",
                Range = 12,
                Type = WeaponTypes.Assault,
                Attacks = 2,
                Strength = 5,
                AP = 0,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponSnaggaKlaw()
        {
            return new SnaggaKlaw()
            {
                Name = "Snagga Klaw",
                Range = 8,
                Type = WeaponTypes.Assault,
                Attacks = 1,
                Strength = 4,
                AP = 1,
                Damage = 1,
            };
        }
        public static Weapon CreateWeaponGrotBlaster()
        {
            return new Weapon()
            {
                Name = "Grot Blaster",
                Range = 12,
                Type = WeaponTypes.Pistol,
                Attacks = 1,
                Strength = 3,
                AP = 0,
                Damage = 1,
            };
        }

        public class TraktorKannon : Weapon
        {
            public override int CalcDamage(Wound wound, Model target, ShootingParams shootingParams)
            {
                if (target.Flyer)
                {
                    //Two damage dices versus flyers
                    return CalcDamage(shootingParams, Damage * 2, DamageDice, DiceModes.Max);
                }

                return CalcDamage(shootingParams, Damage, DamageDice, DiceModes.Max);
            }

            public override Impact ImpactTest(Model attacker, ShootingParams shootingParams)
            {
                return new Impact()
                {
                    Attacker = attacker,
                    Weapon = this,
                    Impacted = true,
                };
            }
        }

        public class ZzapGun : Weapon
        {
            private int currentStrength = 0;

            public override void Initialize()
            {
                base.Initialize();

                currentStrength = base.CalcStrength();
            }

            public override int CalcStrength()
            {
                return currentStrength;
            }

            public override Impact ImpactTest(Model attacker, ShootingParams shootingParams)
            {
                var impact = base.ImpactTest(attacker, shootingParams);

                if (currentStrength >= 11)
                {
                    impact.BearerDamage = BearerDamageTypes.FirstWoundOnly;
                    impact.Mortal = true;
                }

                return impact;
            }
        }

        public class ShokkAttackGun : Weapon
        {
            private int currentStrength = 0;

            public override void Initialize()
            {
                base.Initialize();

                currentStrength = base.CalcStrength();
            }

            public override int CalcStrength()
            {
                return currentStrength;
            }

            public override List<Wound> WoundTest(int t, ShootingParams shootingParams)
            {
                List<Wound> wounds = new List<Wound>();

                if (currentStrength >= 11)
                {
                    wounds.Add(new Wound(this, 0, true));
                }

                wounds.AddRange(base.WoundTest(t, shootingParams));

                return wounds;
            }

            public override int CalcDamage(Wound wound, Model target, ShootingParams shootingParams)
            {
                if (wound.Mortal)
                {
                    return Dice.Sum(3, 1);
                }

                return base.CalcDamage(wound, target, shootingParams);
            }
        }

        public class SmashaGun : Weapon
        {
            public override List<Wound> WoundTest(int t, ShootingParams shootingParams)
            {
                List<Wound> wounds = new List<Wound>();

                int s = CalcStrength();
                if (s >= t)
                {
                    wounds.Add(new Wound(this, 0, false));
                }

                return wounds;
            }
        }

        public class KustomMegaWeapon : Weapon
        {
            public override Impact ImpactTest(Model attacker, ShootingParams shootingParams)
            {
                var impact = base.ImpactTest(attacker, shootingParams);

                if (impact.CriticalFail)
                {
                    impact.BearerDamage = BearerDamageTypes.FirstWoundOnly;
                }

                return impact;
            }
        }

        public class SnaggaKlaw : Weapon
        {
            public override List<Wound> WoundTest(int t, ShootingParams shootingParams)
            {
                var wounds = base.WoundTest(t, shootingParams);

                if (wounds.Count == 0)
                {
                    //Repeats all
                    return base.WoundTest(t, shootingParams);
                }

                return wounds;
            }
        }
    }
}
