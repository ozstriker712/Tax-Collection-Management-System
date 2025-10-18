using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Data.OleDb;

namespace PC_STORE
{
    public partial class Login : SplashScreen
    {

        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0 ; Data Source=.\Pc_Stor_DB.mdb ; Jet OLEDB:Database Password=816170");//Microsoft.Jet.OLEDB.4.0  or   Microsoft.ACE.OLEDB.12.0
        DataTable dt = new DataTable();
        OleDbDataAdapter da;
        OleDbCommand cmd = new OleDbCommand();

        public Login()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            cn.Open();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.dataSet1.login);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string string_cn = "select permission from login where user_name='" + comboBox1.Text + "' and pass_user='" + textEdit2.Text + "'";
                cmd = new OleDbCommand(string_cn, cn);
                OleDbDataReader dr = cmd.ExecuteReader();
                cmd.CommandText = string_cn;


                if (dr.Read() == true)
                {
                    Form1 form1 = new Form1();
                    old_bdd frm2 = new old_bdd();

                    dr.Close();
                    if (cmd.ExecuteScalar().ToString() == "1")
                    {
                        form1.barButtonItem2.Enabled = false; form1.barButtonItem1.Enabled = false; form1.barCheckItem6.Enabled = false;
                        form1.Show();
                        form1.textEdit2.Text = comboBox1.Text; form1.barButtonItem1.Enabled = false;



                        this.Hide();

                    }
                    else
                    {
                        form1.barButtonItem12.Enabled = false; form1.barButtonItem2.Enabled = false; form1.barButtonItem3.Enabled = false;
                        form1.barButtonItem9.Enabled = false; form1.barButtonItem4.Enabled = false; form1.barButtonItem6.Enabled = false;
                        form1.barButtonItem7.Enabled = false; form1.barButtonItem14.Enabled = false; form1.barButtonItem15.Enabled = false;
                        form1.barCheckItem6.Enabled = false; form1.barButtonItem17.Enabled = false; form1.barButtonItem16.Enabled = false;
                        form1.barButtonItem20.Enabled = false; form1.barButtonItem1.Enabled = false;

                        form1.Show();
                        form1.textEdit2.Text = comboBox1.Text;
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show(" كلمة المــــــــرور خاطئــــة أو لا تتطابق مع اسم المستخدم ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textEdit2.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

      
    }
}