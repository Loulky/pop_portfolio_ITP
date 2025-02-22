namespace MiniHry
{
    partial class VybraniHryForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VybraniHryForm));
            this.zkouskaReakceButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.aimButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zkouskaReakceButton
            // 
            this.zkouskaReakceButton.BackColor = System.Drawing.Color.LimeGreen;
            this.zkouskaReakceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zkouskaReakceButton.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zkouskaReakceButton.Location = new System.Drawing.Point(77, 144);
            this.zkouskaReakceButton.Margin = new System.Windows.Forms.Padding(69, 6, 6, 6);
            this.zkouskaReakceButton.Name = "zkouskaReakceButton";
            this.zkouskaReakceButton.Size = new System.Drawing.Size(229, 120);
            this.zkouskaReakceButton.TabIndex = 0;
            this.zkouskaReakceButton.Text = "Rychlost kliknuti";
            this.zkouskaReakceButton.UseVisualStyleBackColor = false;
            this.zkouskaReakceButton.Click += new System.EventHandler(this.ZkouskaReakceButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Font = new System.Drawing.Font("Rockwell", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.Location = new System.Drawing.Point(12, 12);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(133, 62);
            this.InfoButton.TabIndex = 1;
            this.InfoButton.Text = "Informace o aplikaci";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // aimButton
            // 
            this.aimButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.aimButton.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aimButton.Location = new System.Drawing.Point(422, 144);
            this.aimButton.Margin = new System.Windows.Forms.Padding(110, 3, 3, 3);
            this.aimButton.Name = "aimButton";
            this.aimButton.Size = new System.Drawing.Size(229, 120);
            this.aimButton.TabIndex = 2;
            this.aimButton.Text = "Postreh";
            this.aimButton.UseVisualStyleBackColor = false;
            this.aimButton.Click += new System.EventHandler(this.aimButton_Click);
            // 
            // VybraniHryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 398);
            this.Controls.Add(this.aimButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.zkouskaReakceButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "VybraniHryForm";
            this.Text = "Vyber hry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zkouskaReakceButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button aimButton;
    }
}

