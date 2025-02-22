namespace MiniHry
{
    partial class RychlostForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RychlostForm));
            this.cekaniLabel = new System.Windows.Forms.Label();
            this.kliniProStartLabel = new System.Windows.Forms.Label();
            this.mocBrzoLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.odezvaLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.infoOHreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cekaniLabel
            // 
            this.cekaniLabel.AutoSize = true;
            this.cekaniLabel.BackColor = System.Drawing.Color.Transparent;
            this.cekaniLabel.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekaniLabel.Location = new System.Drawing.Point(292, 300);
            this.cekaniLabel.Margin = new System.Windows.Forms.Padding(6, 19, 6, 0);
            this.cekaniLabel.Name = "cekaniLabel";
            this.cekaniLabel.Size = new System.Drawing.Size(1011, 89);
            this.cekaniLabel.TabIndex = 0;
            this.cekaniLabel.Text = "Az se zobrazi zelena klikni";
            this.cekaniLabel.Visible = false;
            this.cekaniLabel.Click += new System.EventHandler(this.cekaniLabel_Click);
            // 
            // kliniProStartLabel
            // 
            this.kliniProStartLabel.AutoSize = true;
            this.kliniProStartLabel.BackColor = System.Drawing.Color.Transparent;
            this.kliniProStartLabel.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kliniProStartLabel.Location = new System.Drawing.Point(502, 496);
            this.kliniProStartLabel.Margin = new System.Windows.Forms.Padding(6, 19, 6, 0);
            this.kliniProStartLabel.Name = "kliniProStartLabel";
            this.kliniProStartLabel.Size = new System.Drawing.Size(591, 89);
            this.kliniProStartLabel.TabIndex = 2;
            this.kliniProStartLabel.Text = "Klikni pro start";
            this.kliniProStartLabel.Click += new System.EventHandler(this.kliniProStartLabel_Click);
            // 
            // mocBrzoLabel
            // 
            this.mocBrzoLabel.AutoSize = true;
            this.mocBrzoLabel.BackColor = System.Drawing.Color.Transparent;
            this.mocBrzoLabel.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mocBrzoLabel.Location = new System.Drawing.Point(200, 204);
            this.mocBrzoLabel.Margin = new System.Windows.Forms.Padding(6, 19, 6, 0);
            this.mocBrzoLabel.Name = "mocBrzoLabel";
            this.mocBrzoLabel.Size = new System.Drawing.Size(1203, 89);
            this.mocBrzoLabel.TabIndex = 3;
            this.mocBrzoLabel.Text = "Moc brzo, zkus to znovu (klikni)";
            this.mocBrzoLabel.Visible = false;
            this.mocBrzoLabel.Click += new System.EventHandler(this.mocBrzoLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // odezvaLabel
            // 
            this.odezvaLabel.AutoSize = true;
            this.odezvaLabel.BackColor = System.Drawing.Color.Transparent;
            this.odezvaLabel.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odezvaLabel.Location = new System.Drawing.Point(478, 408);
            this.odezvaLabel.Margin = new System.Windows.Forms.Padding(6, 19, 6, 0);
            this.odezvaLabel.Name = "odezvaLabel";
            this.odezvaLabel.Size = new System.Drawing.Size(645, 89);
            this.odezvaLabel.TabIndex = 4;
            this.odezvaLabel.Text = "Tvoje odezva je: ";
            this.odezvaLabel.Visible = false;
            this.odezvaLabel.Click += new System.EventHandler(this.odezvaLabel_Click);
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.menuButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(1243, 12);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(344, 54);
            this.menuButton.TabIndex = 5;
            this.menuButton.TabStop = false;
            this.menuButton.Text = "Do vyberu miniher";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // infoOHreButton
            // 
            this.infoOHreButton.AutoSize = true;
            this.infoOHreButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.infoOHreButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoOHreButton.Location = new System.Drawing.Point(12, 12);
            this.infoOHreButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoOHreButton.Name = "infoOHreButton";
            this.infoOHreButton.Size = new System.Drawing.Size(370, 54);
            this.infoOHreButton.TabIndex = 6;
            this.infoOHreButton.TabStop = false;
            this.infoOHreButton.Text = "Informace o minihre";
            this.infoOHreButton.UseVisualStyleBackColor = true;
            this.infoOHreButton.Click += new System.EventHandler(this.infoOHreButton_Click);
            // 
            // RychlostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.infoOHreButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.odezvaLabel);
            this.Controls.Add(this.mocBrzoLabel);
            this.Controls.Add(this.kliniProStartLabel);
            this.Controls.Add(this.cekaniLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RychlostForm";
            this.Text = "Rychlost";
            this.ClientSizeChanged += new System.EventHandler(this.ZkouskaRychlosti_ClientSizeChanged);
            this.Click += new System.EventHandler(this.ZkouskaRychlosti_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cekaniLabel;
        private System.Windows.Forms.Label kliniProStartLabel;
        private System.Windows.Forms.Label mocBrzoLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label odezvaLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button infoOHreButton;
    }
}