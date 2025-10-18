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
    public partial class old_bdd : DevExpress.XtraEditors.XtraForm
    {
        public old_bdd()
        {
            InitializeComponent();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Pc_Stor_DB.mdb; Jet OLEDB:Database Password=816170";  //Microsoft.Jet.OLEDB.4.0
            cmd.Connection = cn;

        }

        private void old_bdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dateSet12.type_local' table. You can move, or remove it, as needed.
            this.type_localTableAdapter.Fill(this.dateSet12.type_local);
            // TODO: This line of code loads data into the 'dateSet12.ancien_bdd' table. You can move, or remove it, as needed.
            this.ancien_bddTableAdapter.Fill(this.dateSet12.ancien_bdd);


            cheeck_who();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cn.Close();
            string sql = "update ancien_bdd set nom='" + nomTextEdit.Text
                + "',  num_index='" + num_indexSpinEdit.Text
                + "',  prenom='" + prenomTextEdit.Text
                + "',  somme='" + sommeSpinEdit.Text
                + "',  type='" + gridLookUpEdit1.EditValue

                + "',  num_boutique='" + num_boutiqueSpinEdit.Text

                + "',  modwala='" + modwalaTextEdit.Text
                + "',  locale_postion='" + locale_postionTextEdit.Text

                + "'  where ID=" + iDSpinEdit.Text;

            Do_String(sql);

            AlertInfo info;
            info = new AlertInfo("", "تم التعديـــــــــل على العنصر ");
            alertControl1.Show(this, info);

        }


        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

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

        private void cheeck_who()
        {
            string string_cn = "select permission from login where user_name='" + textEdit1.Text +"'";
            cmd = new OleDbCommand(string_cn, cn);
            cn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            cmd.CommandText = string_cn;
            

            if (dr.Read() == true)
            {
                dr.Close();
                if (cmd.ExecuteScalar().ToString() != "1")
                {
                    simpleButton2.Enabled = false; simpleButton1.Enabled = false; simpleButton3.Enabled = false;
                   
                    cn.Close();

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            num_indexSpinEdit.Text = "";
            nomTextEdit.Text = "";
                prenomTextEdit.Text = "";
                sommeSpinEdit.Text = "";
                    gridLookUpEdit1.Text = "";
                    num_boutiqueSpinEdit.Text = "";
                        locale_postionTextEdit.Text = "";
                        modwalaTextEdit.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {

                string sql_insert = "insert into ancien_bdd (num_index,nom,prenom,somme,type,num_boutique,locale_postion,modwala) values ('"
                    + num_indexSpinEdit.Text + "','" + nomTextEdit.Text + "','" + prenomTextEdit.Text + "','" + sommeSpinEdit.Text + "','" +
                    gridLookUpEdit1.EditValue + "','" + num_boutiqueSpinEdit.Text + "','" + locale_postionTextEdit.Text + "','"   + modwalaTextEdit.Text+ "')";
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
        }

        

    }
}