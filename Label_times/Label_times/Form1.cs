using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class Form1 : Form
    {
        private double _mercuryAngle, _venusAngle, _earthAngle;
        private readonly int _mercuryRotationRadius;
        private readonly int _venusRotationRadius;
        private readonly int _earthRotationRadius;

        public Form1()
        {
            InitializeComponent();
            CurrentTime_Label.Text = DateTime.Now.ToLongTimeString();
            CurrentDate_label.Text = DateTime.Now.ToShortDateString();
            HalfSecond_timer.Enabled = FiveSeconds_timer.Enabled = SolarSystemTimer.Enabled = true;
            HalfSecond_timer.Interval = 500;
            FiveSeconds_timer.Interval = 5000;
            SolarSystemTimer.Interval = 100;
            _mercuryRotationRadius = Height / 2 - Mercury.Location.Y;
            _venusRotationRadius = Height / 2 - Venus.Location.Y;
            _earthRotationRadius = Height / 2 - Earth.Location.Y;
        }

        private void HalfSecond_timer_Tick(object sender, EventArgs e)
        {
            CurrentTimeRefreshed_label.Text = DateTime.Now.ToLongTimeString();
        }

        private void FiveSeconds_timer_Tick(object sender, EventArgs e)
        {
            CurrentTime_Label.Text = DateTime.Now.ToLongTimeString();
        }

        private void SolarSystemTimer_Tick(object sender, EventArgs e)
        {
            Mercury_Move(6);
            Venus_Move(4);
            Earth_Move(10);
        }

        private void Mercury_Move(double speed)
        {
            _mercuryAngle += Math.PI / speed;
            var x = Sun.Location.X + _mercuryRotationRadius * Math.Cos(_mercuryAngle);
            var y = Sun.Location.Y + _mercuryRotationRadius * Math.Sin(_mercuryAngle);
            Mercury.Location = new Point((int)x, (int)y);
        }

        private void Venus_Move(double speed)
        {
            _venusAngle += Math.PI / speed;
            var x = Sun.Location.X + _venusRotationRadius * Math.Cos(_venusAngle);
            var y = Sun.Location.Y + _venusRotationRadius * Math.Sin(_venusAngle);
            Venus.Location = new Point((int)x, (int)y);
        }

        private void Earth_Move(double speed)
        {
            _earthAngle += Math.PI / speed;
            var x = Sun.Location.X + _earthRotationRadius * Math.Cos(_earthAngle);
            var y = Sun.Location.Y + _earthRotationRadius * Math.Sin(_earthAngle);
            Earth.Location = new Point((int)x, (int)y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Sun_Paint(object sender, PaintEventArgs e)
        {
            var gp = new GraphicsPath();
            gp.AddEllipse(1, 1, Sun.Width - 4, Sun.Height - 4);
            Sun.Region = new Region(gp);
        }

        private void Mercury_Paint(object sender, PaintEventArgs e)
        {
            var gp = new GraphicsPath();
            gp.AddEllipse(1, 1, Mercury.Width - 4, Mercury.Height - 4);
            Mercury.Region = new Region(gp);
        }

        private void Venus_Paint(object sender, PaintEventArgs e)
        {
            var gp = new GraphicsPath();
            gp.AddEllipse(1, 1, Venus.Width - 4, Venus.Height - 4);
            Venus.Region = new Region(gp);
        }

        private void Earth_Paint(object sender, PaintEventArgs e)
        {
            var gp = new GraphicsPath();
            gp.AddEllipse(1, 1, Earth.Width - 4, Earth.Height - 4);
            Earth.Region = new Region(gp);
        }
    }
}