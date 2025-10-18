namespace PC_STORE
{
    partial class historique_plus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historique_plus));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.historiquemodificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PC_STORE.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_index = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_enregistrer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmatricule_local = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirst_name_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_name_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarticle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_boutique = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsomme_payee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_quitance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_payee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_moins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfrom_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colto_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremarque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_operation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloriginal_new_values = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.historique_modificationTableAdapter = new PC_STORE.DataSet1TableAdapters.Historique_modificationTableAdapter();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_days = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsomme_evry_time = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiquemodificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1182, 606);
            this.panelControl2.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(557, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(212, 35);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "  Excel   تصدير القائمة الى";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.historiquemodificationBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1178, 602);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // historiquemodificationBindingSource
            // 
            this.historiquemodificationBindingSource.DataMember = "Historique_modification";
            this.historiquemodificationBindingSource.DataSource = this.dataSet1;
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
            this.colnum_index,
            this.coldate_enregistrer,
            this.colmatricule_local,
            this.colfirst_name_client,
            this.collast_name_client,
            this.colporte,
            this.colarticle,
            this.coltype,
            this.collocation,
            this.colnum_boutique,
            this.colsomme_payee,
            this.colnombre_days,
            this.colnombre_moins,
            this.colsomme_evry_time,
            this.colnum_quitance,
            this.coldate_payee,
            this.colfrom_date,
            this.colto_date,
            this.colremarque,
            this.coldate_operation,
            this.coldate_update,
            this.coloriginal_new_values,
            this.colwho});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid_client, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colid_client
            // 
            this.colid_client.Caption = "ID";
            this.colid_client.FieldName = "id_client";
            this.colid_client.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colid_client.Name = "colid_client";
            this.colid_client.Visible = true;
            this.colid_client.VisibleIndex = 0;
            this.colid_client.Width = 47;
            // 
            // colnum_index
            // 
            this.colnum_index.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colnum_index.AppearanceCell.Options.UseBackColor = true;
            this.colnum_index.Caption = "رقم الفهرس";
            this.colnum_index.FieldName = "matricule_local";
            this.colnum_index.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colnum_index.Name = "colnum_index";
            this.colnum_index.Visible = true;
            this.colnum_index.VisibleIndex = 1;
            this.colnum_index.Width = 94;
            // 
            // coldate_enregistrer
            // 
            this.coldate_enregistrer.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.coldate_enregistrer.AppearanceCell.Options.UseBackColor = true;
            this.coldate_enregistrer.Caption = "تاريخ التسجيل";
            this.coldate_enregistrer.FieldName = "date_enregistrer";
            this.coldate_enregistrer.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.coldate_enregistrer.Name = "coldate_enregistrer";
            this.coldate_enregistrer.Visible = true;
            this.coldate_enregistrer.VisibleIndex = 2;
            this.coldate_enregistrer.Width = 102;
            // 
            // colmatricule_local
            // 
            this.colmatricule_local.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colmatricule_local.AppearanceCell.Options.UseBackColor = true;
            this.colmatricule_local.Caption = "Matricule";
            this.colmatricule_local.FieldName = "matricule_local";
            this.colmatricule_local.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colmatricule_local.Name = "colmatricule_local";
            this.colmatricule_local.Visible = true;
            this.colmatricule_local.VisibleIndex = 3;
            // 
            // colfirst_name_client
            // 
            this.colfirst_name_client.Caption = "اللقب";
            this.colfirst_name_client.FieldName = "first_name_client";
            this.colfirst_name_client.Name = "colfirst_name_client";
            this.colfirst_name_client.Visible = true;
            this.colfirst_name_client.VisibleIndex = 5;
            this.colfirst_name_client.Width = 120;
            // 
            // collast_name_client
            // 
            this.collast_name_client.Caption = "الاسم";
            this.collast_name_client.FieldName = "last_name_client";
            this.collast_name_client.Name = "collast_name_client";
            this.collast_name_client.Visible = true;
            this.collast_name_client.VisibleIndex = 4;
            this.collast_name_client.Width = 114;
            // 
            // colporte
            // 
            this.colporte.Caption = "الباب";
            this.colporte.FieldName = "porte";
            this.colporte.Name = "colporte";
            this.colporte.Visible = true;
            this.colporte.VisibleIndex = 6;
            // 
            // colarticle
            // 
            this.colarticle.Caption = "المادة";
            this.colarticle.FieldName = "article";
            this.colarticle.Name = "colarticle";
            this.colarticle.Visible = true;
            this.colarticle.VisibleIndex = 7;
            // 
            // coltype
            // 
            this.coltype.Caption = "الصنف";
            this.coltype.FieldName = "type";
            this.coltype.Name = "coltype";
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 8;
            // 
            // collocation
            // 
            this.collocation.Caption = "مكان التعيين";
            this.collocation.FieldName = "postion_local";
            this.collocation.Name = "collocation";
            this.collocation.Visible = true;
            this.collocation.VisibleIndex = 9;
            this.collocation.Width = 234;
            // 
            // colnum_boutique
            // 
            this.colnum_boutique.Caption = "رقم المحل";
            this.colnum_boutique.FieldName = "num_boutique";
            this.colnum_boutique.Name = "colnum_boutique";
            this.colnum_boutique.Visible = true;
            this.colnum_boutique.VisibleIndex = 10;
            // 
            // colsomme_payee
            // 
            this.colsomme_payee.Caption = "الملبغ المحصل";
            this.colsomme_payee.FieldName = "somme_payee";
            this.colsomme_payee.Name = "colsomme_payee";
            this.colsomme_payee.Visible = true;
            this.colsomme_payee.VisibleIndex = 11;
            this.colsomme_payee.Width = 105;
            // 
            // colnum_quitance
            // 
            this.colnum_quitance.Caption = "رقم الوصل";
            this.colnum_quitance.FieldName = "num_quitance";
            this.colnum_quitance.Name = "colnum_quitance";
            this.colnum_quitance.Visible = true;
            this.colnum_quitance.VisibleIndex = 15;
            // 
            // coldate_payee
            // 
            this.coldate_payee.Caption = "تاريخ الدفع";
            this.coldate_payee.FieldName = "date_payee";
            this.coldate_payee.Name = "coldate_payee";
            this.coldate_payee.Visible = true;
            this.coldate_payee.VisibleIndex = 16;
            this.coldate_payee.Width = 90;
            // 
            // colnombre_moins
            // 
            this.colnombre_moins.Caption = "عدد الاشهر";
            this.colnombre_moins.FieldName = "nombre_moins";
            this.colnombre_moins.Name = "colnombre_moins";
            this.colnombre_moins.Visible = true;
            this.colnombre_moins.VisibleIndex = 13;
            this.colnombre_moins.Width = 81;
            // 
            // colfrom_date
            // 
            this.colfrom_date.Caption = "من تاريخ";
            this.colfrom_date.FieldName = "from_date";
            this.colfrom_date.Name = "colfrom_date";
            this.colfrom_date.Visible = true;
            this.colfrom_date.VisibleIndex = 17;
            // 
            // colto_date
            // 
            this.colto_date.Caption = "الى تاريخ";
            this.colto_date.FieldName = "to_date";
            this.colto_date.Name = "colto_date";
            this.colto_date.Visible = true;
            this.colto_date.VisibleIndex = 18;
            // 
            // colremarque
            // 
            this.colremarque.Caption = "الملاحظة";
            this.colremarque.FieldName = "remarque";
            this.colremarque.Name = "colremarque";
            this.colremarque.Visible = true;
            this.colremarque.VisibleIndex = 19;
            this.colremarque.Width = 218;
            // 
            // coldate_operation
            // 
            this.coldate_operation.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.coldate_operation.AppearanceCell.Options.UseBackColor = true;
            this.coldate_operation.Caption = "تاريخ الحجز";
            this.coldate_operation.FieldName = "date_operation";
            this.coldate_operation.Name = "coldate_operation";
            this.coldate_operation.Visible = true;
            this.coldate_operation.VisibleIndex = 20;
            this.coldate_operation.Width = 157;
            // 
            // coldate_update
            // 
            this.coldate_update.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.coldate_update.AppearanceCell.Options.UseBackColor = true;
            this.coldate_update.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.coldate_update.AppearanceHeader.Options.UseBackColor = true;
            this.coldate_update.Caption = "تاريخ التعديل";
            this.coldate_update.FieldName = "date_update";
            this.coldate_update.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.coldate_update.Name = "coldate_update";
            this.coldate_update.Visible = true;
            this.coldate_update.VisibleIndex = 21;
            this.coldate_update.Width = 133;
            // 
            // coloriginal_new_values
            // 
            this.coloriginal_new_values.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.coloriginal_new_values.AppearanceCell.Options.UseBackColor = true;
            this.coloriginal_new_values.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.coloriginal_new_values.AppearanceHeader.Options.UseBackColor = true;
            this.coloriginal_new_values.Caption = "نوع القيم الاصلية و المعدلة";
            this.coloriginal_new_values.FieldName = "original_new_values";
            this.coloriginal_new_values.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.coloriginal_new_values.Name = "coloriginal_new_values";
            this.coloriginal_new_values.Visible = true;
            this.coloriginal_new_values.VisibleIndex = 22;
            this.coloriginal_new_values.Width = 173;
            // 
            // colwho
            // 
            this.colwho.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colwho.AppearanceCell.Options.UseBackColor = true;
            this.colwho.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.colwho.AppearanceHeader.Options.UseBackColor = true;
            this.colwho.Caption = "اسم المستخدم";
            this.colwho.FieldName = "who";
            this.colwho.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colwho.Name = "colwho";
            this.colwho.Visible = true;
            this.colwho.VisibleIndex = 23;
            this.colwho.Width = 87;
            // 
            // historique_modificationTableAdapter
            // 
            this.historique_modificationTableAdapter.ClearBeforeFill = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colnombre_days
            // 
            this.colnombre_days.Caption = "عدد الايام";
            this.colnombre_days.FieldName = "nombre_days";
            this.colnombre_days.Name = "colnombre_days";
            this.colnombre_days.Visible = true;
            this.colnombre_days.VisibleIndex = 12;
            // 
            // colsomme_evry_time
            // 
            this.colsomme_evry_time.Caption = "المبلغ المستحق";
            this.colsomme_evry_time.FieldName = "somme_evry_time";
            this.colsomme_evry_time.Name = "colsomme_evry_time";
            this.colsomme_evry_time.Visible = true;
            this.colsomme_evry_time.VisibleIndex = 14;
            this.colsomme_evry_time.Width = 95;
            // 
            // historique_plus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 606);
            this.Controls.Add(this.panelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "historique_plus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل عمليات متقدم  و  التغييرات";
            this.Load += new System.EventHandler(this.historique_plus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiquemodificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_client;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_index;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_enregistrer;
        private DevExpress.XtraGrid.Columns.GridColumn colmatricule_local;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name_client;
        private DevExpress.XtraGrid.Columns.GridColumn collast_name_client;
        private DevExpress.XtraGrid.Columns.GridColumn colporte;
        private DevExpress.XtraGrid.Columns.GridColumn colarticle;
        private DevExpress.XtraGrid.Columns.GridColumn coltype;
        private DevExpress.XtraGrid.Columns.GridColumn collocation;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_boutique;
        private DevExpress.XtraGrid.Columns.GridColumn colsomme_payee;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_payee;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_moins;
        private DevExpress.XtraGrid.Columns.GridColumn colfrom_date;
        private DevExpress.XtraGrid.Columns.GridColumn colto_date;
        private DevExpress.XtraGrid.Columns.GridColumn colremarque;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource historiquemodificationBindingSource;
        private DataSet1TableAdapters.Historique_modificationTableAdapter historique_modificationTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_operation;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_update;
        private DevExpress.XtraGrid.Columns.GridColumn coloriginal_new_values;
        private DevExpress.XtraGrid.Columns.GridColumn colwho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_quitance;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_days;
        private DevExpress.XtraGrid.Columns.GridColumn colsomme_evry_time;
    }
}