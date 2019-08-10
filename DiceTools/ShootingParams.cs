
namespace DiceTools
{
    public class ShootingParams
    {
        public int Distance { get; set; }
        public bool SuperchargeWeapons { get; set; }

        public int ShootingModifiers { get; set; }
        public bool ShootingRerollOnes { get; set; }
        public bool ShootingRerollAll { get; set; }
        public int ShootingRerolls { get; set; }

        public int WoundingModifiers { get; set; }
        public bool WoundingRerollOnes { get; set; }
        public bool WoundingRerollAll { get; set; }
        public int WoundingRerolls { get; set; }

        public ShootingParams Clone()
        {
            return new ShootingParams()
            {
                Distance = Distance,
                SuperchargeWeapons = SuperchargeWeapons,

                ShootingModifiers = ShootingModifiers,
                ShootingRerollOnes = ShootingRerollOnes,
                ShootingRerollAll = ShootingRerollAll,
                ShootingRerolls = ShootingRerolls,

                WoundingModifiers = WoundingModifiers,
                WoundingRerollOnes = WoundingRerollOnes,
                WoundingRerollAll = WoundingRerollAll,
                WoundingRerolls = WoundingRerolls,
            };
        }
    }
}
