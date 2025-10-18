namespace PC_STORE
{
    partial class Stat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stat));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PC_STORE.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnum_index = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_shopping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_name_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmatricule_local = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_boutique = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpostion_local = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarticle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsomme_payee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_moins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfrom_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colto_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.clientTableAdapter = new PC_STORE.DataSet1TableAdapters.clientTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.colnombre_days = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_quitance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsomme_evry_time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_payee = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clientBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 140);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1245, 490);
            this.gridControl1.TabIndex = 3;
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
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.GroupFooter.BackColor2 = System.Drawing.Color.Green;
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Magenta;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseImage = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnum_index,
            this.coldate_shopping,
            this.colproduct_name,
            this.collast_name_client,
            this.colmatricule_local,
            this.coltype,
            this.colnum_boutique,
            this.colpostion_local,
            this.colarticle,
            this.colporte,
            this.colsomme_payee,
            this.colnombre_moins,
            this.colnombre_days,
            this.colsomme_evry_time,
            this.colnum_quitance,
            this.colfrom_date,
            this.colto_date,
            this.coldate_payee});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "somme_payee", this.colsomme_payee, "Somme Total ={0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltype, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colnum_index
            // 
            this.colnum_index.Caption = "رقم الفهرس";
            this.colnum_index.FieldName = "num_index";
            this.colnum_index.Name = "colnum_index";
            this.colnum_index.Visible = true;
            this.colnum_index.VisibleIndex = 0;
            this.colnum_index.Width = 76;
            // 
            // coldate_shopping
            // 
            this.coldate_shopping.Caption = "تاريخ التسجيل";
            this.coldate_shopping.FieldName = "date_enregistrer";
            this.coldate_shopping.Name = "coldate_shopping";
            this.coldate_shopping.Visible = true;
            this.coldate_shopping.VisibleIndex = 7;
            this.coldate_shopping.Width = 83;
            // 
            // colproduct_name
            // 
            this.colproduct_name.Caption = "اللقب";
            this.colproduct_name.FieldName = "first_name_client";
            this.colproduct_name.Name = "colproduct_name";
            this.colproduct_name.Visible = true;
            this.colproduct_name.VisibleIndex = 3;
            this.colproduct_name.Width = 68;
            // 
            // collast_name_client
            // 
            this.collast_name_client.Caption = "الاسم";
            this.collast_name_client.FieldName = "last_name_client";
            this.collast_name_client.Name = "collast_name_client";
            this.collast_name_client.Visible = true;
            this.collast_name_client.VisibleIndex = 4;
            this.collast_name_client.Width = 99;
            // 
            // colmatricule_local
            // 
            this.colmatricule_local.Caption = "Matricule";
            this.colmatricule_local.FieldName = "matricule_local";
            this.colmatricule_local.Name = "colmatricule_local";
            this.colmatricule_local.Visible = true;
            this.colmatricule_local.VisibleIndex = 5;
            this.colmatricule_local.Width = 54;
            // 
            // coltype
            // 
            this.coltype.Caption = "نوع التعيين";
            this.coltype.FieldName = "type";
            this.coltype.Name = "coltype";
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 5;
            this.coltype.Width = 116;
            // 
            // colnum_boutique
            // 
            this.colnum_boutique.Caption = "رقم المحل";
            this.colnum_boutique.FieldName = "num_boutique";
            this.colnum_boutique.Name = "colnum_boutique";
            this.colnum_boutique.Visible = true;
            this.colnum_boutique.VisibleIndex = 6;
            this.colnum_boutique.Width = 61;
            // 
            // colpostion_local
            // 
            this.colpostion_local.Caption = "مكان التعيين";
            this.colpostion_local.FieldName = "postion_local";
            this.colpostion_local.Name = "colpostion_local";
            this.colpostion_local.Visible = true;
            this.colpostion_local.VisibleIndex = 10;
            this.colpostion_local.Width = 156;
            // 
            // colarticle
            // 
            this.colarticle.Caption = "المادة";
            this.colarticle.FieldName = "article";
            this.colarticle.Name = "colarticle";
            this.colarticle.Visible = true;
            this.colarticle.VisibleIndex = 2;
            this.colarticle.Width = 38;
            // 
            // colporte
            // 
            this.colporte.Caption = "الباب";
            this.colporte.FieldName = "porte";
            this.colporte.Name = "colporte";
            this.colporte.Visible = true;
            this.colporte.VisibleIndex = 1;
            this.colporte.Width = 47;
            // 
            // colsomme_payee
            // 
            this.colsomme_payee.Caption = "المبلغ المحصل";
            this.colsomme_payee.FieldName = "somme_payee";
            this.colsomme_payee.Name = "colsomme_payee";
            this.colsomme_payee.Visible = true;
            this.colsomme_payee.VisibleIndex = 13;
            this.colsomme_payee.Width = 218;
            // 
            // colnombre_moins
            // 
            this.colnombre_moins.Caption = "عدد الاشهر";
            this.colnombre_moins.FieldName = "nombre_moins";
            this.colnombre_moins.Name = "colnombre_moins";
            this.colnombre_moins.Visible = true;
            this.colnombre_moins.VisibleIndex = 14;
            this.colnombre_moins.Width = 60;
            // 
            // colfrom_date
            // 
            this.colfrom_date.Caption = "من تاريخ";
            this.colfrom_date.FieldName = "from_date";
            this.colfrom_date.Name = "colfrom_date";
            this.colfrom_date.Visible = true;
            this.colfrom_date.VisibleIndex = 11;
            this.colfrom_date.Width = 68;
            // 
            // colto_date
            // 
            this.colto_date.Caption = "الى تاريخ";
            this.colto_date.FieldName = "to_date";
            this.colto_date.Name = "colto_date";
            this.colto_date.Visible = true;
            this.colto_date.VisibleIndex = 12;
            this.colto_date.Width = 74;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(737, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(125, 39);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "تنفيـــــــــذ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Location = new System.Drawing.Point(270, 12);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(450, 104);
            this.filterControl1.TabIndex = 4;
            this.filterControl1.Text = "filterControl1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(737, 77);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(177, 39);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "  Excel   تصدير القائمة الى";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(22, 48);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit3.Size = new System.Drawing.Size(78, 63);
            this.pictureEdit3.TabIndex = 80;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.pictureEdit3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.filterControl1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1245, 140);
            this.panelControl1.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(22, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(173, 19);
            this.labelControl2.TabIndex = 134;
            this.labelControl2.Text = "احصائيـــــــات مخصصة";
            // 
            // colnombre_days
            // 
            this.colnombre_days.Caption = "عدد الايام";
            this.colnombre_days.FieldName = "nombre_days";
            this.colnombre_days.Name = "colnombre_days";
            this.colnombre_days.Visible = true;
            this.colnombre_days.VisibleIndex = 15;
            // 
            // colnum_quitance
            // 
            this.colnum_quitance.Caption = "رقم الوصل";
            this.colnum_quitance.FieldName = "num_quitance";
            this.colnum_quitance.Name = "colnum_quitance";
            this.colnum_quitance.Visible = true;
            this.colnum_quitance.VisibleIndex = 9;
            // 
            // colsomme_evry_time
            // 
            this.colsomme_evry_time.Caption = "المبلغ المستحق";
            this.colsomme_evry_time.FieldName = "somme_evry_time";
            this.colsomme_evry_time.Name = "colsomme_evry_time";
            this.colsomme_evry_time.Visible = true;
            this.colsomme_evry_time.VisibleIndex = 16;
            this.colsomme_evry_time.Width = 96;
            // 
            // coldate_payee
            // 
            this.coldate_payee.Caption = "تاريخ الدفع";
            this.coldate_payee.FieldName = "date_payee";
            this.coldate_payee.Name = "coldate_payee";
            this.coldate_payee.Visible = true;
            this.coldate_payee.VisibleIndex = 8;
            // 
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 630);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "احصــــــــــــــاء خــــــــــــاص";
            this.Load += new System.EventHandler(this.Stat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_shopping;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_name;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_boutique;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn collast_name_client;
        private DevExpress.XtraGrid.Columns.GridColumn colarticle;
        private DevExpress.XtraGrid.Columns.GridColumn colporte;
        private DevExpress.XtraGrid.Columns.GridColumn coltype;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_index;
        private DevExpress.XtraGrid.Columns.GridColumn colsomme_payee;
        private DevExpress.XtraGrid.Columns.GridColumn colmatricule_local;
        private DevExpress.XtraGrid.Columns.GridColumn colpostion_local;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_moins;
        private DevExpress.XtraGrid.Columns.GridColumn colfrom_date;
        private DevExpress.XtraGrid.Columns.GridColumn colto_date;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_days;
        private DevExpress.XtraGrid.Columns.GridColumn colsomme_evry_time;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_quitance;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_payee;
    }
}