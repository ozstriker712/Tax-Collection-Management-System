namespace PC_STORE
{
    partial class add_new_local
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_new_local));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.typelocalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PC_STORE.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_local_exist = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textedit1 = new DevExpress.XtraEditors.TextEdit();
            this.type_localTableAdapter = new PC_STORE.DataSet1TableAdapters.type_localTableAdapter();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableAdapterManager = new PC_STORE.DataSet1TableAdapters.TableAdapterManager();
            this.id_typeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typelocalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_typeSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(617, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(395, 117);
            this.xtraTabControl1.TabIndex = 28;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.simpleButton4);
            this.xtraTabPage1.Controls.Add(this.simpleButton5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(393, 92);
            this.xtraTabPage1.Text = "اضــــــــــافة مكـــان او مصدر تحصيل";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(258, 21);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(110, 43);
            this.simpleButton4.TabIndex = 16;
            this.simpleButton4.Text = "حفـــــــــــــظ";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(19, 21);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(173, 43);
            this.simpleButton5.TabIndex = 17;
            this.simpleButton5.Text = "اضافة عنصر جديد";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.simpleButton1);
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(393, 92);
            this.xtraTabPage2.Text = "تعديـــــــــــــل مكـــان او مصدر تحصيل";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(32, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(139, 42);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "حفظ التغييرات";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(239, 22);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(129, 42);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "حذف مستخدم";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.typelocalBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(588, 330);
            this.gridControl1.TabIndex = 27;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // typelocalBindingSource
            // 
            this.typelocalBindingSource.DataMember = "type_local";
            this.typelocalBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_type,
            this.colname_type,
            this.colnum_local_exist});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid_type, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid_type
            // 
            this.colid_type.Caption = "الرقم";
            this.colid_type.FieldName = "id_type";
            this.colid_type.Name = "colid_type";
            this.colid_type.Visible = true;
            this.colid_type.VisibleIndex = 0;
            this.colid_type.Width = 77;
            // 
            // colname_type
            // 
            this.colname_type.Caption = "نوع التعييــــــن";
            this.colname_type.FieldName = "name_type";
            this.colname_type.Name = "colname_type";
            this.colname_type.Visible = true;
            this.colname_type.VisibleIndex = 1;
            this.colname_type.Width = 331;
            // 
            // colnum_local_exist
            // 
            this.colnum_local_exist.Caption = "يحتوي على محلات";
            this.colnum_local_exist.FieldName = "num_local_exist";
            this.colnum_local_exist.Name = "colnum_local_exist";
            this.colnum_local_exist.Visible = true;
            this.colnum_local_exist.VisibleIndex = 2;
            this.colnum_local_exist.Width = 159;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(742, 299);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(157, 43);
            this.simpleButton3.TabIndex = 26;
            this.simpleButton3.Text = "تحديـــــــــث الجدول";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.textedit1);
            this.panelControl1.Location = new System.Drawing.Point(617, 161);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(394, 110);
            this.panelControl1.TabIndex = 24;
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.typelocalBindingSource, "num_local_exist", true));
            this.checkEdit1.Location = new System.Drawing.Point(174, 62);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Size = new System.Drawing.Size(20, 19);
            this.checkEdit1.TabIndex = 76;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = ": هل يحتوي على محلات بها ارقام   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = ": نوع التعييـــن   ";
            // 
            // textedit1
            // 
            this.textedit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.typelocalBindingSource, "name_type", true));
            this.textedit1.Location = new System.Drawing.Point(49, 21);
            this.textedit1.Name = "textedit1";
            this.textedit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textedit1.Size = new System.Drawing.Size(232, 20);
            this.textedit1.TabIndex = 8;
            this.textedit1.Enter += new System.EventHandler(this.textedit1_Enter);
            // 
            // type_localTableAdapter
            // 
            this.type_localTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ancien_bddTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.Historique_modificationTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.paramaterTableAdapter = null;
            this.tableAdapterManager.type_localTableAdapter = this.type_localTableAdapter;
            this.tableAdapterManager.UpdateOrder = PC_STORE.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id_typeSpinEdit
            // 
            this.id_typeSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.typelocalBindingSource, "id_type", true));
            this.id_typeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.id_typeSpinEdit.Location = new System.Drawing.Point(617, 322);
            this.id_typeSpinEdit.Name = "id_typeSpinEdit";
            this.id_typeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.id_typeSpinEdit.Size = new System.Drawing.Size(65, 20);
            this.id_typeSpinEdit.TabIndex = 29;
            // 
            // add_new_local
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 363);
            this.Controls.Add(this.id_typeSpinEdit);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "add_new_local";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضــــــــــافة او تعديل مكـــان او مصدر تحصيل";
            this.Load += new System.EventHandler(this.add_new_local_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typelocalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_typeSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraEditors.SimpleButton simpleButton4;
        public DevExpress.XtraEditors.SimpleButton simpleButton5;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit textedit1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource typelocalBindingSource;
        private DataSet1TableAdapters.type_localTableAdapter type_localTableAdapter;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_type;
        private DevExpress.XtraGrid.Columns.GridColumn colname_type;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_local_exist;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        public DevExpress.XtraEditors.SpinEdit id_typeSpinEdit;
    }
}