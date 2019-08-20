
namespace DiceTools
{
    /// <summary>
    /// Shooting phase parameters
    /// </summary>
    public class ShootingParams
    {
        /// <summary>
        /// Distance from shooter to target for all models in the unit
        /// </summary>
        public int Distance { get; set; }

        /// <summary>
        /// Use the super charge weapon profile if available
        /// </summary>
        public bool SuperchargeWeapons { get; set; }
        /// <summary>
        /// Try to make the maximum damage
        /// </summary>
        /// <remarks>For example, firing with supercharged hellblasters, scoring a 2 (failed), reroll the 2 if posible instead of keeping the model safe</remarks>
        public bool OverKill { get; set; }

        /// <summary>
        /// To hit modifiers total (bonus and minus)
        /// </summary>
        public int ShootingModifiers { get; set; }
        /// <summary>
        /// The shooters reroll hit results of one after modifiers
        /// </summary>
        public bool ShootingRerollOnes { get; set; }
        /// <summary>
        /// The shooters reroll hit results of one before modifiers
        /// </summary>
        public bool ShootingRerollUnmodifiedOnes { get; set; }
        /// <summary>
        /// The shooters reroll failed hit results after modifiers
        /// </summary>
        public bool ShootingRerollFails { get; set; }
        /// <summary>
        /// The shooters reroll failed hit results before modifiers
        /// </summary>
        public bool ShootingRerollUnmodifiedFails { get; set; }
        /// <summary>
        /// Number of available hit rerolls
        /// </summary>
        /// <remarks>-1 for all rerolls</remarks>
        public int ShootingRerolls { get; set; }

        /// <summary>
        /// To wound modifiers total (bonus and minus)
        /// </summary>
        public int WoundingModifiers { get; set; }
        /// <summary>
        /// Shooter reroll wound results of one after modifiers
        /// </summary>
        public bool WoundingRerollOnes { get; set; }
        /// <summary>
        /// Shooter reroll wound results of one before modifiers
        /// </summary>
        public bool WoundingRerollUnmodifiedOnes { get; set; }
        /// <summary>
        /// Shooter reroll failed wound results after modifiers
        /// </summary>
        public bool WoundingRerollFails { get; set; }
        /// <summary>
        /// Shooter reroll failed wound results before modifiers
        /// </summary>
        public bool WoundingRerollUnmodifiedFails { get; set; }
        /// <summary>
        /// Number of available wound rerolls
        /// </summary>
        /// <remarks>-1 for all rerolls</remarks>
        public int WoundingRerolls { get; set; }

        /// <summary>
        /// Shooter reroll damage results
        /// </summary>
        public bool DamageReroll { get; set; }
        /// <summary>
        /// Máximum fail percent to make a damage reroll
        /// </summary>
        /// <remarks>
        /// If percent is set to 0, always reroll
        /// If percent is set to 50, in a 1D6 damage roll, results of 1, 2 and 3 will be rerolled
        /// If percent is set to 100, no rerolls
        /// </remarks>
        public float PercentToRerollDamage { get; set; } = 100;
        /// <summary>
        /// Number of available damage rerolls
        /// </summary>
        /// <remarks>-1 for all rerolls</remarks>
        public int DamageRerolls { get; set; }

        /// <summary>
        /// Clones the shooting parameters
        /// </summary>
        /// <returns>Gets a new shooting parameters instance with the same data</returns>
        public ShootingParams Clone()
        {
            return new ShootingParams()
            {
                Distance = Distance,

                SuperchargeWeapons = SuperchargeWeapons,
                OverKill = OverKill,

                ShootingModifiers = ShootingModifiers,
                ShootingRerollOnes = ShootingRerollOnes,
                ShootingRerollUnmodifiedOnes = ShootingRerollUnmodifiedOnes,
                ShootingRerollFails = ShootingRerollFails,
                ShootingRerollUnmodifiedFails = ShootingRerollUnmodifiedFails,
                ShootingRerolls = ShootingRerolls,

                WoundingModifiers = WoundingModifiers,
                WoundingRerollOnes = WoundingRerollOnes,
                WoundingRerollUnmodifiedOnes = WoundingRerollUnmodifiedOnes,
                WoundingRerollFails = WoundingRerollFails,
                WoundingRerollUnmodifiedFails = WoundingRerollUnmodifiedFails,
                WoundingRerolls = WoundingRerolls,

                DamageReroll = DamageReroll,
                PercentToRerollDamage = PercentToRerollDamage,
                DamageRerolls = DamageRerolls,
            };
        }
    }
}
