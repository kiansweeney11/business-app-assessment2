// Name: Kian Sweeney
// ID: 22220670
// MS806: Assignment 2
// Due Date: 14/10/22
// L2P Ltd, is a company that provides residential software
// programming courses in locations across Ireland

using System.Security.Cryptography;
using System.Windows.Forms;

namespace L2P_LTD
{
    public partial class L2PLTDForm : Form
    {
        // decimal values global for historical company summary and book button
        private decimal SummaryTransactionValue, SummaryLodgingValue, SummaryEnrollmentValue,
            LodgingCost, CourseFees, SuiteFees, TotalOptionalCosts, TripCost, PriceReduction, 
            OptionalCertCosts;
        // global integer values - booking related and guest count
        private int TotalNumberBookings, TotalNumberBookingsDiscount, GuestCount;
        // strings need to be global for book button
        private string CourseSelected, VenueSelected, SuiteSelected;

        public L2PLTDForm()
        {
            InitializeComponent();
            this.GuestTextBox.Text = "0";
        }
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            // constant prices per night for venues
            const decimal KILLARNEYNIGHT = 149.99m;
            const decimal BELLMULLETNIGHT = 219.99m;
            const decimal DUBLINNIGHT = 179.99m;
            const decimal CLIFDENNIGHT = 119.99m;
            const decimal CORKNIGHT = 149.99m;
            const decimal LETTERKENNYNIGHT = 89.99m;
            const decimal SLIGONIGHT = 119.99m;

            // venues
            const String VENUEBELLMULLET = "Belmullet";
            const String VENUECLIFDEN = "Clifden";
            const String VENUECORK = "Cork";
            const String VENUEDUBLIN = "Dublin";
            const String VENUEKILLARNEY = "Killarney";
            const String VENUELETTERKENNY = "Letterkenny";
            const String VENUESLIGO = "Sligo";

            // course names
            const String COURSEOPTIONFUNDAMENTALS = "C# Fundamentals";
            const String COURSEOPTIONBASICS = "C# Basics for Beginners";
            const String COURSEOPTIONINTERMEDIATE = "C# Intermediate";
            const String COURSEOPTIONADVANCED = "C# Advanced Topics";
            const String COURSEOPTIONPARTA = "ASP.Net with C# Part A";
            const String COURSEOPTIONPARTB = "ASP.Net with C# Part B";

            // course lengths
            const int FUNDAMENTALSLENGTH = 2;
            const int BASICSLENGTH = 4;
            const int INTERMEDIATELENGTH = 4;
            const int ADVANCEDLENGTH = 2;
            const int ASPPARTALENGTH = 5;
            const int ASPPARTBLENGTH = 5;

            // course fees
            const int FUNDAMENTALSFEE = 900;
            const int BASICSFEE = 1500;
            const int INTERMEDIATEFEE = 1800;
            const int ADVANCEDFEE = 2300;
            const int ASPPARTAFEE = 1250;
            const int ASPPARTBFEE = 1250;

            // room upgrades
            const decimal MASTERSUITECOST = 99.99m;
            const decimal EXECUTIVESUITECOST = 69.99m;
            const decimal JUNIORSUITECOST = 49.99m;

            // room types
            const String MASTERSUITE = "Master Suite";
            const String EXECUTIVESUITE = "Executive Suite";
            const String JUNIORSUITE = "Junior Suite";
            const String STANDARDSUITE = "Standard Suite";

            // digital cert cost
            const decimal DIGITALCERT = 39.99m;

            // discount for three or more guests and special room
            const decimal DISCOUNTRATE = 0.075m;

            // reset values if previous display / booking occurred
            PriceReduction = 0.00m;
            OptionalCertCosts = 0.00m;

            int CourseIndex = 0, VenueIndex = 0, CourseLength = 0;

            decimal CourseSelectedPrice = 0.00m;
            decimal VenueSelectedPrice = 0.00m;
            decimal OptionalsDisplay = 0.00m;
            LodgingCost = 0.00m;
            CourseFees = 0.00m;
            SuiteFees = 0.00m;

