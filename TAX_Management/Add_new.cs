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
    public partial class Add_new : DevExpress.XtraEditors.XtraForm
    {
        public Add_new()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Pc_Stor_DB.mdb; Jet OLEDB:Database Password=816170";  //Provider=Microsoft.Jet.OLEDB.4.0
            cmd.Connection = cn;

            dateEdit3.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            dateEdit4.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            textEdit7.Enabled = false;
            
            textEdit1.Enabled = false; textEdit12.Enabled = false; 
      

            

        }

        OleDbConnection cn = new OleDbConnection();
        Form1 form1 = new Form1();
        OleDbCommand cmd = new OleDbCommand();

        private void Add_new_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dateSet12.ancien_bdd' table. You can move, or remove it, as needed.
            this.ancien_bddTableAdapter.Fill(this.dateSet12.ancien_bdd);
            // TODO: This line of code loads data into the 'dateSet12.type_local' table. You can move, or remove it, as needed.
            this.type_localTableAdapter.Fill(this.dateSet12.type_local);
           
         
            // TODO: This line of code loads data into the 'dataSet11.type_local' table. You can move, or remove it, as needed. 
            this.clientTableAdapter1.Fill(this.dataSet11.client);
            Refresh_me();
           
        }

        public void ClearSpace( )
        {
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = ""; textEdit5.Text = ""; 
            gridLookUpEdit1.Text = "";
            //textEdit6.Text = ""; textEdit7.Text = ""; textEdit8.Text = "";
            textEdit9.Text = ""; textEdit11.Text = ""; //textEdit10.Text = ""; 
          
            textEdit8.Text = "";
            dateEdit2.EditValue = null; dateEdit1.EditValue = null;
            dateEdit3.EditValue = null; dateEdit4.EditValue = null;
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
        
        DateTime now = DateTime.Now;
        //int test = 0;
        int dayssss , monthsss;
        private void simpleButton1_Click(object sender, EventArgs e)
        {

                if (textEdit6.EditValue ==null)
                {
                    textEdit6.EditValue = 0;
                }

                if (textEdit2.Text != "" || textEdit3.Text != "" || textEdit4.Text != "" || textEdit5.Text != "" || textEdit8.Text != "" || textEdit9.Text != "" || textEdit10.Text != "" || dateEdit1.Text != "" || dateEdit2.Text != "")
                {
                if (checkBox1.Checked==false)
                {
                    monthsss = Convert.ToInt32(textEdit10.Text);
                }
                else
                {
                    dayssss= Convert.ToInt32(textEdit10.Text);

                }
                    
                    textEdit12.Text = now.ToString();
                    string q = "insert into client ( num_index,porte,article,first_name_client,last_name_client,type,num_boutique,somme_payee,date_enregistrer,postion_local,date_payee,nombre_moins,from_date,to_date,remarque,date_operation,who,matricule_local, num_quitance, somme_evry_time,nombre_days ) values('"
                           + num_indexSpinEdit.Text + "','" + textEdit2.Text + "','" + textEdit3.Text + "','" + textEdit4.Text + "','" + textEdit5.Text + "','" + gridLookUpEdit1.Text.ToString() + "','" + textEdit7.Text + "','" + textEdit14.Text
                           + "','" + dateEdit1.Text + "','" + textEdit9.Text + "','" + dateEdit2.Text + "','" + monthsss + "','" + dateEdit3.EditValue + "','" + dateEdit4.EditValue + "','" + textEdit11.Text + "','" +
                           textEdit12.Text + "','" + textEdit1.Text + "','" + textEdit6.Text +"','" + textEdit13.Text+ "','"+textEdit8.Text + "','"+ dayssss + "')";


                    Do_String(q);

                     //textEdit14.Text = ""; textEdit13.Text = "";; textEdit7.Text = ""; searchLookUpEdit1.EditValue = null; // textEdit10.Text = ""

                    AlertInfo info;
                    info = new AlertInfo("", "تمــت عمليـــة الحجـــز ");
                    alertControl1.Show(this, info);

                    textBox1.Text = dataSet11.client[dataSet11.client.Count - 1].num_index.ToString();
                    cn.Close();
                    ClearSpace();
                    textEdit7.Enabled = false;

                    Refresh_me();




                 }


                else
                {
                    MessageBox.Show(" بوجد حقل فارغ . برجى التـــــأكد .... ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


        }





        private void textEdit10_EditValueChanged(object sender, EventArgs e)
        {
            //int val_moins;
            //DateTime last_day_in_month; 


            if (textEdit10.Text != "0" )
            {
                //if (textEdit10.EditValue != null)
                //{
                //    val_moins = Convert.ToInt32(textEdit10.Text);
                //} 
                if (checkBox1.Checked == false)
                {
                    dateEdit4.EditValue = dateEdit3.DateTime.AddMonths(Convert.ToInt32(textEdit10.EditValue)).AddDays(-1);
                    textEdit14.EditValue = (Convert.ToInt32(textEdit8.EditValue)) * (Convert.ToInt32(textEdit10.EditValue));
                }
                else
                {
                    dateEdit4.EditValue = dateEdit3.DateTime.AddDays(Convert.ToInt32(textEdit10.EditValue)).AddDays(-1);
                    textEdit14.EditValue = (Convert.ToInt32(textEdit8.EditValue)) * (Convert.ToInt32(textEdit10.EditValue));
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

       

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            cn.Close();

            string string_cn = "select num_local_exist from type_local where name_type='" + gridLookUpEdit1.EditValue.ToString() + "'";
            
            cmd = new OleDbCommand(string_cn, cn);
            cn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            cmd.CommandText = string_cn;
             
              if (dr.Read() == true)
                {
                    dr.Close();
                    //textEdit13.Text = cmd.ExecuteScalar().ToString();
                  if (cmd.ExecuteScalar().ToString()=="False")
                    {
                        textEdit7.Enabled = false;
                        cn.Close();
                    }
                  else
                  {
                      textEdit7.Enabled = true;
                      cn.Close();
                  }
                  
 
                      
               }

        }

       

        void Refresh_me()
        {
            
            this.dataSet11.Reset();
            this.clientTableAdapter1.Fill(this.dataSet11.client);
            textBox1.Text = dataSet11.client[dataSet11.client.Count - 1].num_index.ToString();

            num_indexSpinEdit.EditValue = (dataSet11.client[dataSet11.client.Count - 1].num_index) + 1;
            cn.Close();


        }


        private void searchLookUpEdit1_EditValueChanging_1(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
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
                textEdit8.Text = searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("somme").ToString();
                textEdit6.Text = searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("num_index").ToString();

                ancienbddBindingSource.ResetBindings(true);
            }
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
                dateEdit4.EditValue = dateEdit3.DateTime.AddMonths(Convert.ToInt32(textEdit10.EditValue)).AddDays(-1);
                textEdit14.EditValue = (Convert.ToInt32(textEdit8.EditValue)) * (Convert.ToInt32(textEdit10.EditValue));
                dateEdit3.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
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
                textEdit14.EditValue = (Convert.ToInt32(textEdit8.EditValue)) * (Convert.ToInt32(textEdit10.EditValue));

            }
        }

         
    }
}