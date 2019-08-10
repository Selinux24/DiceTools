using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiceTools
{
    public partial class Tester : Form
    {
        public Tester()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int testCount = 1000;

            var shootingParams = new ShootingParams()
            {
                Distance = 12,

                SuperchargeWeapons = false,

                ShootingRerollOnes = false,
                WoundingRerollOnes = false,

                ShootingModifiers = 1,
                WoundingModifiers = 1,
            };

            Test(new UnitGen(), shootingParams, testCount);
        }

        private void Test(UnitGen unitGenerator, ShootingParams shootingParams, int testCount)
        {
            TestResults.Text = "Testing...";

            StringBuilder tests = new StringBuilder();

            string attackerName = null;
            string defenderName = null;

            int totalModels = 0;
            int totalModelsKilled = 0;

            int totalImpacts = 0;
            int totalHits = 0;
            int totalWounds = 0;
            int totalKills = 0;

            int maxLostWounds = 0;

            for (int i = 0; i < testCount; i++)
            {
                //Set units
                var attacker = unitGenerator.GetAttacker();
                var defender = unitGenerator.GetDefender();

                attackerName = attacker.Name;
                defenderName = defender.Name;

                //Get model wounds counters
                var attackerWounds = attacker.Soldiers.Sum(s => s.W);
                var defenderWounds = defender.Soldiers.Sum(s => s.W);

                //Do the shooting phase
                var stats = attacker.ShootingPhase(defender, shootingParams);

                //Refresh model wounds counters
                var attackerRemainWounds = attacker.Soldiers.Sum(s => s.W);
                var defenderRemainWounds = defender.Soldiers.Sum(s => s.W);

                var modelsKilledString = " ";
                if (defenderRemainWounds == 0)
                {
                    totalKills++;
                    modelsKilledString = "*";
                }

                //Models killed versus total models in unit
                var modelsKilled = defender.Soldiers.Count(s => s.W <= 0);
                var models = defender.Soldiers.Count;
                totalModels += models;
                totalModelsKilled += modelsKilled;

                var lostWounds = defenderWounds - defenderRemainWounds;
                if (lostWounds > maxLostWounds)
                {
                    maxLostWounds = lostWounds;
                }

                totalImpacts += stats.Impacts;
                totalHits += stats.Hits;
                totalWounds += lostWounds;

                tests.AppendLine($"{stats.Hits:000} hits : {stats.Hits / (float)stats.Impacts * 100f:000.00}% | {lostWounds:00}/{defenderWounds:00} Wounds done | {modelsKilledString} {modelsKilled:00}/{models:00} Kills | Attacker lost {attackerWounds - attackerRemainWounds:00} wounds");
            }

            TestResults.Text =
                $"{testCount} tests - {attackerName} vs {defenderName}\r\n\r\n" +
                $"Stats by test\r\n\r\n" +
                $"{totalHits / (float)testCount:000} hits : {totalHits / (float)totalImpacts * 100f:000.00}% | {totalWounds / (float)testCount:00.0}  Wounds done |   {totalKills / (float)testCount * 100:00.0}% Kills | {maxLostWounds:00} Maximum wounds done\r\n\r\n" +
                $"All tests\r\n\r\n" +
                $"{tests}";
        }
    }
}
