namespace SolarSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrentTime_Label = new System.Windows.Forms.Label();
            this.CurrentDate_label = new System.Windows.Forms.Label();
            this.CurrentTimeRefreshed_label = new System.Windows.Forms.Label();
            this.HalfSecond_timer = new System.Windows.Forms.Timer(this.components);
            this.FiveSeconds_timer = new System.Windows.Forms.Timer(this.components);
            this.TimerChanged_label = new System.Windows.Forms.Label();
            this.Sun = new System.Windows.Forms.Button();
            this.Mercury = new System.Windows.Forms.Button();
            this.Venus = new System.Windows.Forms.Button();
            this.Earth = new System.Windows.Forms.Button();
            this.SolarSystemTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CurrentTime_Label
            // 
            this.CurrentTime_Label.AutoSize = true;
            this.CurrentTime_Label.Location = new System.Drawing.Point(52, 43);
            this.CurrentTime_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentTime_Label.Name = "CurrentTime_Label";
            this.CurrentTime_Label.Size = new System.Drawing.Size(46, 17);
            this.CurrentTime_Label.TabIndex = 0;
            this.CurrentTime_Label.Text = "label1";
            // 
            // CurrentDate_label
            // 
            this.CurrentDate_label.AutoSize = true;
            this.CurrentDate_label.Location = new System.Drawing.Point(52, 75);
            this.CurrentDate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentDate_label.Name = "CurrentDate_label";
            this.CurrentDate_label.Size = new System.Drawing.Size(46, 17);
            this.CurrentDate_label.TabIndex = 1;
            this.CurrentDate_label.Text = "label1";
            // 
            // CurrentTimeRefreshed_label
            // 
            this.CurrentTimeRefreshed_label.AutoSize = true;
            this.CurrentTimeRefreshed_label.Location = new System.Drawing.Point(180, 57);
            this.CurrentTimeRefreshed_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentTimeRefreshed_label.Name = "CurrentTimeRefreshed_label";
            this.CurrentTimeRefreshed_label.Size = new System.Drawing.Size(46, 17);
            this.CurrentTimeRefreshed_label.TabIndex = 2;
            this.CurrentTimeRefreshed_label.Text = "label1";
            // 
            // HalfSecond_timer
            // 
            this.HalfSecond_timer.Tick += new System.EventHandler(this.HalfSecond_timer_Tick);
            // 
            // FiveSeconds_timer
            // 
            this.FiveSeconds_timer.Tick += new System.EventHandler(this.FiveSeconds_timer_Tick);
            // 
            // TimerChanged_label
            // 
            this.TimerChanged_label.AutoSize = true;
            this.TimerChanged_label.Location = new System.Drawing.Point(52, 11);
            this.TimerChanged_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimerChanged_label.Name = "TimerChanged_label";
            this.TimerChanged_label.Size = new System.Drawing.Size(0, 17);
            this.TimerChanged_label.TabIndex = 3;
            // 
            // Sun
            // 
            this.Sun.AutoEllipsis = true;
            this.Sun.BackColor = System.Drawing.Color.Gold;
            this.Sun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sun.BackgroundImage")));
            this.Sun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sun.Location = new System.Drawing.Point(627, 271);
            this.Sun.Margin = new System.Windows.Forms.Padding(4);
            this.Sun.Name = "Sun";
            this.Sun.Size = new System.Drawing.Size(120, 117);
            this.Sun.TabIndex = 4;
            this.Sun.TabStop = false;
            this.Sun.UseVisualStyleBackColor = false;
            this.Sun.Paint += new System.Windows.Forms.PaintEventHandler(this.Sun_Paint);
            // 
            // Mercury
            // 
            this.Mercury.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Mercury.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mercury.BackgroundImage")));
            this.Mercury.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mercury.Location = new System.Drawing.Point(647, 199);
            this.Mercury.Margin = new System.Windows.Forms.Padding(4);
            this.Mercury.Name = "Mercury";
            this.Mercury.Size = new System.Drawing.Size(83, 78);
            this.Mercury.TabIndex = 5;
            this.Mercury.TabStop = false;
            this.Mercury.UseVisualStyleBackColor = false;
            this.Mercury.Paint += new System.Windows.Forms.PaintEventHandler(this.Mercury_Paint);
            // 
            // Venus
            // 
            this.Venus.BackColor = System.Drawing.Color.SaddleBrown;
            this.Venus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Venus.BackgroundImage")));
            this.Venus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Venus.Location = new System.Drawing.Point(647, 94);
            this.Venus.Margin = new System.Windows.Forms.Padding(4);
            this.Venus.Name = "Venus";
            this.Venus.Size = new System.Drawing.Size(100, 87);
            this.Venus.TabIndex = 6;
            this.Venus.UseVisualStyleBackColor = false;
            this.Venus.Paint += new System.Windows.Forms.PaintEventHandler(this.Venus_Paint);
            // 
            // Earth
            // 
            this.Earth.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Earth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Earth.BackgroundImage")));
            this.Earth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Earth.Location = new System.Drawing.Point(647, 15);
            this.Earth.Margin = new System.Windows.Forms.Padding(4);
            this.Earth.Name = "Earth";
            this.Earth.Size = new System.Drawing.Size(30, 31);
            this.Earth.TabIndex = 7;
            this.Earth.UseVisualStyleBackColor = false;
            this.Earth.Paint += new System.Windows.Forms.PaintEventHandler(this.Earth_Paint);
            // 
            // SolarSystemTimer
            // 
            this.SolarSystemTimer.Tick += new System.EventHandler(this.SolarSystemTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.Earth);
            this.Controls.Add(this.Venus);
            this.Controls.Add(this.Mercury);
            this.Controls.Add(this.Sun);
            this.Controls.Add(this.TimerChanged_label);
            this.Controls.Add(this.CurrentTimeRefreshed_label);
            this.Controls.Add(this.CurrentDate_label);
            this.Controls.Add(this.CurrentTime_Label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentTime_Label;
        private System.Windows.Forms.Label CurrentDate_label;
        private System.Windows.Forms.Label CurrentTimeRefreshed_label;
        private System.Windows.Forms.Timer HalfSecond_timer;
        private System.Windows.Forms.Timer FiveSeconds_timer;
        private System.Windows.Forms.Label TimerChanged_label;
        private System.Windows.Forms.Button Sun;
        private System.Windows.Forms.Button Mercury;
        private System.Windows.Forms.Button Venus;
        private System.Windows.Forms.Button Earth;
        private System.Windows.Forms.Timer SolarSystemTimer;
    }
}

