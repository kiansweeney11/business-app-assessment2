namespace L2P_LTD
{
    partial class L2PLTDForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L2PLTDForm));
            this.DefaultPictureBox = new System.Windows.Forms.PictureBox();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.GuestTextBox = new System.Windows.Forms.TextBox();
            this.StartMenuLabel = new System.Windows.Forms.Label();
            this.CourseGroupBox = new System.Windows.Forms.GroupBox();
            this.FeesLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.ListBoxCourse = new System.Windows.Forms.ListBox();
            this.VenueGroupBox = new System.Windows.Forms.GroupBox();
            this.PricePerNightLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ListBoxVenue = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GroupBoxUpgrades = new System.Windows.Forms.GroupBox();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.JuniorSuiteRadioButton = new System.Windows.Forms.RadioButton();
            this.ExecutiveRadioButton = new System.Windows.Forms.RadioButton();
            this.MasterSuiteRadioButton = new System.Windows.Forms.RadioButton();
            this.CertificateGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckBoxCertificate = new System.Windows.Forms.CheckBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ToolTipDisplay = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipBook = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipSummary = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipClear = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.DisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxGuestsDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxCourseSelectedDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxCourseFeesDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxVenueSelectedDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxVenueFeesDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxSuiteSelectedDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxSuiteFeesDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxCertificateFeesDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxDiscountDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxTotalBookingDisplay = new System.Windows.Forms.TextBox();
            this.GuestNumberLabelDisplay = new System.Windows.Forms.Label();
            this.DiscountLabelDisplay = new System.Windows.Forms.Label();
            this.TotalCostLabelDisplay = new System.Windows.Forms.Label();
            this.CertificateFeesLabelDisplay = new System.Windows.Forms.Label();
            this.SuiteFeesLabelDisplay = new System.Windows.Forms.Label();
            this.SuiteSelectedLabelDisplay = new System.Windows.Forms.Label();
            this.VenueFeesLabelDisplay = new System.Windows.Forms.Label();
            this.VenueSelectedLabelDisplay = new System.Windows.Forms.Label();
            this.layCourseSelectedLabelDispa = new System.Windows.Forms.Label();
            this.CourseFeesLabelDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultPictureBox)).BeginInit();
            this.StartPanel.SuspendLayout();
            this.CourseGroupBox.SuspendLayout();
            this.VenueGroupBox.SuspendLayout();
            this.GroupBoxUpgrades.SuspendLayout();
            this.CertificateGroupBox.SuspendLayout();
            this.DisplayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DefaultPictureBox
            // 
            this.DefaultPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DefaultPictureBox.Image")));
            this.DefaultPictureBox.Location = new System.Drawing.Point(230, 555);
            this.DefaultPictureBox.Name = "DefaultPictureBox";
            this.DefaultPictureBox.Size = new System.Drawing.Size(337, 138);
            this.DefaultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DefaultPictureBox.TabIndex = 0;
            this.DefaultPictureBox.TabStop = false;
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.SystemColors.Window;
            this.StartPanel.Controls.Add(this.GuestTextBox);
            this.StartPanel.Controls.Add(this.StartMenuLabel);
            this.StartPanel.Location = new System.Drawing.Point(461, 417);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(311, 63);
            this.StartPanel.TabIndex = 1;
            // 
            // GuestTextBox
            // 
            this.GuestTextBox.Location = new System.Drawing.Point(198, 18);
            this.GuestTextBox.Name = "GuestTextBox";
            this.GuestTextBox.Size = new System.Drawing.Size(71, 31);
            this.GuestTextBox.TabIndex = 1;
            this.GuestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartMenuLabel
            // 
            this.StartMenuLabel.AutoSize = true;
            this.StartMenuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartMenuLabel.Location = new System.Drawing.Point(3, 21);
            this.StartMenuLabel.Name = "StartMenuLabel";
            this.StartMenuLabel.Size = new System.Drawing.Size(171, 25);
            this.StartMenuLabel.TabIndex = 0;
            this.StartMenuLabel.Text = "Number of Guests:";
            // 
            // CourseGroupBox
            // 
            this.CourseGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.CourseGroupBox.Controls.Add(this.FeesLabel);
            this.CourseGroupBox.Controls.Add(this.LengthLabel);
            this.CourseGroupBox.Controls.Add(this.CourseLabel);
            this.CourseGroupBox.Controls.Add(this.ListBoxCourse);
            this.CourseGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CourseGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CourseGroupBox.Name = "CourseGroupBox";
            this.CourseGroupBox.Size = new System.Drawing.Size(426, 260);
            this.CourseGroupBox.TabIndex = 2;
            this.CourseGroupBox.TabStop = false;
            this.CourseGroupBox.Text = "Course Selection";
            // 
            // FeesLabel
            // 
            this.FeesLabel.AutoSize = true;
            this.FeesLabel.Location = new System.Drawing.Point(354, 33);
            this.FeesLabel.Name = "FeesLabel";
            this.FeesLabel.Size = new System.Drawing.Size(49, 25);
            this.FeesLabel.TabIndex = 6;
            this.FeesLabel.Text = "Fees";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(266, 33);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(71, 25);
            this.LengthLabel.TabIndex = 5;
            this.LengthLabel.Text = "Length";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(6, 33);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(70, 25);
            this.CourseLabel.TabIndex = 4;
            this.CourseLabel.Text = "Course";
            // 
            // ListBoxCourse
            // 
            this.ListBoxCourse.FormattingEnabled = true;
            this.ListBoxCourse.ItemHeight = 25;
            this.ListBoxCourse.Items.AddRange(new object[] {
            "C# Fundamentals\t           \t2 Days  \t€900",
            "C# Basics for Beginners      \t4 Days  \t€1500",
            "C# Intermediate                 \t4 Days  \t€1800",
            "C# Advanced Topics           \t2 Days  \t€2300",
            "ASAP.NET with C# Part A    \t5 Days  \t€1250",
            "ASAP.NET with C# Part B     \t5 Days  \t€1250"});
            this.ListBoxCourse.Location = new System.Drawing.Point(6, 61);
            this.ListBoxCourse.Name = "ListBoxCourse";
            this.ListBoxCourse.Size = new System.Drawing.Size(414, 154);
            this.ListBoxCourse.TabIndex = 3;
            // 
            // VenueGroupBox
            // 
            this.VenueGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.VenueGroupBox.Controls.Add(this.PricePerNightLabel);
            this.VenueGroupBox.Controls.Add(this.LocationLabel);
            this.VenueGroupBox.Controls.Add(this.ListBoxVenue);
            this.VenueGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VenueGroupBox.Location = new System.Drawing.Point(444, 12);
            this.VenueGroupBox.Name = "VenueGroupBox";
            this.VenueGroupBox.Size = new System.Drawing.Size(344, 251);
            this.VenueGroupBox.TabIndex = 3;
            this.VenueGroupBox.TabStop = false;
            this.VenueGroupBox.Text = "Venue Selection";
            // 
            // PricePerNightLabel
            // 
            this.PricePerNightLabel.AutoSize = true;
            this.PricePerNightLabel.Location = new System.Drawing.Point(180, 27);
            this.PricePerNightLabel.Name = "PricePerNightLabel";
            this.PricePerNightLabel.Size = new System.Drawing.Size(124, 25);
            this.PricePerNightLabel.TabIndex = 3;
            this.PricePerNightLabel.Text = "Price Per Day";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(6, 29);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(85, 25);
            this.LocationLabel.TabIndex = 2;
            this.LocationLabel.Text = "Location";
            // 
            // ListBoxVenue
            // 
            this.ListBoxVenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListBoxVenue.FormattingEnabled = true;
            this.ListBoxVenue.ItemHeight = 25;
            this.ListBoxVenue.Items.AddRange(new object[] {
            "Belmullet                  €219.99",
            "Clifden \t\t€119.99",
            "Cork \t\t€149.99",
            "Dublin \t\t€179.99",
            "Killarney \t\t€149.99",
            "Letterkenny\t€89.99",
            "Sligo \t\t€119.99"});
            this.ListBoxVenue.Location = new System.Drawing.Point(8, 57);
            this.ListBoxVenue.Name = "ListBoxVenue";
            this.ListBoxVenue.Size = new System.Drawing.Size(320, 179);
            this.ListBoxVenue.TabIndex = 1;
            // 
            // GroupBoxUpgrades
            // 
            this.GroupBoxUpgrades.BackColor = System.Drawing.SystemColors.Window;
            this.GroupBoxUpgrades.Controls.Add(this.StandardRadioButton);
            this.GroupBoxUpgrades.Controls.Add(this.JuniorSuiteRadioButton);
            this.GroupBoxUpgrades.Controls.Add(this.ExecutiveRadioButton);
            this.GroupBoxUpgrades.Controls.Add(this.MasterSuiteRadioButton);
            this.GroupBoxUpgrades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxUpgrades.Location = new System.Drawing.Point(12, 278);
            this.GroupBoxUpgrades.Name = "GroupBoxUpgrades";
            this.GroupBoxUpgrades.Size = new System.Drawing.Size(436, 202);
            this.GroupBoxUpgrades.TabIndex = 4;
            this.GroupBoxUpgrades.TabStop = false;
            this.GroupBoxUpgrades.Text = "Room Upgrades";
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(6, 152);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(342, 29);
            this.StandardRadioButton.TabIndex = 3;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard Suite (No Additional Cost)";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            // 
            // JuniorSuiteRadioButton
            // 
            this.JuniorSuiteRadioButton.AutoSize = true;
            this.JuniorSuiteRadioButton.Location = new System.Drawing.Point(6, 117);
            this.JuniorSuiteRadioButton.Name = "JuniorSuiteRadioButton";
            this.JuniorSuiteRadioButton.Size = new System.Drawing.Size(376, 29);
            this.JuniorSuiteRadioButton.TabIndex = 2;
            this.JuniorSuiteRadioButton.Text = "Junior Suite (Additional €49.99 Per Day)";
            this.JuniorSuiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExecutiveRadioButton
            // 
            this.ExecutiveRadioButton.AutoSize = true;
            this.ExecutiveRadioButton.Location = new System.Drawing.Point(6, 82);
            this.ExecutiveRadioButton.Name = "ExecutiveRadioButton";
            this.ExecutiveRadioButton.Size = new System.Drawing.Size(405, 29);
            this.ExecutiveRadioButton.TabIndex = 1;
            this.ExecutiveRadioButton.Text = "Executive Suite (Additional €69.99 Per Day)";
            this.ExecutiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // MasterSuiteRadioButton
            // 
            this.MasterSuiteRadioButton.AutoSize = true;
            this.MasterSuiteRadioButton.Location = new System.Drawing.Point(6, 47);
            this.MasterSuiteRadioButton.Name = "MasterSuiteRadioButton";
            this.MasterSuiteRadioButton.Size = new System.Drawing.Size(382, 29);
            this.MasterSuiteRadioButton.TabIndex = 0;
            this.MasterSuiteRadioButton.Text = "Master Suite (Additional €99.99 Per Day)";
            this.MasterSuiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // CertificateGroupBox
            // 
            this.CertificateGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.CertificateGroupBox.Controls.Add(this.CheckBoxCertificate);
            this.CertificateGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CertificateGroupBox.Location = new System.Drawing.Point(461, 278);
            this.CertificateGroupBox.Name = "CertificateGroupBox";
            this.CertificateGroupBox.Size = new System.Drawing.Size(311, 133);
            this.CertificateGroupBox.TabIndex = 5;
            this.CertificateGroupBox.TabStop = false;
            this.CertificateGroupBox.Text = "Certificates";
            // 
            // CheckBoxCertificate
            // 
            this.CheckBoxCertificate.AutoSize = true;
            this.CheckBoxCertificate.Location = new System.Drawing.Point(18, 47);
            this.CheckBoxCertificate.Name = "CheckBoxCertificate";
            this.CheckBoxCertificate.Size = new System.Drawing.Size(287, 54);
            this.CheckBoxCertificate.TabIndex = 0;
            this.CheckBoxCertificate.Text = "Digital Certificate \r\n(Additional €39.99 Per Guest)";
            this.CheckBoxCertificate.UseVisualStyleBackColor = true;
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.SystemColors.Window;
            this.DisplayButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayButton.Location = new System.Drawing.Point(32, 506);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(112, 34);
            this.DisplayButton.TabIndex = 6;
            this.DisplayButton.Text = "Display";
            this.ToolTipDisplay.SetToolTip(this.DisplayButton, "Display current booking information\r\ndetails before confirming booking.");
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.BackColor = System.Drawing.SystemColors.Window;
            this.BookButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookButton.Location = new System.Drawing.Point(184, 506);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(112, 34);
            this.BookButton.TabIndex = 7;
            this.BookButton.Text = "Book";
            this.ToolTipBook.SetToolTip(this.BookButton, "Confirm booking details currently selected.");
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.SystemColors.Window;
            this.SummaryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryButton.Location = new System.Drawing.Point(336, 506);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(112, 34);
            this.SummaryButton.TabIndex = 8;
            this.SummaryButton.Text = "Summary";
            this.ToolTipSummary.SetToolTip(this.SummaryButton, "Click for company summary transaction data.");
            this.SummaryButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.Window;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(488, 506);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 34);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ToolTipClear.SetToolTip(this.ClearButton, "Press to clear form for next booking.");
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Window;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(640, 506);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 34);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ToolTipExit.SetToolTip(this.ExitButton, "Press to exit application.");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ToolTipDisplay
            // 
            this.ToolTipDisplay.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipDisplay.ToolTipTitle = "Info";
            // 
            // ToolTipBook
            // 
            this.ToolTipBook.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipBook.ToolTipTitle = "Info";
            // 
            // ToolTipSummary
            // 
            this.ToolTipSummary.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipSummary.ToolTipTitle = "Info";
            // 
            // ToolTipClear
            // 
            this.ToolTipClear.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipClear.ToolTipTitle = "Info";
            // 
            // ToolTipExit
            // 
            this.ToolTipExit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipExit.ToolTipTitle = "Info";
            // 
            // DisplayGroupBox
            // 
            this.DisplayGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.DisplayGroupBox.Controls.Add(this.label1);
            this.DisplayGroupBox.Controls.Add(this.TextBoxGuestsDisplay);
            this.DisplayGroupBox.Controls.Add(this.TextBoxCourseSelectedDisplay);
            this.DisplayGroupBox.Controls.Add(this.TextBoxCourseFeesDisplay);
            this.DisplayGroupBox.Controls.Add(this.TextBoxVenueSelectedDisplay);
            this.DisplayGroupBox.Controls.Add(this.TextBoxVenueFeesDisplay);
            this.DisplayGroupBox.Controls.Add(this.TextBoxSuiteSelectedDisplay);
            this.DisplayGroupBox.Controls.Add(this.TextBoxSuiteFeesDisplay);
            this.DisplayGroupBox.Controls.Add(this.TextBoxCertificateFeesDisplay);
            this.DisplayGroupBox.Controls.Add(this.TextBoxDiscountDisplay);
            this.DisplayGroupBox.Controls.Add(this.TextBoxTotalBookingDisplay);
            this.DisplayGroupBox.Controls.Add(this.GuestNumberLabelDisplay);
            this.DisplayGroupBox.Controls.Add(this.DiscountLabelDisplay);
            this.DisplayGroupBox.Controls.Add(this.TotalCostLabelDisplay);
            this.DisplayGroupBox.Controls.Add(this.CertificateFeesLabelDisplay);
            this.DisplayGroupBox.Controls.Add(this.SuiteFeesLabelDisplay);
            this.DisplayGroupBox.Controls.Add(this.SuiteSelectedLabelDisplay);
            this.DisplayGroupBox.Controls.Add(this.VenueFeesLabelDisplay);
            this.DisplayGroupBox.Controls.Add(this.VenueSelectedLabelDisplay);
            this.DisplayGroupBox.Controls.Add(this.layCourseSelectedLabelDispa);
            this.DisplayGroupBox.Controls.Add(this.CourseFeesLabelDisplay);
            this.DisplayGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayGroupBox.Location = new System.Drawing.Point(6, 4);
            this.DisplayGroupBox.Name = "DisplayGroupBox";
            this.DisplayGroupBox.Size = new System.Drawing.Size(776, 476);
            this.DisplayGroupBox.TabIndex = 7;
            this.DisplayGroupBox.TabStop = false;
            this.DisplayGroupBox.Text = "Are These Booking Details Correct?";
            this.DisplayGroupBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Click Book to confirm these booking details.";
            // 
            // TextBoxGuestsDisplay
            // 
            this.TextBoxGuestsDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxGuestsDisplay.Location = new System.Drawing.Point(379, 55);
            this.TextBoxGuestsDisplay.Name = "TextBoxGuestsDisplay";
            this.TextBoxGuestsDisplay.Size = new System.Drawing.Size(317, 34);
            this.TextBoxGuestsDisplay.TabIndex = 19;
            this.TextBoxGuestsDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxCourseSelectedDisplay
            // 
            this.TextBoxCourseSelectedDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxCourseSelectedDisplay.Location = new System.Drawing.Point(379, 92);
            this.TextBoxCourseSelectedDisplay.Name = "TextBoxCourseSelectedDisplay";
            this.TextBoxCourseSelectedDisplay.Size = new System.Drawing.Size(317, 34);
            this.TextBoxCourseSelectedDisplay.TabIndex = 18;
            this.TextBoxCourseSelectedDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxCourseFeesDisplay
            // 
            this.TextBoxCourseFeesDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxCourseFeesDisplay.Location = new System.Drawing.Point(379, 129);
            this.TextBoxCourseFeesDisplay.Name = "TextBoxCourseFeesDisplay";
            this.TextBoxCourseFeesDisplay.Size = new System.Drawing.Size(317, 34);
            this.TextBoxCourseFeesDisplay.TabIndex = 17;
            this.TextBoxCourseFeesDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxVenueSelectedDisplay
            // 
            this.TextBoxVenueSelectedDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxVenueSelectedDisplay.Location = new System.Drawing.Point(379, 166);
            this.TextBoxVenueSelectedDisplay.Name = "TextBoxVenueSelectedDisplay";
            this.TextBoxVenueSelectedDisplay.Size = new System.Drawing.Size(317, 34);
            this.TextBoxVenueSelectedDisplay.TabIndex = 16;
            this.TextBoxVenueSelectedDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxVenueFeesDisplay
            // 
            this.TextBoxVenueFeesDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxVenueFeesDisplay.Location = new System.Drawing.Point(379, 203);
            this.TextBoxVenueFeesDisplay.Name = "TextBoxVenueFeesDisplay";
            this.TextBoxVenueFeesDisplay.Size = new System.Drawing.Size(317, 34);
            this.TextBoxVenueFeesDisplay.TabIndex = 15;
            this.TextBoxVenueFeesDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxSuiteSelectedDisplay
            // 
            this.TextBoxSuiteSelectedDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSuiteSelectedDisplay.Location = new System.Drawing.Point(379, 240);
            this.TextBoxSuiteSelectedDisplay.Name = "TextBoxSuiteSelectedDisplay";
            this.TextBoxSuiteSelectedDisplay.Size = new System.Drawing.Size(317, 34);
            this.TextBoxSuiteSelectedDisplay.TabIndex = 14;
            this.TextBoxSuiteSelectedDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxSuiteFeesDisplay
            // 
            this.TextBoxSuiteFeesDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSuiteFeesDisplay.Location = new System.Drawing.Point(379, 277);
            this.TextBoxSuiteFeesDisplay.Name = "TextBoxSuiteFeesDisplay";
            this.TextBoxSuiteFeesDisplay.Size = new System.Drawing.Size(317, 34);
            this.TextBoxSuiteFeesDisplay.TabIndex = 13;
            this.TextBoxSuiteFeesDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxCertificateFeesDisplay
            // 
            this.TextBoxCertificateFeesDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxCertificateFeesDisplay.Location = new System.Drawing.Point(379, 314);
            this.TextBoxCertificateFeesDisplay.Name = "TextBoxCertificateFeesDisplay";
            this.TextBoxCertificateFeesDisplay.Size = new System.Drawing.Size(317, 34);
            this.TextBoxCertificateFeesDisplay.TabIndex = 12;
            this.TextBoxCertificateFeesDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxDiscountDisplay
            // 
            this.TextBoxDiscountDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDiscountDisplay.Location = new System.Drawing.Point(379, 351);
            this.TextBoxDiscountDisplay.Name = "TextBoxDiscountDisplay";
            this.TextBoxDiscountDisplay.Size = new System.Drawing.Size(317, 34);
            this.TextBoxDiscountDisplay.TabIndex = 11;
            this.TextBoxDiscountDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxTotalBookingDisplay
            // 
            this.TextBoxTotalBookingDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxTotalBookingDisplay.Location = new System.Drawing.Point(379, 388);
            this.TextBoxTotalBookingDisplay.Name = "TextBoxTotalBookingDisplay";
            this.TextBoxTotalBookingDisplay.Size = new System.Drawing.Size(317, 34);
            this.TextBoxTotalBookingDisplay.TabIndex = 10;
            this.TextBoxTotalBookingDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GuestNumberLabelDisplay
            // 
            this.GuestNumberLabelDisplay.AutoSize = true;
            this.GuestNumberLabelDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestNumberLabelDisplay.Location = new System.Drawing.Point(143, 55);
            this.GuestNumberLabelDisplay.Name = "GuestNumberLabelDisplay";
            this.GuestNumberLabelDisplay.Size = new System.Drawing.Size(184, 28);
            this.GuestNumberLabelDisplay.TabIndex = 9;
            this.GuestNumberLabelDisplay.Text = "Number of Guests";
            // 
            // DiscountLabelDisplay
            // 
            this.DiscountLabelDisplay.AutoSize = true;
            this.DiscountLabelDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountLabelDisplay.Location = new System.Drawing.Point(143, 351);
            this.DiscountLabelDisplay.Name = "DiscountLabelDisplay";
            this.DiscountLabelDisplay.Size = new System.Drawing.Size(96, 28);
            this.DiscountLabelDisplay.TabIndex = 8;
            this.DiscountLabelDisplay.Text = "Discount";
            // 
            // TotalCostLabelDisplay
            // 
            this.TotalCostLabelDisplay.AutoSize = true;
            this.TotalCostLabelDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalCostLabelDisplay.Location = new System.Drawing.Point(143, 388);
            this.TotalCostLabelDisplay.Name = "TotalCostLabelDisplay";
            this.TotalCostLabelDisplay.Size = new System.Drawing.Size(190, 28);
            this.TotalCostLabelDisplay.TabIndex = 7;
            this.TotalCostLabelDisplay.Text = "Total Booking Cost";
            // 
            // CertificateFeesLabelDisplay
            // 
            this.CertificateFeesLabelDisplay.AutoSize = true;
            this.CertificateFeesLabelDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CertificateFeesLabelDisplay.Location = new System.Drawing.Point(143, 314);
            this.CertificateFeesLabelDisplay.Name = "CertificateFeesLabelDisplay";
            this.CertificateFeesLabelDisplay.Size = new System.Drawing.Size(211, 28);
            this.CertificateFeesLabelDisplay.TabIndex = 6;
            this.CertificateFeesLabelDisplay.Text = "Certificate Print Fees";
            // 
            // SuiteFeesLabelDisplay
            // 
            this.SuiteFeesLabelDisplay.AutoSize = true;
            this.SuiteFeesLabelDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SuiteFeesLabelDisplay.Location = new System.Drawing.Point(143, 277);
            this.SuiteFeesLabelDisplay.Name = "SuiteFeesLabelDisplay";
            this.SuiteFeesLabelDisplay.Size = new System.Drawing.Size(101, 28);
            this.SuiteFeesLabelDisplay.TabIndex = 5;
            this.SuiteFeesLabelDisplay.Text = "SuiteFees";
            // 
            // SuiteSelectedLabelDisplay
            // 
            this.SuiteSelectedLabelDisplay.AutoSize = true;
            this.SuiteSelectedLabelDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SuiteSelectedLabelDisplay.Location = new System.Drawing.Point(143, 240);
            this.SuiteSelectedLabelDisplay.Name = "SuiteSelectedLabelDisplay";
            this.SuiteSelectedLabelDisplay.Size = new System.Drawing.Size(146, 28);
            this.SuiteSelectedLabelDisplay.TabIndex = 4;
            this.SuiteSelectedLabelDisplay.Text = "Suite Selected";
            // 
            // VenueFeesLabelDisplay
            // 
            this.VenueFeesLabelDisplay.AutoSize = true;
            this.VenueFeesLabelDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VenueFeesLabelDisplay.Location = new System.Drawing.Point(143, 203);
            this.VenueFeesLabelDisplay.Name = "VenueFeesLabelDisplay";
            this.VenueFeesLabelDisplay.Size = new System.Drawing.Size(117, 28);
            this.VenueFeesLabelDisplay.TabIndex = 3;
            this.VenueFeesLabelDisplay.Text = "Venue Fees";
            // 
            // VenueSelectedLabelDisplay
            // 
            this.VenueSelectedLabelDisplay.AutoSize = true;
            this.VenueSelectedLabelDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VenueSelectedLabelDisplay.Location = new System.Drawing.Point(143, 166);
            this.VenueSelectedLabelDisplay.Name = "VenueSelectedLabelDisplay";
            this.VenueSelectedLabelDisplay.Size = new System.Drawing.Size(156, 28);
            this.VenueSelectedLabelDisplay.TabIndex = 2;
            this.VenueSelectedLabelDisplay.Text = "Venue Selected";
            // 
            // layCourseSelectedLabelDispa
            // 
            this.layCourseSelectedLabelDispa.AutoSize = true;
            this.layCourseSelectedLabelDispa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.layCourseSelectedLabelDispa.Location = new System.Drawing.Point(143, 92);
            this.layCourseSelectedLabelDispa.Name = "layCourseSelectedLabelDispa";
            this.layCourseSelectedLabelDispa.Size = new System.Drawing.Size(162, 28);
            this.layCourseSelectedLabelDispa.TabIndex = 1;
            this.layCourseSelectedLabelDispa.Text = "Course Selected";
            // 
            // CourseFeesLabelDisplay
            // 
            this.CourseFeesLabelDisplay.AutoSize = true;
            this.CourseFeesLabelDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CourseFeesLabelDisplay.Location = new System.Drawing.Point(143, 129);
            this.CourseFeesLabelDisplay.Name = "CourseFeesLabelDisplay";
            this.CourseFeesLabelDisplay.Size = new System.Drawing.Size(123, 28);
            this.CourseFeesLabelDisplay.TabIndex = 0;
            this.CourseFeesLabelDisplay.Text = "Course Fees";
            // 
            // L2PLTDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 730);
            this.Controls.Add(this.DisplayGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.CertificateGroupBox);
            this.Controls.Add(this.GroupBoxUpgrades);
            this.Controls.Add(this.VenueGroupBox);
            this.Controls.Add(this.CourseGroupBox);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.DefaultPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "L2PLTDForm";
            this.Text = "L2P LTD. Programming Courses Ireland";
            ((System.ComponentModel.ISupportInitialize)(this.DefaultPictureBox)).EndInit();
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.CourseGroupBox.ResumeLayout(false);
            this.CourseGroupBox.PerformLayout();
            this.VenueGroupBox.ResumeLayout(false);
            this.VenueGroupBox.PerformLayout();
            this.GroupBoxUpgrades.ResumeLayout(false);
            this.GroupBoxUpgrades.PerformLayout();
            this.CertificateGroupBox.ResumeLayout(false);
            this.CertificateGroupBox.PerformLayout();
            this.DisplayGroupBox.ResumeLayout(false);
            this.DisplayGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox DefaultPictureBox;
        private Panel StartPanel;
        private Label StartMenuLabel;
        private TextBox GuestTextBox;
        private GroupBox CourseGroupBox;
        private GroupBox VenueGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox ListBoxVenue;
        private ListBox ListBoxCourse;
        private GroupBox GroupBoxUpgrades;
        private GroupBox CertificateGroupBox;
        private CheckBox CheckBoxCertificate;
        private Button DisplayButton;
        private Button BookButton;
        private Button SummaryButton;
        private Button ClearButton;
        private Button ExitButton;
        private RadioButton MasterSuiteRadioButton;
        private RadioButton ExecutiveRadioButton;
        private RadioButton JuniorSuiteRadioButton;
        private RadioButton StandardRadioButton;
        private Label CourseLabel;
        private Label FeesLabel;
        private Label LengthLabel;
        private Label LocationLabel;
        private Label PricePerNightLabel;
        private ToolTip ToolTipDisplay;
        private ToolTip ToolTipBook;
        private ToolTip ToolTipSummary;
        private ToolTip ToolTipClear;
        private ToolTip ToolTipExit;
        private GroupBox DisplayGroupBox;
        private Label DiscountLabelDisplay;
        private Label TotalCostLabelDisplay;
        private Label CertificateFeesLabelDisplay;
        private Label SuiteFeesLabelDisplay;
        private Label SuiteSelectedLabelDisplay;
        private Label VenueFeesLabelDisplay;
        private Label VenueSelectedLabelDisplay;
        private Label layCourseSelectedLabelDispa;
        private Label CourseFeesLabelDisplay;
        private Label GuestNumberLabelDisplay;
        private TextBox TextBoxGuestsDisplay;
        private TextBox TextBoxCourseSelectedDisplay;
        private TextBox TextBoxCourseFeesDisplay;
        private TextBox TextBoxVenueSelectedDisplay;
        private TextBox TextBoxVenueFeesDisplay;
        private TextBox TextBoxSuiteSelectedDisplay;
        private TextBox TextBoxSuiteFeesDisplay;
        private TextBox TextBoxCertificateFeesDisplay;
        private TextBox TextBoxDiscountDisplay;
        private TextBox TextBoxTotalBookingDisplay;
        private Label label1;
    }
}