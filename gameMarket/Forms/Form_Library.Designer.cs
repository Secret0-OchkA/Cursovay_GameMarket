
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
            this.button_Back = new System.Windows.Forms.Button();
            this.libraryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new gameMarket.DataSet();
            this.libraryTableAdapter = new gameMarket.DataSetTableAdapters.LibraryTableAdapter();
            this.shopTableAdapter = new gameMarket.DataSetTableAdapters.ShopTableAdapter();
            this.shopDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_PlacemarkShop = new System.Windows.Forms.ComboBox();
            this.placemarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_PlacemarkLibrary = new System.Windows.Forms.ComboBox();
            this.placemarksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.placemarksTableAdapter = new gameMarket.DataSetTableAdapters.placemarksTableAdapter();
            this.button_Buy = new System.Windows.Forms.Button();
            this.button_Download = new System.Windows.Forms.Button();
            this.user_gameTableAdapter1 = new gameMarket.DataSetTableAdapters.user_gameTableAdapter();
            this.gamesTableAdapter1 = new gameMarket.DataSetTableAdapters.gamesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placemarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placemarksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 279);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 4;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // libraryDataGridView
            // 
            this.libraryDataGridView.AllowUserToAddRows = false;
            this.libraryDataGridView.AllowUserToDeleteRows = false;
            this.libraryDataGridView.AutoGenerateColumns = false;
            this.libraryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.libraryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.libraryDataGridView.DataSource = this.libraryBindingSource;
            this.libraryDataGridView.Location = new System.Drawing.Point(385, 12);
            this.libraryDataGridView.MultiSelect = false;
            this.libraryDataGridView.Name = "libraryDataGridView";
            this.libraryDataGridView.ReadOnly = true;
            this.libraryDataGridView.RowTemplate.Height = 50;
            this.libraryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.libraryDataGridView.Size = new System.Drawing.Size(343, 220);
            this.libraryDataGridView.TabIndex = 4;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "PictureData";
            this.dataGridViewImageColumn1.FillWeight = 91.37056F;
            this.dataGridViewImageColumn1.HeaderText = "PictureData";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.FillWeight = 104.3147F;
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "studioName";
            this.dataGridViewTextBoxColumn2.FillWeight = 104.3147F;
            this.dataGridViewTextBoxColumn2.HeaderText = "studioName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "Library";
            this.libraryBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // shopTableAdapter
            // 
            this.shopTableAdapter.ClearBeforeFill = true;
            // 
            // shopDataGridView
            // 
            this.shopDataGridView.AllowUserToAddRows = false;
            this.shopDataGridView.AllowUserToDeleteRows = false;
            this.shopDataGridView.AutoGenerateColumns = false;
            this.shopDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.shopDataGridView.DataSource = this.shopBindingSource;
            this.shopDataGridView.Location = new System.Drawing.Point(12, 12);
            this.shopDataGridView.MultiSelect = false;
            this.shopDataGridView.Name = "shopDataGridView";
            this.shopDataGridView.ReadOnly = true;
            this.shopDataGridView.RowTemplate.Height = 50;
            this.shopDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shopDataGridView.Size = new System.Drawing.Size(367, 220);
            this.shopDataGridView.TabIndex = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "PictureData";
            this.dataGridViewImageColumn2.FillWeight = 121.8274F;
            this.dataGridViewImageColumn2.HeaderText = "PictureData";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.FillWeight = 92.7242F;
            this.dataGridViewTextBoxColumn4.HeaderText = "name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "studioName";
            this.dataGridViewTextBoxColumn5.FillWeight = 92.7242F;
            this.dataGridViewTextBoxColumn5.HeaderText = "studioName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.FillWeight = 92.7242F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataMember = "Shop";
            this.shopBindingSource.DataSource = this.dataSet;
            // 
            // comboBox_PlacemarkShop
            // 
            this.comboBox_PlacemarkShop.DataSource = this.placemarksBindingSource;
            this.comboBox_PlacemarkShop.DisplayMember = "placemarker";
            this.comboBox_PlacemarkShop.FormattingEnabled = true;
            this.comboBox_PlacemarkShop.Location = new System.Drawing.Point(50, 238);
            this.comboBox_PlacemarkShop.Name = "comboBox_PlacemarkShop";
            this.comboBox_PlacemarkShop.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PlacemarkShop.TabIndex = 6;
            this.comboBox_PlacemarkShop.ValueMember = "id";
            this.comboBox_PlacemarkShop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // placemarksBindingSource
            // 
            this.placemarksBindingSource.DataMember = "placemarks";
            this.placemarksBindingSource.DataSource = this.dataSet;
            // 
            // comboBox_PlacemarkLibrary
            // 
            this.comboBox_PlacemarkLibrary.DataSource = this.placemarksBindingSource1;
            this.comboBox_PlacemarkLibrary.DisplayMember = "placemarker";
            this.comboBox_PlacemarkLibrary.FormattingEnabled = true;
            this.comboBox_PlacemarkLibrary.Location = new System.Drawing.Point(420, 238);
            this.comboBox_PlacemarkLibrary.Name = "comboBox_PlacemarkLibrary";
            this.comboBox_PlacemarkLibrary.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PlacemarkLibrary.TabIndex = 7;
            this.comboBox_PlacemarkLibrary.ValueMember = "id";
            this.comboBox_PlacemarkLibrary.SelectedIndexChanged += new System.EventHandler(this.comboBox_PlacemarkLibrary_SelectedIndexChanged);
            // 
            // placemarksBindingSource1
            // 
            this.placemarksBindingSource1.DataMember = "placemarks";
            this.placemarksBindingSource1.DataSource = this.dataSet;
            // 
            // placemarksTableAdapter
            // 
            this.placemarksTableAdapter.ClearBeforeFill = true;
            // 
            // button_Buy
            // 
            this.button_Buy.Location = new System.Drawing.Point(177, 238);
            this.button_Buy.Name = "button_Buy";
            this.button_Buy.Size = new System.Drawing.Size(75, 23);
            this.button_Buy.TabIndex = 8;
            this.button_Buy.Text = "Buy";
            this.button_Buy.UseVisualStyleBackColor = true;
            this.button_Buy.Click += new System.EventHandler(this.button_Buy_Click);
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(547, 238);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(75, 23);
            this.button_Download.TabIndex = 9;
            this.button_Download.Text = "Download";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // user_gameTableAdapter1
            // 
            this.user_gameTableAdapter1.ClearBeforeFill = true;
            // 
            // gamesTableAdapter1
            // 
            this.gamesTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter:";
            // 
            // Form_Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.button_Buy);
            this.Controls.Add(this.comboBox_PlacemarkLibrary);
            this.Controls.Add(this.comboBox_PlacemarkShop);
            this.Controls.Add(this.shopDataGridView);
            this.Controls.Add(this.libraryDataGridView);
            this.Controls.Add(this.button_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Library";
            this.Text = "Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Library_FormClosing);
            this.Load += new System.EventHandler(this.Form_Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placemarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placemarksBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Back;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private DataSetTableAdapters.LibraryTableAdapter libraryTableAdapter;
        private DataSetTableAdapters.ShopTableAdapter shopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView libraryDataGridView;
        private System.Windows.Forms.DataGridView shopDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private System.Windows.Forms.ComboBox comboBox_PlacemarkShop;
        private System.Windows.Forms.ComboBox comboBox_PlacemarkLibrary;
        private System.Windows.Forms.BindingSource placemarksBindingSource;
        private DataSetTableAdapters.placemarksTableAdapter placemarksTableAdapter;
        private System.Windows.Forms.BindingSource placemarksBindingSource1;
        private System.Windows.Forms.Button button_Buy;
        private System.Windows.Forms.Button button_Download;
        private DataSetTableAdapters.user_gameTableAdapter user_gameTableAdapter1;
        private DataSetTableAdapters.gamesTableAdapter gamesTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}