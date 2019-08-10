using System.Collections.Generic;

namespace DiceTools.Units.SpaceWolves
{
    public class Razorback : SpaceWolvesUnit
    {
        public static Razorback Create(RazorBackTypes type, bool stormBolter, bool hunterMissile)
        {
            List<Weapon> weapons = new List<Weapon>();

            if (stormBolter)
            {
                weapons.Add(Armory.CreateWeaponStormBolter());
            }

            if (hunterMissile)
            {
                weapons.Add(Armory.CreateWeaponHunterKillerMissile());
            }

            if (type == RazorBackTypes.TwinAssaultCannon)
            {
                weapons.Add(Armory.CreateWeaponTwinAssaultCannon());
            }
            else if (type == RazorBackTypes.TwinLassCannon)
            {
                weapons.Add(Armory.CreateWeaponTwinLassCannon());
            }
            else if (type == RazorBackTypes.LasscannonAndTwinPlasmaGun)
            {
                weapons.Add(Armory.CreateWeaponLassCannon());
                weapons.Add(Armory.CreateWeaponTwinPlasmaGun());
            }
            else if (type == RazorBackTypes.TwinHeavyBolter)
            {
                weapons.Add(Armory.CreateWeaponTwinHeavyBolter());
            }

            var rb = CreateRazorback(weapons);

            return new Razorback()
            {
                Name = "Razorback",
                Soldiers = new List<Model>() { rb },
            };
        }

        public static Model CreateRazorback(List<Weapon> weapons)
        {
            return new Model()
            {
                Name = "Razorback",
                WS = 6,
                BS = 3,
                S = 6,
                T = 7,
                W = 10,
                A = 3,
                Sv = 3,
                ISv = 0,
                Weapons = weapons,
            };
        }
    }

    public enum RazorBackTypes
    {
        TwinHeavyBolter,
        TwinAssaultCannon,
        TwinLassCannon,
        LasscannonAndTwinPlasmaGun
    }
}
