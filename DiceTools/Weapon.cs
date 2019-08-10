using System;
using System.Collections.Generic;

namespace DiceTools
{
    /// <summary>
    /// Weapon
    /// </summary>
    public class Weapon
    {
        public static bool CalcImpacts(int bs, ShootingParams shootingParams, out int roll, out int rollModified)
        {
            roll = Dice.D6();

            if (roll == 1 && shootingParams.ShootingRerollOnes)
            {
                //Reroll ones before modifiers
                roll = Dice.D6();
            }
            else if (roll + shootingParams.ShootingModifiers < bs)
            {
                if (shootingParams.ShootingRerollAll)
                {
                    //Reroll all after modifiers
                    roll = Dice.D6();
                }
                else if (shootingParams.ShootingRerolls > 0)
                {
                    //Reroll until rerolls available
                    shootingParams.ShootingRerolls--;
                    roll = Dice.D6();
                }
            }

            rollModified = roll + shootingParams.ShootingModifiers;

            return roll != 1 && rollModified >= bs;
        }
        public static int CalcToWoundRoll(int s, int t)
        {
            if (s == t) return 4;

            if (s >= t * 2) return 2;
            if (s > t) return 3;

            if (s * 2 <= t) return 6;
            return 5;
        }
        public static int CalcDamage(int damageValue, int damageDice, DiceModes mode)
        {
            return damageDice != 0 ? Dice.D(damageDice, damageValue, mode) : damageValue;
        }

        public string Name { get; set; }
        public int Range { get; set; }
        public WeaponTypes Type { get; set; }
        public int Attacks { get; set; }
        public int AttackDice { get; set; }
        public int Strength { get; set; }
        public int StrengthDice { get; internal set; }
        public int AP { get; set; }
        public int APDice { get; internal set; }
        public int Damage { get; set; }
        public int DamageDice { get; set; }
        public Weapon SuperchargeProfile { get; set; } = null;

        public virtual void Initialize()
        {

        }

        public virtual int CalcAttacks()
        {
            return AttackDice != 0 ? Dice.Sum(AttackDice, Attacks) : Attacks;
        }
        public virtual int CalcStrength()
        {
            return StrengthDice != 0 ? Dice.Sum(StrengthDice, Strength) : Strength;
        }
        public virtual int CalcAP()
        {
            return APDice != 0 ? -Dice.Sum(APDice, Math.Abs(AP)) : AP;
        }
        public virtual int CalcDamage(Wound wound, Model target, ShootingParams shootingParams)
        {
            return CalcDamage(Damage, DamageDice, DiceModes.Sum);
        }

        public virtual int GenerateShoots(int distance)
        {
            if (Type == WeaponTypes.Melee)
            {
                return 0;
            }

            if (distance > Range)
            {
                return 0;
            }

            int shoots = 0;
            int attacks = Attacks;

            if (Type == WeaponTypes.RapidFire && distance < Range / 2)
            {
                attacks *= 2;
            }

            if (AttackDice != 0)
            {
                shoots = Dice.Sum(AttackDice, attacks);
            }
            else
            {
                shoots = attacks;
            }

            return shoots;
        }
        public virtual Impact ImpactTest(Model attacker, ShootingParams shootingParams)
        {
            bool impacted = CalcImpacts(attacker.BS, shootingParams, out int roll, out int rollModified);

            return new Impact()
            {
                Attacker = attacker,
                Weapon = this,
                Impacted = impacted,
                Roll = roll,
                RollModified = rollModified,
            };
        }
        public virtual List<Wound> WoundTest(int t, ShootingParams shootingParams)
        {
            List<Wound> wounds = new List<Wound>();

            int s = CalcStrength();
            int toWoundRoll = CalcToWoundRoll(s, t);

            int res = Dice.D6();
            if (res == 1 && shootingParams.WoundingRerollOnes)
            {
                res = Dice.D6();
            }
            else if (res + shootingParams.WoundingModifiers < toWoundRoll)
            {
                if (shootingParams.WoundingRerollAll)
                {
                    res = Dice.D6();
                }
                else if (shootingParams.WoundingRerolls > 0)
                {
                    shootingParams.WoundingRerolls--;
                    res = Dice.D6();
                }
            }

            if (res + shootingParams.WoundingModifiers >= toWoundRoll)
            {
                wounds.Add(new Wound()
                {
                    Weapon = this,
                });
            }

            return wounds;
        }
    }

    /// <summary>
    /// Melta
    /// </summary>
    public class Melta : Weapon
    {
        public override int CalcDamage(Wound wound, Model target, ShootingParams shootingParams)
        {
            if (Range / 2 >= shootingParams.Distance)
            {
                return CalcDamage(Damage * 2, DamageDice, DiceModes.Max);
            }

            return base.CalcDamage(wound, target, shootingParams);
        }
    }

    /// <summary>
    /// Plasma Supercharge
    /// </summary>
    public class PlasmaSupercharge : Weapon
    {
        public override Impact ImpactTest(Model attacker, ShootingParams shootingParams)
        {
            var impact = base.ImpactTest(attacker, shootingParams);

            if (impact.Roll == 1)
            {
                impact.BearerDamage = BearerDamageTypes.Slain;
            }

            return impact;
        }
    }

    /// <summary>
    /// Flammer
    /// </summary>
    public class Flammer : Weapon
    {
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

    /// <summary>
    /// Shotgun
    /// </summary>
    public class Shotgun : Weapon
    {
        public override Impact ImpactTest(Model attacker, ShootingParams shootingParams)
        {
            if (Range / 2 >= shootingParams.Distance)
            {
                //+1 to impact at short range
                var nShootingParams = shootingParams.Clone();
                nShootingParams.ShootingModifiers++;

                return base.ImpactTest(attacker, nShootingParams);
            }

            return base.ImpactTest(attacker, shootingParams);
        }
    }
}
