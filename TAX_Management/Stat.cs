using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System.IO;
using System.Diagnostics;

namespace PC_STORE
{
    public partial class Stat : DevExpress.XtraEditors.XtraForm
    {
        public Stat()
        {
            InitializeComponent(); 
            
            filterControl1.SourceControl = gridControl1;
            GridColumn columnCustomer = gridView1.Columns["date_enregistrer"];
            GridColumn columnCustomer2 = gridView1.Columns["type"];
           
            columnCustomer.FilterInfo = new ColumnFilterInfo("[date_enregistrer] between ('[ à partir de ]', '[ à cette date ]')");
            columnCustomer2.FilterInfo = new ColumnFilterInfo("[type] is like % ('[ Quelle Type ? ]')");

        }

        private void Stat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dataSet1.client);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
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
    }
}