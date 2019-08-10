using System.Collections.Generic;
using System.Linq;

namespace DiceTools.Units.Orks
{
    public class Gunwagon : OrkUnit
    {
        public static Gunwagon Create(GunwagonTypes type, int bigShootas)
        {
            List<Weapon> weapons = new List<Weapon>();

            switch (type)
            {
                case GunwagonTypes.KillKannon:
                    weapons.Add(Armory.CreateWeaponKillKannon());
                    break;
                case GunwagonTypes.ZzapGun:
                    weapons.Add(Armory.CreateWeaponZzapGun());
                    break;
                default:
                    weapons.Add(Armory.CreateWeaponKannon());
                    break;
            }

            for (int i = 0; i < bigShootas; i++)
            {
                weapons.Add(Armory.CreateWeaponBigShoota());
            }

            return new Gunwagon()
            {
                Name = "Gunwagon",
                Soldiers = new List<Model>() { CreateGunwagon(weapons) }
            };
        }

        public static Model CreateGunwagon(List<Weapon> weapons)
        {
            return new Model()
            {
                Name = "Gunwagon",
                WS = 5,
                BS = 5,
                S = 8,
                T = 8,
                W = 16,
                A = 6,
                Sv = 4,
                ISv = 0,
                Weapons = weapons,
            };
        }

        public Gunwagon() : base(true)
        {

        }

        public override ShootingPhaseStats ShootingPhase(Unit target, ShootingParams shootingParams)
        {
            var stats = base.ShootingPhase(target, shootingParams);

            //Periscope
            if (target.Soldiers.Any(s => s.W > 0))
            {
                stats += base.ShootingPhase(target, shootingParams);
            }

            return stats;
        }
    }

    public enum GunwagonTypes
    {
        Default,
        KillKannon,
        ZzapGun,
    }
}
