
namespace DiceTools
{
    /// <summary>
    /// Wound description
    /// </summary>
    public class Wound
    {
        /// <summary>
        /// The weapon who wounds
        /// </summary>
        public Weapon Weapon { get; set; }
        /// <summary>
        /// The modified wound roll
        /// </summary>
        public int ToWoundRoll { get; set; }
        /// <summary>
        /// Gets or sets whether the wound is mortal or not
        /// </summary>
        public bool Mortal { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="weapon">Weapon</param>
        /// <param name="roll">Modified wound roll</param>
        /// <param name="mortal">It's a mortal wound</param>
        public Wound(Weapon weapon, int roll, bool mortal)
        {
            Weapon = weapon;
            ToWoundRoll = roll;
            Mortal = mortal;
        }
    }
}
