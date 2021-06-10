namespace CarInterface
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnAnalysis = new System.Windows.Forms.Button();
            this.BtnOverwiev = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.BtnRadio);
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnAnalysis);
            this.panel1.Controls.Add(this.BtnOverwiev);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 155);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 42);
            this.PnlNav.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 155);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(58, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(50, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LblTitle.Location = new System.Drawing.Point(477, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(130, 32);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Analysis";
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(186, 100);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(765, 477);
            this.PnlFormLoader.TabIndex = 2;
            // 
            // BtnRadio
            // 
            this.BtnRadio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRadio.FlatAppearance.BorderSize = 0;
            this.BtnRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRadio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnRadio.Image = global::CarInterface.Properties.Resources.radio;
            this.BtnRadio.Location = new System.Drawing.Point(0, 239);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(186, 42);
            this.BtnRadio.TabIndex = 4;
            this.BtnRadio.Text = "Radio     ";
            this.BtnRadio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRadio.UseVisualStyleBackColor = true;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnHelp.Image = global::CarInterface.Properties.Resources.help;
            this.BtnHelp.Location = new System.Drawing.Point(0, 493);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(186, 42);
            this.BtnHelp.TabIndex = 2;
            this.BtnHelp.Text = "Help";
            this.BtnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnSettings.Image = global::CarInterface.Properties.Resources.settings;
            this.BtnSettings.Location = new System.Drawing.Point(0, 535);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(186, 42);
            this.BtnSettings.TabIndex = 2;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnAnalysis
            // 
            this.BtnAnalysis.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAnalysis.FlatAppearance.BorderSize = 0;
            this.BtnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalysis.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnAnalysis.Image = global::CarInterface.Properties.Resources.analysis;
            this.BtnAnalysis.Location = new System.Drawing.Point(0, 197);
            this.BtnAnalysis.Name = "BtnAnalysis";
            this.BtnAnalysis.Size = new System.Drawing.Size(186, 42);
            this.BtnAnalysis.TabIndex = 2;
            this.BtnAnalysis.Text = "Analysis";
            this.BtnAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAnalysis.UseVisualStyleBackColor = true;
            this.BtnAnalysis.Click += new System.EventHandler(this.BtnAnalysis_Click);
            // 
            // BtnOverwiev
            // 
            this.BtnOverwiev.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOverwiev.FlatAppearance.BorderSize = 0;
            this.BtnOverwiev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOverwiev.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOverwiev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnOverwiev.Image = global::CarInterface.Properties.Resources.home;
            this.BtnOverwiev.Location = new System.Drawing.Point(0, 155);
            this.BtnOverwiev.Name = "BtnOverwiev";
            this.BtnOverwiev.Size = new System.Drawing.Size(186, 42);
            this.BtnOverwiev.TabIndex = 2;
            this.BtnOverwiev.Text = "Overwiev";
            this.BtnOverwiev.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnOverwiev.UseVisualStyleBackColor = true;
            this.BtnOverwiev.Click += new System.EventHandler(this.BtnOverwiev_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarInterface.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "k";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnOverwiev;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnAnalysis;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Button BtnRadio;
    }
}

