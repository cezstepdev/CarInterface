namespace CarInterface
{
    partial class FormSettings
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
            this.Close = new System.Windows.Forms.Button();
            this.ChangeFont = new System.Windows.Forms.Button();
            this.TextTrackBar = new System.Windows.Forms.TrackBar();
            this.TextSize = new System.Windows.Forms.Label();
            this.ThemeChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Dock = System.Windows.Forms.DockStyle.Top;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Close.Location = new System.Drawing.Point(0, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(733, 42);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close application";
            this.Close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.BtnOverwiev_Click);
            // 
            // ChangeFont
            // 
            this.ChangeFont.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeFont.FlatAppearance.BorderSize = 0;
            this.ChangeFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeFont.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeFont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ChangeFont.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChangeFont.Location = new System.Drawing.Point(0, 42);
            this.ChangeFont.Name = "ChangeFont";
            this.ChangeFont.Size = new System.Drawing.Size(733, 42);
            this.ChangeFont.TabIndex = 4;
            this.ChangeFont.Text = "Change Font";
            this.ChangeFont.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ChangeFont.UseVisualStyleBackColor = true;
            this.ChangeFont.Click += new System.EventHandler(this.ChangeFont_Click);
            // 
            // TextTrackBar
            // 
            this.TextTrackBar.Location = new System.Drawing.Point(180, 90);
            this.TextTrackBar.Maximum = 16;
            this.TextTrackBar.Minimum = 10;
            this.TextTrackBar.Name = "TextTrackBar";
            this.TextTrackBar.Size = new System.Drawing.Size(379, 45);
            this.TextTrackBar.TabIndex = 5;
            this.TextTrackBar.Value = 10;
            this.TextTrackBar.Scroll += new System.EventHandler(this.TextTrackBar_Scroll);
            // 
            // TextSize
            // 
            this.TextSize.AutoSize = true;
            this.TextSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextSize.ForeColor = System.Drawing.SystemColors.Control;
            this.TextSize.Location = new System.Drawing.Point(350, 138);
            this.TextSize.Name = "TextSize";
            this.TextSize.Size = new System.Drawing.Size(36, 26);
            this.TextSize.TabIndex = 6;
            this.TextSize.Text = "10";
            // 
            // ThemeChange
            // 
            this.ThemeChange.FlatAppearance.BorderSize = 0;
            this.ThemeChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeChange.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ThemeChange.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ThemeChange.Location = new System.Drawing.Point(0, 167);
            this.ThemeChange.Name = "ThemeChange";
            this.ThemeChange.Size = new System.Drawing.Size(733, 42);
            this.ThemeChange.TabIndex = 7;
            this.ThemeChange.Text = "Change Theme";
            this.ThemeChange.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ThemeChange.UseVisualStyleBackColor = true;
            this.ThemeChange.Click += new System.EventHandler(this.ThemeChange_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.ThemeChange);
            this.Controls.Add(this.TextSize);
            this.Controls.Add(this.TextTrackBar);
            this.Controls.Add(this.ChangeFont);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            ((System.ComponentModel.ISupportInitialize)(this.TextTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button ChangeFont;
        private System.Windows.Forms.TrackBar TextTrackBar;
        private System.Windows.Forms.Label TextSize;
        private System.Windows.Forms.Button ThemeChange;
    }
}