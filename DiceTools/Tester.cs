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
                OverKill = false,

                ShootingModifiers = 0,
                ShootingRerollUnmodifiedOnes = false,
                ShootingRerollUnmodifiedFails = false,
                ShootingRerollOnes = false,
                ShootingRerollFails = true,
                ShootingRerolls = 1,

                WoundingModifiers = 1,
                WoundingRerollUnmodifiedOnes = false,
                WoundingRerollUnmodifiedFails = false,
                WoundingRerollOnes = false,
                WoundingRerollFails = true,
                WoundingRerolls = 1,

                DamageReroll = true,
                PercentToRerollDamage = 45,
                DamageRerolls = 1,
            };

            Test(new UnitGen(), shootingParams, testCount);
        }

        private void Test(UnitGen unitGenerator, ShootingParams shootingParams, int testCount)
        {
            TestResults.Text = "Testing...";

            StringBuilder tests = new StringBuilder();

            string attackerName = null;
            string defenderName = null;

            int attackerWounds = 0;
            int defenderWounds = 0;

            int totalModels = 0;
            int totalModelsKilled = 0;

            int totalShoots = 0;
            int totalHits = 0;
            int totalWounds = 0;
            int totalDamage = 0;
            int totalGeneratedDamage = 0;
            int totalKills = 0;

            int maxDamage = 0;

            for (int i = 0; i < testCount; i++)
            {
                //Set units
                var attacker = unitGenerator.GetAttacker();
                var defender = unitGenerator.GetDefender();

                //Get model names
                attackerName = attacker.Name;
                defenderName = defender.Name;

                //Get model wounds counters
                attackerWounds = attacker.Soldiers.Sum(s => s.W);
                defenderWounds = defender.Soldiers.Sum(s => s.W);

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

                totalShoots += stats.Shoots;
                totalHits += stats.Hits;
                totalWounds += stats.Wounds;
                totalGeneratedDamage += stats.GeneratedDamage;
                totalDamage += stats.Damage;

                if (stats.GeneratedDamage > maxDamage)
                {
                    maxDamage = stats.GeneratedDamage;
                }

                tests.AppendLine($"{stats.Shoots:000} shoots : {stats.HitPercentage:000.00}% of hits | {stats.Hits:000} hits : {stats.WoundPercentage:000.00}% of wounds | {stats.GeneratedDamage:00}/{defenderWounds:00} Damage done | {modelsKilledString} {modelsKilled:00}/{models:00} Kills | Attacker lost {attackerWounds - attackerRemainWounds:00} wounds");
            }

            TestResults.Text =
                $"{testCount} tests - {attackerName} vs {defenderName}\r\n\r\n" +
                $"Medimum stats by test\r\n\r\n" +
                $"{totalShoots / (float)testCount:000} shoots : {totalHits / (float)totalShoots * 100f:000.00}% of hits | {totalHits / (float)testCount:000} hits : {totalWounds / (float)totalHits * 100f:000.00}% of wounds | {totalDamage / testCount:00}/{defenderWounds:00} Damage done |   {totalKills / (float)testCount * 100:00.0}% Kills | {maxDamage:00} Maximum wounds done\r\n\r\n" +
                $"All tests detail\r\n\r\n" +
                $"{tests}";
        }
    }
}
