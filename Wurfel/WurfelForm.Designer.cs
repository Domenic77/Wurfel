namespace Wurfel
{
    partial class WurfelForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.WurfelnButton = new System.Windows.Forms.Button();
            this.lastThrow = new System.Windows.Forms.Label();
            this.LasThrowValueLabel = new System.Windows.Forms.Label();
            this.TrowValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WurfelnButton
            // 
            this.WurfelnButton.BackColor = System.Drawing.SystemColors.Window;
            this.WurfelnButton.Location = new System.Drawing.Point(63, 78);
            this.WurfelnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WurfelnButton.Name = "WurfelnButton";
            this.WurfelnButton.Size = new System.Drawing.Size(237, 95);
            this.WurfelnButton.TabIndex = 0;
            this.WurfelnButton.Text = "Würfeln";
            this.WurfelnButton.UseVisualStyleBackColor = false;
            this.WurfelnButton.Click += new System.EventHandler(this.WurfelnButton_Click);
            // 
            // lastThrow
            // 
            this.lastThrow.AutoSize = true;
            this.lastThrow.Location = new System.Drawing.Point(107, 355);
            this.lastThrow.Name = "lastThrow";
            this.lastThrow.Size = new System.Drawing.Size(101, 20);
            this.lastThrow.TabIndex = 1;
            this.lastThrow.Text = "Letzter Wurf:";
            // 
            // LasThrowValueLabel
            // 
            this.LasThrowValueLabel.AutoSize = true;
            this.LasThrowValueLabel.Location = new System.Drawing.Point(212, 355);
            this.LasThrowValueLabel.Name = "LasThrowValueLabel";
            this.LasThrowValueLabel.Size = new System.Drawing.Size(18, 20);
            this.LasThrowValueLabel.TabIndex = 2;
            this.LasThrowValueLabel.Text = "0";
            // 
            // TrowValueLabel
            // 
            this.TrowValueLabel.AutoSize = true;
            this.TrowValueLabel.Location = new System.Drawing.Point(390, 135);
            this.TrowValueLabel.Name = "TrowValueLabel";
            this.TrowValueLabel.Size = new System.Drawing.Size(18, 20);
            this.TrowValueLabel.TabIndex = 3;
            this.TrowValueLabel.Text = "0";
            // 
            // WurfelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(449, 430);
            this.Controls.Add(this.WurfelnButton);
            this.Controls.Add(this.TrowValueLabel);
            this.Controls.Add(this.LasThrowValueLabel);
            this.Controls.Add(this.lastThrow);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WurfelForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WurfelnButton;
        private System.Windows.Forms.Label lastThrow;
        private System.Windows.Forms.Label LasThrowValueLabel;
        private System.Windows.Forms.Label TrowValueLabel;
    }
}

