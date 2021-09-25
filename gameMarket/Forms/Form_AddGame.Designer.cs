
namespace gameMarket
{
    partial class Form_AddGame
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
            System.Windows.Forms.Label gameStudioIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label serverIdLabel;
            System.Windows.Forms.Label priceLabel;
            this.dataSet = new gameMarket.DataSet();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new gameMarket.DataSetTableAdapters.gamesTableAdapter();
            this.tableAdapterManager = new gameMarket.DataSetTableAdapters.TableAdapterManager();
            this.gameStudiosTableAdapter = new gameMarket.DataSetTableAdapters.gameStudiosTableAdapter();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Studio = new System.Windows.Forms.ComboBox();
            this.gameStudiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_SelectImage = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picturesTableAdapter1 = new gameMarket.DataSetTableAdapters.PicturesTableAdapter();
            this.numericUpDown_Price = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Server = new System.Windows.Forms.ComboBox();
            this.serversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serversTableAdapter = new gameMarket.DataSetTableAdapters.serversTableAdapter();
            gameStudioIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            serverIdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStudiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gameStudioIdLabel
            // 
            gameStudioIdLabel.AutoSize = true;
            gameStudioIdLabel.Location = new System.Drawing.Point(12, 31);
            gameStudioIdLabel.Name = "gameStudioIdLabel";
            gameStudioIdLabel.Size = new System.Drawing.Size(69, 13);
            gameStudioIdLabel.TabIndex = 3;
            gameStudioIdLabel.Text = "game Studio:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 57);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "name:";
            // 
            // serverIdLabel
            // 
            serverIdLabel.AutoSize = true;
            serverIdLabel.Location = new System.Drawing.Point(12, 83);
            serverIdLabel.Name = "serverIdLabel";
            serverIdLabel.Size = new System.Drawing.Size(39, 13);
            serverIdLabel.TabIndex = 7;
            serverIdLabel.Text = "server:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(14, 109);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 20;
            priceLabel.Text = "Price:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "games";
            this.gamesBindingSource.DataSource = this.dataSet;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.game_placemarkTableAdapter = null;
            this.tableAdapterManager.gamesTableAdapter = this.gamesTableAdapter;
            this.tableAdapterManager.gameStudiosTableAdapter = this.gameStudiosTableAdapter;
            this.tableAdapterManager.PicturesTableAdapter = null;
            this.tableAdapterManager.placemarksTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.serversTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gameMarket.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_gameTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // gameStudiosTableAdapter
            // 
            this.gameStudiosTableAdapter.ClearBeforeFill = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(99, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Logo.ErrorImage = null;
            this.pictureBox_Logo.Location = new System.Drawing.Point(289, 27);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(215, 131);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 9;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Logo:";
            // 
            // comboBox_Studio
            // 
            this.comboBox_Studio.DataSource = this.gameStudiosBindingSource;
            this.comboBox_Studio.DisplayMember = "studioName";
            this.comboBox_Studio.FormattingEnabled = true;
            this.comboBox_Studio.Location = new System.Drawing.Point(99, 27);
            this.comboBox_Studio.Name = "comboBox_Studio";
            this.comboBox_Studio.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Studio.TabIndex = 11;
            this.comboBox_Studio.ValueMember = "id";
            // 
            // gameStudiosBindingSource
            // 
            this.gameStudiosBindingSource.DataMember = "gameStudios";
            this.gameStudiosBindingSource.DataSource = this.dataSet;
            // 
            // button_SelectImage
            // 
            this.button_SelectImage.Location = new System.Drawing.Point(289, 184);
            this.button_SelectImage.Name = "button_SelectImage";
            this.button_SelectImage.Size = new System.Drawing.Size(89, 23);
            this.button_SelectImage.TabIndex = 13;
            this.button_SelectImage.Text = "Select image";
            this.button_SelectImage.UseVisualStyleBackColor = true;
            this.button_SelectImage.Click += new System.EventHandler(this.button_SelectImage_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 184);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 14;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(429, 184);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 15;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picturesTableAdapter1
            // 
            this.picturesTableAdapter1.ClearBeforeFill = true;
            // 
            // numericUpDown_Price
            // 
            this.numericUpDown_Price.DecimalPlaces = 2;
            this.numericUpDown_Price.InterceptArrowKeys = false;
            this.numericUpDown_Price.Location = new System.Drawing.Point(99, 107);
            this.numericUpDown_Price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Price.Name = "numericUpDown_Price";
            this.numericUpDown_Price.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown_Price.TabIndex = 21;
            // 
            // comboBox_Server
            // 
            this.comboBox_Server.DataSource = this.serversBindingSource;
            this.comboBox_Server.DisplayMember = "location";
            this.comboBox_Server.FormattingEnabled = true;
            this.comboBox_Server.Location = new System.Drawing.Point(99, 81);
            this.comboBox_Server.Name = "comboBox_Server";
            this.comboBox_Server.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Server.TabIndex = 22;
            this.comboBox_Server.ValueMember = "id";
            // 
            // serversBindingSource
            // 
            this.serversBindingSource.DataMember = "servers";
            this.serversBindingSource.DataSource = this.dataSet;
            // 
            // serversTableAdapter
            // 
            this.serversTableAdapter.ClearBeforeFill = true;
            // 
            // Form_AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 213);
            this.Controls.Add(this.comboBox_Server);
            this.Controls.Add(this.numericUpDown_Price);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_SelectImage);
            this.Controls.Add(this.comboBox_Studio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(gameStudioIdLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(serverIdLabel);
            this.Name = "Form_AddGame";
            this.Text = "Form_AddGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AddGame_FormClosing);
            this.Load += new System.EventHandler(this.Form_AddGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStudiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private DataSetTableAdapters.gamesTableAdapter gamesTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetTableAdapters.gameStudiosTableAdapter gameStudiosTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Studio;
        private System.Windows.Forms.BindingSource gameStudiosBindingSource;
        private System.Windows.Forms.Button button_SelectImage;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DataSetTableAdapters.PicturesTableAdapter picturesTableAdapter1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Price;
        private System.Windows.Forms.ComboBox comboBox_Server;
        private System.Windows.Forms.BindingSource serversBindingSource;
        private DataSetTableAdapters.serversTableAdapter serversTableAdapter;
    }
}