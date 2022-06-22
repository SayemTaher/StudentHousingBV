namespace Student_Housing
{
    partial class HomePage
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
            this.btnHome = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHouseApplience = new System.Windows.Forms.Button();
            this.panelHouseApplience = new System.Windows.Forms.Panel();
            this.lblHousingRules = new System.Windows.Forms.Label();
            this.rtbHousingRules = new System.Windows.Forms.RichTextBox();
            this.lblCreateEvent = new System.Windows.Forms.Label();
            this.dtpEnddate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartdate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.tbNameOfEvent = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblNameOfEvent = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblUpcomingTask = new System.Windows.Forms.Label();
            this.listBoxUpcomingTasks = new System.Windows.Forms.ListBox();
            this.lblVerificationOfNameOfEvent = new System.Windows.Forms.Label();
            this.lblVerifitationOfDecriptionForCreateAnEvent = new System.Windows.Forms.Label();
            this.listViewStudentsEvents = new System.Windows.Forms.ListView();
            this.IndexOfObject = new System.Windows.Forms.ColumnHeader();
            this.NameOfEvent = new System.Windows.Forms.ColumnHeader();
            this.Student = new System.Windows.Forms.ColumnHeader();
            this.StartDate = new System.Windows.Forms.ColumnHeader();
            this.EndDate = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.lblYourEvents = new System.Windows.Forms.Label();
            this.listViewAllEvents = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.panelHouseApplience.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnHome.Location = new System.Drawing.Point(0, 103);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(99)))), ((int)(((byte)(127)))));
            this.SidePanel.Controls.Add(this.btnLogOut);
            this.SidePanel.Controls.Add(this.btnHouseApplience);
            this.SidePanel.Controls.Add(this.btnHome);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(200, 1121);
            this.SidePanel.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnLogOut.Location = new System.Drawing.Point(0, 1010);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 60);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHouseApplience
            // 
            this.btnHouseApplience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnHouseApplience.FlatAppearance.BorderSize = 0;
            this.btnHouseApplience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHouseApplience.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHouseApplience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnHouseApplience.Location = new System.Drawing.Point(0, 169);
            this.btnHouseApplience.Name = "btnHouseApplience";
            this.btnHouseApplience.Size = new System.Drawing.Size(200, 100);
            this.btnHouseApplience.TabIndex = 1;
            this.btnHouseApplience.Text = "House Applience";
            this.btnHouseApplience.UseVisualStyleBackColor = false;
            this.btnHouseApplience.Click += new System.EventHandler(this.btnHouseApplience_Click);
            // 
            // panelHouseApplience
            // 
            this.panelHouseApplience.BackColor = System.Drawing.Color.Transparent;
            this.panelHouseApplience.Controls.Add(this.lblHousingRules);
            this.panelHouseApplience.Controls.Add(this.rtbHousingRules);
            this.panelHouseApplience.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelHouseApplience.Location = new System.Drawing.Point(206, 0);
            this.panelHouseApplience.Name = "panelHouseApplience";
            this.panelHouseApplience.Size = new System.Drawing.Size(1770, 1120);
            this.panelHouseApplience.TabIndex = 6;
            // 
            // lblHousingRules
            // 
            this.lblHousingRules.AutoSize = true;
            this.lblHousingRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblHousingRules.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHousingRules.ForeColor = System.Drawing.Color.White;
            this.lblHousingRules.Location = new System.Drawing.Point(263, 124);
            this.lblHousingRules.Name = "lblHousingRules";
            this.lblHousingRules.Size = new System.Drawing.Size(306, 48);
            this.lblHousingRules.TabIndex = 19;
            this.lblHousingRules.Text = "Housing rules";
            // 
            // rtbHousingRules
            // 
            this.rtbHousingRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.rtbHousingRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHousingRules.ForeColor = System.Drawing.Color.White;
            this.rtbHousingRules.Location = new System.Drawing.Point(263, 219);
            this.rtbHousingRules.Name = "rtbHousingRules";
            this.rtbHousingRules.Size = new System.Drawing.Size(1192, 712);
            this.rtbHousingRules.TabIndex = 0;
            this.rtbHousingRules.Text = "";
            // 
            // lblCreateEvent
            // 
            this.lblCreateEvent.AutoSize = true;
            this.lblCreateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCreateEvent.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreateEvent.ForeColor = System.Drawing.Color.White;
            this.lblCreateEvent.Location = new System.Drawing.Point(1171, 39);
            this.lblCreateEvent.Name = "lblCreateEvent";
            this.lblCreateEvent.Size = new System.Drawing.Size(284, 48);
            this.lblCreateEvent.TabIndex = 0;
            this.lblCreateEvent.Text = "Create Event";
            // 
            // dtpEnddate
            // 
            this.dtpEnddate.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEnddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnddate.Location = new System.Drawing.Point(1484, 264);
            this.dtpEnddate.Name = "dtpEnddate";
            this.dtpEnddate.Size = new System.Drawing.Size(233, 47);
            this.dtpEnddate.TabIndex = 2;
            // 
            // dtpStartdate
            // 
            this.dtpStartdate.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartdate.Location = new System.Drawing.Point(1484, 159);
            this.dtpStartdate.Name = "dtpStartdate";
            this.dtpStartdate.Size = new System.Drawing.Size(233, 47);
            this.dtpStartdate.TabIndex = 3;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblStartDate.Location = new System.Drawing.Point(1520, 104);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(197, 39);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblEndDate.Location = new System.Drawing.Point(1556, 219);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(161, 39);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End date";
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCreateEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateEvent.FlatAppearance.BorderSize = 0;
            this.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEvent.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCreateEvent.Location = new System.Drawing.Point(1611, 536);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(106, 52);
            this.btnCreateEvent.TabIndex = 6;
            this.btnCreateEvent.Text = "Add";
            this.btnCreateEvent.UseVisualStyleBackColor = false;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // tbNameOfEvent
            // 
            this.tbNameOfEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbNameOfEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNameOfEvent.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNameOfEvent.ForeColor = System.Drawing.Color.White;
            this.tbNameOfEvent.Location = new System.Drawing.Point(1168, 176);
            this.tbNameOfEvent.Name = "tbNameOfEvent";
            this.tbNameOfEvent.Size = new System.Drawing.Size(287, 40);
            this.tbNameOfEvent.TabIndex = 7;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.ForeColor = System.Drawing.Color.White;
            this.tbDescription.Location = new System.Drawing.Point(1168, 324);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(549, 174);
            this.tbDescription.TabIndex = 8;
            // 
            // lblNameOfEvent
            // 
            this.lblNameOfEvent.AutoSize = true;
            this.lblNameOfEvent.Font = new System.Drawing.Font("Roboto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameOfEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblNameOfEvent.Location = new System.Drawing.Point(1168, 124);
            this.lblNameOfEvent.Name = "lblNameOfEvent";
            this.lblNameOfEvent.Size = new System.Drawing.Size(89, 39);
            this.lblNameOfEvent.TabIndex = 9;
            this.lblNameOfEvent.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblDescription.Location = new System.Drawing.Point(1171, 273);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(191, 35);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // lblUpcomingTask
            // 
            this.lblUpcomingTask.AutoSize = true;
            this.lblUpcomingTask.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpcomingTask.ForeColor = System.Drawing.Color.White;
            this.lblUpcomingTask.Location = new System.Drawing.Point(1168, 628);
            this.lblUpcomingTask.Name = "lblUpcomingTask";
            this.lblUpcomingTask.Size = new System.Drawing.Size(328, 48);
            this.lblUpcomingTask.TabIndex = 11;
            this.lblUpcomingTask.Text = "Upcoming Tasks";
            // 
            // listBoxUpcomingTasks
            // 
            this.listBoxUpcomingTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.listBoxUpcomingTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxUpcomingTasks.ForeColor = System.Drawing.Color.White;
            this.listBoxUpcomingTasks.FormattingEnabled = true;
            this.listBoxUpcomingTasks.ItemHeight = 35;
            this.listBoxUpcomingTasks.Location = new System.Drawing.Point(1171, 695);
            this.listBoxUpcomingTasks.Name = "listBoxUpcomingTasks";
            this.listBoxUpcomingTasks.Size = new System.Drawing.Size(533, 280);
            this.listBoxUpcomingTasks.TabIndex = 12;
            // 
            // lblVerificationOfNameOfEvent
            // 
            this.lblVerificationOfNameOfEvent.AutoSize = true;
            this.lblVerificationOfNameOfEvent.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVerificationOfNameOfEvent.ForeColor = System.Drawing.Color.LightCoral;
            this.lblVerificationOfNameOfEvent.Location = new System.Drawing.Point(1168, 219);
            this.lblVerificationOfNameOfEvent.Name = "lblVerificationOfNameOfEvent";
            this.lblVerificationOfNameOfEvent.Size = new System.Drawing.Size(378, 32);
            this.lblVerificationOfNameOfEvent.TabIndex = 13;
            this.lblVerificationOfNameOfEvent.Text = "Please input name of event";
            this.lblVerificationOfNameOfEvent.Visible = false;
            // 
            // lblVerifitationOfDecriptionForCreateAnEvent
            // 
            this.lblVerifitationOfDecriptionForCreateAnEvent.AutoSize = true;
            this.lblVerifitationOfDecriptionForCreateAnEvent.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVerifitationOfDecriptionForCreateAnEvent.ForeColor = System.Drawing.Color.LightCoral;
            this.lblVerifitationOfDecriptionForCreateAnEvent.Location = new System.Drawing.Point(1171, 501);
            this.lblVerifitationOfDecriptionForCreateAnEvent.Name = "lblVerifitationOfDecriptionForCreateAnEvent";
            this.lblVerifitationOfDecriptionForCreateAnEvent.Size = new System.Drawing.Size(448, 32);
            this.lblVerifitationOfDecriptionForCreateAnEvent.TabIndex = 14;
            this.lblVerifitationOfDecriptionForCreateAnEvent.Text = "Please add description of event";
            this.lblVerifitationOfDecriptionForCreateAnEvent.Visible = false;
            // 
            // listViewStudentsEvents
            // 
            this.listViewStudentsEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.listViewStudentsEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStudentsEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IndexOfObject,
            this.NameOfEvent,
            this.Student,
            this.StartDate,
            this.EndDate,
            this.Description});
            this.listViewStudentsEvents.ForeColor = System.Drawing.Color.White;
            this.listViewStudentsEvents.FullRowSelect = true;
            this.listViewStudentsEvents.Location = new System.Drawing.Point(37, 124);
            this.listViewStudentsEvents.Name = "listViewStudentsEvents";
            this.listViewStudentsEvents.Size = new System.Drawing.Size(1062, 354);
            this.listViewStudentsEvents.TabIndex = 15;
            this.listViewStudentsEvents.UseCompatibleStateImageBehavior = false;
            this.listViewStudentsEvents.View = System.Windows.Forms.View.Details;
            this.listViewStudentsEvents.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewStudentsEvents_ItemSelectionChanged);
            this.listViewStudentsEvents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewStudentsEvents_KeyDown);
            // 
            // IndexOfObject
            // 
            this.IndexOfObject.Text = "Index";
            this.IndexOfObject.Width = 0;
            // 
            // NameOfEvent
            // 
            this.NameOfEvent.Text = "Name";
            this.NameOfEvent.Width = 100;
            // 
            // Student
            // 
            this.Student.DisplayIndex = 5;
            this.Student.Width = 0;
            // 
            // StartDate
            // 
            this.StartDate.DisplayIndex = 2;
            this.StartDate.Text = "Start Date";
            this.StartDate.Width = 200;
            // 
            // EndDate
            // 
            this.EndDate.DisplayIndex = 3;
            this.EndDate.Text = "End Date";
            this.EndDate.Width = 200;
            // 
            // Description
            // 
            this.Description.DisplayIndex = 4;
            this.Description.Text = "Description";
            this.Description.Width = 500;
            // 
            // lblYourEvents
            // 
            this.lblYourEvents.AutoSize = true;
            this.lblYourEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblYourEvents.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYourEvents.ForeColor = System.Drawing.Color.White;
            this.lblYourEvents.Location = new System.Drawing.Point(37, 39);
            this.lblYourEvents.Name = "lblYourEvents";
            this.lblYourEvents.Size = new System.Drawing.Size(262, 48);
            this.lblYourEvents.TabIndex = 16;
            this.lblYourEvents.Text = "Your events";
            // 
            // listViewAllEvents
            // 
            this.listViewAllEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.listViewAllEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAllEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewAllEvents.ForeColor = System.Drawing.Color.White;
            this.listViewAllEvents.FullRowSelect = true;
            this.listViewAllEvents.Location = new System.Drawing.Point(37, 628);
            this.listViewAllEvents.Name = "listViewAllEvents";
            this.listViewAllEvents.Size = new System.Drawing.Size(1062, 354);
            this.listViewAllEvents.TabIndex = 17;
            this.listViewAllEvents.UseCompatibleStateImageBehavior = false;
            this.listViewAllEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 5;
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 2;
            this.columnHeader4.Text = "Start Date";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 3;
            this.columnHeader5.Text = "End Date";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 4;
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 500;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "All events";
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.listViewAllEvents);
            this.panelHome.Controls.Add(this.lblYourEvents);
            this.panelHome.Controls.Add(this.listViewStudentsEvents);
            this.panelHome.Controls.Add(this.lblVerifitationOfDecriptionForCreateAnEvent);
            this.panelHome.Controls.Add(this.lblVerificationOfNameOfEvent);
            this.panelHome.Controls.Add(this.listBoxUpcomingTasks);
            this.panelHome.Controls.Add(this.lblUpcomingTask);
            this.panelHome.Controls.Add(this.lblDescription);
            this.panelHome.Controls.Add(this.lblNameOfEvent);
            this.panelHome.Controls.Add(this.tbDescription);
            this.panelHome.Controls.Add(this.tbNameOfEvent);
            this.panelHome.Controls.Add(this.btnCreateEvent);
            this.panelHome.Controls.Add(this.lblEndDate);
            this.panelHome.Controls.Add(this.lblStartDate);
            this.panelHome.Controls.Add(this.dtpStartdate);
            this.panelHome.Controls.Add(this.dtpEnddate);
            this.panelHome.Controls.Add(this.lblCreateEvent);
            this.panelHome.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelHome.Location = new System.Drawing.Point(206, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1770, 1120);
            this.panelHome.TabIndex = 4;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1972, 1121);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelHouseApplience);
            this.Name = "HomePage";
            this.Text = "Home";
            this.SidePanel.ResumeLayout(false);
            this.panelHouseApplience.ResumeLayout(false);
            this.panelHouseApplience.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHome;
        private Panel SidePanel;
        private Panel panelHouseApplience;
        private Button btnLogOut;
        private Button btnHouseApplience;
        private Label lblCreateEvent;
        private DateTimePicker dtpEnddate;
        private DateTimePicker dtpStartdate;
        private Label lblStartDate;
        private Label lblEndDate;
        private Button btnCreateEvent;
        private TextBox tbNameOfEvent;
        private TextBox tbDescription;
        private Label lblNameOfEvent;
        private Label lblDescription;
        private Label lblUpcomingTask;
        private ListBox listBoxUpcomingTasks;
        private Label lblVerificationOfNameOfEvent;
        private Label lblVerifitationOfDecriptionForCreateAnEvent;
        private ListView listViewStudentsEvents;
        private ColumnHeader IndexOfObject;
        private ColumnHeader NameOfEvent;
        private ColumnHeader Student;
        private ColumnHeader StartDate;
        private ColumnHeader EndDate;
        private ColumnHeader Description;
        private Label lblYourEvents;
        private ListView listViewAllEvents;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
        private Panel panelHome;
        private Label lblHousingRules;
        private RichTextBox rtbHousingRules;
    }
}