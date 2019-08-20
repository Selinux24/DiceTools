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

            var unitsAttacker = UnitGen.ListUnits();
            var unitsTargets = UnitGen.ListUnits();

            cbUnitAttacker.Items.AddRange(unitsAttacker.ToArray());
            cbUnitTarget.Items.AddRange(unitsTargets.ToArray());

            LoadShootingParams(new ShootingParams() { Distance = 24 });
        }

        private void LoadShootingParams(ShootingParams shootingParams)
        {
            txtSPDistance.Text = $"{shootingParams.Distance}";

            cbSPSupercharge.Checked = shootingParams.SuperchargeWeapons;
            cbSPOverkill.Checked = shootingParams.OverKill;

            txtSPToHitModifiers.Text = $"{shootingParams.ShootingModifiers}";
            cbSPToHitRerollUOnes.Checked = shootingParams.ShootingRerollUnmodifiedOnes;
            cbSPToHitRerollUFails.Checked = shootingParams.ShootingRerollUnmodifiedFails;
            cbSPToHitRerollOnes.Checked = shootingParams.ShootingRerollOnes;
            cbSPToHitRerollFails.Checked = shootingParams.ShootingRerollFails;
            txtSPToHitRerolls.Text = $"{shootingParams.ShootingRerolls}";

            txtSPToWoundModifiers.Text = $"{shootingParams.WoundingModifiers}";
            cbSPToWoundRerollUOnes.Checked = shootingParams.WoundingRerollUnmodifiedOnes;
            cbSPToWoundRerollUFails.Checked = shootingParams.WoundingRerollUnmodifiedFails;
            cbSPToWoundRerollOnes.Checked = shootingParams.WoundingRerollOnes;
            cbSPToWoundRerollFails.Checked = shootingParams.WoundingRerollFails;
            txtSPToWoundRerolls.Text = $"{shootingParams.WoundingRerolls}";

            cbSPToDamageReroll.Checked = shootingParams.DamageReroll;
            txtSPToDamageThreshold.Text = $"{shootingParams.PercentToRerollDamage}";
            txtSPToDamageRerolls.Text = $"{shootingParams.DamageRerolls}";
        }

        private bool ReadShootingParams(out ShootingParams shootingParams)
        {
            StringBuilder sb = new StringBuilder();

            string distanceError = "Write a valid distance number (positive integer)";
            string toHitModifiersError = "Write a valid to hit modifiers number (integer)";
            string toHitRerollsError = "Write a valid to hit number of rerolls (integer, -1 for all rolls)";
            string toWoundModifiersError = "Write a valid to wound modifiers number (integer)";
            string toWoundRerollsError = "Write a valid to wound number of rerolls (integer, -1 for all rolls)";
            string toDamageThresholdError = "Write a valid damage reroll threshold number (positive integer from 0 to 100)";
            string toDamageRerollsError = "Write a valid damage number of rerolls (integer, -1 for all rolls)";

            if (!int.TryParse(txtSPDistance.Text, out int distance))
            {
                sb.AppendLine(distanceError);
            }
            else if (distance <= 0)
            {
                sb.AppendLine(distanceError);
            }

            if (!int.TryParse(txtSPToHitModifiers.Text, out int shootingModifiers))
            {
                sb.AppendLine(toHitModifiersError);
            }

            if (!int.TryParse(txtSPToHitRerolls.Text, out int shootingRerolls))
            {
                sb.AppendLine(toHitRerollsError);
            }
            else if (shootingRerolls < -1)
            {
                sb.AppendLine(toHitRerollsError);
            }

            if (!int.TryParse(txtSPToWoundModifiers.Text, out int woundingModifiers))
            {
                sb.AppendLine(toWoundModifiersError);
            }

            if (!int.TryParse(txtSPToWoundRerolls.Text, out int woundingRerolls))
            {
                sb.AppendLine(toWoundRerollsError);
            }
            else if (woundingRerolls < -1)
            {
                sb.AppendLine(toWoundRerollsError);
            }

            if (!int.TryParse(txtSPToDamageThreshold.Text, out int damageThreshold))
            {
                sb.AppendLine(toDamageThresholdError);
            }
            else if (damageThreshold < 0 || damageThreshold > 100)
            {
                sb.AppendLine(toDamageThresholdError);
            }

            if (!int.TryParse(txtSPToDamageRerolls.Text, out int damageRerolls))
            {
                sb.AppendLine(toDamageRerollsError);
            }
            else if (damageRerolls < -1)
            {
                sb.AppendLine(toDamageRerollsError);
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());

                shootingParams = null;

                return false;
            }

            shootingParams = new ShootingParams()
            {
                Distance = distance,

                SuperchargeWeapons = cbSPSupercharge.Checked,
                OverKill = cbSPOverkill.Checked,

                ShootingModifiers = shootingModifiers,
                ShootingRerollUnmodifiedOnes = cbSPToHitRerollUOnes.Checked,
                ShootingRerollUnmodifiedFails = cbSPToHitRerollUFails.Checked,
                ShootingRerollOnes = cbSPToHitRerollOnes.Checked,
                ShootingRerollFails = cbSPToHitRerollFails.Checked,
                ShootingRerolls = shootingRerolls,

                WoundingModifiers = woundingModifiers,
                WoundingRerollUnmodifiedOnes = cbSPToWoundRerollUOnes.Checked,
                WoundingRerollUnmodifiedFails = cbSPToWoundRerollUFails.Checked,
                WoundingRerollOnes = cbSPToWoundRerollOnes.Checked,
                WoundingRerollFails = cbSPToWoundRerollFails.Checked,
                WoundingRerolls = woundingRerolls,

                DamageReroll = cbSPToDamageReroll.Checked,
                PercentToRerollDamage = damageThreshold,
                DamageRerolls = damageRerolls,
            };

            return true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int testCount = 1000;

            if (ReadShootingParams(out var shootingParams))
            {
                Test(new UnitGen(), shootingParams, testCount);
            }
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
