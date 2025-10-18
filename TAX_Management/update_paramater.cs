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
    public partial class update_paramater : DevExpress.XtraEditors.XtraForm
    {
        public update_paramater()
        {
            InitializeComponent();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Pc_Stor_DB.mdb; Jet OLEDB:Database Password=816170";  //Microsoft.Jet.OLEDB.4.0
            cmd.Connection = cn;

        }

        OleDbConnection cn = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();

        private void paramaterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paramaterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);



        }

        private void Paramater_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.paramater' table. You can move, or remove it, as needed.
            this.paramaterTableAdapter.Fill(this.dataSet1.paramater);

        }

        private void Do_String(string q)
        {
            try
            {
                cn.Open();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sql = "update paramater set active_check_user_for_update='" + comboBoxEdit1.EditValue

               + "'  where id_paramater=" + id_paramaterSpinEdit.Text;

            Do_String(sql);

            AlertInfo info;
            info = new AlertInfo("", "تم التعديـــــــــل و الحفظ على العنصر ");
            alertControl1.Show(this, info);


        }
    }
}