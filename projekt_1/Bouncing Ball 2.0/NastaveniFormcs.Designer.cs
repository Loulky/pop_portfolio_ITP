namespace Bouncing_Ball_2._0
{
    partial class NastaveniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NastaveniForm));
            this.nastaveniLabel = new System.Windows.Forms.Label();
            this.OdejitLabel = new System.Windows.Forms.Button();
            this.barvaLabel = new System.Windows.Forms.Label();
            this.barvaCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.bodyVyhraLabel = new System.Windows.Forms.Label();
            this.bodyNaVyhruCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.rychlostHracuLabel = new System.Windows.Forms.Label();
            this.rychlosthracuCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.rychlostMiceLabel = new System.Windows.Forms.Label();
            this.rychlostMiceCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.informaceButton = new System.Windows.Forms.Button();
            this.pozadiPiBox = new System.Windows.Forms.PictureBox();
            this.hracVlevoPiBox = new System.Windows.Forms.PictureBox();
            this.hracVpravoPiBox = new System.Windows.Forms.PictureBox();
            this.hracVlevoBodyLabel = new System.Windows.Forms.Label();
            this.hracVpravoBodyLabel = new System.Windows.Forms.Label();
            this.micPiBox = new System.Windows.Forms.PictureBox();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.barvaHracuCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.vyhraLabel = new System.Windows.Forms.Label();
            this.VyhraTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pozadiPiBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hracVlevoPiBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hracVpravoPiBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micPiBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nastaveniLabel
            // 
            this.nastaveniLabel.AutoSize = true;
            this.nastaveniLabel.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nastaveniLabel.Location = new System.Drawing.Point(274, 13);
            this.nastaveniLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nastaveniLabel.Name = "nastaveniLabel";
            this.nastaveniLabel.Size = new System.Drawing.Size(367, 27);
            this.nastaveniLabel.TabIndex = 0;
            this.nastaveniLabel.Text = "Bouncing Ball 2.0 \\n\\r Nastaveni";
            this.nastaveniLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OdejitLabel
            // 
            this.OdejitLabel.Font = new System.Drawing.Font("Rockwell", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdejitLabel.Location = new System.Drawing.Point(783, 449);
            this.OdejitLabel.Margin = new System.Windows.Forms.Padding(2);
            this.OdejitLabel.Name = "OdejitLabel";
            this.OdejitLabel.Size = new System.Drawing.Size(110, 42);
            this.OdejitLabel.TabIndex = 2;
            this.OdejitLabel.Text = "Potrdit a hrat";
            this.OdejitLabel.UseVisualStyleBackColor = true;
            this.OdejitLabel.Click += new System.EventHandler(this.UlOdejitLabel_Click);
            // 
            // barvaLabel
            // 
            this.barvaLabel.BackColor = System.Drawing.Color.Transparent;
            this.barvaLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barvaLabel.Location = new System.Drawing.Point(26, 87);
            this.barvaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.barvaLabel.Name = "barvaLabel";
            this.barvaLabel.Size = new System.Drawing.Size(160, 23);
            this.barvaLabel.TabIndex = 3;
            this.barvaLabel.Text = "Barva pozadi";
            this.barvaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barvaCheckedListBox
            // 
            this.barvaCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barvaCheckedListBox.CheckOnClick = true;
            this.barvaCheckedListBox.Font = new System.Drawing.Font("Rockwell", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.barvaCheckedListBox.FormattingEnabled = true;
            this.barvaCheckedListBox.Items.AddRange(new object[] {
            "Bila (Z)",
            "Fialova",
            "Modra"});
            this.barvaCheckedListBox.Location = new System.Drawing.Point(26, 112);
            this.barvaCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.barvaCheckedListBox.Name = "barvaCheckedListBox";
            this.barvaCheckedListBox.Size = new System.Drawing.Size(177, 62);
            this.barvaCheckedListBox.TabIndex = 4;
            this.barvaCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.barvaCheckedListBox_SelectedIndexChanged);
            // 
            // bodyVyhraLabel
            // 
            this.bodyVyhraLabel.BackColor = System.Drawing.Color.Transparent;
            this.bodyVyhraLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyVyhraLabel.Location = new System.Drawing.Point(26, 207);
            this.bodyVyhraLabel.Margin = new System.Windows.Forms.Padding(2, 31, 2, 0);
            this.bodyVyhraLabel.Name = "bodyVyhraLabel";
            this.bodyVyhraLabel.Size = new System.Drawing.Size(160, 23);
            this.bodyVyhraLabel.TabIndex = 5;
            this.bodyVyhraLabel.Text = "Body na vyhru";
            this.bodyVyhraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bodyNaVyhruCheckedListBox
            // 
            this.bodyNaVyhruCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyNaVyhruCheckedListBox.CheckOnClick = true;
            this.bodyNaVyhruCheckedListBox.Font = new System.Drawing.Font("Rockwell", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bodyNaVyhruCheckedListBox.FormattingEnabled = true;
            this.bodyNaVyhruCheckedListBox.Items.AddRange(new object[] {
            "3 (Z)",
            "5",
            "10",
            "15"});
            this.bodyNaVyhruCheckedListBox.Location = new System.Drawing.Point(30, 232);
            this.bodyNaVyhruCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.bodyNaVyhruCheckedListBox.MultiColumn = true;
            this.bodyNaVyhruCheckedListBox.Name = "bodyNaVyhruCheckedListBox";
            this.bodyNaVyhruCheckedListBox.Size = new System.Drawing.Size(173, 82);
            this.bodyNaVyhruCheckedListBox.TabIndex = 6;
            this.bodyNaVyhruCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.bodyNaVyhruCheckedListBox_SelectedIndexChanged);
            // 
            // rychlostHracuLabel
            // 
            this.rychlostHracuLabel.BackColor = System.Drawing.Color.Transparent;
            this.rychlostHracuLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rychlostHracuLabel.Location = new System.Drawing.Point(218, 87);
            this.rychlostHracuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rychlostHracuLabel.Name = "rychlostHracuLabel";
            this.rychlostHracuLabel.Size = new System.Drawing.Size(160, 23);
            this.rychlostHracuLabel.TabIndex = 7;
            this.rychlostHracuLabel.Text = "Rychlost hracu";
            this.rychlostHracuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rychlosthracuCheckedListBox
            // 
            this.rychlosthracuCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rychlosthracuCheckedListBox.CheckOnClick = true;
            this.rychlosthracuCheckedListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.rychlosthracuCheckedListBox.Font = new System.Drawing.Font("Rockwell", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rychlosthracuCheckedListBox.FormattingEnabled = true;
            this.rychlosthracuCheckedListBox.Items.AddRange(new object[] {
            "Pomala",
            "Stredni (Z)",
            "Velka",
            "Hodne velka"});
            this.rychlosthracuCheckedListBox.Location = new System.Drawing.Point(218, 112);
            this.rychlosthracuCheckedListBox.Margin = new System.Windows.Forms.Padding(30, 2, 2, 2);
            this.rychlosthracuCheckedListBox.Name = "rychlosthracuCheckedListBox";
            this.rychlosthracuCheckedListBox.Size = new System.Drawing.Size(161, 62);
            this.rychlosthracuCheckedListBox.TabIndex = 8;
            this.rychlosthracuCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.rychlosthracuCheckedListBox_SelectedIndexChanged);
            // 
            // rychlostMiceLabel
            // 
            this.rychlostMiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.rychlostMiceLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rychlostMiceLabel.Location = new System.Drawing.Point(218, 207);
            this.rychlostMiceLabel.Margin = new System.Windows.Forms.Padding(2, 31, 2, 0);
            this.rychlostMiceLabel.Name = "rychlostMiceLabel";
            this.rychlostMiceLabel.Size = new System.Drawing.Size(160, 23);
            this.rychlostMiceLabel.TabIndex = 9;
            this.rychlostMiceLabel.Text = "Rychlost mice";
            this.rychlostMiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rychlostMiceCheckedListBox
            // 
            this.rychlostMiceCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rychlostMiceCheckedListBox.CheckOnClick = true;
            this.rychlostMiceCheckedListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.rychlostMiceCheckedListBox.Font = new System.Drawing.Font("Rockwell", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rychlostMiceCheckedListBox.FormattingEnabled = true;
            this.rychlostMiceCheckedListBox.Items.AddRange(new object[] {
            "Pomala",
            "Stredni (Z)",
            "Velka",
            "Hodne Velka"});
            this.rychlostMiceCheckedListBox.Location = new System.Drawing.Point(218, 232);
            this.rychlostMiceCheckedListBox.Margin = new System.Windows.Forms.Padding(30, 2, 2, 2);
            this.rychlostMiceCheckedListBox.Name = "rychlostMiceCheckedListBox";
            this.rychlostMiceCheckedListBox.Size = new System.Drawing.Size(161, 62);
            this.rychlostMiceCheckedListBox.TabIndex = 10;
            this.rychlostMiceCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.rychlostMiceCheckedListBox_SelectedIndexChanged);
            // 
            // informaceButton
            // 
            this.informaceButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.informaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.informaceButton.Font = new System.Drawing.Font("Rockwell", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.informaceButton.Location = new System.Drawing.Point(7, 7);
            this.informaceButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.informaceButton.Name = "informaceButton";
            this.informaceButton.Size = new System.Drawing.Size(68, 34);
            this.informaceButton.TabIndex = 11;
            this.informaceButton.TabStop = false;
            this.informaceButton.Text = "Informace o aplikaci";
            this.informaceButton.UseVisualStyleBackColor = false;
            this.informaceButton.Click += new System.EventHandler(this.odkazyButton_Click);
            // 
            // pozadiPiBox
            // 
            this.pozadiPiBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pozadiPiBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pozadiPiBox.Location = new System.Drawing.Point(480, 123);
            this.pozadiPiBox.Margin = new System.Windows.Forms.Padding(2, 2, 22, 2);
            this.pozadiPiBox.MaximumSize = new System.Drawing.Size(401, 235);
            this.pozadiPiBox.MinimumSize = new System.Drawing.Size(401, 235);
            this.pozadiPiBox.Name = "pozadiPiBox";
            this.pozadiPiBox.Size = new System.Drawing.Size(401, 235);
            this.pozadiPiBox.TabIndex = 12;
            this.pozadiPiBox.TabStop = false;
            // 
            // hracVlevoPiBox
            // 
            this.hracVlevoPiBox.BackColor = System.Drawing.Color.Crimson;
            this.hracVlevoPiBox.Location = new System.Drawing.Point(488, 129);
            this.hracVlevoPiBox.Margin = new System.Windows.Forms.Padding(2);
            this.hracVlevoPiBox.Name = "hracVlevoPiBox";
            this.hracVlevoPiBox.Size = new System.Drawing.Size(10, 52);
            this.hracVlevoPiBox.TabIndex = 13;
            this.hracVlevoPiBox.TabStop = false;
            // 
            // hracVpravoPiBox
            // 
            this.hracVpravoPiBox.BackColor = System.Drawing.Color.MediumBlue;
            this.hracVpravoPiBox.Location = new System.Drawing.Point(862, 268);
            this.hracVpravoPiBox.Margin = new System.Windows.Forms.Padding(2);
            this.hracVpravoPiBox.Name = "hracVpravoPiBox";
            this.hracVpravoPiBox.Size = new System.Drawing.Size(10, 52);
            this.hracVpravoPiBox.TabIndex = 14;
            this.hracVpravoPiBox.TabStop = false;
            // 
            // hracVlevoBodyLabel
            // 
            this.hracVlevoBodyLabel.AutoSize = true;
            this.hracVlevoBodyLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hracVlevoBodyLabel.Font = new System.Drawing.Font("Rockwell", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hracVlevoBodyLabel.ForeColor = System.Drawing.Color.Crimson;
            this.hracVlevoBodyLabel.Location = new System.Drawing.Point(512, 140);
            this.hracVlevoBodyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hracVlevoBodyLabel.Name = "hracVlevoBodyLabel";
            this.hracVlevoBodyLabel.Size = new System.Drawing.Size(16, 18);
            this.hracVlevoBodyLabel.TabIndex = 15;
            this.hracVlevoBodyLabel.Text = "2";
            // 
            // hracVpravoBodyLabel
            // 
            this.hracVpravoBodyLabel.AutoSize = true;
            this.hracVpravoBodyLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hracVpravoBodyLabel.Font = new System.Drawing.Font("Rockwell", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hracVpravoBodyLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.hracVpravoBodyLabel.Location = new System.Drawing.Point(832, 140);
            this.hracVpravoBodyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hracVpravoBodyLabel.Name = "hracVpravoBodyLabel";
            this.hracVpravoBodyLabel.Size = new System.Drawing.Size(16, 18);
            this.hracVpravoBodyLabel.TabIndex = 16;
            this.hracVpravoBodyLabel.Text = "1";
            // 
            // micPiBox
            // 
            this.micPiBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.micPiBox.Image = ((System.Drawing.Image)(resources.GetObject("micPiBox.Image")));
            this.micPiBox.Location = new System.Drawing.Point(668, 227);
            this.micPiBox.Margin = new System.Windows.Forms.Padding(2);
            this.micPiBox.Name = "micPiBox";
            this.micPiBox.Size = new System.Drawing.Size(25, 26);
            this.micPiBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.micPiBox.TabIndex = 17;
            this.micPiBox.TabStop = false;
            // 
            // gameTime
            // 
            this.gameTime.Interval = 30;
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 31, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Barva hracu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barvaHracuCheckedListBox
            // 
            this.barvaHracuCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barvaHracuCheckedListBox.CheckOnClick = true;
            this.barvaHracuCheckedListBox.Font = new System.Drawing.Font("Rockwell", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.barvaHracuCheckedListBox.FormattingEnabled = true;
            this.barvaHracuCheckedListBox.Items.AddRange(new object[] {
            "Modra x Cervena (Z)",
            "Ruzova x Zluta",
            "Fialova x Oranzova"});
            this.barvaHracuCheckedListBox.Location = new System.Drawing.Point(26, 352);
            this.barvaHracuCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.barvaHracuCheckedListBox.Name = "barvaHracuCheckedListBox";
            this.barvaHracuCheckedListBox.Size = new System.Drawing.Size(177, 62);
            this.barvaHracuCheckedListBox.TabIndex = 19;
            this.barvaHracuCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.barvaHracuCheckedListBox_SelectedIndexChanged);
            // 
            // vyhraLabel
            // 
            this.vyhraLabel.AutoSize = true;
            this.vyhraLabel.BackColor = System.Drawing.Color.Transparent;
            this.vyhraLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vyhraLabel.Location = new System.Drawing.Point(636, 225);
            this.vyhraLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vyhraLabel.Name = "vyhraLabel";
            this.vyhraLabel.Size = new System.Drawing.Size(84, 29);
            this.vyhraLabel.TabIndex = 20;
            this.vyhraLabel.Text = "Vyhra";
            this.vyhraLabel.Visible = false;
            // 
            // VyhraTimer
            // 
            this.VyhraTimer.Interval = 10;
            this.VyhraTimer.Tick += new System.EventHandler(this.VyhraTimer_Tick);
            // 
            // NastaveniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 502);
            this.Controls.Add(this.micPiBox);
            this.Controls.Add(this.vyhraLabel);
            this.Controls.Add(this.barvaHracuCheckedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hracVpravoBodyLabel);
            this.Controls.Add(this.hracVlevoBodyLabel);
            this.Controls.Add(this.hracVpravoPiBox);
            this.Controls.Add(this.hracVlevoPiBox);
            this.Controls.Add(this.pozadiPiBox);
            this.Controls.Add(this.informaceButton);
            this.Controls.Add(this.rychlostMiceCheckedListBox);
            this.Controls.Add(this.rychlostMiceLabel);
            this.Controls.Add(this.rychlosthracuCheckedListBox);
            this.Controls.Add(this.rychlostHracuLabel);
            this.Controls.Add(this.bodyNaVyhruCheckedListBox);
            this.Controls.Add(this.bodyVyhraLabel);
            this.Controls.Add(this.barvaCheckedListBox);
            this.Controls.Add(this.barvaLabel);
            this.Controls.Add(this.OdejitLabel);
            this.Controls.Add(this.nastaveniLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(928, 557);
            this.MinimumSize = new System.Drawing.Size(545, 360);
            this.Name = "NastaveniForm";
            this.Text = "Nastaveni";
            this.Shown += new System.EventHandler(this.NastaveniForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pozadiPiBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hracVlevoPiBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hracVpravoPiBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micPiBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nastaveniLabel;
        private System.Windows.Forms.Button OdejitLabel;
        private System.Windows.Forms.Label barvaLabel;
        private System.Windows.Forms.CheckedListBox barvaCheckedListBox;
        private System.Windows.Forms.Label bodyVyhraLabel;
        private System.Windows.Forms.CheckedListBox bodyNaVyhruCheckedListBox;
        private System.Windows.Forms.Label rychlostHracuLabel;
        private System.Windows.Forms.CheckedListBox rychlosthracuCheckedListBox;
        private System.Windows.Forms.Label rychlostMiceLabel;
        private System.Windows.Forms.CheckedListBox rychlostMiceCheckedListBox;
        private System.Windows.Forms.Button informaceButton;
        private System.Windows.Forms.PictureBox pozadiPiBox;
        private System.Windows.Forms.PictureBox hracVlevoPiBox;
        private System.Windows.Forms.PictureBox hracVpravoPiBox;
        private System.Windows.Forms.Label hracVlevoBodyLabel;
        private System.Windows.Forms.Label hracVpravoBodyLabel;
        private System.Windows.Forms.PictureBox micPiBox;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox barvaHracuCheckedListBox;
        private System.Windows.Forms.Label vyhraLabel;
        private System.Windows.Forms.Timer VyhraTimer;
    }
}