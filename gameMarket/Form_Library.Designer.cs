
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
            System.Windows.Forms.Label studioNameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label pictureNameLabel;
            System.Windows.Forms.Label userLoginLabel;
            System.Windows.Forms.Label pictureDataLabel;
            this.button_Back = new System.Windows.Forms.Button();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new gameMarket.DataSet();
            this.libraryTableAdapter = new gameMarket.DataSetTableAdapters.LibraryTableAdapter();
            this.tableAdapterManager = new gameMarket.DataSetTableAdapters.TableAdapterManager();
            this.libraryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_placemarker = new System.Windows.Forms.ComboBox();
            this.placemarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placemarksTableAdapter = new gameMarket.DataSetTableAdapters.placemarksTableAdapter();
            this.studioNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pictureNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureDataPictureBox = new System.Windows.Forms.PictureBox();
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            studioNameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            pictureNameLabel = new System.Windows.Forms.Label();
            userLoginLabel = new System.Windows.Forms.Label();
            pictureDataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placemarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(26, 325);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 4;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.game_placemarkTableAdapter = null;
            this.tableAdapterManager.gamesTableAdapter = null;
            this.tableAdapterManager.gameStudiosTableAdapter = null;
            this.tableAdapterManager.PicturesTableAdapter = null;
            this.tableAdapterManager.placemarksTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.serversTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gameMarket.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_gameTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // libraryDataGridView
            // 
            this.libraryDataGridView.AutoGenerateColumns = false;
            this.libraryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.libraryDataGridView.DataSource = this.libraryBindingSource;
            this.libraryDataGridView.Location = new System.Drawing.Point(12, 27);
            this.libraryDataGridView.Name = "libraryDataGridView";
            this.libraryDataGridView.Size = new System.Drawing.Size(300, 249);
            this.libraryDataGridView.TabIndex = 4;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "PictureData";
            this.dataGridViewImageColumn1.HeaderText = "PictureData";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pictureName";
            this.dataGridViewTextBoxColumn2.HeaderText = "pictureName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "studioName";
            this.dataGridViewTextBoxColumn4.HeaderText = "studioName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // comboBox_placemarker
            // 
            this.comboBox_placemarker.DataSource = this.placemarksBindingSource;
            this.comboBox_placemarker.DisplayMember = "placemarker";
            this.comboBox_placemarker.FormattingEnabled = true;
            this.comboBox_placemarker.Location = new System.Drawing.Point(348, 188);
            this.comboBox_placemarker.Name = "comboBox_placemarker";
            this.comboBox_placemarker.Size = new System.Drawing.Size(176, 21);
            this.comboBox_placemarker.TabIndex = 14;
            this.comboBox_placemarker.ValueMember = "id";
            this.comboBox_placemarker.SelectedIndexChanged += new System.EventHandler(this.comboBox_placemarker_SelectedIndexChanged);
            // 
            // placemarksBindingSource
            // 
            this.placemarksBindingSource.DataMember = "placemarks";
            this.placemarksBindingSource.DataSource = this.dataSet;
            // 
            // placemarksTableAdapter
            // 
            this.placemarksTableAdapter.ClearBeforeFill = true;
            // 
            // studioNameTextBox
            // 
            this.studioNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "studioName", true));
            this.studioNameTextBox.Location = new System.Drawing.Point(424, 162);
            this.studioNameTextBox.Name = "studioNameTextBox";
            this.studioNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studioNameTextBox.TabIndex = 23;
            // 
            // studioNameLabel
            // 
            studioNameLabel.AutoSize = true;
            studioNameLabel.Location = new System.Drawing.Point(345, 165);
            studioNameLabel.Name = "studioNameLabel";
            studioNameLabel.Size = new System.Drawing.Size(69, 13);
            studioNameLabel.TabIndex = 22;
            studioNameLabel.Text = "studio Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(424, 136);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 21;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(345, 139);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "name:";
            // 
            // pictureNameTextBox
            // 
            this.pictureNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "pictureName", true));
            this.pictureNameTextBox.Location = new System.Drawing.Point(424, 110);
            this.pictureNameTextBox.Name = "pictureNameTextBox";
            this.pictureNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.pictureNameTextBox.TabIndex = 19;
            // 
            // pictureNameLabel
            // 
            pictureNameLabel.AutoSize = true;
            pictureNameLabel.Location = new System.Drawing.Point(345, 113);
            pictureNameLabel.Name = "pictureNameLabel";
            pictureNameLabel.Size = new System.Drawing.Size(73, 13);
            pictureNameLabel.TabIndex = 18;
            pictureNameLabel.Text = "picture Name:";
            // 
            // pictureDataPictureBox
            // 
            this.pictureDataPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.libraryBindingSource, "PictureData", true));
            this.pictureDataPictureBox.Location = new System.Drawing.Point(424, 54);
            this.pictureDataPictureBox.Name = "pictureDataPictureBox";
            this.pictureDataPictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureDataPictureBox.TabIndex = 17;
            this.pictureDataPictureBox.TabStop = false;
            // 
            // userLoginLabel
            // 
            userLoginLabel.AutoSize = true;
            userLoginLabel.Location = new System.Drawing.Point(345, 31);
            userLoginLabel.Name = "userLoginLabel";
            userLoginLabel.Size = new System.Drawing.Size(59, 13);
            userLoginLabel.TabIndex = 14;
            userLoginLabel.Text = "user Login:";
            // 
            // pictureDataLabel
            // 
            pictureDataLabel.AutoSize = true;
            pictureDataLabel.Location = new System.Drawing.Point(345, 54);
            pictureDataLabel.Name = "pictureDataLabel";
            pictureDataLabel.Size = new System.Drawing.Size(69, 13);
            pictureDataLabel.TabIndex = 16;
            pictureDataLabel.Text = "Picture Data:";
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "userLogin", true));
            this.userLoginTextBox.Location = new System.Drawing.Point(424, 28);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.userLoginTextBox.TabIndex = 15;
            // 
            // Form_Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 565);
            this.Controls.Add(userLoginLabel);
            this.Controls.Add(this.userLoginTextBox);
            this.Controls.Add(pictureDataLabel);
            this.Controls.Add(this.pictureDataPictureBox);
            this.Controls.Add(pictureNameLabel);
            this.Controls.Add(this.pictureNameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(studioNameLabel);
            this.Controls.Add(this.studioNameTextBox);
            this.Controls.Add(this.comboBox_placemarker);
            this.Controls.Add(this.libraryDataGridView);
            this.Controls.Add(this.button_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form_Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placemarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet dataSet;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private DataSetTableAdapters.LibraryTableAdapter libraryTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView libraryDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox comboBox_placemarker;
        private System.Windows.Forms.BindingSource placemarksBindingSource;
        private DataSetTableAdapters.placemarksTableAdapter placemarksTableAdapter;
        private System.Windows.Forms.TextBox studioNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox pictureNameTextBox;
        private System.Windows.Forms.PictureBox pictureDataPictureBox;
        private System.Windows.Forms.TextBox userLoginTextBox;
    }
}