            // if statements to check if listboxes have a selection made
            if (ListBoxCourse.SelectedIndex != -1)
            {
                if (ListBoxVenue.SelectedIndex != -1)
                {
                    // User input is validated against negative and decimals.
                    if (!int.TryParse(GuestTextBox.Text, out GuestCount) ||
                         GuestCount <= 0)
                    {
                        MessageBox.Show("Please check value for Guests." +
                            "\nPlease ensure there are no decimals or negative numbers inputted.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GuestTextBox.Focus();
                    }
                    else
                    {
                        CourseIndex = ListBoxCourse.SelectedIndex;
                        VenueIndex = ListBoxVenue.SelectedIndex;

                        switch (CourseIndex)
                        {
                            case 0:
                                CourseSelected = COURSEOPTIONFUNDAMENTALS; CourseLength = FUNDAMENTALSLENGTH;
                                CourseSelectedPrice = FUNDAMENTALSFEE; break;
                            case 1:
                                CourseSelected = COURSEOPTIONBASICS; CourseLength = BASICSLENGTH;
                                CourseSelectedPrice = BASICSFEE; break;
                            case 2:
                                CourseSelected = COURSEOPTIONINTERMEDIATE; CourseLength = INTERMEDIATELENGTH;
                                CourseSelectedPrice = INTERMEDIATEFEE; break;
                            case 3:
                                CourseSelected = COURSEOPTIONADVANCED; CourseLength = ADVANCEDLENGTH;
                                CourseSelectedPrice = ADVANCEDFEE; break;
                            case 4:
                                CourseSelected = COURSEOPTIONPARTA; CourseLength = ASPPARTALENGTH;
                                CourseSelectedPrice = ASPPARTAFEE; break;
                            case 5:
                                CourseSelected = COURSEOPTIONPARTB; CourseLength = ASPPARTBLENGTH;
                                CourseSelectedPrice = ASPPARTBFEE; break;
                        }

                        switch (VenueIndex)
                        {
                            case 0: VenueSelected = VENUEBELLMULLET; VenueSelectedPrice = BELLMULLETNIGHT; break;
                            case 1: VenueSelected = VENUECLIFDEN; VenueSelectedPrice = CLIFDENNIGHT; break;
                            case 2: VenueSelected = VENUECORK; VenueSelectedPrice = CORKNIGHT; break;
                            case 3: VenueSelected = VENUEDUBLIN; VenueSelectedPrice = DUBLINNIGHT; break;
                            case 4: VenueSelected = VENUEKILLARNEY; VenueSelectedPrice = KILLARNEYNIGHT; break;
                            case 5: VenueSelected = VENUELETTERKENNY; VenueSelectedPrice = LETTERKENNYNIGHT; break;
                            case 6: VenueSelected = VENUESLIGO; VenueSelectedPrice = SLIGONIGHT; break;
                        }

                        // check for user upgrading suite or not
                        if (MasterSuiteRadioButton.Checked)
                        {
                            SuiteSelected = MASTERSUITE;
                            SuiteFees += MASTERSUITECOST * CourseLength;
                        }
                        else if (ExecutiveRadioButton.Checked)
                        {
                            SuiteSelected = EXECUTIVESUITE;
                            SuiteFees += EXECUTIVESUITECOST * CourseLength;
                        }
                        else if (JuniorSuiteRadioButton.Checked)
                        {
                            SuiteSelected = JUNIORSUITE;
                            SuiteFees += JUNIORSUITECOST * CourseLength;
                        }
                        else if (StandardRadioButton.Checked)
                        {
                            SuiteSelected = STANDARDSUITE;
                        }

                        if (CheckBoxCertificate.Checked)
                        {
                            OptionalCertCosts += DIGITALCERT * GuestCount;
                        }

                        LodgingCost += VenueSelectedPrice * CourseLength;
                        CourseFees = CourseSelectedPrice * GuestCount;
                        OptionalsDisplay = OptionalCertCosts + SuiteFees;

                        // overall trip cost
                        TripCost = CourseFees + LodgingCost + OptionalCertCosts + SuiteFees;

                        // apply discounts
                        if (GuestCount >= 3 && SuiteSelected != STANDARDSUITE)
                        {
                            PriceReduction = TripCost * DISCOUNTRATE;
                            TripCost = TripCost - PriceReduction;
                        }

                        this.TextBoxGuestsDisplay.Text = GuestCount.ToString();
                        this.TextBoxCourseSelectedDisplay.Text = CourseSelected;
                        this.TextBoxCourseFeesDisplay.Text = CourseFees.ToString("C");
                        this.TextBoxVenueSelectedDisplay.Text = VenueSelected;
                        this.TextBoxVenueFeesDisplay.Text = LodgingCost.ToString("C");
                        this.TextBoxCertificateFeesDisplay.Text = OptionalsDisplay.ToString("C");
                        this.TextBoxDiscountDisplay.Text = PriceReduction.ToString("C");
                        this.TextBoxTotalBookingDisplay.Text = TripCost.ToString("C");

                        this.DisplayGroupBox.Visible = true;
                        this.Text = "Booking Overview";

                        BookButton.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Please select a course venue for participants.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a course for participants.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            // message box to confirm booking
            var Confirm = MessageBox.Show("Confirmation of selected booking details:" +
               "\nThe Course Selected is: " + CourseSelected +
               "\nVenue Selected is: " + VenueSelected +
               "\nNumber of Attendees are: " + GuestCount.ToString() +
               "\nBooking Cost is: " + TripCost.ToString("C"), "Confirm Booking?", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Information);

            // If the OK button pressed
            if (Confirm == DialogResult.OK)
            {
                // add summary stats
                SummaryTransactionValue += TripCost;
                SummaryLodgingValue += LodgingCost;
                SummaryEnrollmentValue += CourseFees;
                TotalOptionalCosts += OptionalCertCosts + SuiteFees;
                TotalNumberBookings += 1;

                if (PriceReduction > 0)
                {
                    TotalNumberBookingsDiscount += 1;
                }
            }
            // change form header after message box cleared
            this.Text = "L2P LTD. Programming Courses Ireland";
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            if (TotalNumberBookings > 0)
            {
                this.TotalSummaryTranasctionsTextBox.Text = TotalNumberBookings.ToString();
                this.TotalSummarySalesTextBox.Text = SummaryTransactionValue.ToString("C");
                this.TotalEnrollmentFeesTextBox.Text = SummaryEnrollmentValue.ToString("C");
                this.TotalLodgingFeesTextBox.Text = SummaryLodgingValue.ToString("C");
                decimal AverageRevenueTrip = SummaryTransactionValue / TotalNumberBookings;
                this.AverageRevenueSummaryTextBox.Text = AverageRevenueTrip.ToString("C");
                this.TotalDiscountedTextBox.Text = TotalNumberBookingsDiscount.ToString();
                this.CertificateSummaryTextBox.Text = TotalOptionalCosts.ToString("C");
                // change after all values verified
                this.Text = "L2P LTD. Summary Data";
                this.SummaryGroupBox.Visible = true;
                this.DisplayGroupBox.Visible = false;
            }
            else
            {
                MessageBox.Show("There are no transactions to show." +
                            "\nPlease ensure there are transactions made.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.GuestTextBox.Text = "0";
            // have no default selection on listbox
            this.ListBoxVenue.SelectedIndex = -1;
            this.ListBoxCourse.SelectedIndex = -1;
            // uncheck checkbox if digital cert selected
            this.CheckBoxCertificate.Checked = false;
            // radio buttons - leave standard as default selected
            this.StandardRadioButton.Checked = true;
            this.ExecutiveRadioButton.Checked = false;
            this.JuniorSuiteRadioButton.Checked = false;
            this.MasterSuiteRadioButton.Checked = false;
            // hide summary and display
            this.SummaryGroupBox.Visible = false;
            this.DisplayGroupBox.Visible = false;
            // reset title of form
            this.Text = "L2P LTD. Programming Courses Ireland";
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}