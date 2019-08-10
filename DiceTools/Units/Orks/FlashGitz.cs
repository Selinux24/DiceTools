using System.Collections.Generic;
using System.Linq;

namespace DiceTools.Units.Orks
{
    public class FlashGitz : OrkUnit
    {
        public static FlashGitz Create(bool kapt, int boyz, int ammoRunts)
        {
            List<Model> soldiers = new List<Model>();

            if (kapt)
            {
                soldiers.Add(CreateFlashGitzKaptin());
            }

            for (int i = 0; i < boyz; i++)
            {
                soldiers.Add(CreateFlashGitz());
            }

            for (int i = 0; i < ammoRunts; i++)
            {
                soldiers.Add(CreateAmmoRunt());
            }

            return new FlashGitz()
            {
                Name = "Flash Gitz",
                Soldiers = soldiers,
            };
        }

        public static Model CreateFlashGitzKaptin()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponSnazzgun(),
            };

            return new Model()
            {
                Name = "Flash Gitz Kaptin",
                WS = 3,
                BS = 3,
                S = 5,
                T = 4,
                W = 2,
                A = 3,
                Sv = 4,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateFlashGitz()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponSnazzgun(),
            };

            return new Model()
            {
                Name = "Flash Gitz",
                WS = 3,
                BS = 4,
                S = 5,
                T = 4,
                W = 2,
                A = 3,
                Sv = 4,
                ISv = 0,
                Weapons = weapons,
            };
        }
        public static Model CreateAmmoRunt()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponGrotGun(),
            };

            return new Model()
            {
                Name = "Ammo Runt",
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

        public FlashGitz() : base(true)
        {
            
        }

        public override ShootingPhaseStats ShootingPhase(Unit target, ShootingParams shootingParams)
        {
            //One reroll per alive ammo runt
            shootingParams.ShootingRerolls = this.Soldiers.Count(c => c.W > 0 && c.Name == "Ammo Runt");
            var stats = base.ShootingPhase(target, shootingParams);

            int reShoot = Dice.D6();
            if (reShoot == 6)
            {
                //One reroll per alive ammo runt
                shootingParams.ShootingRerolls = this.Soldiers.Count(c => c.W > 0 && c.Name == "Ammo Runt");
                stats += base.ShootingPhase(target, shootingParams);
            }

            return stats;
        }
    }
}
