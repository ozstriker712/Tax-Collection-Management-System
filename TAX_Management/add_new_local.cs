using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using DevExpress.XtraBars.Alerter;
using System.Globalization;

namespace PC_STORE
{
    public partial class add_new_local : DevExpress.XtraEditors.XtraForm
    {
        public add_new_local()
        {
            InitializeComponent();

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            //id_loginSpinEdit.Enabled = false;
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Pc_Stor_DB.mdb; Jet OLEDB:Database Password=816170";  //Provider=Microsoft.Jet.OLEDB.4.0
            cmd.Connection = cn;
            cn.Open();
            //Load_Data();
            simpleButton4.Enabled = false;

            id_typeSpinEdit.Enabled = false;
        }

        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        private void add_new_local_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.type_local' table. You can move, or remove it, as needed.
            this.type_localTableAdapter.Fill(this.dataSet1.type_local);

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            textedit1.Text = "";
            checkEdit1.EditValue = null;
            simpleButton4.Enabled = true;
            simpleButton5.Enabled = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {

                string sql_insert = "insert into type_local (name_type,num_local_exist) values ('" + textedit1.Text + "','" + val+ "')";
                cmd.CommandText = sql_insert;
                cmd.ExecuteNonQuery();

                AlertInfo info;
                info = new AlertInfo("", "لقد تم عملية الحفـــظ بنجــــاح ");
                alertControl1.Show(this, info);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            simpleButton5.Enabled = true;
            textedit1.Text = "";
            checkEdit1.EditValue = null;
             
            simpleButton4.Enabled = false;
        }

        int val;
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            val = checkEdit1.Checked ? 1 : 0;
           
        }


        public void Load_Data()
        {

            try
            {
                OleDbConnection connet1 = new OleDbConnection(cn.ConnectionString);
                string sql = "select * from type_local";
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update type_local set name_type='" + textedit1.Text + "',  num_local_exist='" + val

                    + "' where id_type=" + id_typeSpinEdit.Text;

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                AlertInfo info;
                info = new AlertInfo("", "لقـــد تمت عمليــة التعديـــل ");
                alertControl1.Show(this, info);

                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Load_Data();
        }

        private void textedit1_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("  هل أنت متأكــــــد من عملية الحــــذف ؟     ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                string strSql = "delete from type_local where id_type=" + id_typeSpinEdit.Text;

                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();


                AlertInfo info;
                info = new AlertInfo("", "لفد تمت عملية الحـــذف");
                alertControl1.Show(this, info);

            }

            Load_Data();
        }
    }
}