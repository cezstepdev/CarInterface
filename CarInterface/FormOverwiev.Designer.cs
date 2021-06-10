namespace CarInterface
{
    partial class FormOverwiev
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MetersSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MilesSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RotationPerMinute = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Gear = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Light = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Brake = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Lock = new System.Windows.Forms.Button();
            this.BtnOverwiev = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.MetersSpeed);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.MilesSpeed);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(235, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 130);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(119, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "km/h";
            // 
            // MetersSpeed
            // 
            this.MetersSpeed.AutoSize = true;
            this.MetersSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MetersSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.MetersSpeed.Location = new System.Drawing.Point(52, 47);
            this.MetersSpeed.Name = "MetersSpeed";
            this.MetersSpeed.Size = new System.Drawing.Size(32, 32);
            this.MetersSpeed.TabIndex = 1;
            this.MetersSpeed.Text = "0";
            this.MetersSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(122, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MPH";
            this.label2.Click += new System.EventHandler(this.milesSpeed_Click);
            // 
            // MilesSpeed
            // 
            this.MilesSpeed.AutoSize = true;
            this.MilesSpeed.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilesSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.MilesSpeed.Location = new System.Drawing.Point(101, 97);
            this.MilesSpeed.Name = "MilesSpeed";
            this.MilesSpeed.Size = new System.Drawing.Size(15, 17);
            this.MilesSpeed.TabIndex = 0;
            this.MilesSpeed.Text = "0";
            this.MilesSpeed.Click += new System.EventHandler(this.milesSpeed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(99, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Speed";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.RotationPerMinute);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(222, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 130);
            this.panel1.TabIndex = 9;
            // 
            // RotationPerMinute
            // 
            this.RotationPerMinute.AutoSize = true;
            this.RotationPerMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RotationPerMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RotationPerMinute.Location = new System.Drawing.Point(39, 47);
            this.RotationPerMinute.Name = "RotationPerMinute";
            this.RotationPerMinute.Size = new System.Drawing.Size(58, 32);
            this.RotationPerMinute.TabIndex = 1;
            this.RotationPerMinute.Text = "1,0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(68, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "x1000";
            this.label6.Click += new System.EventHandler(this.milesSpeed_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "RPM";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Gear);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(383, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 130);
            this.panel2.TabIndex = 9;
            // 
            // Gear
            // 
            this.Gear.AutoSize = true;
            this.Gear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Gear.Location = new System.Drawing.Point(44, 47);
            this.Gear.Name = "Gear";
            this.Gear.Size = new System.Drawing.Size(32, 32);
            this.Gear.TabIndex = 1;
            this.Gear.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(35, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Gear";
            this.label11.Click += new System.EventHandler(this.label4_Click);
            // 
            // Light
            // 
            this.Light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(43)))));
            this.Light.FlatAppearance.BorderSize = 0;
            this.Light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Light.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Light.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Light.Image = global::CarInterface.Properties.Resources.lights;
            this.Light.Location = new System.Drawing.Point(582, 308);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(46, 42);
            this.Light.TabIndex = 10;
            this.Light.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Light.UseVisualStyleBackColor = false;
            this.Light.Click += new System.EventHandler(this.Light_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(43)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Image = global::CarInterface.Properties.Resources.seatBelts;
            this.button2.Location = new System.Drawing.Point(172, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 42);
            this.button2.TabIndex = 10;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Brake
            // 
            this.Brake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(43)))));
            this.Brake.FlatAppearance.BorderSize = 0;
            this.Brake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brake.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Brake.Image = global::CarInterface.Properties.Resources.handbrake;
            this.Brake.Location = new System.Drawing.Point(543, 356);
            this.Brake.Name = "Brake";
            this.Brake.Size = new System.Drawing.Size(46, 42);
            this.Brake.TabIndex = 10;
            this.Brake.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Brake.UseVisualStyleBackColor = false;
            this.Brake.Click += new System.EventHandler(this.Brake_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(43)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = global::CarInterface.Properties.Resources.gasolinePump;
            this.button1.Location = new System.Drawing.Point(120, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 42);
            this.button1.TabIndex = 10;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Lock
            // 
            this.Lock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(43)))));
            this.Lock.FlatAppearance.BorderSize = 0;
            this.Lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lock.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Lock.Image = global::CarInterface.Properties.Resources.doorLock;
            this.Lock.Location = new System.Drawing.Point(491, 393);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(46, 42);
            this.Lock.TabIndex = 10;
            this.Lock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Lock.UseVisualStyleBackColor = false;
            this.Lock.Click += new System.EventHandler(this.Lock_Click);
            // 
            // BtnOverwiev
            // 
            this.BtnOverwiev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(43)))));
            this.BtnOverwiev.FlatAppearance.BorderSize = 0;
            this.BtnOverwiev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOverwiev.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOverwiev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnOverwiev.Image = global::CarInterface.Properties.Resources.baterry;
            this.BtnOverwiev.Location = new System.Drawing.Point(93, 308);
            this.BtnOverwiev.Name = "BtnOverwiev";
            this.BtnOverwiev.Size = new System.Drawing.Size(46, 42);
            this.BtnOverwiev.TabIndex = 10;
            this.BtnOverwiev.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnOverwiev.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(35, 188);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(661, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // FormOverwiev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Light);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Brake);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.BtnOverwiev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOverwiev";
            this.Text = "FromOverwiev";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label MetersSpeed;
        private System.Windows.Forms.Label MilesSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RotationPerMinute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Gear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnOverwiev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Lock;
        private System.Windows.Forms.Button Brake;
        private System.Windows.Forms.Button Light;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}