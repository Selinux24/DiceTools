using System.Collections.Generic;

namespace DiceTools.Units.SpaceWolves
{
    public class LandSpeeders : SpaceWolvesUnit
    {
        public static LandSpeeders Create(LandSpeederTypes type, LandSpeederWeaponTypes heavyType, int count)
        {
            List<Model> models = new List<Model>();

            for (int i = 0; i < count; i++)
            {
                var weapons = SelectWeapons(type, heavyType);

                models.Add(CreateLandSpeeder(weapons));
            }

            return new LandSpeeders()
            {
                Name = "Land Speeders",
                Soldiers = models,
            };
        }

        private static List<Weapon> SelectWeapons(LandSpeederTypes type, LandSpeederWeaponTypes heavyType)
        {
            List<Weapon> weapons = new List<Weapon>();

            if (type == LandSpeederTypes.Default)
            {
                weapons.Add(Armory.CreateWeaponHeavyBolter());
            }
            else if (type == LandSpeederTypes.MeltaCannon)
            {
                weapons.Add(Armory.CreateWeaponMeltaCannon());
            }

            if (heavyType == LandSpeederWeaponTypes.AssaultCannon)
            {
                weapons.Add(Armory.CreateWeaponAssaultCannon());
            }
            else if (heavyType == LandSpeederWeaponTypes.HeavyFlammer)
            {
                weapons.Add(Armory.CreateWeaponHeavyFlammer());
            }
            else if (heavyType == LandSpeederWeaponTypes.TyphoonMissileLauncher)
            {
                weapons.Add(Armory.CreateWeaponTyphoonMissileLauncher());
            }

            return weapons;
        }

        public static Model CreateLandSpeeder(List<Weapon> weapons)
        {
            return new Model()
            {
                Name = "Land Speeder",
                WS = 3,
                BS = 3,
                S = 4,
                T = 5,
                W = 6,
                A = 2,
                Sv = 3,
                ISv = 0,
                Flyer = true,
                Weapons = weapons,
            };
        }
    }

    public enum LandSpeederTypes
    {
        Default,
        MeltaCannon,
    }

    public enum LandSpeederWeaponTypes
    {
        Node,
        AssaultCannon,
        HeavyFlammer,
        TyphoonMissileLauncher,
    }
}
