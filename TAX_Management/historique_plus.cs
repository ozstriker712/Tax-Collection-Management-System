using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Diagnostics;

namespace PC_STORE
{
    public partial class historique_plus : DevExpress.XtraEditors.XtraForm
    {
        public historique_plus()
        {
            InitializeComponent();
        }

        private void historique_plus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Historique_modification' table. You can move, or remove it, as needed.
            this.historique_modificationTableAdapter.Fill(this.dataSet1.Historique_modification);

        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string new_original_values = View.GetRowCellDisplayText(e.RowHandle, View.Columns["original_new_values"]);

                if (new_original_values == "Originale Values")
                {
                    e.Appearance.BackColor = Color.BurlyWood;
                    e.Appearance.BackColor2 = Color.SeaShell;

                }


            }
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