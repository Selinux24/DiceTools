
namespace DiceTools
{
    public class Impact
    {
        public Model Attacker { get; set; }
        public Weapon Weapon { get; set; }
        public bool Impacted { get; set; }
        public bool Mortal { get; set; }
        public int Roll { get; set; }
        public int RollModified { get; set; }
        public BearerDamageTypes BearerDamage { get; set; } = BearerDamageTypes.None;

        /// <summary>
        /// Critical fail
        /// </summary>
        public bool CriticalFail
        {
            get
            {
                return Roll == 1 || RollModified == 1;
            }
        }
    }
}
