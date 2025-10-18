namespace PC_STORE
{
    partial class update_paramater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_paramater));
            this.dataSet1 = new PC_STORE.DataSet1();
            this.paramaterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paramaterTableAdapter = new PC_STORE.DataSet1TableAdapters.paramaterTableAdapter();
            this.tableAdapterManager = new PC_STORE.DataSet1TableAdapters.TableAdapterManager();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.id_paramaterSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramaterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_paramaterSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paramaterBindingSource
            // 
            this.paramaterBindingSource.DataMember = "paramater";
            this.paramaterBindingSource.DataSource = this.dataSet1;
            // 
            // paramaterTableAdapter
            // 
            this.paramaterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ancien_bddTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.Historique_modificationTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.paramaterTableAdapter = this.paramaterTableAdapter;
            this.tableAdapterManager.type_localTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PC_STORE.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(155, 92);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(145, 44);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "حفظ الاعدادت";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paramaterBindingSource, "active_check_user_for_update", true));
            this.comboBoxEdit1.Location = new System.Drawing.Point(90, 38);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.AutoComplete = false;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "no",
            "yes"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = ": تفعيل خاصية التحقق من اسم المستخدم   ";
            // 
            // id_paramaterSpinEdit
            // 
            this.id_paramaterSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paramaterBindingSource, "id_paramater", true));
            this.id_paramaterSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.id_paramaterSpinEdit.Location = new System.Drawing.Point(12, 24);
            this.id_paramaterSpinEdit.Name = "id_paramaterSpinEdit";
            this.id_paramaterSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.id_paramaterSpinEdit.Properties.ReadOnly = true;
            this.id_paramaterSpinEdit.Size = new System.Drawing.Size(32, 20);
            this.id_paramaterSpinEdit.TabIndex = 0;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(1, 5);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit4.Size = new System.Drawing.Size(70, 61);
            this.pictureEdit4.TabIndex = 116;
            // 
            // update_paramater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 162);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.id_paramaterSpinEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "update_paramater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاعــــــــــدادت";
            this.Load += new System.EventHandler(this.Paramater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramaterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_paramaterSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource paramaterBindingSource;
        private DataSet1TableAdapters.paramaterTableAdapter paramaterTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.SpinEdit id_paramaterSpinEdit;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
    }
}