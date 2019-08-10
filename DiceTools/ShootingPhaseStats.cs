
namespace DiceTools
{
    public class ShootingPhaseStats
    {
        public static ShootingPhaseStats operator +(ShootingPhaseStats s1, ShootingPhaseStats s2)
        {
            return new ShootingPhaseStats()
            {
                Impacts = s1.Impacts + s2.Impacts,
                Hits = s1.Hits + s2.Hits,
            };
        }

        public int Impacts { get; set; }
        public int Hits { get; set; }
    }
}
