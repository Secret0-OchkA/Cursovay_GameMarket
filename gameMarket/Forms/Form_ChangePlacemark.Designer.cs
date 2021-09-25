
namespace gameMarket.Forms
{
    partial class Form_ChangePlacemark
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
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.comboBox_Placemark = new System.Windows.Forms.ComboBox();
            this.placemarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new gameMarket.DataSet();
            this.dataGridView_Placemarks = new System.Windows.Forms.DataGridView();
            this.placemarkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placemarkIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placemakrsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placemarksTableAdapter = new gameMarket.DataSetTableAdapters.placemarksTableAdapter();
            this.placemakrsViewTableAdapter = new gameMarket.DataSetTableAdapters.PlacemakrsViewTableAdapter();
            this.game_placemarkTableAdapter1 = new gameMarket.DataSetTableAdapters.game_placemarkTableAdapter();
            this.label_Errors = new System.Windows.Forms.Label();
            this.timer_clearLabelError = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.placemarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Placemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placemakrsViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 204);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 0;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(93, 204);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(12, 168);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // comboBox_Placemark
            // 
            this.comboBox_Placemark.DataSource = this.placemarksBindingSource;
            this.comboBox_Placemark.DisplayMember = "placemarker";
            this.comboBox_Placemark.FormattingEnabled = true;
            this.comboBox_Placemark.Location = new System.Drawing.Point(176, 204);
            this.comboBox_Placemark.Name = "comboBox_Placemark";
            this.comboBox_Placemark.Size = new System.Drawing.Size(92, 21);
            this.comboBox_Placemark.TabIndex = 4;
            this.comboBox_Placemark.ValueMember = "id";
            // 
            // placemarksBindingSource
            // 
            this.placemarksBindingSource.DataMember = "placemarks";
            this.placemarksBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_Placemarks
            // 
            this.dataGridView_Placemarks.AllowUserToAddRows = false;
            this.dataGridView_Placemarks.AllowUserToDeleteRows = false;
            this.dataGridView_Placemarks.AutoGenerateColumns = false;
            this.dataGridView_Placemarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Placemarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Placemarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placemarkerDataGridViewTextBoxColumn,
            this.placemarkIdDataGridViewTextBoxColumn});
            this.dataGridView_Placemarks.DataSource = this.placemakrsViewBindingSource;
            this.dataGridView_Placemarks.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Placemarks.MultiSelect = false;
            this.dataGridView_Placemarks.Name = "dataGridView_Placemarks";
            this.dataGridView_Placemarks.ReadOnly = true;
            this.dataGridView_Placemarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Placemarks.Size = new System.Drawing.Size(256, 150);
            this.dataGridView_Placemarks.TabIndex = 5;
            // 
            // placemarkerDataGridViewTextBoxColumn
            // 
            this.placemarkerDataGridViewTextBoxColumn.DataPropertyName = "placemarker";
            this.placemarkerDataGridViewTextBoxColumn.HeaderText = "placemarker";
            this.placemarkerDataGridViewTextBoxColumn.Name = "placemarkerDataGridViewTextBoxColumn";
            this.placemarkerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placemarkIdDataGridViewTextBoxColumn
            // 
            this.placemarkIdDataGridViewTextBoxColumn.DataPropertyName = "placemarkId";
            this.placemarkIdDataGridViewTextBoxColumn.HeaderText = "placemarkId";
            this.placemarkIdDataGridViewTextBoxColumn.Name = "placemarkIdDataGridViewTextBoxColumn";
            this.placemarkIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.placemarkIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // placemakrsViewBindingSource
            // 
            this.placemakrsViewBindingSource.DataMember = "PlaceMakrsView";
            this.placemakrsViewBindingSource.DataSource = this.dataSet;
            // 
            // placemarksTableAdapter
            // 
            this.placemarksTableAdapter.ClearBeforeFill = true;
            // 
            // placemakrsViewTableAdapter
            // 
            this.placemakrsViewTableAdapter.ClearBeforeFill = true;
            // 
            // game_placemarkTableAdapter1
            // 
            this.game_placemarkTableAdapter1.ClearBeforeFill = true;
            // 
            // label_Errors
            // 
            this.label_Errors.AutoSize = true;
            this.label_Errors.ForeColor = System.Drawing.Color.Red;
            this.label_Errors.Location = new System.Drawing.Point(93, 173);
            this.label_Errors.Name = "label_Errors";
            this.label_Errors.Size = new System.Drawing.Size(0, 13);
            this.label_Errors.TabIndex = 6;
            // 
            // timer_clearLabelError
            // 
            this.timer_clearLabelError.Interval = 2000;
            this.timer_clearLabelError.Tick += new System.EventHandler(this.timer_clearLabelError_Tick);
            // 
            // Form_ChangePlacemark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 238);
            this.Controls.Add(this.label_Errors);
            this.Controls.Add(this.dataGridView_Placemarks);
            this.Controls.Add(this.comboBox_Placemark);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_ChangePlacemark";
            this.Text = "Change placemark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ChangePlacemark_FormClosing);
            this.Load += new System.EventHandler(this.Form_ChangePlacemark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placemarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Placemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placemakrsViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ComboBox comboBox_Placemark;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource placemarksBindingSource;
        private DataSetTableAdapters.placemarksTableAdapter placemarksTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_Placemarks;
        private System.Windows.Forms.BindingSource placemakrsViewBindingSource;
        private DataSetTableAdapters.PlacemakrsViewTableAdapter placemakrsViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn placemarkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placemarkIdDataGridViewTextBoxColumn;
        private DataSetTableAdapters.game_placemarkTableAdapter game_placemarkTableAdapter1;
        private System.Windows.Forms.Label label_Errors;
        private System.Windows.Forms.Timer timer_clearLabelError;
    }
}