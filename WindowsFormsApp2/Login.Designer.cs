namespace WindowsFormsApp2
{
    partial class Login
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.keyinput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.remmberCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.versionLable = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.statusLable = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // keyinput
            // 
            // 
            // 
            // 
            this.keyinput.CustomButton.Image = null;
            this.keyinput.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.keyinput.CustomButton.Name = "";
            this.keyinput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.keyinput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyinput.CustomButton.TabIndex = 1;
            this.keyinput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyinput.CustomButton.UseSelectable = true;
            this.keyinput.CustomButton.Visible = false;
            this.keyinput.Lines = new string[0];
            this.keyinput.Location = new System.Drawing.Point(76, 67);
            this.keyinput.MaxLength = 32767;
            this.keyinput.Name = "keyinput";
            this.keyinput.PasswordChar = '\0';
            this.keyinput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyinput.SelectedText = "";
            this.keyinput.SelectionLength = 0;
            this.keyinput.SelectionStart = 0;
            this.keyinput.ShortcutsEnabled = true;
            this.keyinput.Size = new System.Drawing.Size(191, 23);
            this.keyinput.TabIndex = 0;
            this.keyinput.UseSelectable = true;
            this.keyinput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyinput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(29, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Key";
            // 
            // remmberCheckbox
            // 
            this.remmberCheckbox.AutoSize = true;
            this.remmberCheckbox.Location = new System.Drawing.Point(76, 96);
            this.remmberCheckbox.Name = "remmberCheckbox";
            this.remmberCheckbox.Size = new System.Drawing.Size(103, 15);
            this.remmberCheckbox.TabIndex = 2;
            this.remmberCheckbox.Text = "Remember Key";
            this.remmberCheckbox.UseSelectable = true;
            this.remmberCheckbox.CheckedChanged += new System.EventHandler(this.MetroCheckBox1_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(76, 117);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(76, 181);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Version : ";
            // 
            // versionLable
            // 
            this.versionLable.AutoSize = true;
            this.versionLable.Location = new System.Drawing.Point(144, 181);
            this.versionLable.Name = "versionLable";
            this.versionLable.Size = new System.Drawing.Size(21, 19);
            this.versionLable.TabIndex = 6;
            this.versionLable.Text = "--";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(76, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Status : ";
            // 
            // statusLable
            // 
            this.statusLable.AutoSize = true;
            this.statusLable.Location = new System.Drawing.Point(123, 158);
            this.statusLable.Name = "statusLable";
            this.statusLable.Size = new System.Drawing.Size(21, 19);
            this.statusLable.TabIndex = 11;
            this.statusLable.Text = "--";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 220);
            this.Controls.Add(this.statusLable);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.versionLable);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.remmberCheckbox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.keyinput);
            this.Name = "Login";
            this.Text = "Hackpanel Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox keyinput;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox remmberCheckbox;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel versionLable;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel statusLable;
    }
}