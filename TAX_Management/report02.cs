using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PC_STORE
{
    public partial class report02 : DevExpress.XtraReports.UI.XtraReport
    {
        public report02(int get_index)
        {
            InitializeComponent();
            val_index = get_index;
        }
        int val_index;
        DateTime save = DateTime.Now;
        private void report02_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.clientTableAdapter.FillBy(this.dataSet11.client, val_index);


            xrLabel13.Text = save.ToString(); xrLabel61.Text = save.ToString(); 

            string get_catgr = dataSet11.Tables[0].Rows[0]["categories"].ToString();

            if (get_catgr == "Laptop")
            {
                xrLabel33.Visible = false; xrLabel30.Visible = false; xrLabel31.Visible = false; xrLabel29.Visible = false;
                xrLabel80.Visible = false; xrLabel79.Visible = false; xrLabel81.Visible = false; xrLabel50.Visible = false;
            }
            else
            {
                if (get_catgr == "Desktop PC")
                {
                    xrLabel9.Visible = false; xrLabel69.Visible = false;
                }

            }
        }
    }
}
