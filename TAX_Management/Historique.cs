using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PC_STORE
{
    public partial class Historique : DevExpress.XtraEditors.XtraForm
    {
        public Historique()
        {
            InitializeComponent();
        }

        private void Historique_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dataSet1.client);

        }
    }
}