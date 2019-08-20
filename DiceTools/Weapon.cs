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
            rollModified = roll + shootingParams.ShootingModifiers;

            if (shootingParams.ShootingRerolls == 0)
            {
                return roll != 1 && rollModified >= bs;
            }

            bool reroll = false;
            if (roll == 1 && shootingParams.ShootingRerollUnmodifiedOnes)
            {
                //Reroll ones before modifiers
                reroll = true;
            }
            else if (roll < bs && shootingParams.ShootingRerollUnmodifiedFails)
            {
                //Reroll fails before modifiers
                reroll = true;
            }
            else if (rollModified == 1 && shootingParams.ShootingRerollOnes)
            {
                //Reroll ones after modifiers
                reroll = true;
            }
            else if (rollModified < bs && shootingParams.ShootingRerollFails)
            {
                //Reroll fails after modifiers
                reroll = true;
            }

            if (reroll && shootingParams.ShootingRerolls > 0)
            {
                roll = Dice.D6();
                rollModified = roll + shootingParams.ShootingModifiers;

                shootingParams.ShootingRerolls--;
            }

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
        public static int CalcDamage(ShootingParams shootingParams, int damageValue, int damageDice, DiceModes mode)
        {
            int totalDamage = 0;

            for (int i = 0; i < damageValue; i++)
            {
                int damage = damageDice != 0 ? Dice.D(damageDice, 1, mode) : damageValue;

                if (shootingParams.DamageRerolls == 0)
                {
                    totalDamage += damage;

                    continue;
                }

                float threshold = 100.0f * damage / damageDice;

                if (threshold < shootingParams.PercentToRerollDamage && shootingParams.DamageRerolls > 0)
                {
                    shootingParams.DamageRerolls--;

                    damage = damageDice != 0 ? Dice.D(damageDice, 1, mode) : damageValue;

                    totalDamage += damage;
                }
            }

            return totalDamage;
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
            return CalcDamage(shootingParams, Damage, DamageDice, DiceModes.Sum);
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

            int roll = Dice.D6();
            int rollModified = roll + shootingParams.WoundingModifiers;

            if (shootingParams.WoundingRerolls == 0 && roll != 1 && rollModified >= toWoundRoll)
            {
                Wound w = new Wound(this, rollModified, false);
                wounds.Add(w);
            }

            bool reroll = false;
            if (roll == 1 && shootingParams.WoundingRerollUnmodifiedOnes)
            {
                reroll = true;
            }
            else if (roll < toWoundRoll && shootingParams.WoundingRerollUnmodifiedFails)
            {
                reroll = true;
            }
            else if (rollModified == 1 && shootingParams.WoundingRerollOnes)
            {
                reroll = true;
            }
            else if (rollModified < toWoundRoll && shootingParams.WoundingRerollFails)
            {
                reroll = true;
            }

            if (reroll && shootingParams.WoundingRerolls > 0)
            {
                roll = Dice.D6();
                rollModified = roll + shootingParams.WoundingModifiers;

                shootingParams.WoundingRerolls--;
            }

            if (roll != 1 && rollModified >= toWoundRoll)
            {
                Wound w = new Wound(this, rollModified, false);
                wounds.Add(w);
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
                return CalcDamage(shootingParams, Damage * 2, DamageDice, DiceModes.Max);
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
