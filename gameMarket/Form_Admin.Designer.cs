
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
            System.Windows.Forms.Label roleIdLabel;
            System.Windows.Forms.Label loginLabel1;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label gameStudioIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label label1;
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new gameMarket.DataSet();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersTableAdapter = new gameMarket.DataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new gameMarket.DataSetTableAdapters.TableAdapterManager();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new gameMarket.DataSetTableAdapters.gamesTableAdapter();
            this.game_placemarkTableAdapter1 = new gameMarket.DataSetTableAdapters.game_placemarkTableAdapter();
            this.gamesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Users = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_ = new System.Windows.Forms.Button();
            this.loginTextBox_Delete = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_UsUp_Password = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.groupBox_games = new System.Windows.Forms.GroupBox();
            this.button_AddGame = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Ga_Delete = new System.Windows.Forms.Button();
            this.nameTextBox1_Delete = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_Studio = new System.Windows.Forms.ComboBox();
            this.gameStudiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Server = new System.Windows.Forms.ComboBox();
            this.serversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_GaUp_Studio = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.rolesTableAdapter = new gameMarket.DataSetTableAdapters.rolesTableAdapter();
            this.serversTableAdapter = new gameMarket.DataSetTableAdapters.serversTableAdapter();
            this.gameStudiosTableAdapter = new gameMarket.DataSetTableAdapters.gameStudiosTableAdapter();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            roleIdLabel = new System.Windows.Forms.Label();
            loginLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            gameStudioIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).BeginInit();
            this.groupBox_Users.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.groupBox_games.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameStudiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(146, 22);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(32, 13);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(146, 48);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "password:";
            // 
            // roleIdLabel
            // 
            roleIdLabel.AutoSize = true;
            roleIdLabel.Location = new System.Drawing.Point(146, 74);
            roleIdLabel.Name = "roleIdLabel";
            roleIdLabel.Size = new System.Drawing.Size(39, 13);
            roleIdLabel.TabIndex = 7;
            roleIdLabel.Text = "role Id:";
            // 
            // loginLabel1
            // 
            loginLabel1.AutoSize = true;
            loginLabel1.Location = new System.Drawing.Point(145, 22);
            loginLabel1.Name = "loginLabel1";
            loginLabel1.Size = new System.Drawing.Size(32, 13);
            loginLabel1.TabIndex = 0;
            loginLabel1.Text = "login:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(103, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "id:";
            // 
            // gameStudioIdLabel
            // 
            gameStudioIdLabel.AutoSize = true;
            gameStudioIdLabel.Location = new System.Drawing.Point(103, 48);
            gameStudioIdLabel.Name = "gameStudioIdLabel";
            gameStudioIdLabel.Size = new System.Drawing.Size(81, 13);
            gameStudioIdLabel.TabIndex = 2;
            gameStudioIdLabel.Text = "game Studio Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(103, 74);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "name:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(95, 24);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(36, 13);
            nameLabel1.TabIndex = 4;
            nameLabel1.Text = "name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(103, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 13);
            label1.TabIndex = 11;
            label1.Text = "server:";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.usersDataGridView.DataSource = this.usersBindingSource;
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
            this.dataGridViewTextBoxColumn1.HeaderText = "login";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn2.HeaderText = "password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "roleId";
            this.dataGridViewTextBoxColumn3.HeaderText = "roleId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.game_placemarkTableAdapter = null;
            this.tableAdapterManager.gamesTableAdapter = null;
            this.tableAdapterManager.gameStudiosTableAdapter = null;
            this.tableAdapterManager.PicturesTableAdapter = null;
            this.tableAdapterManager.placemarksTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.serversTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gameMarket.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_gameTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
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
            // game_placemarkTableAdapter1
            // 
            this.game_placemarkTableAdapter1.ClearBeforeFill = true;
            // 
            // gamesDataGridView
            // 
            this.gamesDataGridView.AllowUserToAddRows = false;
            this.gamesDataGridView.AllowUserToDeleteRows = false;
            this.gamesDataGridView.AutoGenerateColumns = false;
            this.gamesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gamesDataGridView.DataSource = this.gamesBindingSource;
            this.gamesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.gamesDataGridView.MultiSelect = false;
            this.gamesDataGridView.Name = "gamesDataGridView";
            this.gamesDataGridView.ReadOnly = true;
            this.gamesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gamesDataGridView.Size = new System.Drawing.Size(443, 220);
            this.gamesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gameStudioId";
            this.dataGridViewTextBoxColumn5.HeaderText = "gameStudioId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "serverId";
            this.dataGridViewTextBoxColumn7.HeaderText = "serverId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // groupBox_Users
            // 
            this.groupBox_Users.Controls.Add(this.button2);
            this.groupBox_Users.Controls.Add(this.button_Exit);
            this.groupBox_Users.Controls.Add(this.groupBox2);
            this.groupBox_Users.Controls.Add(this.groupBox1);
            this.groupBox_Users.Controls.Add(this.usersDataGridView);
            this.groupBox_Users.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Users.Name = "groupBox_Users";
            this.groupBox_Users.Size = new System.Drawing.Size(357, 467);
            this.groupBox_Users.TabIndex = 1;
            this.groupBox_Users.TabStop = false;
            this.groupBox_Users.Text = "Users";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_);
            this.groupBox2.Controls.Add(loginLabel1);
            this.groupBox2.Controls.Add(this.loginTextBox_Delete);
            this.groupBox2.Location = new System.Drawing.Point(7, 348);
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
            // loginTextBox_Delete
            // 
            this.loginTextBox_Delete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "login", true));
            this.loginTextBox_Delete.Location = new System.Drawing.Point(206, 19);
            this.loginTextBox_Delete.Name = "loginTextBox_Delete";
            this.loginTextBox_Delete.ReadOnly = true;
            this.loginTextBox_Delete.Size = new System.Drawing.Size(130, 20);
            this.loginTextBox_Delete.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.comboBox_Role);
            this.groupBox1.Controls.Add(this.button_UsUp_Password);
            this.groupBox1.Controls.Add(loginLabel);
            this.groupBox1.Controls.Add(this.loginTextBox);
            this.groupBox1.Controls.Add(roleIdLabel);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 97);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update user";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(207, 45);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(130, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.DataSource = this.rolesBindingSource;
            this.comboBox_Role.DisplayMember = "role";
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Location = new System.Drawing.Point(207, 69);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(130, 21);
            this.comboBox_Role.TabIndex = 8;
            this.comboBox_Role.ValueMember = "id";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.dataSet;
            // 
            // button_UsUp_Password
            // 
            this.button_UsUp_Password.Location = new System.Drawing.Point(65, 17);
            this.button_UsUp_Password.Name = "button_UsUp_Password";
            this.button_UsUp_Password.Size = new System.Drawing.Size(75, 23);
            this.button_UsUp_Password.TabIndex = 1;
            this.button_UsUp_Password.Text = "Change";
            this.button_UsUp_Password.UseVisualStyleBackColor = true;
            this.button_UsUp_Password.Click += new System.EventHandler(this.button_UsUp_Password_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(207, 19);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.ReadOnly = true;
            this.loginTextBox.Size = new System.Drawing.Size(130, 20);
            this.loginTextBox.TabIndex = 4;
            // 
            // groupBox_games
            // 
            this.groupBox_games.Controls.Add(this.button_AddGame);
            this.groupBox_games.Controls.Add(this.groupBox4);
            this.groupBox_games.Controls.Add(this.groupBox3);
            this.groupBox_games.Controls.Add(this.gamesDataGridView);
            this.groupBox_games.Location = new System.Drawing.Point(375, 12);
            this.groupBox_games.Name = "groupBox_games";
            this.groupBox_games.Size = new System.Drawing.Size(455, 467);
            this.groupBox_games.TabIndex = 2;
            this.groupBox_games.TabStop = false;
            this.groupBox_games.Text = "Games";
            // 
            // button_AddGame
            // 
            this.button_AddGame.Location = new System.Drawing.Point(20, 435);
            this.button_AddGame.Name = "button_AddGame";
            this.button_AddGame.Size = new System.Drawing.Size(75, 23);
            this.button_AddGame.TabIndex = 5;
            this.button_AddGame.Text = "Add game";
            this.button_AddGame.UseVisualStyleBackColor = true;
            this.button_AddGame.Click += new System.EventHandler(this.button_AddGame_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_Ga_Delete);
            this.groupBox4.Controls.Add(nameLabel1);
            this.groupBox4.Controls.Add(this.nameTextBox1_Delete);
            this.groupBox4.Location = new System.Drawing.Point(6, 374);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 55);
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
            this.button_Ga_Delete.Text = "delete";
            this.button_Ga_Delete.UseVisualStyleBackColor = true;
            this.button_Ga_Delete.Click += new System.EventHandler(this.button_Ga_Delete_Click);
            // 
            // nameTextBox1_Delete
            // 
            this.nameTextBox1_Delete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "name", true));
            this.nameTextBox1_Delete.Location = new System.Drawing.Point(182, 21);
            this.nameTextBox1_Delete.Name = "nameTextBox1_Delete";
            this.nameTextBox1_Delete.ReadOnly = true;
            this.nameTextBox1_Delete.Size = new System.Drawing.Size(130, 20);
            this.nameTextBox1_Delete.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_Studio);
            this.groupBox3.Controls.Add(this.comboBox_Server);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(this.button_GaUp_Studio);
            this.groupBox3.Controls.Add(idLabel);
            this.groupBox3.Controls.Add(this.idTextBox);
            this.groupBox3.Controls.Add(this.nameTextBox);
            this.groupBox3.Controls.Add(gameStudioIdLabel);
            this.groupBox3.Controls.Add(nameLabel);
            this.groupBox3.Location = new System.Drawing.Point(6, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 123);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update game";
            // 
            // comboBox_Studio
            // 
            this.comboBox_Studio.DataSource = this.gameStudiosBindingSource;
            this.comboBox_Studio.DisplayMember = "studioName";
            this.comboBox_Studio.FormattingEnabled = true;
            this.comboBox_Studio.Location = new System.Drawing.Point(190, 45);
            this.comboBox_Studio.Name = "comboBox_Studio";
            this.comboBox_Studio.Size = new System.Drawing.Size(130, 21);
            this.comboBox_Studio.TabIndex = 13;
            this.comboBox_Studio.ValueMember = "id";
            // 
            // gameStudiosBindingSource
            // 
            this.gameStudiosBindingSource.DataMember = "gameStudios";
            this.gameStudiosBindingSource.DataSource = this.dataSet;
            // 
            // comboBox_Server
            // 
            this.comboBox_Server.DataSource = this.serversBindingSource;
            this.comboBox_Server.DisplayMember = "id";
            this.comboBox_Server.FormattingEnabled = true;
            this.comboBox_Server.Location = new System.Drawing.Point(190, 97);
            this.comboBox_Server.Name = "comboBox_Server";
            this.comboBox_Server.Size = new System.Drawing.Size(130, 21);
            this.comboBox_Server.TabIndex = 12;
            this.comboBox_Server.ValueMember = "id";
            // 
            // serversBindingSource
            // 
            this.serversBindingSource.DataMember = "servers";
            this.serversBindingSource.DataSource = this.dataSet;
            // 
            // button_GaUp_Studio
            // 
            this.button_GaUp_Studio.Location = new System.Drawing.Point(14, 17);
            this.button_GaUp_Studio.Name = "button_GaUp_Studio";
            this.button_GaUp_Studio.Size = new System.Drawing.Size(75, 23);
            this.button_GaUp_Studio.TabIndex = 8;
            this.button_GaUp_Studio.Text = "Change";
            this.button_GaUp_Studio.UseVisualStyleBackColor = true;
            this.button_GaUp_Studio.Click += new System.EventHandler(this.button_GaUp_Studio_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(190, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(130, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(190, 71);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(130, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // serversTableAdapter
            // 
            this.serversTableAdapter.ClearBeforeFill = true;
            // 
            // gameStudiosTableAdapter
            // 
            this.gameStudiosTableAdapter.ClearBeforeFill = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(25, 435);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 11;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 484);
            this.Controls.Add(this.groupBox_games);
            this.Controls.Add(this.groupBox_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Admin";
            this.Text = "Form_Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Admin_FormClosing);
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gameStudiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private DataSetTableAdapters.gamesTableAdapter gamesTableAdapter;
        private DataSetTableAdapters.game_placemarkTableAdapter game_placemarkTableAdapter1;
        private System.Windows.Forms.DataGridView gamesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox_Users;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button_UsUp_Password;
        private System.Windows.Forms.GroupBox groupBox_games;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private DataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_;
        private System.Windows.Forms.TextBox loginTextBox_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Ga_Delete;
        private System.Windows.Forms.TextBox nameTextBox1_Delete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_GaUp_Studio;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button_AddGame;
        private System.Windows.Forms.ComboBox comboBox_Server;
        private System.Windows.Forms.BindingSource serversBindingSource;
        private DataSetTableAdapters.serversTableAdapter serversTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_Studio;
        private System.Windows.Forms.BindingSource gameStudiosBindingSource;
        private DataSetTableAdapters.gameStudiosTableAdapter gameStudiosTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Exit;
    }
}