
namespace gameMarket
{
    partial class Form_Library
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataTable1TableAdapter = new gameMarket.DataSetTableAdapters.DataTable1TableAdapter();
            this.dataSet = new gameMarket.DataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureDataDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.userLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.button,
            this.pictureDataDataGridViewImageColumn,
            this.userLogin,
            this.pictureName});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(303, 320);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet;
            // 
            // button
            // 
            this.button.Frozen = true;
            this.button.HeaderText = "button";
            this.button.Name = "button";
            this.button.ReadOnly = true;
            this.button.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pictureDataDataGridViewImageColumn
            // 
            this.pictureDataDataGridViewImageColumn.DataPropertyName = "PictureData";
            this.pictureDataDataGridViewImageColumn.FillWeight = 200F;
            this.pictureDataDataGridViewImageColumn.Frozen = true;
            this.pictureDataDataGridViewImageColumn.HeaderText = "PictureData";
            this.pictureDataDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pictureDataDataGridViewImageColumn.MinimumWidth = 200;
            this.pictureDataDataGridViewImageColumn.Name = "pictureDataDataGridViewImageColumn";
            this.pictureDataDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pictureDataDataGridViewImageColumn.Width = 200;
            // 
            // userLogin
            // 
            this.userLogin.DataPropertyName = "userLogin";
            this.userLogin.HeaderText = "userLogin";
            this.userLogin.Name = "userLogin";
            this.userLogin.ReadOnly = true;
            this.userLogin.Visible = false;
            // 
            // pictureName
            // 
            this.pictureName.DataPropertyName = "pictureName";
            this.pictureName.Frozen = true;
            this.pictureName.HeaderText = "pictureName";
            this.pictureName.Name = "pictureName";
            this.pictureName.ReadOnly = true;
            this.pictureName.Visible = false;
            // 
            // Form_Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 391);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form_Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureName;
    }
}