namespace Bouncing_Ball_2._0
{
    partial class BouncingBallForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BouncingBallForm));
            this.hracVlevo = new System.Windows.Forms.PictureBox();
            this.hracVpravo = new System.Windows.Forms.PictureBox();
            this.mic = new System.Windows.Forms.PictureBox();
            this.pauzaLabel = new System.Windows.Forms.Label();
            this.doNastaveniButton = new System.Windows.Forms.Button();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.hracVlevoBodyLabel = new System.Windows.Forms.Label();
            this.hracVpravoBodyLabel = new System.Windows.Forms.Label();
            this.konecButton = new System.Windows.Forms.Button();
            this.hracVlevoVyhraLabel = new System.Windows.Forms.Label();
            this.hracVpravoVyhraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hracVlevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hracVpravo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mic)).BeginInit();
            this.SuspendLayout();
            // 
            // hracVlevo
            // 
            this.hracVlevo.BackColor = System.Drawing.Color.Crimson;
            this.hracVlevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hracVlevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hracVlevo.Location = new System.Drawing.Point(12, 295);
            this.hracVlevo.Name = "hracVlevo";
            this.hracVlevo.Size = new System.Drawing.Size(24, 149);
            this.hracVlevo.TabIndex = 0;
            this.hracVlevo.TabStop = false;
            // 
            // hracVpravo
            // 
            this.hracVpravo.BackColor = System.Drawing.Color.MediumBlue;
            this.hracVpravo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hracVpravo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hracVpravo.Location = new System.Drawing.Point(1378, 295);
            this.hracVpravo.Name = "hracVpravo";
            this.hracVpravo.Size = new System.Drawing.Size(24, 149);
            this.hracVpravo.TabIndex = 1;
            this.hracVpravo.TabStop = false;
            // 
            // mic
            // 
            this.mic.Image = ((System.Drawing.Image)(resources.GetObject("mic.Image")));
            this.mic.Location = new System.Drawing.Point(675, 337);
            this.mic.Name = "mic";
            this.mic.Size = new System.Drawing.Size(65, 65);
            this.mic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mic.TabIndex = 2;
            this.mic.TabStop = false;
            // 
            // pauzaLabel
            // 
            this.pauzaLabel.AutoSize = true;
            this.pauzaLabel.BackColor = System.Drawing.Color.Transparent;
            this.pauzaLabel.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauzaLabel.Location = new System.Drawing.Point(626, 59);
            this.pauzaLabel.Name = "pauzaLabel";
            this.pauzaLabel.Size = new System.Drawing.Size(169, 53);
            this.pauzaLabel.TabIndex = 3;
            this.pauzaLabel.Text = "PAUZA";
            this.pauzaLabel.Click += new System.EventHandler(this.pauzaLabel_Click);
            // 
            // doNastaveniButton
            // 
            this.doNastaveniButton.BackColor = System.Drawing.Color.Ivory;
            this.doNastaveniButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doNastaveniButton.Font = new System.Drawing.Font("Rockwell", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doNastaveniButton.Location = new System.Drawing.Point(611, 139);
            this.doNastaveniButton.Name = "doNastaveniButton";
            this.doNastaveniButton.Size = new System.Drawing.Size(192, 89);
            this.doNastaveniButton.TabIndex = 4;
            this.doNastaveniButton.TabStop = false;
            this.doNastaveniButton.Text = "Zpet do nastaveni";
            this.doNastaveniButton.UseVisualStyleBackColor = false;
            this.doNastaveniButton.Click += new System.EventHandler(this.doNastaveniButton_Click);
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 30;
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // hracVlevoBodyLabel
            // 
            this.hracVlevoBodyLabel.AutoSize = true;
            this.hracVlevoBodyLabel.BackColor = System.Drawing.Color.Transparent;
            this.hracVlevoBodyLabel.Font = new System.Drawing.Font("Rockwell", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hracVlevoBodyLabel.Location = new System.Drawing.Point(60, 60);
            this.hracVlevoBodyLabel.Name = "hracVlevoBodyLabel";
            this.hracVlevoBodyLabel.Size = new System.Drawing.Size(73, 84);
            this.hracVlevoBodyLabel.TabIndex = 5;
            this.hracVlevoBodyLabel.Text = "0";
            // 
            // hracVpravoBodyLabel
            // 
            this.hracVpravoBodyLabel.AutoSize = true;
            this.hracVpravoBodyLabel.BackColor = System.Drawing.Color.Transparent;
            this.hracVpravoBodyLabel.Font = new System.Drawing.Font("Rockwell", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.hracVpravoBodyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hracVpravoBodyLabel.Location = new System.Drawing.Point(1280, 60);
            this.hracVpravoBodyLabel.Name = "hracVpravoBodyLabel";
            this.hracVpravoBodyLabel.Size = new System.Drawing.Size(73, 84);
            this.hracVpravoBodyLabel.TabIndex = 6;
            this.hracVpravoBodyLabel.Text = "0";
            // 
            // konecButton
            // 
            this.konecButton.BackColor = System.Drawing.Color.AliceBlue;
            this.konecButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.konecButton.Font = new System.Drawing.Font("Rockwell", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.konecButton.Location = new System.Drawing.Point(586, 530);
            this.konecButton.Name = "konecButton";
            this.konecButton.Size = new System.Drawing.Size(242, 75);
            this.konecButton.TabIndex = 7;
            this.konecButton.TabStop = false;
            this.konecButton.Text = "Konec hrani";
            this.konecButton.UseVisualStyleBackColor = false;
            this.konecButton.Click += new System.EventHandler(this.konecButton_Click);
            // 
            // hracVlevoVyhraLabel
            // 
            this.hracVlevoVyhraLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.hracVlevoVyhraLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hracVlevoVyhraLabel.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hracVlevoVyhraLabel.ForeColor = System.Drawing.Color.Crimson;
            this.hracVlevoVyhraLabel.Location = new System.Drawing.Point(165, 305);
            this.hracVlevoVyhraLabel.Name = "hracVlevoVyhraLabel";
            this.hracVlevoVyhraLabel.Size = new System.Drawing.Size(322, 128);
            this.hracVlevoVyhraLabel.TabIndex = 8;
            this.hracVlevoVyhraLabel.Text = "Hrac Vlevo !!VYHRAL!!";
            this.hracVlevoVyhraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hracVlevoVyhraLabel.Visible = false;
            // 
            // hracVpravoVyhraLabel
            // 
            this.hracVpravoVyhraLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.hracVpravoVyhraLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hracVpravoVyhraLabel.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hracVpravoVyhraLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.hracVpravoVyhraLabel.Location = new System.Drawing.Point(936, 305);
            this.hracVpravoVyhraLabel.Name = "hracVpravoVyhraLabel";
            this.hracVpravoVyhraLabel.Size = new System.Drawing.Size(322, 128);
            this.hracVpravoVyhraLabel.TabIndex = 9;
            this.hracVpravoVyhraLabel.Text = "Hrac Vpravo !!VYHRAL!!";
            this.hracVpravoVyhraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hracVpravoVyhraLabel.Visible = false;
            // 
            // BouncingBallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1414, 739);
            this.Controls.Add(this.hracVpravoVyhraLabel);
            this.Controls.Add(this.hracVlevoVyhraLabel);
            this.Controls.Add(this.konecButton);
            this.Controls.Add(this.doNastaveniButton);
            this.Controls.Add(this.pauzaLabel);
            this.Controls.Add(this.mic);
            this.Controls.Add(this.hracVpravo);
            this.Controls.Add(this.hracVlevo);
            this.Controls.Add(this.hracVpravoBodyLabel);
            this.Controls.Add(this.hracVlevoBodyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1440, 810);
            this.Name = "BouncingBallForm";
            this.Text = "Bouncing Ball 2.0";
            this.Load += new System.EventHandler(this.BouncingBallForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.BouncingBallForm_ClientSizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BouncingBallForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BouncingBallForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.hracVlevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hracVpravo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hracVlevo;
        private System.Windows.Forms.PictureBox hracVpravo;
        private System.Windows.Forms.PictureBox mic;
        private System.Windows.Forms.Label pauzaLabel;
        private System.Windows.Forms.Button doNastaveniButton;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Label hracVlevoBodyLabel;
        private System.Windows.Forms.Label hracVpravoBodyLabel;
        private System.Windows.Forms.Button konecButton;
        private System.Windows.Forms.Label hracVlevoVyhraLabel;
        private System.Windows.Forms.Label hracVpravoVyhraLabel;
    }
}

