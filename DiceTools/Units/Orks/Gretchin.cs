using System.Collections.Generic;
using System.Linq;

namespace DiceTools.Units.Orks
{
    public class Gretchin : OrkUnit
    {
        public static Gretchin Create(int boyz)
        {
            List<Model> soldiers = new List<Model>();

            for (int i = 0; i < boyz; i++)
            {
                soldiers.Add(CreateGretchin());
            }

            return new Gretchin()
            {
                Name = "Gretchin",
                Soldiers = soldiers,
            };
        }

        public static Model CreateGretchin()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponGrotBlaster()
            };

            return new Model()
            {
                Name = "Gretchin",
                WS = 5,
                BS = 4,
                S = 2,
                T = 2,
                W = 1,
                A = 1,
                Sv = 6,
                ISv = 0,
                Weapons = weapons,
            };
        }

        public Gretchin() : base(true)
        {

        }

        public override List<Impact> ResolveShoots(List<Shoot> shoots, ShootingParams shootingParams)
        {
            if (Soldiers.Count(s => s.W > 0) >= 20)
            {
                var nShootingParams = shootingParams.Clone();
                nShootingParams.ShootingModifiers++;

                return base.ResolveShoots(shoots, nShootingParams);
            }

            return base.ResolveShoots(shoots, shootingParams);
        }
    }
}
