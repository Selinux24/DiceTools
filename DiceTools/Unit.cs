using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceTools
{
    public class Unit
    {
        public string Name { get; set; }
        public List<Model> Soldiers { get; set; } = new List<Model>();

        public virtual ShootingPhaseStats ShootingPhase(Unit target, ShootingParams shootingParams)
        {
            ShootingPhaseStats stats = new ShootingPhaseStats();

            var shoots = GenerateShoots(shootingParams);
            if (shoots.Any())
            {
                var impacts = ResolveShoots(shoots, shootingParams);
                if (impacts.Any())
                {
                    stats.Impacts += impacts.Count;
                    stats.Hits += impacts.Count(i => i.Impacted);

                    var targetSoldiers = target.Soldiers.Where(s => s.W > 0);

                    ResolveWounds(impacts, targetSoldiers, shootingParams);

                    ResolveBearerWounds(impacts);
                }
            }

            return stats;
        }
        public virtual List<Shoot> GenerateShoots(ShootingParams shootingParams)
        {
            List<Shoot> shoots = new List<Shoot>();

            var attackingSoldiers = this.Soldiers.Where(s => s.W > 0);
            if (attackingSoldiers.Any())
            {
                foreach (var soldier in attackingSoldiers)
                {
                    shoots.AddRange(GenerateShoots(soldier, shootingParams));
                }
            }

            return shoots;
        }
        public virtual List<Shoot> GenerateShoots(Model soldier, ShootingParams shootingParams)
        {
            List<Shoot> shoots = new List<Shoot>();

            var weapons = soldier.SelectShootingWeapons();
            if (weapons.Any())
            {
                foreach (var cweapon in weapons)
                {
                    var weapon = shootingParams.SuperchargeWeapons ? cweapon.SuperchargeProfile ?? cweapon : cweapon;

                    int count = weapon.GenerateShoots(shootingParams.Distance);

                    shoots.Add(new Shoot()
                    {
                        Attacker = soldier,
                        Weapon = weapon,
                        Attacks = count,
                    });
                }
            }

            return shoots;
        }
        public virtual List<Impact> ResolveShoots(List<Shoot> shoots, ShootingParams shootingParams)
        {
            List<Impact> impacts = new List<Impact>();

            foreach (var shoot in shoots)
            {
                for (int i = 0; i < shoot.Attacks; i++)
                {
                    impacts.Add(shoot.Weapon.ImpactTest(shoot.Attacker, shootingParams));
                }
            }

            return impacts;
        }
        public virtual void ResolveWounds(List<Impact> impacts, IEnumerable<Model> targets, ShootingParams shootingParams)
        {
            //Resolve wounds
            foreach (var impact in impacts.Where(i => i.Impacted))
            {
                //Get max T
                var maxT = targets
                    .Where(s => s.W > 0)
                    .OrderByDescending(s => s.T)
                    .Select(s => s.T)
                    .FirstOrDefault();

                if (maxT == 0)
                {
                    //No targets
                    break;
                }

                var wounds = impact.Weapon.WoundTest(maxT, shootingParams);
                if (wounds.Any())
                {
                    //Find target model
                    var activeTarget = targets
                        .Where(s => s.W > 0)
                        .OrderBy(s => s.W)
                        .FirstOrDefault();

                    foreach (var wound in wounds)
                    {
                        //Save roll
                        var saved = activeTarget.SaveTest(wound);
                        if (!saved)
                        {
                            //Not saved
                            var damage = impact.Weapon.CalcDamage(wound, activeTarget, shootingParams);

                            //Set damage to target
                            activeTarget.Damage(damage);
                        }
                    }
                }
            }
        }
        public virtual void ResolveBearerWounds(List<Impact> impacts)
        {
            var bearerWounds = impacts.Where(i => i.BearerDamage != BearerDamageTypes.None);
            if (bearerWounds.Any())
            {
                //Gets affected models
                var models = bearerWounds.Select(i => i.Attacker).Distinct();
                foreach (var model in models)
                {
                    //Get model maximum bearer wounds
                    var maxWound = bearerWounds
                        .Where(i => i.Attacker == model)
                        .Select(i => i.BearerDamage)
                        .Max();

                    if (maxWound == BearerDamageTypes.FirstWoundOnly)
                    {
                        model.Damage(1);
                    }
                    else if (maxWound == BearerDamageTypes.Slain)
                    {
                        model.Damage(model.W);
                    }
                    else if (maxWound == BearerDamageTypes.OneWound)
                    {
                        var wounds = bearerWounds
                            .Count(i => i.Attacker == model && i.BearerDamage == BearerDamageTypes.OneWound);

                        model.Damage(wounds);
                    }
                }
            }
        }

        public virtual void Attack(Unit target)
        {
            throw new NotImplementedException();
        }
    }
}
