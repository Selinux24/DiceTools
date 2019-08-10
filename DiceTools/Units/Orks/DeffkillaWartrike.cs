using System.Collections.Generic;

namespace DiceTools.Units.Orks
{
    public class DeffkillaWartrike : OrkUnit
    {
        public static DeffkillaWartrike Create()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                Armory.CreateWeaponKillaJet(),
                Armory.CreateWeaponSnaggaKlaw(),
                Armory.CreateWeaponTwinBoomstick(),
                Armory.CreateWeaponTwinBoomstick(),
                Armory.CreateWeaponTwinBoomstick(),
            };

            return new DeffkillaWartrike()
            {
                Name = "Deffkilla Wartrike",
                Soldiers = new List<Model>() { CreateDeffkillaWartrike(weapons) }
            };
        }

        public static Model CreateDeffkillaWartrike(List<Weapon> weapons)
        {
            return new Model()
            {
                Name = "Deffkilla Wartrike",
                WS = 2,
                BS = 5,
                S = 5,
                T = 6,
                W = 8,
                A = 5,
                Sv = 4,
                ISv = 0,
                Weapons = weapons,
            };
        }

        public DeffkillaWartrike() : base(true)
        {

        }
    }
}
