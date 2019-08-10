using System.Collections.Generic;

namespace DiceTools.Units.Orks
{
    public class MekGunz : OrkUnit
    {
        public static MekGunz Create(MekGunzTypes type, int count = 1)
        {
            List<Model> gunz = new List<Model>();

            for (int i = 0; i < count; i++)
            {
                Weapon weapon = null;
                switch (type)
                {
                    case MekGunzTypes.Bubblechukka:
                        weapon = Armory.CreateWeaponBubblechukka();
                        break;
                    case MekGunzTypes.KustomMegaKannon:
                        weapon = Armory.CreateWeaponKustomMegaKannon();
                        break;
                    case MekGunzTypes.SmashaGun:
                        weapon = Armory.CreateWeaponSmashaGun();
                        break;
                    case MekGunzTypes.TraktorKannon:
                        weapon = Armory.CreateWeaponTraktorKannon();
                        break;
                }

                gunz.Add(MekGun(weapon));
            }

            return new MekGunz()
            {
                Name = "Mek Gunz",
                Soldiers = gunz,
            };
        }

        public static Model MekGun(Weapon weapon)
        {
            return new Model()
            {
                Name = "Mek Gun",
                WS = 5,
                BS = 4,
                S = 2,
                T = 5,
                W = 6,
                A = 6,
                Sv = 5,
                ISv = 0,
                Weapons = new List<Weapon>() { weapon },
            };
        }

        public MekGunz() : base(true)
        {
            
        }
    }

    public enum MekGunzTypes
    {
        Bubblechukka,
        KustomMegaKannon,
        SmashaGun,
        TraktorKannon,
    }
}
