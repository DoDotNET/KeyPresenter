namespace Do.DotNet.KeyPresenter
{
    partial class Presenter
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
            this.labelKey = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelPainter = new System.Windows.Forms.Panel();
            this.panelPainter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            this.labelKey.BackColor = System.Drawing.Color.Transparent;
            this.labelKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKey.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey.ForeColor = System.Drawing.Color.White;
            this.labelKey.Location = new System.Drawing.Point(0, 0);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(500, 80);
            this.labelKey.TabIndex = 0;
            this.labelKey.Text = "Ctrl+C";
            this.labelKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKey.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.labelKey.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelKey_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelPainter
            // 
            this.panelPainter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelPainter.Controls.Add(this.labelKey);
            this.panelPainter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPainter.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelPainter.Location = new System.Drawing.Point(0, 0);
            this.panelPainter.Name = "panelPainter";
            this.panelPainter.Size = new System.Drawing.Size(500, 80);
            this.panelPainter.TabIndex = 2;
            this.panelPainter.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxFrame_Paint);
            // 
            // Presenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(500, 80);
            this.Controls.Add(this.panelPainter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Presenter";
            this.Opacity = 0.9;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Do .NET Key Presenter 0.2 by do-dotnet.de";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Desktop;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPainter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelPainter;
    }
}

