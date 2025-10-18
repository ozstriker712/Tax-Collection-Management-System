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
    public partial class Update : DevExpress.XtraEditors.XtraForm
    {
        OleDbConnection cn = new OleDbConnection();

        OleDbCommand cmd = new OleDbCommand();

        public Update()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            dateEdit3.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            dateEdit4.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;

            //dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;  
            //dateEdit1.Properties.EditMask = "dd/MM/yyyy";
            //dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;

            dateEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dateEdit3.Properties.DisplayFormat.FormatString = "yyyy/MM";
            dateEdit3.Properties.EditMask = "yyyy/MM";
            dateEdit3.Properties.Mask.UseMaskAsDisplayFormat = true;

            dateEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dateEdit4.Properties.EditMask = "yyyy/MM";
            dateEdit4.Properties.Mask.UseMaskAsDisplayFormat = true;

            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Pc_Stor_DB.mdb; Jet OLEDB:Database Password=816170";  //Microsoft.Jet.OLEDB.4.0
            cmd.Connection = cn;
            textEdit1.Enabled = false;

            
            
        }

        public int index_val;
        private void Update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Historique_modification' table. You can move, or remove it, as needed.
            this.historique_modificationTableAdapter.Fill(this.dataSet11.Historique_modification);
            // TODO: This line of code loads data into the 'dataSet11.Historique_modification' table. You can move, or remove it, as needed.
            this.historique_modificationTableAdapter.Fill(this.dataSet11.Historique_modification);
            // TODO: This line of code loads data into the 'dateSet12.ancien_bdd' table. You can move, or remove it, as needed.
            this.ancien_bddTableAdapter.Fill(this.dateSet12.ancien_bdd);
            // TODO: This line of code loads data into the 'dataSet11.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.dataSet11.login);
            // TODO: This line of code loads data into the 'dataSet11.paramater' table. You can move, or remove it, as needed.
            this.paramaterTableAdapter.Fill(this.dataSet11.paramater);
            // TODO: This line of code loads data into the 'dataSet11.type_local' table. You can move, or remove it, as needed.
            this.type_localTableAdapter.Fill(this.dataSet11.type_local);
            
            // TODO: This line of code loads data into the 'pc_Stor_DBDataSet.client' table. You can move, or remove it, as needed.

            this.clientTableAdapter1.Fill(this.dataSet11.client);


            simpleButton2.Enabled = false;

            who_check();

        
           
        }

        
        private void who_check()
        {
            string string_cn = "select permission from login where user_name='" + textEdit6.Text +"'";
            cmd = new OleDbCommand(string_cn, cn);
            cn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            cmd.CommandText = string_cn;
           
            if (dr.Read() == true)
            {
                dr.Close();
                if (active_check_user_for_updateTextEdit.Text == "no")
                {
                    simpleButton2.Enabled = true;
                    MessageBox.Show("  خاصـــــية التعديـــــل مفتوحــــــة    ", " The Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    cn.Close();
                    
                }
                else
                {
                    if (active_check_user_for_updateTextEdit.Text == "yes" && cmd.ExecuteScalar().ToString() == "1")
                    {
                        simpleButton2.Enabled = true;
                        cn.Close();
                    }
                    else
                    {
                        if (active_check_user_for_updateTextEdit.Text == "yes" && cmd.ExecuteScalar().ToString() != "1" && textEdit6.Text == textEdit12.Text)
                        {
                            simpleButton2.Enabled = true;
                            cn.Close();
                        }
                        else
                        {
                            simpleButton2.Enabled = false;
                            MessageBox.Show("  هذا المستخـــــدم غير مصرح له للتعديل على هذا العنصر   ", " The Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cn.Close();
                        }
                    }
                }
                
                 
            }
 
            
        }

        int matricule_local;
        int dayssss, monthsss;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;


            ///
            string sqll = "SELECT * FROM client where num_index = " + num_indexSpinEdit.Text + "";
            cmd = new OleDbCommand(sqll, cn);
            cn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            cmd.CommandText = sqll;


            OleDbConnection connet1 = new OleDbConnection(cn.ConnectionString);

            connet1.Open();
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            myadapter.SelectCommand = new OleDbCommand(sqll, connet1);
            myadapter.Fill(ds);

            int num_index = ds.Tables[0].Rows[0].Field<int>("num_index");
            int porte = ds.Tables[0].Rows[0].Field<int>("porte");
            int article = ds.Tables[0].Rows[0].Field<int>("article");
            string first_name_client = ds.Tables[0].Rows[0].Field<string>("first_name_client").ToString();
            string last_name_client = ds.Tables[0].Rows[0].Field<string>("last_name_client").ToString();
            string type = ds.Tables[0].Rows[0].Field<string>("type").ToString();
            string num_boutique = ds.Tables[0].Rows[0].Field<string>("num_boutique").ToString(); 
            Single somme_evry_time = ds.Tables[0].Rows[0].Field<int>("somme_evry_time");
            Single somme_payee = ds.Tables[0].Rows[0].Field<Single>("somme_payee");
            DateTime date_enregistrer = ds.Tables[0].Rows[0].Field<DateTime>("date_enregistrer");
            string date_payee = ds.Tables[0].Rows[0].Field<string>("date_payee").ToString();
            int nombre_moins = ds.Tables[0].Rows[0].Field<int>("nombre_moins");
            int nombre_daysss = ds.Tables[0].Rows[0].Field<int>("nombre_days");
            DateTime from_date = ds.Tables[0].Rows[0].Field<DateTime>("from_date");
            DateTime to_date = ds.Tables[0].Rows[0].Field<DateTime>("to_date");
            string remarque = ds.Tables[0].Rows[0].Field<string>("remarque").ToString();
            string date_operation = ds.Tables[0].Rows[0].Field<string>("date_operation").ToString();;
            string who = ds.Tables[0].Rows[0].Field<string>("who").ToString();
            string postion_local = ds.Tables[0].Rows[0].Field<string>("postion_local").ToString();
            matricule_local = ds.Tables[0].Rows[0].Field<int>("matricule_local");
            int num_quitance = ds.Tables[0].Rows[0].Field<int>("num_quitance");

           
            if (dr.Read() == true)
            {
                dr.Close();
                cn.Close();
            }
             

            string gg = "insert into Historique_modification ( num_index,porte,article,first_name_client,last_name_client,type,num_boutique,somme_payee,date_enregistrer,date_payee,nombre_moins,from_date,to_date,remarque,date_operation,who,postion_local,matricule_local, date_update,original_new_values,num_quitance,somme_evry_time,nombre_days ) values('"
                + num_index + "','" + porte + "','" + article + "','" + first_name_client + "','" + last_name_client + "','" + type + "','" + num_boutique + "','" + somme_payee + "','" + date_enregistrer + "','" + date_payee + "','" + nombre_moins
                + "','" + from_date + "','" + to_date + "','" + remarque + "','" + date_operation + "','" + who + "','" + postion_local + "','" + matricule_local + "','" + now.ToString() + "','" + "Originale Values" + "','" +num_quitance+ "','"+ somme_evry_time + "','"+nombre_daysss+ "')";
            Do_String(gg);
            cn.Close();

            ///


            if (checkBox1.Checked == false)
            {
                monthsss = Convert.ToInt32(textEdit10.Text);
            }
            else
            {
                dayssss = Convert.ToInt32(textEdit10.Text);

            }

            string sql = "update client set porte='" + textEdit2.Text
                + "',  article='" + textEdit3.Text
                + "',  first_name_client='" + textEdit4.Text
                + "',  last_name_client='" + textEdit5.Text
                + "',  type='" + gridLookUpEdit1.EditValue

                + "',  num_boutique='" + textEdit7.Text
                + "',  somme_payee='" + textEdit15.Text         //----
                + "',  somme_evry_time='" + textEdit8.Text
                + "',  date_enregistrer='" + dateEdit1.Text
                + "',  postion_local='" + textEdit9.Text
                + "',  date_payee='" + dateEdit2.Text
                + "',  nombre_moins='" + monthsss
                 + "',  nombre_days='" + dayssss
                + "',  from_date='" + dateEdit3.Text
                + "',  to_date='" + dateEdit4.Text
                + "',  remarque='" + textEdit11.Text
                + "',  num_index='" + num_indexSpinEdit.Text
                 + "',  matricule_local='" + num_indexSpinEdit.Text  
                 + "',  date_update='" + now.ToString()
                 + "',  num_quitance='" + textEdit14.Text 
                + "'  where id_client=" + textEdit1.Text;

                Do_String(sql);

                AlertInfo info;
                info = new AlertInfo("", "تم التعديـــــــــل على العنصر ");
                alertControl1.Show(this, info);

                cn.Close();
           
            // insert f new tab copy new +  rename new

                string kk = "insert into Historique_modification ( num_index,porte,article,first_name_client,last_name_client,type,num_boutique,somme_payee,date_enregistrer,date_payee,nombre_moins,from_date,to_date,remarque,date_operation,who,postion_local,matricule_local, date_update,original_new_values,somme_evry_time,nombre_days,num_quitance) values('"
                  + num_indexSpinEdit.Text + "','" + textEdit2.Text + "','" + textEdit3.Text + "','" + textEdit4.Text + "','" + textEdit5.Text + "','" + gridLookUpEdit1.EditValue + "','" + textEdit7.Text + "','" + textEdit15.Text + "','" + dateEdit1.Text + "','" + dateEdit2.Text + "','" + monthsss
                  + "','" + dateEdit3.Text + "','" + dateEdit4.Text + "','" + textEdit11.Text + "','" + date_operation + "','" + who + "','" + textEdit9.Text + "','" + num_indexSpinEdit.Text + "','" + now.ToString() + "','" + "NEW values" + "','"+textEdit8.Text + "','"+dayssss+ "','"+ textEdit14.Text + "')";

                Do_String(kk);
                cn.Close(); 
            //

             
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

        private void textEdit10_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit10.Text != "0")
            {
                //if (textEdit10.EditValue != null)
                //{
                //    val_moins = Convert.ToInt32(textEdit10.Text);
                //} 
                if (checkBox1.Checked == false)
                {
                    dateEdit4.EditValue = dateEdit3.DateTime.AddMonths(Convert.ToInt32(textEdit10.EditValue)).AddDays(-1);
                    textEdit15.EditValue = (Convert.ToInt32(textEdit8.EditValue)) * (Convert.ToInt32(textEdit10.EditValue));
                }
                else
                {
                    dateEdit4.EditValue = dateEdit3.DateTime.AddDays(Convert.ToInt32(textEdit10.EditValue)).AddDays(-1);
                    textEdit15.EditValue = (Convert.ToInt32(textEdit8.EditValue)) * (Convert.ToInt32(textEdit10.EditValue));
                }


            }
            else
            {
                MessageBox.Show(" !!....عدد الاشهر او الايام المحجوزة خاطئ . برجى التـــــأكد ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textEdit4_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));
        }

        private void textEdit5_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));
        }

        private void textEdit6_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));
        }

        private void textEdit11_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));
        }

        private void searchLookUpEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            ancienbddBindingSource.EndEdit();

            if (searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("num_index") != null)
            {

                textEdit4.Text = searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("nom").ToString();
                textEdit5.Text = searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("prenom").ToString();
                textEdit4.Text = searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("nom").ToString();
                gridLookUpEdit1.Text = searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("type").ToString();
                textEdit9.Text = searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("locale_postion").ToString();
                textEdit7.Text = searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("num_boutique").ToString();
                if (matricule_local !=0)
                {
                    textEdit8.Text = searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("somme").ToString();
                }
                
                textEdit13.Text = searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("num_index").ToString();

                ancienbddBindingSource.ResetBindings(true);
            }
        }

        private void simpleButton2_Enter(object sender, EventArgs e)
        {
            
            //string sql1 = "select * from client where num_index='" + num_indexSpinEdit.Text + "'";

            string sql2 = "insert into Historique_modification ( num_index,first_name_client,last_name_client,somme_payee,original_new_values) values('" + num_indexSpinEdit.Text + "','" + textEdit4.Text + "','" + textEdit5.Text + "','" + textEdit8.Text + "','" + "Originale Values" + "')";
            //Do_String(sql1);
            //memoEdit1.Text = sql1;
            //cn.Close();
        }

        
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                label13.Text = ": عدد الاشهر   ";
                dateEdit4.Properties.EditFormat.FormatString = "MM-yyyy";
                dateEdit3.Properties.EditFormat.FormatString = "MM-yyyy";
                dateEdit4.Properties.DisplayFormat.FormatString = "MM-yyyy";
                dateEdit3.Properties.DisplayFormat.FormatString = "MM-yyyy";
                dateEdit4.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
                dateEdit3.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
                dateEdit4.EditValue = dateEdit3.DateTime.AddMonths(Convert.ToInt32(textEdit10.EditValue)).AddDays(-1);
                textEdit15.EditValue = (Convert.ToInt32(textEdit8.EditValue)) * (Convert.ToInt32(textEdit10.EditValue));
               
            }
            else
            {


                label13.Text = ": عدد الأيام   ";
                dateEdit4.Properties.EditFormat.FormatString = "dd-MM-yyyy";
                dateEdit3.Properties.EditFormat.FormatString = "dd-MM-yyyy";
                dateEdit4.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
                dateEdit3.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
                dateEdit3.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView;
                dateEdit4.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView;
                dateEdit4.EditValue = dateEdit3.DateTime.AddDays(Convert.ToInt32(textEdit10.EditValue));
                textEdit15.EditValue = (Convert.ToInt32(textEdit8.EditValue)) * (Convert.ToInt32(textEdit10.EditValue));

            }
        }
    }
}

       
      
    

