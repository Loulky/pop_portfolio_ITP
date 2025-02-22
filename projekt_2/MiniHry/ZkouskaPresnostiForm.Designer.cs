namespace MiniHry
{
    partial class PostrehForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostrehForm));
            this.menuButton = new System.Windows.Forms.Button();
            this.infoOMinihreButton = new System.Windows.Forms.Button();
            this.tercPiBox = new System.Windows.Forms.PictureBox();
            this.zacniLabel = new System.Windows.Forms.Label();
            this.pocetTerceLabel = new System.Windows.Forms.Label();
            this.prumernaOdezvaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tercPiBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.menuButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(1262, 12);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(326, 53);
            this.menuButton.TabIndex = 6;
            this.menuButton.TabStop = false;
            this.menuButton.Text = "Do vyberu miniher";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // infoOMinihreButton
            // 
            this.infoOMinihreButton.AutoSize = true;
            this.infoOMinihreButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.infoOMinihreButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoOMinihreButton.Location = new System.Drawing.Point(12, 12);
            this.infoOMinihreButton.Name = "infoOMinihreButton";
            this.infoOMinihreButton.Size = new System.Drawing.Size(354, 53);
            this.infoOMinihreButton.TabIndex = 7;
            this.infoOMinihreButton.TabStop = false;
            this.infoOMinihreButton.Text = "Informace o minihre";
            this.infoOMinihreButton.UseVisualStyleBackColor = true;
            this.infoOMinihreButton.Click += new System.EventHandler(this.infoOMinihreButton_Click);
            // 
            // tercPiBox
            // 
            this.tercPiBox.Image = ((System.Drawing.Image)(resources.GetObject("tercPiBox.Image")));
            this.tercPiBox.Location = new System.Drawing.Point(750, 382);
            this.tercPiBox.Name = "tercPiBox";
            this.tercPiBox.Size = new System.Drawing.Size(100, 100);
            this.tercPiBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tercPiBox.TabIndex = 8;
            this.tercPiBox.TabStop = false;
            this.tercPiBox.Click += new System.EventHandler(this.tercPiBox_Click);
            // 
            // zacniLabel
            // 
            this.zacniLabel.AutoSize = true;
            this.zacniLabel.BackColor = System.Drawing.Color.Transparent;
            this.zacniLabel.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zacniLabel.Location = new System.Drawing.Point(311, 259);
            this.zacniLabel.Name = "zacniLabel";
            this.zacniLabel.Size = new System.Drawing.Size(978, 89);
            this.zacniLabel.TabIndex = 9;
            this.zacniLabel.Text = "Klikni na terc pro zacatek";
            // 
            // pocetTerceLabel
            // 
            this.pocetTerceLabel.AutoSize = true;
            this.pocetTerceLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pocetTerceLabel.Location = new System.Drawing.Point(762, 6);
            this.pocetTerceLabel.Name = "pocetTerceLabel";
            this.pocetTerceLabel.Size = new System.Drawing.Size(77, 59);
            this.pocetTerceLabel.TabIndex = 10;
            this.pocetTerceLabel.Text = "30";
            // 
            // prumernaOdezvaLabel
            // 
            this.prumernaOdezvaLabel.AutoSize = true;
            this.prumernaOdezvaLabel.BackColor = System.Drawing.Color.Transparent;
            this.prumernaOdezvaLabel.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prumernaOdezvaLabel.Location = new System.Drawing.Point(331, 767);
            this.prumernaOdezvaLabel.Name = "prumernaOdezvaLabel";
            this.prumernaOdezvaLabel.Size = new System.Drawing.Size(939, 89);
            this.prumernaOdezvaLabel.TabIndex = 11;
            this.prumernaOdezvaLabel.Text = "Tvoje prumerna odezva: ";
            this.prumernaOdezvaLabel.Visible = false;
            // 
            // PostrehForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.prumernaOdezvaLabel);
            this.Controls.Add(this.pocetTerceLabel);
            this.Controls.Add(this.zacniLabel);
            this.Controls.Add(this.tercPiBox);
            this.Controls.Add(this.infoOMinihreButton);
            this.Controls.Add(this.menuButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1626, 936);
            this.MinimumSize = new System.Drawing.Size(1626, 936);
            this.Name = "PostrehForm";
            this.Text = "Postreh";
            ((System.ComponentModel.ISupportInitialize)(this.tercPiBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button infoOMinihreButton;
        private System.Windows.Forms.PictureBox tercPiBox;
        private System.Windows.Forms.Label zacniLabel;
        private System.Windows.Forms.Label pocetTerceLabel;
        private System.Windows.Forms.Label prumernaOdezvaLabel;
    }
}