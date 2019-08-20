
namespace DiceTools
{
    public class ShootingPhaseStats
    {
        public static ShootingPhaseStats operator +(ShootingPhaseStats s1, ShootingPhaseStats s2)
        {
            return new ShootingPhaseStats()
            {
                Shoots = s1.Shoots + s2.Shoots,
                Hits = s1.Hits + s2.Hits,
                Wounds = s1.Wounds + s2.Wounds,
                GeneratedDamage = s1.GeneratedDamage + s2.GeneratedDamage,
                Damage = s1.Damage + s2.Damage,
            };
        }

        public int Shoots { get; set; }
        public int Hits { get; set; }
        public int Wounds { get; set; }
        public int GeneratedDamage { get; set; }
        public int Damage { get; set; }


        public float HitPercentage
        {
            get
            {
                if (Shoots > 0)
                {
                    return Hits / (float)Shoots * 100f;
                }
                else
                {
                    return 0f;
                }
            }
        }

        public float WoundPercentage
        {
            get
            {
                if (Hits > 0)
                {
                    return Wounds / (float)Hits * 100f;
                }
                else
                {
                    return 0f;
                }
            }
        }
    }
}
