namespace DiceTools
{
    partial class Tester
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButTest = new System.Windows.Forms.Button();
            this.TestResults = new System.Windows.Forms.TextBox();
            this.grShootingParams = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSPDistance = new System.Windows.Forms.TextBox();
            this.cbSPSupercharge = new System.Windows.Forms.CheckBox();
            this.cbSPOverkill = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSPToHitModifiers = new System.Windows.Forms.TextBox();
            this.cbSPToHitRerollUOnes = new System.Windows.Forms.CheckBox();
            this.cbSPToHitRerollUFails = new System.Windows.Forms.CheckBox();
            this.cbSPToHitRerollOnes = new System.Windows.Forms.CheckBox();
            this.cbSPToHitRerollFails = new System.Windows.Forms.CheckBox();
            this.grSPToHit = new System.Windows.Forms.GroupBox();
            this.txtSPToHitRerolls = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grSPToWound = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSPToWoundRerolls = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSPToWoundModifiers = new System.Windows.Forms.TextBox();
            this.cbSPToWoundRerollFails = new System.Windows.Forms.CheckBox();
            this.cbSPToWoundRerollUOnes = new System.Windows.Forms.CheckBox();
            this.cbSPToWoundRerollOnes = new System.Windows.Forms.CheckBox();
            this.cbSPToWoundRerollUFails = new System.Windows.Forms.CheckBox();
            this.grSPToDamage = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSPToDamageRerolls = new System.Windows.Forms.TextBox();
            this.cbSPToDamageReroll = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSPToDamageThreshold = new System.Windows.Forms.TextBox();
            this.cbUnitAttacker = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbUnitTarget = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grShootingParams.SuspendLayout();
            this.grSPToHit.SuspendLayout();
            this.grSPToWound.SuspendLayout();
            this.grSPToDamage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButTest
            // 
            this.ButTest.Location = new System.Drawing.Point(750, 254);
            this.ButTest.Name = "ButTest";
            this.ButTest.Size = new System.Drawing.Size(75, 23);
            this.ButTest.TabIndex = 0;
            this.ButTest.Text = "Test";
            this.ButTest.UseVisualStyleBackColor = true;
            this.ButTest.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TestResults
            // 
            this.TestResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestResults.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestResults.Location = new System.Drawing.Point(12, 283);
            this.TestResults.Multiline = true;
            this.TestResults.Name = "TestResults";
            this.TestResults.ReadOnly = true;
            this.TestResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TestResults.Size = new System.Drawing.Size(1009, 195);
            this.TestResults.TabIndex = 1;
            this.TestResults.WordWrap = false;
            // 
            // grShootingParams
            // 
            this.grShootingParams.Controls.Add(this.grSPToDamage);
            this.grShootingParams.Controls.Add(this.grSPToWound);
            this.grShootingParams.Controls.Add(this.grSPToHit);
            this.grShootingParams.Controls.Add(this.cbSPOverkill);
            this.grShootingParams.Controls.Add(this.cbSPSupercharge);
            this.grShootingParams.Controls.Add(this.txtSPDistance);
            this.grShootingParams.Controls.Add(this.label1);
            this.grShootingParams.Location = new System.Drawing.Point(12, 12);
            this.grShootingParams.Name = "grShootingParams";
            this.grShootingParams.Size = new System.Drawing.Size(1009, 236);
            this.grShootingParams.TabIndex = 2;
            this.grShootingParams.TabStop = false;
            this.grShootingParams.Text = "Shooting Phase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance";
            // 
            // txtSPDistance
            // 
            this.txtSPDistance.Location = new System.Drawing.Point(101, 22);
            this.txtSPDistance.Name = "txtSPDistance";
            this.txtSPDistance.Size = new System.Drawing.Size(100, 20);
            this.txtSPDistance.TabIndex = 1;
            // 
            // cbSPSupercharge
            // 
            this.cbSPSupercharge.AutoSize = true;
            this.cbSPSupercharge.Location = new System.Drawing.Point(233, 24);
            this.cbSPSupercharge.Name = "cbSPSupercharge";
            this.cbSPSupercharge.Size = new System.Drawing.Size(88, 17);
            this.cbSPSupercharge.TabIndex = 2;
            this.cbSPSupercharge.Text = "SuperCharge";
            this.cbSPSupercharge.UseVisualStyleBackColor = true;
            // 
            // cbSPOverkill
            // 
            this.cbSPOverkill.AutoSize = true;
            this.cbSPOverkill.Location = new System.Drawing.Point(376, 24);
            this.cbSPOverkill.Name = "cbSPOverkill";
            this.cbSPOverkill.Size = new System.Drawing.Size(61, 17);
            this.cbSPOverkill.TabIndex = 2;
            this.cbSPOverkill.Text = "Overkill";
            this.cbSPOverkill.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modifiers";
            // 
            // txtSPToHitModifiers
            // 
            this.txtSPToHitModifiers.Location = new System.Drawing.Point(95, 22);
            this.txtSPToHitModifiers.Name = "txtSPToHitModifiers";
            this.txtSPToHitModifiers.Size = new System.Drawing.Size(100, 20);
            this.txtSPToHitModifiers.TabIndex = 1;
            // 
            // cbSPToHitRerollUOnes
            // 
            this.cbSPToHitRerollUOnes.AutoSize = true;
            this.cbSPToHitRerollUOnes.Location = new System.Drawing.Point(227, 24);
            this.cbSPToHitRerollUOnes.Name = "cbSPToHitRerollUOnes";
            this.cbSPToHitRerollUOnes.Size = new System.Drawing.Size(137, 17);
            this.cbSPToHitRerollUOnes.TabIndex = 2;
            this.cbSPToHitRerollUOnes.Text = "Reroll Unmodified Ones";
            this.cbSPToHitRerollUOnes.UseVisualStyleBackColor = true;
            // 
            // cbSPToHitRerollUFails
            // 
            this.cbSPToHitRerollUFails.AutoSize = true;
            this.cbSPToHitRerollUFails.Location = new System.Drawing.Point(370, 24);
            this.cbSPToHitRerollUFails.Name = "cbSPToHitRerollUFails";
            this.cbSPToHitRerollUFails.Size = new System.Drawing.Size(133, 17);
            this.cbSPToHitRerollUFails.TabIndex = 2;
            this.cbSPToHitRerollUFails.Text = "Reroll Unmodified Fails";
            this.cbSPToHitRerollUFails.UseVisualStyleBackColor = true;
            // 
            // cbSPToHitRerollOnes
            // 
            this.cbSPToHitRerollOnes.AutoSize = true;
            this.cbSPToHitRerollOnes.Location = new System.Drawing.Point(509, 24);
            this.cbSPToHitRerollOnes.Name = "cbSPToHitRerollOnes";
            this.cbSPToHitRerollOnes.Size = new System.Drawing.Size(81, 17);
            this.cbSPToHitRerollOnes.TabIndex = 2;
            this.cbSPToHitRerollOnes.Text = "Reroll Ones";
            this.cbSPToHitRerollOnes.UseVisualStyleBackColor = true;
            // 
            // cbSPToHitRerollFails
            // 
            this.cbSPToHitRerollFails.AutoSize = true;
            this.cbSPToHitRerollFails.Location = new System.Drawing.Point(603, 24);
            this.cbSPToHitRerollFails.Name = "cbSPToHitRerollFails";
            this.cbSPToHitRerollFails.Size = new System.Drawing.Size(77, 17);
            this.cbSPToHitRerollFails.TabIndex = 2;
            this.cbSPToHitRerollFails.Text = "Reroll Fails";
            this.cbSPToHitRerollFails.UseVisualStyleBackColor = true;
            // 
            // grSPToHit
            // 
            this.grSPToHit.Controls.Add(this.label3);
            this.grSPToHit.Controls.Add(this.txtSPToHitRerolls);
            this.grSPToHit.Controls.Add(this.label2);
            this.grSPToHit.Controls.Add(this.txtSPToHitModifiers);
            this.grSPToHit.Controls.Add(this.cbSPToHitRerollFails);
            this.grSPToHit.Controls.Add(this.cbSPToHitRerollUOnes);
            this.grSPToHit.Controls.Add(this.cbSPToHitRerollOnes);
            this.grSPToHit.Controls.Add(this.cbSPToHitRerollUFails);
            this.grSPToHit.Location = new System.Drawing.Point(6, 48);
            this.grSPToHit.Name = "grSPToHit";
            this.grSPToHit.Size = new System.Drawing.Size(946, 56);
            this.grSPToHit.TabIndex = 3;
            this.grSPToHit.TabStop = false;
            this.grSPToHit.Text = "To Hit";
            // 
            // txtSPToHitRerolls
            // 
            this.txtSPToHitRerolls.Location = new System.Drawing.Point(820, 22);
            this.txtSPToHitRerolls.Name = "txtSPToHitRerolls";
            this.txtSPToHitRerolls.Size = new System.Drawing.Size(100, 20);
            this.txtSPToHitRerolls.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numer of Rerolls";
            // 
            // grSPToWound
            // 
            this.grSPToWound.Controls.Add(this.label4);
            this.grSPToWound.Controls.Add(this.txtSPToWoundRerolls);
            this.grSPToWound.Controls.Add(this.label5);
            this.grSPToWound.Controls.Add(this.txtSPToWoundModifiers);
            this.grSPToWound.Controls.Add(this.cbSPToWoundRerollFails);
            this.grSPToWound.Controls.Add(this.cbSPToWoundRerollUOnes);
            this.grSPToWound.Controls.Add(this.cbSPToWoundRerollOnes);
            this.grSPToWound.Controls.Add(this.cbSPToWoundRerollUFails);
            this.grSPToWound.Location = new System.Drawing.Point(6, 110);
            this.grSPToWound.Name = "grSPToWound";
            this.grSPToWound.Size = new System.Drawing.Size(946, 56);
            this.grSPToWound.TabIndex = 4;
            this.grSPToWound.TabStop = false;
            this.grSPToWound.Text = "To Wound";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numer of Rerolls";
            // 
            // txtSPToWoundRerolls
            // 
            this.txtSPToWoundRerolls.Location = new System.Drawing.Point(820, 22);
            this.txtSPToWoundRerolls.Name = "txtSPToWoundRerolls";
            this.txtSPToWoundRerolls.Size = new System.Drawing.Size(100, 20);
            this.txtSPToWoundRerolls.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Modifiers";
            // 
            // txtSPToWoundModifiers
            // 
            this.txtSPToWoundModifiers.Location = new System.Drawing.Point(95, 22);
            this.txtSPToWoundModifiers.Name = "txtSPToWoundModifiers";
            this.txtSPToWoundModifiers.Size = new System.Drawing.Size(100, 20);
            this.txtSPToWoundModifiers.TabIndex = 1;
            // 
            // cbSPToWoundRerollFails
            // 
            this.cbSPToWoundRerollFails.AutoSize = true;
            this.cbSPToWoundRerollFails.Location = new System.Drawing.Point(603, 24);
            this.cbSPToWoundRerollFails.Name = "cbSPToWoundRerollFails";
            this.cbSPToWoundRerollFails.Size = new System.Drawing.Size(77, 17);
            this.cbSPToWoundRerollFails.TabIndex = 2;
            this.cbSPToWoundRerollFails.Text = "Reroll Fails";
            this.cbSPToWoundRerollFails.UseVisualStyleBackColor = true;
            // 
            // cbSPToWoundRerollUOnes
            // 
            this.cbSPToWoundRerollUOnes.AutoSize = true;
            this.cbSPToWoundRerollUOnes.Location = new System.Drawing.Point(227, 24);
            this.cbSPToWoundRerollUOnes.Name = "cbSPToWoundRerollUOnes";
            this.cbSPToWoundRerollUOnes.Size = new System.Drawing.Size(137, 17);
            this.cbSPToWoundRerollUOnes.TabIndex = 2;
            this.cbSPToWoundRerollUOnes.Text = "Reroll Unmodified Ones";
            this.cbSPToWoundRerollUOnes.UseVisualStyleBackColor = true;
            // 
            // cbSPToWoundRerollOnes
            // 
            this.cbSPToWoundRerollOnes.AutoSize = true;
            this.cbSPToWoundRerollOnes.Location = new System.Drawing.Point(509, 24);
            this.cbSPToWoundRerollOnes.Name = "cbSPToWoundRerollOnes";
            this.cbSPToWoundRerollOnes.Size = new System.Drawing.Size(81, 17);
            this.cbSPToWoundRerollOnes.TabIndex = 2;
            this.cbSPToWoundRerollOnes.Text = "Reroll Ones";
            this.cbSPToWoundRerollOnes.UseVisualStyleBackColor = true;
            // 
            // cbSPToWoundRerollUFails
            // 
            this.cbSPToWoundRerollUFails.AutoSize = true;
            this.cbSPToWoundRerollUFails.Location = new System.Drawing.Point(370, 24);
            this.cbSPToWoundRerollUFails.Name = "cbSPToWoundRerollUFails";
            this.cbSPToWoundRerollUFails.Size = new System.Drawing.Size(133, 17);
            this.cbSPToWoundRerollUFails.TabIndex = 2;
            this.cbSPToWoundRerollUFails.Text = "Reroll Unmodified Fails";
            this.cbSPToWoundRerollUFails.UseVisualStyleBackColor = true;
            // 
            // grSPToDamage
            // 
            this.grSPToDamage.Controls.Add(this.label7);
            this.grSPToDamage.Controls.Add(this.txtSPToDamageThreshold);
            this.grSPToDamage.Controls.Add(this.label6);
            this.grSPToDamage.Controls.Add(this.txtSPToDamageRerolls);
            this.grSPToDamage.Controls.Add(this.cbSPToDamageReroll);
            this.grSPToDamage.Location = new System.Drawing.Point(6, 172);
            this.grSPToDamage.Name = "grSPToDamage";
            this.grSPToDamage.Size = new System.Drawing.Size(946, 56);
            this.grSPToDamage.TabIndex = 5;
            this.grSPToDamage.TabStop = false;
            this.grSPToDamage.Text = "To Damage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numer of Rerolls";
            // 
            // txtSPToDamageRerolls
            // 
            this.txtSPToDamageRerolls.Location = new System.Drawing.Point(820, 22);
            this.txtSPToDamageRerolls.Name = "txtSPToDamageRerolls";
            this.txtSPToDamageRerolls.Size = new System.Drawing.Size(100, 20);
            this.txtSPToDamageRerolls.TabIndex = 1;
            // 
            // cbSPToDamageReroll
            // 
            this.cbSPToDamageReroll.AutoSize = true;
            this.cbSPToDamageReroll.Location = new System.Drawing.Point(227, 24);
            this.cbSPToDamageReroll.Name = "cbSPToDamageReroll";
            this.cbSPToDamageReroll.Size = new System.Drawing.Size(53, 17);
            this.cbSPToDamageReroll.TabIndex = 2;
            this.cbSPToDamageReroll.Text = "Reroll";
            this.cbSPToDamageReroll.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Threshold";
            // 
            // txtSPToDamageThreshold
            // 
            this.txtSPToDamageThreshold.Location = new System.Drawing.Point(95, 22);
            this.txtSPToDamageThreshold.Name = "txtSPToDamageThreshold";
            this.txtSPToDamageThreshold.Size = new System.Drawing.Size(100, 20);
            this.txtSPToDamageThreshold.TabIndex = 4;
            // 
            // cbUnitAttacker
            // 
            this.cbUnitAttacker.FormattingEnabled = true;
            this.cbUnitAttacker.Location = new System.Drawing.Point(113, 256);
            this.cbUnitAttacker.Name = "cbUnitAttacker";
            this.cbUnitAttacker.Size = new System.Drawing.Size(230, 21);
            this.cbUnitAttacker.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Shotter";
            // 
            // cbUnitTarget
            // 
            this.cbUnitTarget.FormattingEnabled = true;
            this.cbUnitTarget.Location = new System.Drawing.Point(467, 256);
            this.cbUnitTarget.Name = "cbUnitTarget";
            this.cbUnitTarget.Size = new System.Drawing.Size(230, 21);
            this.cbUnitTarget.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Target";
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 490);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbUnitTarget);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbUnitAttacker);
            this.Controls.Add(this.grShootingParams);
            this.Controls.Add(this.TestResults);
            this.Controls.Add(this.ButTest);
            this.Name = "Tester";
            this.Text = "Tester";
            this.grShootingParams.ResumeLayout(false);
            this.grShootingParams.PerformLayout();
            this.grSPToHit.ResumeLayout(false);
            this.grSPToHit.PerformLayout();
            this.grSPToWound.ResumeLayout(false);
            this.grSPToWound.PerformLayout();
            this.grSPToDamage.ResumeLayout(false);
            this.grSPToDamage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButTest;
        private System.Windows.Forms.TextBox TestResults;
        private System.Windows.Forms.GroupBox grShootingParams;
        private System.Windows.Forms.TextBox txtSPDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSPOverkill;
        private System.Windows.Forms.CheckBox cbSPSupercharge;
        private System.Windows.Forms.TextBox txtSPToHitModifiers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSPToHitRerollFails;
        private System.Windows.Forms.CheckBox cbSPToHitRerollOnes;
        private System.Windows.Forms.CheckBox cbSPToHitRerollUFails;
        private System.Windows.Forms.CheckBox cbSPToHitRerollUOnes;
        private System.Windows.Forms.GroupBox grSPToHit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSPToHitRerolls;
        private System.Windows.Forms.GroupBox grSPToWound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSPToWoundRerolls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSPToWoundModifiers;
        private System.Windows.Forms.CheckBox cbSPToWoundRerollFails;
        private System.Windows.Forms.CheckBox cbSPToWoundRerollUOnes;
        private System.Windows.Forms.CheckBox cbSPToWoundRerollOnes;
        private System.Windows.Forms.CheckBox cbSPToWoundRerollUFails;
        private System.Windows.Forms.GroupBox grSPToDamage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSPToDamageRerolls;
        private System.Windows.Forms.CheckBox cbSPToDamageReroll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSPToDamageThreshold;
        private System.Windows.Forms.ComboBox cbUnitAttacker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUnitTarget;
        private System.Windows.Forms.Label label9;
    }
}

