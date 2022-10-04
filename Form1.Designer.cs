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
            ((System.ComponentModel.ISupportInitialize)(this.DefaultPictureBox)).BeginInit();
            this.StartPanel.SuspendLayout();
            this.CourseGroupBox.SuspendLayout();
            this.VenueGroupBox.SuspendLayout();
            this.GroupBoxUpgrades.SuspendLayout();
            this.CertificateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DefaultPictureBox
            // 
            this.DefaultPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DefaultPictureBox.Image")));
            this.DefaultPictureBox.Location = new System.Drawing.Point(232, 563);
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
            this.BookButton.UseVisualStyleBackColor = false;
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
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // L2PLTDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 730);
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
    }
}