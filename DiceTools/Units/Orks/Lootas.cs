using System.Collections.Generic;
using System.Linq;

namespace DiceTools.Units.Orks
{
    public class Lootas : OrkUnit
    {
        public static Lootas Create(int spanners, int lootas)
        {
            List<Model> soldiers = new List<Model>();

            for (int i = 0; i < spanners; i++)
            {
                soldiers.Add(CreateSpanner());
            }

            for (int i = 0; i < lootas; i++)
            {
                soldiers.Add(CreateLoota());
            }

            return new Lootas()
            {
                Name = "Lootas",
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
        public static Model CreateLoota()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponDeffgun(),
            };

            return new Model()
            {
                Name = "Loota",
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

        public Lootas() : base(true)
        {
            
        }

        public override List<Shoot> GenerateShoots(ShootingParams shootingParams)
        {
            var attackingSoldiers = this.Soldiers.Where(s => s.W > 0);

            int lootaShoots = 0;
            var lootas = attackingSoldiers.Where(s => s.Name == "Loota");
            if (lootas.Any())
            {
                //Generate fixed impacts per Loota
                lootaShoots = lootas.First().Weapons[0].GenerateShoots(shootingParams.Distance);
            }

            List<Shoot> shoots = new List<Shoot>();

            foreach (var soldier in attackingSoldiers)
            {
                if (soldier.Name != "Loota")
                {
                    shoots.AddRange(GenerateShoots(soldier, shootingParams));
                }
                else
                {
                    shoots.Add(new Shoot()
                    {
                        Attacker = soldier,
                        Weapon = soldier.Weapons[0],
                        Attacks = lootaShoots,
                    });
                }
            }

            return shoots;
        }
    }
}
