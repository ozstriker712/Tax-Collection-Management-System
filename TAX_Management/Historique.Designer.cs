namespace PC_STORE
{
    partial class Historique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historique));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PC_STORE.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_operation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirst_name_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_name_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmatricule_local = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpostion_local = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_boutique = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsomme_payee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_index = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_quitance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_payee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_enregistrer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clientTableAdapter = new PC_STORE.DataSet1TableAdapters.clientTableAdapter();
            this.colnombre_days = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_moins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsomme_evry_time = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1165, 504);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clientBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1161, 500);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_client,
            this.colwho,
            this.coldate_operation,
            this.coldate_update,
            this.colfirst_name_client,
            this.collast_name_client,
            this.colmatricule_local,
            this.coltype,
            this.colpostion_local,
            this.colnum_boutique,
            this.colsomme_payee,
            this.colsomme_evry_time,
            this.colnombre_moins,
            this.colnombre_days,
            this.colnum_index,
            this.colnum_quitance,
            this.coldate_payee,
            this.coldate_enregistrer});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid_client, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid_client
            // 
            this.colid_client.Caption = "ID";
            this.colid_client.FieldName = "id_client";
            this.colid_client.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colid_client.Name = "colid_client";
            this.colid_client.Visible = true;
            this.colid_client.VisibleIndex = 0;
            this.colid_client.Width = 54;
            // 
            // colwho
            // 
            this.colwho.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colwho.AppearanceCell.Options.UseBackColor = true;
            this.colwho.Caption = "اسم المستخدم";
            this.colwho.FieldName = "who";
            this.colwho.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colwho.Name = "colwho";
            this.colwho.Visible = true;
            this.colwho.VisibleIndex = 1;
            this.colwho.Width = 83;
            // 
            // coldate_operation
            // 
            this.coldate_operation.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.coldate_operation.AppearanceCell.Options.UseBackColor = true;
            this.coldate_operation.Caption = "تاريخ الحجز";
            this.coldate_operation.FieldName = "date_operation";
            this.coldate_operation.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.coldate_operation.Name = "coldate_operation";
            this.coldate_operation.Visible = true;
            this.coldate_operation.VisibleIndex = 2;
            this.coldate_operation.Width = 144;
            // 
            // coldate_update
            // 
            this.coldate_update.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.coldate_update.AppearanceCell.Options.UseBackColor = true;
            this.coldate_update.Caption = "تاريخ التعديل";
            this.coldate_update.FieldName = "date_update";
            this.coldate_update.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.coldate_update.Name = "coldate_update";
            this.coldate_update.Visible = true;
            this.coldate_update.VisibleIndex = 3;
            this.coldate_update.Width = 130;
            // 
            // colfirst_name_client
            // 
            this.colfirst_name_client.Caption = "اللقب";
            this.colfirst_name_client.FieldName = "first_name_client";
            this.colfirst_name_client.Name = "colfirst_name_client";
            this.colfirst_name_client.Visible = true;
            this.colfirst_name_client.VisibleIndex = 6;
            this.colfirst_name_client.Width = 120;
            // 
            // collast_name_client
            // 
            this.collast_name_client.Caption = "الاسم";
            this.collast_name_client.FieldName = "last_name_client";
            this.collast_name_client.Name = "collast_name_client";
            this.collast_name_client.Visible = true;
            this.collast_name_client.VisibleIndex = 5;
            this.collast_name_client.Width = 114;
            // 
            // colmatricule_local
            // 
            this.colmatricule_local.Caption = "Matricule";
            this.colmatricule_local.FieldName = "matricule_local";
            this.colmatricule_local.Name = "colmatricule_local";
            this.colmatricule_local.Visible = true;
            this.colmatricule_local.VisibleIndex = 4;
            this.colmatricule_local.Width = 64;
            // 
            // coltype
            // 
            this.coltype.Caption = "الصنف";
            this.coltype.FieldName = "type";
            this.coltype.Name = "coltype";
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 7;
            this.coltype.Width = 122;
            // 
            // colpostion_local
            // 
            this.colpostion_local.Caption = "مكان التعيين";
            this.colpostion_local.FieldName = "postion_local";
            this.colpostion_local.Name = "colpostion_local";
            this.colpostion_local.Visible = true;
            this.colpostion_local.VisibleIndex = 15;
            this.colpostion_local.Width = 201;
            // 
            // colnum_boutique
            // 
            this.colnum_boutique.Caption = "رقم المحل";
            this.colnum_boutique.FieldName = "num_boutique";
            this.colnum_boutique.Name = "colnum_boutique";
            this.colnum_boutique.Visible = true;
            this.colnum_boutique.VisibleIndex = 8;
            this.colnum_boutique.Width = 66;
            // 
            // colsomme_payee
            // 
            this.colsomme_payee.Caption = "المبلغ المحصل";
            this.colsomme_payee.FieldName = "somme_payee";
            this.colsomme_payee.Name = "colsomme_payee";
            this.colsomme_payee.Visible = true;
            this.colsomme_payee.VisibleIndex = 11;
            this.colsomme_payee.Width = 108;
            // 
            // colnum_index
            // 
            this.colnum_index.Caption = "الفهرس";
            this.colnum_index.FieldName = "num_index";
            this.colnum_index.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colnum_index.Name = "colnum_index";
            this.colnum_index.Visible = true;
            this.colnum_index.VisibleIndex = 16;
            // 
            // colnum_quitance
            // 
            this.colnum_quitance.Caption = "رقم الوصل";
            this.colnum_quitance.FieldName = "num_quitance";
            this.colnum_quitance.Name = "colnum_quitance";
            this.colnum_quitance.Visible = true;
            this.colnum_quitance.VisibleIndex = 10;
            // 
            // coldate_payee
            // 
            this.coldate_payee.Caption = "تاريخ الدفع";
            this.coldate_payee.FieldName = "date_payee";
            this.coldate_payee.Name = "coldate_payee";
            this.coldate_payee.Visible = true;
            this.coldate_payee.VisibleIndex = 9;
            this.coldate_payee.Width = 97;
            // 
            // coldate_enregistrer
            // 
            this.coldate_enregistrer.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.coldate_enregistrer.AppearanceCell.Options.UseBackColor = true;
            this.coldate_enregistrer.Caption = "تاريخ التسجيل";
            this.coldate_enregistrer.FieldName = "date_enregistrer";
            this.coldate_enregistrer.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.coldate_enregistrer.Name = "coldate_enregistrer";
            this.coldate_enregistrer.Visible = true;
            this.coldate_enregistrer.VisibleIndex = 17;
            this.coldate_enregistrer.Width = 96;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // colnombre_days
            // 
            this.colnombre_days.Caption = "عدد الايام";
            this.colnombre_days.FieldName = "nombre_days";
            this.colnombre_days.Name = "colnombre_days";
            this.colnombre_days.Visible = true;
            this.colnombre_days.VisibleIndex = 12;
            // 
            // colnombre_moins
            // 
            this.colnombre_moins.Caption = "عدد الاشهر";
            this.colnombre_moins.FieldName = "nombre_moins";
            this.colnombre_moins.Name = "colnombre_moins";
            this.colnombre_moins.Visible = true;
            this.colnombre_moins.VisibleIndex = 13;
            // 
            // colsomme_evry_time
            // 
            this.colsomme_evry_time.Caption = "المبلغ المستحق";
            this.colsomme_evry_time.FieldName = "somme_evry_time";
            this.colsomme_evry_time.Name = "colsomme_evry_time";
            this.colsomme_evry_time.Visible = true;
            this.colsomme_evry_time.VisibleIndex = 14;
            this.colsomme_evry_time.Width = 114;
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 504);
            this.Controls.Add(this.panelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Historique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجــــــــــــل العمليات ";
            this.Load += new System.EventHandler(this.Historique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colwho;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_operation;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name_client;
        private DevExpress.XtraGrid.Columns.GridColumn collast_name_client;
        private DevExpress.XtraGrid.Columns.GridColumn coltype;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_boutique;
        private DevExpress.XtraGrid.Columns.GridColumn colsomme_payee;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_payee;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_enregistrer;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_update;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_index;
        private DevExpress.XtraGrid.Columns.GridColumn colmatricule_local;
        private DevExpress.XtraGrid.Columns.GridColumn colpostion_local;
        private DevExpress.XtraGrid.Columns.GridColumn colid_client;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_quitance;
        private DevExpress.XtraGrid.Columns.GridColumn colsomme_evry_time;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_moins;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_days;
    }
}