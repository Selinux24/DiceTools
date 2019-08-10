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
            this.SuspendLayout();
            // 
            // ButTest
            // 
            this.ButTest.Location = new System.Drawing.Point(12, 12);
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
            this.TestResults.Location = new System.Drawing.Point(12, 41);
            this.TestResults.Multiline = true;
            this.TestResults.Name = "TestResults";
            this.TestResults.ReadOnly = true;
            this.TestResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TestResults.Size = new System.Drawing.Size(796, 437);
            this.TestResults.TabIndex = 1;
            this.TestResults.WordWrap = false;
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 490);
            this.Controls.Add(this.TestResults);
            this.Controls.Add(this.ButTest);
            this.Name = "Tester";
            this.Text = "Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButTest;
        private System.Windows.Forms.TextBox TestResults;
    }
}

