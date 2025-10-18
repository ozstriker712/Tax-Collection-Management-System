using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PC_STORE
{
    public partial class Print_fact : DevExpress.XtraReports.UI.XtraReport
    {
        public Print_fact(int get_index)
        {
            InitializeComponent();
            val_index = get_index;
        }

        DateTime save = DateTime.Now;
        int val_index;

        private void Print_fact_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.clientTableAdapter.FillBy(this.dataSet11.client, val_index);
            xrLabel13.Text = save.ToShortDateString();
            string get_catgr= dataSet11.Tables[0].Rows[0]["categories"].ToString();

            if ( get_catgr =="Laptop")
            {
                xrLabel29.Visible = false; xrLabel30.Visible = false; xrLabel31.Visible = false; xrLabel33.Visible = false;
            }
            else
            {
                if (get_catgr=="Desktop PC")
                {
                    xrLabel18.Visible = false; xrLabel28.Visible = false;
                }
                 
            }
        }


    }
}
