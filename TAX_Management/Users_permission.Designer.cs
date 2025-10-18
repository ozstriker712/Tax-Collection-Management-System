namespace PC_STORE
{
    partial class Users_permission
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
            System.Windows.Forms.Label pass_userLabel;
            System.Windows.Forms.Label permissionLabel;
            System.Windows.Forms.Label user_nameLabel;
            System.Windows.Forms.Label id_loginLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_permission));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PC_STORE.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_login = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpermission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpass_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pass_userTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.user_nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.id_loginSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.permissionSpinEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.loginTableAdapter = new PC_STORE.DataSet1TableAdapters.loginTableAdapter();
            pass_userLabel = new System.Windows.Forms.Label();
            permissionLabel = new System.Windows.Forms.Label();
            user_nameLabel = new System.Windows.Forms.Label();
            id_loginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_userTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_loginSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pass_userLabel
            // 
            pass_userLabel.AutoSize = true;
            pass_userLabel.Location = new System.Drawing.Point(21, 117);
            pass_userLabel.Name = "pass_userLabel";
            pass_userLabel.Size = new System.Drawing.Size(66, 13);
            pass_userLabel.TabIndex = 9;
            pass_userLabel.Text = "كلمة المرور :";
            // 
            // permissionLabel
            // 
            permissionLabel.AutoSize = true;
            permissionLabel.Location = new System.Drawing.Point(38, 164);
            permissionLabel.Name = "permissionLabel";
            permissionLabel.Size = new System.Drawing.Size(49, 13);
            permissionLabel.TabIndex = 8;
            permissionLabel.Text = "التصريح :";
            // 
            // user_nameLabel
            // 
            user_nameLabel.AutoSize = true;
            user_nameLabel.Location = new System.Drawing.Point(5, 78);
            user_nameLabel.Name = "user_nameLabel";
            user_nameLabel.Size = new System.Drawing.Size(88, 13);
            user_nameLabel.TabIndex = 7;
            user_nameLabel.Text = "اسم المستخدم :";
            // 
            // id_loginLabel
            // 
            id_loginLabel.AutoSize = true;
            id_loginLabel.Location = new System.Drawing.Point(38, 32);
            id_loginLabel.Name = "id_loginLabel";
            id_loginLabel.Size = new System.Drawing.Size(49, 13);
            id_loginLabel.TabIndex = 6;
            id_loginLabel.Text = "ID user :";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(25, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(412, 117);
            this.xtraTabControl1.TabIndex = 23;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.simpleButton4);
            this.xtraTabPage1.Controls.Add(this.simpleButton5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(410, 92);
            this.xtraTabPage1.Text = "اضافة متسخدم";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(235, 21);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(110, 43);
            this.simpleButton4.TabIndex = 16;
            this.simpleButton4.Text = "حفظ";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(19, 21);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(173, 43);
            this.simpleButton5.TabIndex = 17;
            this.simpleButton5.Text = "اضافة مستخدم";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.simpleButton1);
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(410, 92);
            this.xtraTabPage2.Text = "تعديل مستخدم";
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
            this.simpleButton2.Location = new System.Drawing.Point(200, 22);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(129, 42);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "حذف مستخدم";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.loginBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(292, 160);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(414, 223);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_login,
            this.coluser_name,
            this.colpermission,
            this.colpass_user});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid_login, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid_login
            // 
            this.colid_login.Caption = "ID user";
            this.colid_login.FieldName = "id_login";
            this.colid_login.Name = "colid_login";
            this.colid_login.Visible = true;
            this.colid_login.VisibleIndex = 0;
            this.colid_login.Width = 67;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "اسم مستخدم";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 1;
            this.coluser_name.Width = 108;
            // 
            // colpermission
            // 
            this.colpermission.Caption = "التصريح";
            this.colpermission.FieldName = "permission";
            this.colpermission.Name = "colpermission";
            this.colpermission.Visible = true;
            this.colpermission.VisibleIndex = 3;
            this.colpermission.Width = 108;
            // 
            // colpass_user
            // 
            this.colpass_user.Caption = "كلمة المرور";
            this.colpass_user.FieldName = "pass_user";
            this.colpass_user.Name = "colpass_user";
            this.colpass_user.Visible = true;
            this.colpass_user.VisibleIndex = 2;
            this.colpass_user.Width = 110;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(456, 36);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(105, 43);
            this.simpleButton3.TabIndex = 21;
            this.simpleButton3.Text = "تحديــــــــــث";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(629, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(77, 73);
            this.pictureEdit1.TabIndex = 20;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(pass_userLabel);
            this.panelControl1.Controls.Add(this.pass_userTextEdit);
            this.panelControl1.Controls.Add(permissionLabel);
            this.panelControl1.Controls.Add(user_nameLabel);
            this.panelControl1.Controls.Add(this.user_nameTextEdit);
            this.panelControl1.Controls.Add(id_loginLabel);
            this.panelControl1.Controls.Add(this.id_loginSpinEdit);
            this.panelControl1.Controls.Add(this.permissionSpinEdit);
            this.panelControl1.Location = new System.Drawing.Point(25, 160);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(252, 223);
            this.panelControl1.TabIndex = 19;
            // 
            // pass_userTextEdit
            // 
            this.pass_userTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBindingSource, "pass_user", true));
            this.pass_userTextEdit.Location = new System.Drawing.Point(99, 114);
            this.pass_userTextEdit.Name = "pass_userTextEdit";
            this.pass_userTextEdit.Size = new System.Drawing.Size(100, 20);
            this.pass_userTextEdit.TabIndex = 10;
            // 
            // user_nameTextEdit
            // 
            this.user_nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBindingSource, "user_name", true));
            this.user_nameTextEdit.Location = new System.Drawing.Point(99, 75);
            this.user_nameTextEdit.Name = "user_nameTextEdit";
            this.user_nameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.user_nameTextEdit.TabIndex = 8;
            // 
            // id_loginSpinEdit
            // 
            this.id_loginSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBindingSource, "id_login", true));
            this.id_loginSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.id_loginSpinEdit.Location = new System.Drawing.Point(99, 29);
            this.id_loginSpinEdit.Name = "id_loginSpinEdit";
            this.id_loginSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.id_loginSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.id_loginSpinEdit.Size = new System.Drawing.Size(48, 20);
            this.id_loginSpinEdit.TabIndex = 7;
            // 
            // permissionSpinEdit
            // 
            this.permissionSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBindingSource, "permission", true));
            this.permissionSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.permissionSpinEdit.Location = new System.Drawing.Point(99, 161);
            this.permissionSpinEdit.Name = "permissionSpinEdit";
            this.permissionSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.permissionSpinEdit.Properties.Items.AddRange(new object[] {
            "1",
            "2"});
            this.permissionSpinEdit.Size = new System.Drawing.Size(48, 20);
            this.permissionSpinEdit.TabIndex = 9;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // Users_permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 411);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Users_permission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمين و التصريحات";
            this.Load += new System.EventHandler(this.Users_permission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_userTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_loginSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionSpinEdit.Properties)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colid_login;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private DevExpress.XtraGrid.Columns.GridColumn colpermission;
        private DevExpress.XtraGrid.Columns.GridColumn colpass_user;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit pass_userTextEdit;
        private DevExpress.XtraEditors.TextEdit user_nameTextEdit;
        private DevExpress.XtraEditors.TextEdit id_loginSpinEdit;
        private DevExpress.XtraEditors.ComboBoxEdit permissionSpinEdit;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private DataSet1TableAdapters.loginTableAdapter loginTableAdapter;
    }
}