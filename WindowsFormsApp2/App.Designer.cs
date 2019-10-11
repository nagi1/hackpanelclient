namespace WindowsFormsApp2
{
    partial class App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.keyinfolable = new System.Windows.Forms.GroupBox();
            this.keyinfo = new System.Windows.Forms.ListBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.keyinfolable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.keyinfolable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 161);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // keyinfolable
            // 
            this.keyinfolable.Controls.Add(this.keyinfo);
            this.keyinfolable.Location = new System.Drawing.Point(380, 19);
            this.keyinfolable.Name = "keyinfolable";
            this.keyinfolable.Size = new System.Drawing.Size(169, 124);
            this.keyinfolable.TabIndex = 24;
            this.keyinfolable.TabStop = false;
            this.keyinfolable.Text = "Key Info";
            // 
            // keyinfo
            // 
            this.keyinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyinfo.ForeColor = System.Drawing.Color.Black;
            this.keyinfo.FormattingEnabled = true;
            this.keyinfo.Location = new System.Drawing.Point(3, 16);
            this.keyinfo.Name = "keyinfo";
            this.keyinfo.Size = new System.Drawing.Size(163, 105);
            this.keyinfo.TabIndex = 0;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 241);
            this.Controls.Add(this.panel1);
            this.Name = "App";
            this.Text = "Hackpanel Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.keyinfolable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox keyinfolable;
        private System.Windows.Forms.ListBox keyinfo;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

