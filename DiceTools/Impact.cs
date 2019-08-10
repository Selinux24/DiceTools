
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
        public BearerDamageTypes BearerDamage { get; set; }
    }
}
