using MetroFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using API;
using Security;
using Settings;
using Tools;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace WindowsFormsApp2
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        
        ApiHandler api = Program.api;
        IniFile config = Program.config;      

        public Login()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroColorStyle.Black;
            metroStyleManager1.Theme = MetroThemeStyle.Light;
            metroStyleManager1.Update();

            versionLable.Text = config.Read("version", "App");
            statusLable.Text = config.Read("status", "App");

            string appHash = config.Read("hash", "App");
            //Console.WriteLine(api.getMeta());

           // foreach (var kvp in api.getAllMeta())
            //{
            //var Dump = ObjectDumper.Dump(api.getAppInfo());

            //var personsDump = ObjectDumper.Dump(api.getAppInfo().ToString(), DumpStyle.CSharp);
            //Console.WriteLine(personsDump);

            //foreach (var data in api.pairAllMeta())
            //{
            //    Console.WriteLine(data);
            //}
            //Console.WriteLine(personsDump);
           
                //Console.WriteLine(kvp.Value);
          //  }

           // Console.WriteLine(api.checkForMeta("version_check"));

            //Console.WriteLine(api.getMeta("version_check"));
            //Console.WriteLine(String.Equals(api.getMeta("version_check"), "true"));





            //if (Client.prod() != hashprod)
            //{
            //    //MessageBox.Show("Blocked");
            //    //Process.Start("https://www.facebook.com/PZ1996/");
            //    //this.Enabled = false;
            //    //this.Close();             
            //}



            if (Convert.ToBoolean(config.Read("version_check", "Meta") == "true"))
            {
                string appVersion = config.Read("version", "App");
                if (Program.getVersion() != appVersion)
                {
                    string newVersionLink = config.Read("update_url", "App");
                    MessageBox.Show("Plesae update you are using v (" + Program.getVersion() + ") Click Okay to download v (" + appVersion + ").");
                    Process.Start(newVersionLink);
                    loginButton.Enabled = false;
                    System.Environment.Exit(1);
                }
            }
            
             
            if (Convert.ToBoolean(config.Read("REMEMBER", "OPTIONS") == "1"))
            {
                remmberCheckbox.Checked = true;
            }
            else
            {
                remmberCheckbox.Checked = false;
            }

            if (remmberCheckbox.Checked)
            {
                if (config.KeyExists("data.key", "API"))
                {
                    keyinput.Text = Convert.ToString(config.Read("data.key", "API"));
                }
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var hwid = FingerPrint.Value();

            var login = api.Login(keyinput.Text, hwid, Program.appToken);
            var personsDump = ObjectDumper.Dump(login, DumpStyle.CSharp);
            Console.WriteLine(personsDump);

            if (Convert.ToBoolean(login["success"]) == false)
            {
                string message = login["message"].ToString();
                MessageBox.Show(message,
                 "something wrong!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error
                );
            }
            else if (Convert.ToBoolean(login["success"]) == true)
            {
                string message = login["message"].ToString();
                MessageBox.Show(message,
                 "Thanks!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );

                Program.syncKeyConfig(login);
                App app = new App();
                app.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Unknown Error!",
                 "Something Wrong!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error
                );
            }
        }

        private void MetroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (remmberCheckbox.Checked)
            {

                config.Write("REMEMBER", "1", "OPTIONS");
            }
            else
            {
                config.Write("REMEMBER", "0", "OPTIONS");
            }
        }
    }
}
