using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Alerter;
using System.Data.OleDb;

namespace PC_STORE
{
    public partial class Users_permission : DevExpress.XtraEditors.XtraForm
    {
        public Users_permission()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            id_loginSpinEdit.Enabled = false;
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Pc_Stor_DB.mdb; Jet OLEDB:Database Password=816170";  //Provider=Microsoft.Jet.OLEDB.4.0
            cmd.Connection = cn;
            cn.Open();
            //Load_Data();
            simpleButton4.Enabled = false;
        }

        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();


        private void Users_permission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.dataSet1.login);

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            user_nameTextEdit.Text = ""; pass_userTextEdit.Text = ""; permissionSpinEdit.Text = "";
            simpleButton4.Enabled = true;
            simpleButton5.Enabled = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {

                string sql_insert = "insert into login (user_name,pass_user,permission) values ('" + user_nameTextEdit.Text + "','" + pass_userTextEdit.Text + "','" + permissionSpinEdit.Text + "')";
                cmd.CommandText = sql_insert;
                cmd.ExecuteNonQuery();

                AlertInfo info;
                info = new AlertInfo("", "Insertion User & Permission successful ");
                alertControl1.Show(this, info);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            simpleButton5.Enabled = true;
            user_nameTextEdit.Text = ""; pass_userTextEdit.Text = ""; permissionSpinEdit.Text = "";
            simpleButton4.Enabled = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        public void Load_Data()
        {

            try
            {


                OleDbConnection connet1 = new OleDbConnection(cn.ConnectionString);
                string sql = "select * from login";
                connet1.Open();
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sql, connet1);
                myadapter.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];
                connet1.Close();
                gridControl1.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update login set user_name='" + user_nameTextEdit.Text
                        + "',  pass_user='" + pass_userTextEdit.Text
                            + "',  permission='" + permissionSpinEdit.Text
                    + "' where id_login=" + id_loginSpinEdit.Text;

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                AlertInfo info;
                info = new AlertInfo("", "UPDATE User & Permission successful ");
                alertControl1.Show(this, info);

                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Load_Data();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" Are you sure you want to DELETE this USER ??   ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                string strSql = "delete from login where id_login=" + id_loginSpinEdit.Text;

                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();


                AlertInfo info;
                info = new AlertInfo("", "Deleted USER successful ");
                alertControl1.Show(this, info);

            }

            Load_Data();
        }
    }
}