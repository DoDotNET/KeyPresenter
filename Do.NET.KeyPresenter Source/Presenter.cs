using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Do.DotNet.KeyPresenter
{
    public partial class Presenter : Form
    {
        public Presenter()
        {
            InitializeComponent();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            this.FormBorderStyle = this.FormBorderStyle == FormBorderStyle.None ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
            if (this.FormBorderStyle != FormBorderStyle.None)
                this.Region = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();

            foreach (Keys k in Enum.GetValues(typeof(Keys)))
            {
                if (Keyboard.IsKeyDown(k))
                {
                    if (text.Length != 0)
                        text.Append("+");

                    text.Append(k);
                }
            }

            string rowtext = text.ToString();
            rowtext = rowtext.Replace("+LControlKey", "");
            rowtext = rowtext.Replace("+RControlKey", "");
            rowtext = rowtext.Replace("+LMenu", "");
            rowtext = rowtext.Replace("+RMenu", "");
            rowtext = rowtext.Replace("+LShiftKey", "");
            rowtext = rowtext.Replace("+RShiftKey", "");
            rowtext = rowtext.Replace("+Return", "");
            rowtext = rowtext.Replace("+Next", "");
            rowtext = rowtext.Replace("+PageUp", "");
            rowtext = rowtext.Replace("+Oem1", "");
            rowtext = rowtext.Replace("+Oem2", "");
            rowtext = rowtext.Replace("+Oem3", "");
            rowtext = rowtext.Replace("+Oem4", "");
            rowtext = rowtext.Replace("+Oem5", "");
            rowtext = rowtext.Replace("+Oem6", "");
            rowtext = rowtext.Replace("+Oem7", "");
            rowtext = rowtext.Replace("+Oem8", "");
            rowtext = rowtext.Replace("+Oem102", "");
            rowtext = rowtext.Replace("+OemQuestion", "");
            rowtext = rowtext.Replace("+OemBackslash", "");
            rowtext = rowtext.Replace("+Oemtilde", "");
            rowtext = rowtext.Replace("+PrintScreen", "");
            rowtext = rowtext.Replace("+Capital", "");

            rowtext = rowtext.Replace("ControlKey", "Ctrl");
            rowtext = rowtext.Replace("ShiftKey", "Shift");
            rowtext = rowtext.Replace("Menu", "Alt");
            labelKey.Text = rowtext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 20;
        }


        private void groupBoxFrame_Paint(object sender, PaintEventArgs e)
        {
            if (this.FormBorderStyle != FormBorderStyle.None)
                return;

            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                System.Drawing.Drawing2D.LinearGradientBrush BackgroundGradientBrush = null;

                //Declare Variables
                int ArcWidth = 21;
                int ArcHeight = 21;
                int ArcX1 = 0;
                int ArcX2 = this.Width - 23;
                int ArcY1 = 0;
                int ArcY2 = this.Height - 23;

                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Brush BorderBrush = new SolidBrush(this.panelPainter.BackColor);
                System.Drawing.Pen BorderPen = new Pen(BorderBrush, 7);
                System.Drawing.Brush BackgroundBrush = new SolidBrush(this.panelPainter.BackColor);
                System.Drawing.SolidBrush ShadowBrush = null; System.Drawing.Drawing2D.GraphicsPath ShadowPath = null;

                float SweepAngle = 90f;
                path.AddArc(ArcX1, ArcY1, ArcWidth, ArcHeight, 180, SweepAngle);
                // Top Left 
                path.AddArc(ArcX2, ArcY1, ArcWidth, ArcHeight, 270, SweepAngle);
                //Top Right  
                path.AddArc(ArcX2, ArcY2, ArcWidth, ArcHeight, 360, SweepAngle);
                //Bottom Right 
                path.AddArc(ArcX1, ArcY2, ArcWidth, ArcHeight, 90, SweepAngle);
                //Bottom Left 
                path.CloseAllFigures();


                this.Region = new Region(path);

                BackgroundGradientBrush = new LinearGradientBrush(
                    new Rectangle(0, 0, this.Width, this.Height),
                     this.ForeColor, this.BackColor,
                    (LinearGradientMode)LinearGradientMode.Vertical);
                //Paint Rounded Rectangle                
                g.FillPath(BackgroundGradientBrush, path);

                g.DrawPath(BorderPen, path);

                if (path != null) { path.Dispose(); }
                if (BorderBrush != null) { BorderBrush.Dispose(); }
                if (BorderPen != null) { BorderPen.Dispose(); }
                if (BackgroundGradientBrush != null) { BackgroundGradientBrush.Dispose(); }
                if (BackgroundBrush != null) { BackgroundBrush.Dispose(); }
                if (ShadowBrush != null) { ShadowBrush.Dispose(); }
                if (ShadowPath != null) { ShadowPath.Dispose(); }
            }

        }

        private void labelKey_MouseMove(object sender, MouseEventArgs e)
        {
            
            if(
                (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left))
            {
                int x = e.X < 0 ? 0 : e.X;
                x = x > this.Width ? this.Width : x;
                this.Opacity = (x / (double)this.Width) + 0.1;
                Invalidate();
            }

            if (this.Opacity >= 1.0)
            {
                this.TransparencyKey = Color.Empty;
            }
            else
            {
                this.BackColor = SystemColors.Desktop;
            }
        }

    }
}
