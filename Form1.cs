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
        private decimal SummaryTransactionValue, SummaryLodgingValue, SummaryEnrollmentValue,
            SummaryCertCosts;
        private decimal TripCost, AverageRevenueTrip, PriceReduction, OptionalCosts;
        private int TotalNumberBookings, TotalNumberBookingsDiscount, GuestCount;
        private string CourseSelected, VenueSelected, SuiteSelected;

        private decimal CourseSelectedPrice, VenueSelectedPrice,
            LodgingCost, CourseFees, SuiteFees;

        public L2PLTDForm()
        {
            InitializeComponent();
            this.GuestTextBox.Text = "0";
        }
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            // constant prices per night for venues
            const decimal KillarneyNight = 149.99m;
            const decimal BelmulletNight = 219.99m;
            const decimal DublinNight = 179.99m;
            const decimal ClifdenNight = 119.99m;
            const decimal CorkNight = 149.99m;
            const decimal LetterkennyNight = 89.99m;
            const decimal SligoNight = 119.99m;

            const String Venue1 = "Belmullet";
            const String Venue2 = "Clifden";
            const String Venue3 = "Cork";
            const String Venue4 = "Dublin";
            const String Venue5 = "Killarney";
            const String Venue6 = "Letterkenny";
            const String Venue7 = "Sligo";

            // course lengths
            const int FundamentalsLength = 2;
            const int BasicsLength = 4;
            const int IntermediateLength = 4;
            const int AdvancedLength = 2;
            const int ASPPartALength = 5;
            const int ASPPartBLength = 5;

            // course fees
            const int FundamentalsFee = 900;
            const int BasicsFee = 1500;
            const int IntermediateFee = 1800;
            const int AdvancedFee = 2300;
            const int ASPPartAFee = 1250;
            const int ASPPartBFee = 1250;

            // room upgrades
            const decimal MasterSuiteCost = 99.99m;
            const decimal ExecutiveSuiteCost = 69.99m;
            const decimal JuniorSuiteCost = 49.99m;

            // digital cert cost
            const decimal DigitalCert = 39.99m;

            // discount for three or more guests and special room
            const decimal DiscountRate = 0.075m;

            // reset values if previous display / booking occurred
            PriceReduction = 0.00m;
            OptionalCosts = 0.00m;

            int CourseIndex = 0, VenueIndex = 0, CourseLength = 0;

            CourseSelectedPrice = 0.00m;
            VenueSelectedPrice = 0.00m;
            LodgingCost = 0.00m;
            CourseFees = 0.00m;
            SuiteFees = 0.00m;

            // if statements to check if listboxes have a selection made
            if (ListBoxCourse.SelectedIndex != -1)
            {   
                if(ListBoxVenue.SelectedIndex != -1)
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
                                CourseSelected = "C# Fundamentals"; CourseLength = FundamentalsLength;
                                CourseSelectedPrice = FundamentalsFee; break;
                            case 1:
                                CourseSelected = "C# Basics for Beginners"; CourseLength = BasicsLength;
                                CourseSelectedPrice = BasicsFee; break;
                            case 2:
                                CourseSelected = "C# Intermediate"; CourseLength = IntermediateLength;
                                CourseSelectedPrice = IntermediateFee; break;
                            case 3:
                                CourseSelected = "C# Advanced Topics"; CourseLength = AdvancedLength;
                                CourseSelectedPrice = AdvancedFee; break;
                            case 4:
                                CourseSelected = "ASP.Net with C# Part A"; CourseLength = ASPPartALength;
                                CourseSelectedPrice = ASPPartAFee; break;
                            case 5:
                                CourseSelected = "ASP.Net with C# Part B"; CourseLength = ASPPartBLength;
                                CourseSelectedPrice = ASPPartBFee; break;
                        }

                        switch (VenueIndex)
                        {
                            case 0: VenueSelected = Venue1; VenueSelectedPrice = BelmulletNight; break;
                            case 1: VenueSelected = Venue2; VenueSelectedPrice = ClifdenNight; break;
                            case 2: VenueSelected = Venue3; VenueSelectedPrice = CorkNight; break;
                            case 3: VenueSelected = Venue4; VenueSelectedPrice = DublinNight; break;
                            case 4: VenueSelected = Venue5; VenueSelectedPrice = KillarneyNight; break;
                            case 5: VenueSelected = Venue6; VenueSelectedPrice = LetterkennyNight; break;
                            case 6: VenueSelected = Venue7; VenueSelectedPrice = SligoNight; break;
                        }

                        // check for user upgrading suite or not
                        if (MasterSuiteRadioButton.Checked)
                        {
                            SuiteSelected = "Master Suite";
                            SuiteFees += MasterSuiteCost * CourseLength;
                        }
                        else if (ExecutiveRadioButton.Checked)
                        {
                            SuiteSelected = "Executive Suite";
                            SuiteFees += ExecutiveSuiteCost * CourseLength;
                        }
                        else if (JuniorSuiteRadioButton.Checked)
                        {
                            SuiteSelected = "Junior Suite";
                            SuiteFees += JuniorSuiteCost * CourseLength;
                        }
                        else if (StandardRadioButton.Checked)
                        {
                            SuiteSelected = "Standard Suite";
                            SuiteFees = 0.00m;
                        }

                        if (CheckBoxCertificate.Checked)
                        {
                            OptionalCosts += DigitalCert * GuestCount;
                        }

                        LodgingCost += VenueSelectedPrice * CourseLength;
                        CourseFees = CourseSelectedPrice * GuestCount;

                        // overall trip cost
                        TripCost = CourseFees + LodgingCost + OptionalCosts + SuiteFees;

                        // apply discounts
                        if (GuestCount >= 3 && SuiteSelected != "Standard Suite")
                        {
                            PriceReduction = TripCost * DiscountRate;
                            TripCost = TripCost - PriceReduction;
                        }

                        this.DisplayGroupBox.Visible = true;
                        this.Text = "Booking Overview";

                        this.TextBoxGuestsDisplay.Text = GuestCount.ToString();
                        this.TextBoxCourseSelectedDisplay.Text = CourseSelected;
                        this.TextBoxCourseFeesDisplay.Text = "€" + CourseFees.ToString("0.00");
                        this.TextBoxVenueSelectedDisplay.Text = VenueSelected;
                        this.TextBoxVenueFeesDisplay.Text = "€" + LodgingCost.ToString("0.00");
                        this.TextBoxSuiteSelectedDisplay.Text = SuiteSelected;
                        this.TextBoxSuiteFeesDisplay.Text = "€" + SuiteFees.ToString("0.00");
                        this.TextBoxCertificateFeesDisplay.Text = "€" + OptionalCosts.ToString("0.00");
                        this.TextBoxDiscountDisplay.Text = "€" + PriceReduction.ToString("0.00");
                        this.TextBoxTotalBookingDisplay.Text = "€" + TripCost.ToString("0.00");

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
            MessageBox.Show("Your booking was Successful." +
               "\nThe Course Selected is: " + CourseSelected +
               "\nVenue Selected is: " + VenueSelected +
               "\nNumber of Guests are: " + GuestCount.ToString() +
               "\nBooking Cost was: €" + TripCost.ToString("0.00"), "Booking Successful", MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            // add summary stats
            SummaryTransactionValue += TripCost;
            SummaryLodgingValue += LodgingCost;
            SummaryEnrollmentValue += CourseFees;
            SummaryCertCosts += OptionalCosts;
            TotalNumberBookings += 1;

            // change form header after message box cleared
            this.Text = "L2P LTD. Programming Courses Ireland";

            if(PriceReduction > 0)
            {
                TotalNumberBookingsDiscount += 1;
            }
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(TotalNumberBookings > 0)
                {
                    this.Text = "L2P LTD. Summary Data";
                    this.SummaryGroupBox.Visible = true;
                    this.DisplayGroupBox.Visible = false;
                    this.TotalSummaryTranasctionsTextBox.Text = TotalNumberBookings.ToString();
                    this.TotalSummarySalesTextBox.Text = "€" + SummaryTransactionValue.ToString("0.00");
                    this.TotalEnrollmentFeesTextBox.Text = "€" + SummaryEnrollmentValue.ToString();
                    this.TotalLodgingFeesTextBox.Text = "€" + SummaryLodgingValue.ToString("0.00");
                    AverageRevenueTrip = SummaryTransactionValue / TotalNumberBookings;
                    this.AverageRevenueSummaryTextBox.Text = "€" + AverageRevenueTrip.ToString("0.00");
                    this.TotalDiscountedTextBox.Text = TotalNumberBookingsDiscount.ToString();
                    this.CertificateSummaryTextBox.Text = "€" + SummaryCertCosts.ToString("0.00");
                }
            }
            catch
            {
                MessageBox.Show("There are no transactions to show." +
                            "\nPlease ensure there are transactions made.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.SummaryGroupBox.Visible = false;
            this.DisplayGroupBox.Visible = false;
            // reset title of form
            this.Text = "L2P LTD. Programming Courses Ireland";
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
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}