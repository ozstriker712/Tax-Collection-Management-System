using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace PC_STORE
{
    public partial class Backup : DevExpress.XtraEditors.XtraForm
    {
        public Backup()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }


        string savePath;
        private void simpleButton1_Click(object sender, EventArgs e)
        {


            string dummyFileName = "S'il vous plaît sélectionner un dossier ";

            SaveFileDialog sf = new SaveFileDialog();
            // Feed the dummy name to the save dialog
            sf.FileName = dummyFileName;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                 
                 savePath = Path.GetDirectoryName(sf.FileName);

                string sourcePath = @".\";

                string sourceFileName = "Pc_Stor_DB.mdb";
                string destinationFileName = DateTime.Now.ToString("dd-MM-yyyy") + " BDD_save.mdb"; // Don't mind this. I did this because I needed to name the copied files with respect to time.
                string sourceFile = System.IO.Path.Combine(sourcePath, sourceFileName);
                string destinationFile = System.IO.Path.Combine(savePath, destinationFileName);


                System.IO.Directory.CreateDirectory(savePath);
                System.IO.File.Copy(sourceFile, destinationFile, true);


                progressBarControl1.Properties.Step = 1;

                progressBarControl1.Properties.Minimum = 0;

                for (int i = 0; i < 1000; i++)
                {
                    progressBarControl1.Properties.Maximum = i;
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }

                label1.Text = savePath.ToString() + "\\" + destinationFileName.ToString();
 
 
            }

          
        }

      

    }
}