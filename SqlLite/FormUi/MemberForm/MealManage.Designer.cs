namespace SqlLite.FormUi.MemberForm
{
    partial class MealManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.deMealDate = new DevExpress.XtraEditors.DateEdit();
            this.lueMealUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.mealUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lueMember = new DevExpress.XtraEditors.LookUpEdit();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deMealDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deMealDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMealUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.deMealDate);
            this.groupBox1.Controls.Add(this.lueMealUnit);
            this.groupBox1.Controls.Add(this.lueMember);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // deMealDate
            // 
            this.deMealDate.EditValue = null;
            this.deMealDate.Location = new System.Drawing.Point(84, 45);
            this.deMealDate.Name = "deMealDate";
            this.deMealDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deMealDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deMealDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deMealDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deMealDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deMealDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deMealDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deMealDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deMealDate.Size = new System.Drawing.Size(100, 20);
            this.deMealDate.TabIndex = 2;
            // 
            // lueMealUnit
            // 
            this.lueMealUnit.Location = new System.Drawing.Point(84, 71);
            this.lueMealUnit.Name = "lueMealUnit";
            this.lueMealUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMealUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 50, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.lueMealUnit.Properties.DataSource = this.mealUnitBindingSource;
            this.lueMealUnit.Properties.DisplayMember = "Name";
            this.lueMealUnit.Properties.ShowHeader = false;
            this.lueMealUnit.Properties.ValueMember = "Value";
            this.lueMealUnit.Size = new System.Drawing.Size(100, 20);
            this.lueMealUnit.TabIndex = 1;
            // 
            // mealUnitBindingSource
            // 
            this.mealUnitBindingSource.DataSource = typeof(SqlLite.Models.Entities.MealUnit);
            // 
            // lueMember
            // 
            this.lueMember.Location = new System.Drawing.Point(84, 19);
            this.lueMember.Name = "lueMember";
            this.lueMember.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMember.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Contact", "Contact", 48, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueMember.Properties.DataSource = this.memberBindingSource;
            this.lueMember.Properties.DisplayMember = "Name";
            this.lueMember.Properties.ValueMember = "ID";
            this.lueMember.Size = new System.Drawing.Size(237, 20);
            this.lueMember.TabIndex = 0;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(SqlLite.Models.Entities.Member);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 245);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(945, 200);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MealManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 457);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MealManage";
            this.Text = "MealManage";
            this.Load += new System.EventHandler(this.MealManage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deMealDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deMealDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMealUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lueMember;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private DevExpress.XtraEditors.LookUpEdit lueMealUnit;
        private DevExpress.XtraEditors.DateEdit deMealDate;
        private System.Windows.Forms.BindingSource mealUnitBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
    }
}