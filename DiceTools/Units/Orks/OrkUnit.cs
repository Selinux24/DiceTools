using System.Collections.Generic;
using System.Linq;

namespace DiceTools.Units.Orks
{
    public abstract class OrkUnit : Unit
    {
        public bool DakkaDakkaDakka { get; set; }

        protected OrkUnit(bool dakka) : base()
        {
            DakkaDakkaDakka = dakka;
        }

        public override List<Impact> ResolveShoots(List<Shoot> shoots, ShootingParams shootingParams)
        {
            List<Impact> impacts = base.ResolveShoots(shoots, shootingParams);

            if (DakkaDakkaDakka)
            {
                //Dakka dakka dakka!!
                var dakkaImpacts = impacts.Where(i => i.Roll == 6);
                if (dakkaImpacts.Any())
                {
                    List<Shoot> dakkaShoots = new List<Shoot>();

                    foreach (var dakkaImpact in dakkaImpacts)
                    {
                        dakkaShoots.Add(new Shoot()
                        {
                            Attacker = dakkaImpact.Attacker,
                            Weapon = dakkaImpact.Weapon,
                            Attacks = 1,
                        });
                    }

                    impacts.AddRange(base.ResolveShoots(dakkaShoots, shootingParams));
                }
            }

            return impacts;
        }
    }
}
