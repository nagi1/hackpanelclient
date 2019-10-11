using API;
using MetroFramework;
using Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace WindowsFormsApp2
{
    public partial class App : MetroFramework.Forms.MetroForm
    {
        IniFile config = Program.config;

        public App()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            metroStyleManager1.Style = MetroColorStyle.Orange;
            metroStyleManager1.Theme = MetroThemeStyle.Light;
            metroStyleManager1.Update();           

            DateTime startDate = DateTime.Now;
            var time = config.Read("data.expires", "App");
            DateTime endDate = DateTime.Now;
                try
                {
                    endDate = DateTime.ParseExact(time.ToString(), "yyyy-M-dd HH:mm:ss", System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat);
                }
                catch (Exception exp) {}
                TimeSpan ts = endDate.Date - startDate.Date;
                double TotalDays = ts.TotalDays;
                keyinfo.Items.Add("Key: " + config.Read("data.key", "API"));
                keyinfo.Items.Add("Email: " + config.Read("data.email", "API"));
                keyinfo.Items.Add("Expire After: " + TotalDays + " Days");
           
                this.Update();

        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
           
        }


        private void Timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                //if (!Magic.GetProcessesByName("1", out _))
                //    Magic.Clear(pathui.Text, pathui.Text + "//1.exe");
                //if (!Magic.GetProcessesByName("2", out _))
                //    Magic.Clear(pathui.Text, pathui.Text + "//2.exe");
                //if (!Magic.GetProcessesByName("afix", out _))
                //    Magic.Clear(pathui.Text, pathui.Text + "//afix.exe");
            }
            catch { }
        }


        private void MetroTile1_Click(object sender, EventArgs e)
        {

        }

        private void MetroTile6_Click(object sender, EventArgs e)
        { }


        private void MetroTile2_Click(object sender, EventArgs e)
        {

        }

        private void MetroTile5_Click(object sender, EventArgs e)
        {

        }

        private void MetroTile3_Click(object sender, EventArgs e)
        {

        }

        private void MetroTile4_Click(object sender, EventArgs e)
        {
            //Task.Factory.StartNew(delegate ()
            //{
            //    Magic.Clear(pathui.Text, pathui.Text + "\\22.exe");
            //    string link = ApiHandler.getExeFile("22");
            //    Magic.download(pathui.Text, link, pathui.Text + "\\22.exe");
            //    Magic.hide(pathui.Text + "\\22.exe");
            //    if (File.Exists(pathui.Text + "\\22.exe"))
            //    {
            //        Process.Start(pathui.Text + "\\22.exe");
            //        listBox1.Items.Add("Bypassed2 Done");
            //        metroTile6.Enabled = false;
            //        metroTile5.Enabled = false;
            //    }
            //});
        }

        private void MetroTile8_Click(object sender, EventArgs e)
        {
            //////Task.Factory.StartNew(delegate ()
            //////{
            //////    Magic.Clear(pathui.Text, pathui.Text + "\\3.exe");
            //////    string link = ApiHandler.getExeFile("3");
            //////    Magic.download(pathui.Text, link, pathui.Text + "\\3.exe");
            //////    Magic.hide(pathui.Text + "\\3.exe");
            //////    if (File.Exists(pathui.Text + "\\3.exe"))
            //////    {
            //////        Process.Start(pathui.Text + "\\3.exe");
            //////        listBox1.Items.Add("Wait Game/98% Fix");
            //////    }
            //////});
        }

        private void MetroLink2_Click_1(object sender, EventArgs e)
        {
        
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            WebClient _webClient = new WebClient();
            Process.Start("https://youtu.be/BU6qLo-lAgY");
        }

        private void MetroTile7_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\ipfix.bat");
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
           
        }

        private void MetroTile9_Click(object sender, EventArgs e)
        {
            //Task.Factory.StartNew(delegate ()
            //{
            //    Magic.Clear(Environment.SystemDirectory + "\\drivers\\etc", Environment.SystemDirectory + "\\drivers\\etc\\" + "\\hosts");
            //    string link = ApiHandler.getExeFile("11");
            //    Magic.download(Environment.SystemDirectory + "\\drivers\\etc", link, Environment.SystemDirectory + "\\drivers\\etc\\" + "\\hosts");
            //    Magic.hide(Environment.SystemDirectory + "\\drivers\\etc\\" + "\\hosts");
            //    if (File.Exists(Environment.SystemDirectory + "\\drivers\\etc\\" + "\\hosts"))
            //    {
            //        //listBox1.Items.Add("Patched Servers Done");
            //    }
            //});
        }

        private void MetroTile11_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\fixE.bat");
        }

        private void MetroTile10_Click(object sender, EventArgs e)
        {
            //Magic.Clear(Environment.SystemDirectory + "\\drivers\\etc", Environment.SystemDirectory + "\\drivers\\etc\\" + "\\hosts");

        }

        private void MetroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
             
        }

        private void MetroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
