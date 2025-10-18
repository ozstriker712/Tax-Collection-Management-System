using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;

        public Form1()
        {
            InitializeComponent();
             gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            //gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
             show_current_month(); 
            //timer1.Start();
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dataSet1.client);


            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\Pc_Stor_DB.mdb; Jet OLEDB:Database Password=816170";  //Microsoft.Jet.OLEDB.4.0
            cmd.Connection = cn;

            Refresh_me();

        }


        int get_index;
        string strID = "";
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] rowCount = this.gridView1.GetSelectedRows();
             
            foreach (int i in rowCount)
            {
                this.gridView1.FocusedRowHandle = -1; 
                strID = this.gridView1.GetRowCellValue(i, "id_client").ToString();
            }

            if (strID != "" )
            {
                get_index = int.Parse(strID);
                //Print_fact repot1 = new Print_fact(get_index);
                report02 repot1 = new report02(get_index);
                ReportPrintTool printTool = new ReportPrintTool(repot1);
                printTool.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show(" s'il vous plaît assurez-vous que vous êtes sélectionné un client pour l'impression ??   ", " The Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            gridControl1.ShowRibbonPrintPreview();
            Cursor.Current = currentCursor;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;


                    gridView1.ExportToXls(exportFilePath);
                    Process proc = new Process();
                    proc.StartInfo.FileName = exportFilePath;
                    proc.StartInfo.UseShellExecute = true;
                    proc.Start();

                }
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dashboard1 dashboard_form = new Dashboard1();
            dashboard_form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stat stat_form = new Stat();
            stat_form.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Users_permission gestio_user_frm = new Users_permission();
            gestio_user_frm.xtraTabPage1.PageEnabled = true;
            gestio_user_frm.xtraTabPage2.PageEnabled = false;
            gestio_user_frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Users_permission gestio_user_frm = new Users_permission();
            gestio_user_frm.xtraTabPage1.PageEnabled = false;
            gestio_user_frm.xtraTabPage2.PageEnabled = true;
            gestio_user_frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            about about_form = new about();
            about_form.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Backup backup_from = new Backup();
            backup_from.Show();
        }



        DateTime first_day_in_month;
        DateTime last_day_in_month;

        public void show_current_month()
        {
            DateTime dCalcDate = DateTime.Now;
            first_day_in_month = new DateTime(dCalcDate.Year, dCalcDate.Month, 1);
            last_day_in_month = new DateTime(dCalcDate.Year, dCalcDate.Month, DateTime.DaysInMonth(dCalcDate.Year, dCalcDate.Month));
            filterControl2.SourceControl = gridControl1;
            GridColumn columnCustomer = gridView1.Columns["date_enregistrer"];
            //gridView1.ActiveFilterString = "[date_shopping] >= #" + first_day_in_month.ToShortDateString() + "#";
            columnCustomer.FilterInfo = new ColumnFilterInfo("[date_enregistrer] between (#" + first_day_in_month.ToString(CultureInfo.InvariantCulture) + "#,#" + last_day_in_month.ToString(CultureInfo.InvariantCulture) + "#)");

            filterControl2.ApplyFilter();


        }

        private void Do_String(string q)
        {
            try
            {
                cn.Open();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        OleDbDataAdapter oledbAdapter;
        DataSet ds = new DataSet();

        public void Load_Data()
        {

            try
            {


                OleDbConnection connet1 = new OleDbConnection(cn.ConnectionString);
                string sql = "select * from client";
                connet1.Open();
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sql, connet1);
                myadapter.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];
                connet1.Close();
                gridControl1.Refresh();

                Refresh_me();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ClearSpace(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var textBox = c as TextBox;
                var comboBox = c as System.Windows.Forms.ComboBox;

                if (textBox != null)
                    (textBox).Clear();

                if (comboBox != null)
                    comboBox.SelectedIndex = -1;

                if (c.HasChildren)
                    ClearSpace(c);
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            Load_Data();
            //sql_check_guarante_date();
           
            //timer1.Stop();  
            //timer1.Start();
        }

        DateTime saveNow = DateTime.Now;
        public void sql_check_guarante_date()
        {
            //string sql = "update client set etat_guarantee =true where date_expire_guarantee <#'" + "' saveNow.ToShortDateString() '" + "'# and set etat_guarantee =false where date_expire_guarantee >#'" ,+ "' saveNow.ToShortDateString()'" ,+ "'# ";
            //string sql2 = "update client set etat_guarantee =false where date_expire_guarantee >#" + saveNow.ToShortDateString() + "#";
            //string sql3 = "update client set etat_guarantee =true where date_expire_guarantee <#" + saveNow.ToShortDateString() + "#";

            string sql3 = " update client set etat_guarantee= IIf ( date_expire_guarantee >#" + saveNow.ToShortDateString() + "#, false, IIf (date_expire_guarantee <#" + saveNow.ToShortDateString() + "#,true))";
            Do_String(sql3);
            //Do_String(sql2);

        }

        private void barCheckItem4_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow = barCheckItem4.Checked;
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" هــــل أنت فعـــلا تريد حــــــــذف هذا العنصـــر ؟؟؟   ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                delete();
            }
        }

        private void delete()
        {

            try
            {
                int[] rowCount = this.gridView1.GetSelectedRows();
                string strSql = "";
                foreach (int i in rowCount)
                {
                    this.gridView1.FocusedRowHandle = -1;
                    string strID = "";
                    strID = this.gridView1.GetRowCellValue(i, "id_client").ToString();
                    strSql = "delete from client where id_client=" + strID + ""; //where              

                }

                OleDbConnection connet1 = new OleDbConnection(cn.ConnectionString);
                connet1.Open();
                OleDbCommand cmd = new OleDbCommand(strSql, connet1);
                int a = cmd.ExecuteNonQuery();
                connet1.Close();
                if (a > 0)
                {

                    MessageBox.Show(" لقـــد تمت عملية الحذف من قاعدة البياتات !! ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = gridControl1.FocusedView as GridView;

            if (barCheckItem1.Checked)
            {
                GridColumnSortInfo[] sortinfo = { new GridColumnSortInfo(gridView.Columns["type"], DevExpress.Data.ColumnSortOrder.Ascending) };
                gridView.SortInfo.ClearAndAddRange(sortinfo, 2);
            }

            else
            {
                gridView.ClearGrouping();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barCheckItem2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem2.Checked)
            {
                gridView1.ShowCustomization();
                gridView1.CustomizationForm.Text = "Customize Box";

            }
            else
            {
                gridView1.ShowCustomization();
                gridView1.CustomizationForm.Hide();

            }
        }

        private void barCheckItem3_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem3.Checked == true)
            {
                gridView1.ClearColumnsFilter();
            }
            else
            {
                show_current_month();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl2.ApplyFilter();
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            //GridView View = sender as GridView;
            //if (e.RowHandle >= 0)
            //{
            //    string etat_guarnt = View.GetRowCellDisplayText(e.RowHandle, View.Columns["etat_guarantee"]);

            //    if (etat_guarnt == "Checked")
            //    {
            //        e.Appearance.BackColor = Color.Salmon;
            //        e.Appearance.BackColor2 = Color.SeaShell;

            //    }


            //}
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add_new add_new = new Add_new();
            add_new.Show();
            add_new.textEdit1.Text = textEdit2.Text;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }



        //int count;

        //public void timer1_Tick(object sender, EventArgs e)
        //{
        //    count = clientBindingSource.Count; 
        //    textEdit1.Text = count.ToString();
             
        //}

        void Refresh_me()
        {

            this.dataSet1.Reset();
            this.clientTableAdapter.Fill(this.dataSet1.client);
            textEdit1.Text = clientBindingSource.Count.ToString();
        }


        int selected_row, val_time;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] rowCount = this.gridView1.GetSelectedRows();

            foreach (int i in rowCount)
            {
                selected_row = i;
                
            }


            Update update_form = new Update();

            if (selected_row != -1)
            {
                this.gridView1.FocusedRowHandle = -1;
                update_form.textEdit1.Text = this.gridView1.GetRowCellValue(selected_row, "id_client").ToString();

                update_form.textEdit2.Text = this.gridView1.GetRowCellValue(selected_row, "porte").ToString();
                update_form.textEdit3.Text = this.gridView1.GetRowCellValue(selected_row, "article").ToString();

                update_form.textEdit4.Text = this.gridView1.GetRowCellValue(selected_row, "first_name_client").ToString();
                update_form.textEdit5.Text = this.gridView1.GetRowCellValue(selected_row, "last_name_client").ToString();

                update_form.gridLookUpEdit1.EditValue = this.gridView1.GetRowCellValue(selected_row, "type").ToString();
               

                update_form.textEdit7.Text = this.gridView1.GetRowCellValue(selected_row, "num_boutique").ToString();
                update_form.textEdit15.EditValue = this.gridView1.GetRowCellValue(selected_row, "somme_payee");
                update_form.textEdit8.EditValue = this.gridView1.GetRowCellValue(selected_row, "somme_evry_time");
                //update_form.dateEdit5.Text = this.gridView1.GetRowCellValue(selected_row, "date_enregistrer").ToString(); //
                update_form.dateEdit1.EditValue = this.gridView1.GetRowCellValue(selected_row, "date_enregistrer"); //

                update_form.textEdit9.Text = this.gridView1.GetRowCellValue(selected_row, "postion_local").ToString();

                update_form.dateEdit2.Text = this.gridView1.GetRowCellValue(selected_row, "date_payee").ToString();
                
                if (  Convert.ToInt32(this.gridView1.GetRowCellValue(selected_row, "nombre_moins"))!=0)
                {
                    update_form.textEdit10.Text = this.gridView1.GetRowCellValue(selected_row, "nombre_moins").ToString();
                    update_form.checkBox1.Checked = false;
                    
                }
                else
                {
                    update_form.textEdit10.Text = this.gridView1.GetRowCellValue(selected_row, "nombre_days").ToString();
                    update_form.checkBox1.Checked = true;
                    update_form.label13.Text = ": عدد الأيام";
                }

                update_form.dateEdit3.EditValue = this.gridView1.GetRowCellValue(selected_row, "from_date") ;

                update_form.dateEdit4.EditValue = this.gridView1.GetRowCellValue(selected_row, "to_date");
                update_form.textEdit11.Text = this.gridView1.GetRowCellValue(selected_row, "remarque").ToString();

                update_form.textEdit12.Text = this.gridView1.GetRowCellValue(selected_row, "who").ToString();
                update_form.textEdit6.Text = textEdit2.Text;

                update_form.num_indexSpinEdit.Text = this.gridView1.GetRowCellValue(selected_row, "num_index").ToString();
                update_form.textEdit13.Text = this.gridView1.GetRowCellValue(selected_row, "matricule_local").ToString();
                update_form.textEdit14.Text = this.gridView1.GetRowCellValue(selected_row, "num_quitance").ToString();
                update_form.Show();
            }
            else
            {
                MessageBox.Show("   قــم بتحديد العنصر أولا للتعديل عليه ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void barCheckItem6_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem6.Checked)
            {
                gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                gridView1.OptionsPrint.PrintSelectedRowsOnly = true;

            }
            else
            {
                gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
                gridView1.OptionsPrint.PrintSelectedRowsOnly = false;

            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add_new_local add_new_local = new add_new_local();
            add_new_local.xtraTabPage1.PageEnabled = true;
            add_new_local.xtraTabPage2.PageEnabled = false;
            add_new_local.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add_new_local gestio_user_frm = new add_new_local();
            gestio_user_frm.xtraTabPage1.PageEnabled = false;
            gestio_user_frm.xtraTabPage2.PageEnabled = true;
            gestio_user_frm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Historique frm = new Historique();
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            update_paramater frm = new update_paramater();
            frm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            old_bdd frm = new old_bdd();
            frm.textEdit1.Text = textEdit2.Text;
            frm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            historique_plus frm = new historique_plus();
            frm.Show();
        }

        
       
    }
}
