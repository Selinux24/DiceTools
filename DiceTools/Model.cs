using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceTools
{
    public class Model
    {
        public string Name { get; set; }
        public int WS { get; set; }
        public int BS { get; set; }
        public int S { get; set; }
        public int T { get; set; }
        public int W { get; set; }
        public int A { get; set; }
        public int Sv { get; set; }
        public int ISv { get; set; }
        public bool Flyer { get; set; }
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();

        public virtual IEnumerable<Weapon> SelectShootingWeapons()
        {
            //No pistols, melee or grenades
            var weapons = Weapons.Where(w => w.Type > WeaponTypes.Pistol);
            if (!weapons.Any())
            {
                //No weapons, then pistols
                weapons = Weapons.Where(w => w.Type == WeaponTypes.Pistol);
            }

            foreach (var weapon in weapons)
            {
                weapon.Initialize();
            }

            return weapons;
        }
        public virtual bool SaveTest(Wound wound)
        {
            if (wound.Mortal)
            {
                return false;
            }

            var ap = wound.Weapon.CalcAP();

            int toSaveRoll = Sv - ap;
            if (ISv != 0)
            {
                toSaveRoll = Math.Min(toSaveRoll, ISv);
            }

            //Save roll
            var saveRoll = Dice.D6();

            return saveRoll >= toSaveRoll;
        }
        public virtual void Damage(int damage)
        {
            W = Math.Max(0, W - damage);
        }
    }
}
