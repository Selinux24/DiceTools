using System.Collections.Generic;
using System.Linq;

namespace DiceTools.Units.Orks
{
    public class BurnaBoyz : OrkUnit
    {
        public static BurnaBoyz Create(int spanners, int boyz)
        {
            List<Model> soldiers = new List<Model>();

            for (int i = 0; i < spanners; i++)
            {
                soldiers.Add(CreateSpanner());
            }

            for (int i = 0; i < boyz; i++)
            {
                soldiers.Add(CreateBurnaBoy());
            }

            return new BurnaBoyz()
            {
                Name = "Burna Boyz",
                Soldiers = soldiers,
            };
        }

        public static Model CreateSpanner()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponKustomMegaBlasta(),
            };

            return new Model()
            {
                Name = "Spanner",
                WS = 3,
                BS = 5,
                S = 4,
                T = 4,
                W = 1,
                A = 2,
                Sv = 6,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateBurnaBoy()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponBurna(),
            };

            return new Model()
            {
                Name = "Burna Boy",
                WS = 3,
                BS = 5,
                S = 4,
                T = 4,
                W = 1,
                A = 2,
                Sv = 6,
                ISv = 0,
                Weapons = weapons,
            };
        }

        public BurnaBoyz() : base(true)
        {
            
        }

        public override List<Shoot> GenerateShoots(ShootingParams shootingParams)
        {
            var attackingSoldiers = this.Soldiers.Where(s => s.W > 0);

            int burnaShoots = 0;
            var burnas = attackingSoldiers.Where(s => s.Name == "Burna Boy");
            if (burnas.Any())
            {
                //Generate fixed impacts per Burna
                burnaShoots = burnas.First().Weapons[0].GenerateShoots(shootingParams.Distance);
            }

            List<Shoot> shoots = new List<Shoot>();

            foreach (var soldier in attackingSoldiers)
            {
                if (soldier.Name != "Burna Boy")
                {
                    shoots.AddRange(GenerateShoots(soldier, shootingParams));
                }
                else
                {
                    shoots.Add(new Shoot()
                    {
                        Attacker = soldier,
                        Weapon = soldier.Weapons[0],
                        Attacks = burnaShoots,
                    });
                }
            }

            return shoots;
        }
    }
}
