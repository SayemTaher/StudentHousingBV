namespace Student_Housing
{
    partial class AdminPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbtxtAdminAccountCreation = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnCreateAdminAccount = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.confirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.lblSetPassword = new System.Windows.Forms.Label();
            this.createPasswordTextBox = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastNameGB = new System.Windows.Forms.TextBox();
            this.emailInputTextbox = new System.Windows.Forms.TextBox();
            this.txtFirstNameGB = new System.Windows.Forms.TextBox();
            this.tbNameProperty = new System.Windows.Forms.TextBox();
            this.tbLocationProperty = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.lbCreateProperty = new System.Windows.Forms.Label();
            this.dgvProperties = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtxtAdminAccountCreation
            // 
            this.lbtxtAdminAccountCreation.AutoSize = true;
            this.lbtxtAdminAccountCreation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbtxtAdminAccountCreation.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtxtAdminAccountCreation.ForeColor = System.Drawing.Color.White;
            this.lbtxtAdminAccountCreation.Location = new System.Drawing.Point(68, 89);
            this.lbtxtAdminAccountCreation.Name = "lbtxtAdminAccountCreation";
            this.lbtxtAdminAccountCreation.Size = new System.Drawing.Size(460, 48);
            this.lbtxtAdminAccountCreation.TabIndex = 24;
            this.lbtxtAdminAccountCreation.Text = "Create Admin Account";
            // 
            // dgvStudents
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvStudents.Location = new System.Drawing.Point(824, 107);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowHeadersWidth = 92;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudents.RowTemplate.Height = 45;
            this.dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1203, 600);
            this.dgvStudents.TabIndex = 25;
            // 
            // btnCreateAdminAccount
            // 
            this.btnCreateAdminAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCreateAdminAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAdminAccount.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateAdminAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCreateAdminAccount.Location = new System.Drawing.Point(68, 745);
            this.btnCreateAdminAccount.Name = "btnCreateAdminAccount";
            this.btnCreateAdminAccount.Size = new System.Drawing.Size(170, 60);
            this.btnCreateAdminAccount.TabIndex = 38;
            this.btnCreateAdminAccount.Text = "Create";
            this.btnCreateAdminAccount.UseVisualStyleBackColor = false;
            this.btnCreateAdminAccount.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(68, 614);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(305, 39);
            this.lblConfirmPassword.TabIndex = 31;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblLastName.Location = new System.Drawing.Point(68, 272);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(179, 39);
            this.lblLastName.TabIndex = 37;
            this.lblLastName.Text = "Last Name";
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.confirmPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextbox.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordTextbox.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(68, 667);
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(350, 40);
            this.confirmPasswordTextbox.TabIndex = 30;
            this.confirmPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // lblSetPassword
            // 
            this.lblSetPassword.AutoSize = true;
            this.lblSetPassword.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblSetPassword.Location = new System.Drawing.Point(68, 501);
            this.lblSetPassword.Name = "lblSetPassword";
            this.lblSetPassword.Size = new System.Drawing.Size(287, 39);
            this.lblSetPassword.TabIndex = 32;
            this.lblSetPassword.Text = "Create Password";
            // 
            // createPasswordTextBox
            // 
            this.createPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.createPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createPasswordTextBox.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.createPasswordTextBox.Location = new System.Drawing.Point(68, 557);
            this.createPasswordTextBox.Name = "createPasswordTextBox";
            this.createPasswordTextBox.Size = new System.Drawing.Size(350, 40);
            this.createPasswordTextBox.TabIndex = 29;
            this.createPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblEmail.Location = new System.Drawing.Point(68, 390);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(269, 39);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblFirstName.Location = new System.Drawing.Point(68, 172);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(197, 39);
            this.lblFirstName.TabIndex = 35;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastNameGB
            // 
            this.txtLastNameGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtLastNameGB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastNameGB.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastNameGB.ForeColor = System.Drawing.Color.White;
            this.txtLastNameGB.Location = new System.Drawing.Point(68, 325);
            this.txtLastNameGB.Name = "txtLastNameGB";
            this.txtLastNameGB.Size = new System.Drawing.Size(350, 40);
            this.txtLastNameGB.TabIndex = 26;
            // 
            // emailInputTextbox
            // 
            this.emailInputTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.emailInputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailInputTextbox.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailInputTextbox.ForeColor = System.Drawing.Color.White;
            this.emailInputTextbox.Location = new System.Drawing.Point(68, 443);
            this.emailInputTextbox.Name = "emailInputTextbox";
            this.emailInputTextbox.Size = new System.Drawing.Size(500, 40);
            this.emailInputTextbox.TabIndex = 28;
            // 
            // txtFirstNameGB
            // 
            this.txtFirstNameGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtFirstNameGB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstNameGB.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstNameGB.ForeColor = System.Drawing.Color.White;
            this.txtFirstNameGB.Location = new System.Drawing.Point(68, 214);
            this.txtFirstNameGB.Name = "txtFirstNameGB";
            this.txtFirstNameGB.Size = new System.Drawing.Size(350, 40);
            this.txtFirstNameGB.TabIndex = 27;
            // 
            // tbNameProperty
            // 
            this.tbNameProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbNameProperty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNameProperty.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNameProperty.ForeColor = System.Drawing.Color.White;
            this.tbNameProperty.Location = new System.Drawing.Point(68, 973);
            this.tbNameProperty.Name = "tbNameProperty";
            this.tbNameProperty.Size = new System.Drawing.Size(350, 40);
            this.tbNameProperty.TabIndex = 39;
            // 
            // tbLocationProperty
            // 
            this.tbLocationProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbLocationProperty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLocationProperty.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLocationProperty.ForeColor = System.Drawing.Color.White;
            this.tbLocationProperty.Location = new System.Drawing.Point(68, 1069);
            this.tbLocationProperty.Name = "tbLocationProperty";
            this.tbLocationProperty.Size = new System.Drawing.Size(350, 40);
            this.tbLocationProperty.TabIndex = 40;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lbName.Location = new System.Drawing.Point(68, 931);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(89, 39);
            this.lbName.TabIndex = 41;
            this.lbName.Text = "Name";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lbLocation.Location = new System.Drawing.Point(68, 1027);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(161, 39);
            this.lbLocation.TabIndex = 42;
            this.lbLocation.Text = "Location";
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProperty.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddProperty.Location = new System.Drawing.Point(68, 1148);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(114, 60);
            this.btnAddProperty.TabIndex = 43;
            this.btnAddProperty.Text = "Add";
            this.btnAddProperty.UseVisualStyleBackColor = false;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // lbCreateProperty
            // 
            this.lbCreateProperty.AutoSize = true;
            this.lbCreateProperty.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbCreateProperty.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCreateProperty.ForeColor = System.Drawing.Color.White;
            this.lbCreateProperty.Location = new System.Drawing.Point(68, 864);
            this.lbCreateProperty.Name = "lbCreateProperty";
            this.lbCreateProperty.Size = new System.Drawing.Size(350, 48);
            this.lbCreateProperty.TabIndex = 44;
            this.lbCreateProperty.Text = "Create Property";
            // 
            // dgvProperties
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProperties.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProperties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProperties.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProperties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProperties.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProperties.EnableHeadersVisualStyles = false;
            this.dgvProperties.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvProperties.Location = new System.Drawing.Point(824, 814);
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.RowHeadersVisible = false;
            this.dgvProperties.RowHeadersWidth = 92;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProperties.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProperties.RowTemplate.Height = 45;
            this.dgvProperties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProperties.Size = new System.Drawing.Size(694, 497);
            this.dgvProperties.TabIndex = 45;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(2249, 1450);
            this.Controls.Add(this.dgvProperties);
            this.Controls.Add(this.lbCreateProperty);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbLocationProperty);
            this.Controls.Add(this.tbNameProperty);
            this.Controls.Add(this.btnCreateAdminAccount);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.confirmPasswordTextbox);
            this.Controls.Add(this.lblSetPassword);
            this.Controls.Add(this.createPasswordTextBox);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastNameGB);
            this.Controls.Add(this.emailInputTextbox);
            this.Controls.Add(this.txtFirstNameGB);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lbtxtAdminAccountCreation);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbtxtAdminAccountCreation;
        private DataGridView dgvStudents;
        private Button btnCreateAdminAccount;
        private Label lblConfirmPassword;
        private Label lblLastName;
        private TextBox confirmPasswordTextbox;
        private Label lblSetPassword;
        private TextBox createPasswordTextBox;
        private Label lblEmail;
        private Label lblFirstName;
        private TextBox txtLastNameGB;
        private TextBox emailInputTextbox;
        private TextBox txtFirstNameGB;
        private TextBox tbNameProperty;
        private TextBox tbLocationProperty;
        private Label lbName;
        private Label lbLocation;
        private Button btnAddProperty;
        private Label lbCreateProperty;
        private DataGridView dgvProperties;
    }
}