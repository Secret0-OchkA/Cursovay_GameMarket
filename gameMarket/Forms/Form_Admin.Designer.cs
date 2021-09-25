
namespace gameMarket
{
    partial class Form_Admin
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label pictureDataLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label studioNameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new gameMarket.DataSet();
            this.gamesDataGridView = new System.Windows.Forms.DataGridView();
            this.gamesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_Users = new System.Windows.Forms.GroupBox();
            this.button_Library = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_ = new System.Windows.Forms.Button();
            this.textBox_Delete = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_RoleUpdate = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTextBox_Update = new System.Windows.Forms.TextBox();
            this.passwordTextBox_Update = new System.Windows.Forms.TextBox();
            this.button_UsUp = new System.Windows.Forms.Button();
            this.groupBox_games = new System.Windows.Forms.GroupBox();
            this.button_AddGame = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Ga_Delete = new System.Windows.Forms.Button();
            this.textBox_DeleteGame = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_ChangePlacemark = new System.Windows.Forms.Button();
            this.numericUpDown_Price = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Server = new System.Windows.Forms.ComboBox();
            this.serversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_SelectImage = new System.Windows.Forms.Button();
            this.comboBox_GameStudio = new System.Windows.Forms.ComboBox();
            this.gameStudiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureDataPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button_GaUp = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.userViewTableAdapter = new gameMarket.DataSetTableAdapters.UserViewTableAdapter();
            this.rolesTableAdapter = new gameMarket.DataSetTableAdapters.rolesTableAdapter();
            this.usersTableAdapter1 = new gameMarket.DataSetTableAdapters.usersTableAdapter();
            this.gamesViewTableAdapter = new gameMarket.DataSetTableAdapters.GamesViewTableAdapter();
            this.tableAdapterManager = new gameMarket.DataSetTableAdapters.TableAdapterManager();
            this.gameStudiosTableAdapter = new gameMarket.DataSetTableAdapters.gameStudiosTableAdapter();
            this.gamesTableAdapter1 = new gameMarket.DataSetTableAdapters.gamesTableAdapter();
            this.picturesTableAdapter1 = new gameMarket.DataSetTableAdapters.PicturesTableAdapter();
            this.serversTableAdapter = new gameMarket.DataSetTableAdapters.serversTableAdapter();
            this.pictureDataDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studioNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureDataLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            studioNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesViewBindingSource)).BeginInit();
            this.groupBox_Users.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.groupBox_games.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStudiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(153, 22);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(32, 13);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(153, 48);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "password:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(153, 74);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(27, 13);
            roleLabel.TabIndex = 5;
            roleLabel.Text = "role:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(146, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 13);
            label2.TabIndex = 7;
            label2.Text = "login:";
            // 
            // pictureDataLabel
            // 
            pictureDataLabel.AutoSize = true;
            pictureDataLabel.Location = new System.Drawing.Point(128, 22);
            pictureDataLabel.Name = "pictureDataLabel";
            pictureDataLabel.Size = new System.Drawing.Size(34, 13);
            pictureDataLabel.TabIndex = 8;
            pictureDataLabel.Text = "Logo:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(317, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(317, 48);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Price:";
            // 
            // studioNameLabel
            // 
            studioNameLabel.AutoSize = true;
            studioNameLabel.Location = new System.Drawing.Point(318, 79);
            studioNameLabel.Name = "studioNameLabel";
            studioNameLabel.Size = new System.Drawing.Size(69, 13);
            studioNameLabel.TabIndex = 14;
            studioNameLabel.Text = "studio Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(318, 105);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 17;
            label1.Text = "Server:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(112, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 13);
            label3.TabIndex = 20;
            label3.Text = "name:";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.usersDataGridView.DataSource = this.userViewBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(6, 19);
            this.usersDataGridView.MultiSelect = false;
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(343, 220);
            this.usersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn1.HeaderText = "Login";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "role";
            this.dataGridViewTextBoxColumn3.HeaderText = "Role";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // userViewBindingSource
            // 
            this.userViewBindingSource.DataMember = "UserView";
            this.userViewBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesDataGridView
            // 
            this.gamesDataGridView.AllowUserToAddRows = false;
            this.gamesDataGridView.AllowUserToDeleteRows = false;
            this.gamesDataGridView.AutoGenerateColumns = false;
            this.gamesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pictureDataDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.studioNameDataGridViewTextBoxColumn,
            this.location});
            this.gamesDataGridView.DataSource = this.gamesViewBindingSource;
            this.gamesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.gamesDataGridView.MultiSelect = false;
            this.gamesDataGridView.Name = "gamesDataGridView";
            this.gamesDataGridView.ReadOnly = true;
            this.gamesDataGridView.RowTemplate.Height = 50;
            this.gamesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gamesDataGridView.Size = new System.Drawing.Size(498, 220);
            this.gamesDataGridView.TabIndex = 0;
            // 
            // gamesViewBindingSource
            // 
            this.gamesViewBindingSource.DataMember = "GamesView";
            this.gamesViewBindingSource.DataSource = this.dataSet;
            // 
            // groupBox_Users
            // 
            this.groupBox_Users.Controls.Add(this.button_Library);
            this.groupBox_Users.Controls.Add(this.button_Exit);
            this.groupBox_Users.Controls.Add(this.groupBox2);
            this.groupBox_Users.Controls.Add(this.groupBox1);
            this.groupBox_Users.Controls.Add(this.usersDataGridView);
            this.groupBox_Users.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Users.Name = "groupBox_Users";
            this.groupBox_Users.Size = new System.Drawing.Size(357, 493);
            this.groupBox_Users.TabIndex = 1;
            this.groupBox_Users.TabStop = false;
            this.groupBox_Users.Text = "Users";
            // 
            // button_Library
            // 
            this.button_Library.Location = new System.Drawing.Point(98, 435);
            this.button_Library.Name = "button_Library";
            this.button_Library.Size = new System.Drawing.Size(75, 23);
            this.button_Library.TabIndex = 12;
            this.button_Library.Text = "Library";
            this.button_Library.UseVisualStyleBackColor = true;
            this.button_Library.Click += new System.EventHandler(this.button_Library_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(7, 435);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 11;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.button_);
            this.groupBox2.Controls.Add(this.textBox_Delete);
            this.groupBox2.Location = new System.Drawing.Point(7, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 55);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete user";
            // 
            // button_
            // 
            this.button_.Location = new System.Drawing.Point(64, 17);
            this.button_.Name = "button_";
            this.button_.Size = new System.Drawing.Size(75, 23);
            this.button_.TabIndex = 6;
            this.button_.Text = "Delete";
            this.button_.UseVisualStyleBackColor = true;
            this.button_.Click += new System.EventHandler(this.button__Click);
            // 
            // textBox_Delete
            // 
            this.textBox_Delete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userViewBindingSource, "login", true));
            this.textBox_Delete.Location = new System.Drawing.Point(214, 19);
            this.textBox_Delete.Name = "textBox_Delete";
            this.textBox_Delete.ReadOnly = true;
            this.textBox_Delete.Size = new System.Drawing.Size(114, 20);
            this.textBox_Delete.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_RoleUpdate);
            this.groupBox1.Controls.Add(loginLabel);
            this.groupBox1.Controls.Add(this.loginTextBox_Update);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(roleLabel);
            this.groupBox1.Controls.Add(this.passwordTextBox_Update);
            this.groupBox1.Controls.Add(this.button_UsUp);
            this.groupBox1.Location = new System.Drawing.Point(6, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 113);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update user";
            // 
            // comboBox_RoleUpdate
            // 
            this.comboBox_RoleUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userViewBindingSource, "role", true));
            this.comboBox_RoleUpdate.DataSource = this.rolesBindingSource;
            this.comboBox_RoleUpdate.DisplayMember = "role";
            this.comboBox_RoleUpdate.FormattingEnabled = true;
            this.comboBox_RoleUpdate.Location = new System.Drawing.Point(213, 71);
            this.comboBox_RoleUpdate.Name = "comboBox_RoleUpdate";
            this.comboBox_RoleUpdate.Size = new System.Drawing.Size(116, 21);
            this.comboBox_RoleUpdate.TabIndex = 6;
            this.comboBox_RoleUpdate.ValueMember = "id";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.dataSet;
            // 
            // loginTextBox_Update
            // 
            this.loginTextBox_Update.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userViewBindingSource, "login", true));
            this.loginTextBox_Update.Location = new System.Drawing.Point(213, 19);
            this.loginTextBox_Update.Name = "loginTextBox_Update";
            this.loginTextBox_Update.ReadOnly = true;
            this.loginTextBox_Update.Size = new System.Drawing.Size(116, 20);
            this.loginTextBox_Update.TabIndex = 2;
            // 
            // passwordTextBox_Update
            // 
            this.passwordTextBox_Update.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userViewBindingSource, "password", true));
            this.passwordTextBox_Update.Location = new System.Drawing.Point(213, 45);
            this.passwordTextBox_Update.Name = "passwordTextBox_Update";
            this.passwordTextBox_Update.Size = new System.Drawing.Size(116, 20);
            this.passwordTextBox_Update.TabIndex = 4;
            // 
            // button_UsUp
            // 
            this.button_UsUp.Location = new System.Drawing.Point(65, 17);
            this.button_UsUp.Name = "button_UsUp";
            this.button_UsUp.Size = new System.Drawing.Size(75, 23);
            this.button_UsUp.TabIndex = 1;
            this.button_UsUp.Text = "Change";
            this.button_UsUp.UseVisualStyleBackColor = true;
            this.button_UsUp.Click += new System.EventHandler(this.button_UsUp_Password_Click);
            // 
            // groupBox_games
            // 
            this.groupBox_games.Controls.Add(this.button_AddGame);
            this.groupBox_games.Controls.Add(this.groupBox4);
            this.groupBox_games.Controls.Add(this.groupBox3);
            this.groupBox_games.Controls.Add(this.gamesDataGridView);
            this.groupBox_games.Location = new System.Drawing.Point(375, 12);
            this.groupBox_games.Name = "groupBox_games";
            this.groupBox_games.Size = new System.Drawing.Size(510, 493);
            this.groupBox_games.TabIndex = 2;
            this.groupBox_games.TabStop = false;
            this.groupBox_games.Text = "Games";
            // 
            // button_AddGame
            // 
            this.button_AddGame.Location = new System.Drawing.Point(20, 464);
            this.button_AddGame.Name = "button_AddGame";
            this.button_AddGame.Size = new System.Drawing.Size(75, 23);
            this.button_AddGame.TabIndex = 5;
            this.button_AddGame.Text = "Add game";
            this.button_AddGame.UseVisualStyleBackColor = true;
            this.button_AddGame.Click += new System.EventHandler(this.button_AddGame_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(label3);
            this.groupBox4.Controls.Add(this.button_Ga_Delete);
            this.groupBox4.Controls.Add(this.textBox_DeleteGame);
            this.groupBox4.Location = new System.Drawing.Point(7, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 55);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete game";
            // 
            // button_Ga_Delete
            // 
            this.button_Ga_Delete.Location = new System.Drawing.Point(14, 19);
            this.button_Ga_Delete.Name = "button_Ga_Delete";
            this.button_Ga_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Ga_Delete.TabIndex = 6;
            this.button_Ga_Delete.Text = "Delete";
            this.button_Ga_Delete.UseVisualStyleBackColor = true;
            this.button_Ga_Delete.Click += new System.EventHandler(this.button_Ga_Delete_Click);
            // 
            // textBox_DeleteGame
            // 
            this.textBox_DeleteGame.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesViewBindingSource, "name", true));
            this.textBox_DeleteGame.Location = new System.Drawing.Point(154, 22);
            this.textBox_DeleteGame.Name = "textBox_DeleteGame";
            this.textBox_DeleteGame.ReadOnly = true;
            this.textBox_DeleteGame.Size = new System.Drawing.Size(100, 20);
            this.textBox_DeleteGame.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_ChangePlacemark);
            this.groupBox3.Controls.Add(this.numericUpDown_Price);
            this.groupBox3.Controls.Add(this.comboBox_Server);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(this.button_SelectImage);
            this.groupBox3.Controls.Add(this.comboBox_GameStudio);
            this.groupBox3.Controls.Add(pictureDataLabel);
            this.groupBox3.Controls.Add(this.pictureDataPictureBox);
            this.groupBox3.Controls.Add(nameLabel);
            this.groupBox3.Controls.Add(this.nameTextBox);
            this.groupBox3.Controls.Add(priceLabel);
            this.groupBox3.Controls.Add(studioNameLabel);
            this.groupBox3.Controls.Add(this.button_GaUp);
            this.groupBox3.Location = new System.Drawing.Point(6, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 133);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update game";
            // 
            // button_ChangePlacemark
            // 
            this.button_ChangePlacemark.Location = new System.Drawing.Point(14, 77);
            this.button_ChangePlacemark.Name = "button_ChangePlacemark";
            this.button_ChangePlacemark.Size = new System.Drawing.Size(107, 23);
            this.button_ChangePlacemark.TabIndex = 21;
            this.button_ChangePlacemark.Text = "Change placemark";
            this.button_ChangePlacemark.UseVisualStyleBackColor = true;
            this.button_ChangePlacemark.Click += new System.EventHandler(this.button_ChangePlacemark_Click);
            // 
            // numericUpDown_Price
            // 
            this.numericUpDown_Price.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gamesViewBindingSource, "Price", true));
            this.numericUpDown_Price.DecimalPlaces = 2;
            this.numericUpDown_Price.InterceptArrowKeys = false;
            this.numericUpDown_Price.Location = new System.Drawing.Point(393, 45);
            this.numericUpDown_Price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Price.Name = "numericUpDown_Price";
            this.numericUpDown_Price.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_Price.TabIndex = 19;
            // 
            // comboBox_Server
            // 
            this.comboBox_Server.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesViewBindingSource, "location", true));
            this.comboBox_Server.DataSource = this.serversBindingSource;
            this.comboBox_Server.DisplayMember = "location";
            this.comboBox_Server.FormattingEnabled = true;
            this.comboBox_Server.Location = new System.Drawing.Point(392, 102);
            this.comboBox_Server.Name = "comboBox_Server";
            this.comboBox_Server.Size = new System.Drawing.Size(99, 21);
            this.comboBox_Server.TabIndex = 18;
            this.comboBox_Server.ValueMember = "id";
            // 
            // serversBindingSource
            // 
            this.serversBindingSource.DataMember = "servers";
            this.serversBindingSource.DataSource = this.dataSet;
            // 
            // button_SelectImage
            // 
            this.button_SelectImage.Location = new System.Drawing.Point(14, 48);
            this.button_SelectImage.Name = "button_SelectImage";
            this.button_SelectImage.Size = new System.Drawing.Size(108, 23);
            this.button_SelectImage.TabIndex = 16;
            this.button_SelectImage.Text = "Select image";
            this.button_SelectImage.UseVisualStyleBackColor = true;
            this.button_SelectImage.Click += new System.EventHandler(this.button_SelectImage_Click);
            // 
            // comboBox_GameStudio
            // 
            this.comboBox_GameStudio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesViewBindingSource, "studioName", true));
            this.comboBox_GameStudio.DataSource = this.gameStudiosBindingSource;
            this.comboBox_GameStudio.DisplayMember = "studioName";
            this.comboBox_GameStudio.FormattingEnabled = true;
            this.comboBox_GameStudio.Location = new System.Drawing.Point(393, 74);
            this.comboBox_GameStudio.Name = "comboBox_GameStudio";
            this.comboBox_GameStudio.Size = new System.Drawing.Size(99, 21);
            this.comboBox_GameStudio.TabIndex = 15;
            this.comboBox_GameStudio.ValueMember = "id";
            // 
            // gameStudiosBindingSource
            // 
            this.gameStudiosBindingSource.DataMember = "gameStudios";
            this.gameStudiosBindingSource.DataSource = this.dataSet;
            // 
            // pictureDataPictureBox
            // 
            this.pictureDataPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.gamesViewBindingSource, "PictureData", true));
            this.pictureDataPictureBox.Location = new System.Drawing.Point(172, 19);
            this.pictureDataPictureBox.Name = "pictureDataPictureBox";
            this.pictureDataPictureBox.Size = new System.Drawing.Size(139, 99);
            this.pictureDataPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDataPictureBox.TabIndex = 9;
            this.pictureDataPictureBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesViewBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(392, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // button_GaUp
            // 
            this.button_GaUp.Location = new System.Drawing.Point(14, 19);
            this.button_GaUp.Name = "button_GaUp";
            this.button_GaUp.Size = new System.Drawing.Size(108, 23);
            this.button_GaUp.TabIndex = 8;
            this.button_GaUp.Text = "Change";
            this.button_GaUp.UseVisualStyleBackColor = true;
            this.button_GaUp.Click += new System.EventHandler(this.button_GaUp_Studio_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // userViewTableAdapter
            // 
            this.userViewTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // gamesViewTableAdapter
            // 
            this.gamesViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.game_placemarkTableAdapter = null;
            this.tableAdapterManager.gamesTableAdapter = null;
            this.tableAdapterManager.gameStudiosTableAdapter = this.gameStudiosTableAdapter;
            this.tableAdapterManager.PicturesTableAdapter = null;
            this.tableAdapterManager.placemarksTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager.serversTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gameMarket.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_gameTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter1;
            // 
            // gameStudiosTableAdapter
            // 
            this.gameStudiosTableAdapter.ClearBeforeFill = true;
            // 
            // gamesTableAdapter1
            // 
            this.gamesTableAdapter1.ClearBeforeFill = true;
            // 
            // picturesTableAdapter1
            // 
            this.picturesTableAdapter1.ClearBeforeFill = true;
            // 
            // serversTableAdapter
            // 
            this.serversTableAdapter.ClearBeforeFill = true;
            // 
            // pictureDataDataGridViewImageColumn
            // 
            this.pictureDataDataGridViewImageColumn.DataPropertyName = "PictureData";
            this.pictureDataDataGridViewImageColumn.HeaderText = "Logo";
            this.pictureDataDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pictureDataDataGridViewImageColumn.Name = "pictureDataDataGridViewImageColumn";
            this.pictureDataDataGridViewImageColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studioNameDataGridViewTextBoxColumn
            // 
            this.studioNameDataGridViewTextBoxColumn.DataPropertyName = "studioName";
            this.studioNameDataGridViewTextBoxColumn.HeaderText = "studioName";
            this.studioNameDataGridViewTextBoxColumn.Name = "studioNameDataGridViewTextBoxColumn";
            this.studioNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "Server";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 517);
            this.Controls.Add(this.groupBox_games);
            this.Controls.Add(this.groupBox_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Admin";
            this.Text = "Form_Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Admin_FormClosing_1);
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesViewBindingSource)).EndInit();
            this.groupBox_Users.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.groupBox_games.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStudiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridView gamesDataGridView;
        private System.Windows.Forms.GroupBox groupBox_Users;
        private System.Windows.Forms.Button button_UsUp;
        private System.Windows.Forms.GroupBox groupBox_games;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Ga_Delete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_GaUp;
        private System.Windows.Forms.Button button_AddGame;
        private System.Windows.Forms.Button button_Library;
        private System.Windows.Forms.Button button_Exit;
        //private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_Delete;
        private System.Windows.Forms.TextBox loginTextBox_Update;
        private System.Windows.Forms.TextBox passwordTextBox_Update;
        private System.Windows.Forms.ComboBox comboBox_RoleUpdate;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource userViewBindingSource;
        private DataSetTableAdapters.UserViewTableAdapter userViewTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private DataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private DataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource gamesViewBindingSource;
        private DataSetTableAdapters.GamesViewTableAdapter gamesViewTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_GameStudio;
        private System.Windows.Forms.PictureBox pictureDataPictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetTableAdapters.gameStudiosTableAdapter gameStudiosTableAdapter;
        private System.Windows.Forms.BindingSource gameStudiosBindingSource;
        private System.Windows.Forms.Button button_SelectImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DataSetTableAdapters.gamesTableAdapter gamesTableAdapter1;
        private DataSetTableAdapters.PicturesTableAdapter picturesTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox_Server;
        private System.Windows.Forms.BindingSource serversBindingSource;
        private DataSetTableAdapters.serversTableAdapter serversTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown_Price;
        private System.Windows.Forms.TextBox textBox_DeleteGame;
        private System.Windows.Forms.Button button_ChangePlacemark;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studioNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
    }
}