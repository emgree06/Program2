/*
 * Grading ID: Z9435
 * Program 2
 * CIS 200-01
 * Due Date: 3/10/17
 * Description: The purpose if the book class is to collect information about a book the user would like
 *              to enter in the library. The attributes it'll collect are title, publisher, copyright year,
 *              loan period, and author. Then it will validate the data entered and if everythig validates it will send
 *              the dialog result OK to the main form and the book will be added to the library.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class Book : Form
    {
        //  Precodition: none
        //  Postcondition: The book for has been created.
        public Book()
        {
            InitializeComponent();
        }

        internal string InputBook_Title
        {
            // Precondition:  None
            // Postcondition: Text in TitleTxt is returned
            get { return TitleTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in TitleTxt is set to specified value
            set { TitleTxt.Text = value; }
        }

        internal string InputBook_Publisher // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in publisherTxt is returned
            get { return publisherTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in publisherTxt is set to specified value
            set { publisherTxt.Text = value; }
        }

        internal string InputBook_Copyright
        {
            // Precondition:  None
            // Postcondition: Text in inputTxt is returned
            get { return copyrightTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in inputTxt is set to specified value
            set { copyrightTxt.Text = value; }
        }

        internal string InputBook_LoanPeriod // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in inputTxt is returned
            get { return loanPeriodTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in inputTxt is set to specified value
            set { loanPeriodTxt.Text = value; }
        }

        internal string InputBook_CallNum
        {
            // Precondition:  None
            // Postcondition: Text in callNumberTxt is returned
            get { return callNumberTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in callNumberTxt is set to specified value
            set { callNumberTxt.Text = value; }
        }

        internal string InputBook_Author // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in authorTxt is returned
            get { return authorTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in authorTxt is set to specified value
            set { authorTxt.Text = value; }
        }

        //  Precondition: the user has clicked on the cancelBtn
        //  postcondition: if left-click the dialog box is dismissed with a Cancel result
        private void CancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }


        // Precondition:  User has clicked on the OKBtn
        // Postcondition: If all controls on form validate, Patron_Form is dismissed with OK result
        private void OK_button_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //  Precondition: TitleInput validating succeeded
        //  Postcondition: any error message set for TitleInput
        //                 will be cleared and focus will be allowed to change
        private void TitleInput_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TitleTxt.Text))
            {
                errorProvider1.SetError(TitleTxt, "");
            }
        }

        // Precondition:  Attempting to change focus from TitleInput
        // Postcondition: If entered value is valid text, focus will change,
        //                else focus will remain and error provider message set
        private void TitleInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TitleTxt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TitleTxt, "Please enter a book title.");
                TitleTxt.SelectAll();
            }
        }

        // Precondition:  Attempting to change focus from PublisherInput
        // Postcondition: If entered value is valid text, focus will change,
        //                else focus will remain and error provider message set
        private void PublisherInput__Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(publisherTxt.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(publisherTxt, "Please enter a book publisher.");
                publisherTxt.SelectAll();
            }
        }

        //  Precondition: PublisherInput validating succeeded
        //  Postcondition: any error message set for PublisherInput
        //                 will be cleared and focus will be allowed to change
        private void PublisherInput_Validated(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(publisherTxt.Text))
            {
                errorProvider2.SetError(publisherTxt, "");
            }
        }

        //  Precondition: Copyright validating succeeded
        //  Postcondition: any error message set for Copyright
        //                 will be cleared and focus will be allowed to change
        private void Copyright_Validated(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(copyrightTxt.Text))
            {
                errorProvider3.SetError(copyrightTxt, "");
            }
        }

        // Precondition:  Attempting to change focus from Cpoyright
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void Copyright_Validating(object sender, CancelEventArgs e)
        {
            int number;// used to represent the number entered by the user

            if (string.IsNullOrEmpty(copyrightTxt.Text))
            {
                e.Cancel = true;
                errorProvider3.SetError(copyrightTxt, "Please enter a book copyright year.");
                copyrightTxt.SelectAll();
            }
            else if (!int.TryParse(copyrightTxt.Text, out number))
                {
                    e.Cancel = true; // Stops focus changing process
                                     // Will NOT proceed to Validated event

                    errorProvider3.SetError(copyrightTxt, "Enter an integer!"); // Set error message

                    copyrightTxt.SelectAll(); // Select all text in inputTxt to ease correction
                }
            else
            {
                if (number < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    errorProvider3.SetError(copyrightTxt, "Enter a non-negative integer!"); // Set error message

                    copyrightTxt.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }

        //  Precondition: Author validating succeeded
        //  Postcondition: any error message set for Author
        //                 will be cleared and focus will be allowed to change
        private void Author_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(authorTxt.Text))
            {
                errorProvider4.SetError(authorTxt, "");
            }
        }

        // Precondition:  Attempting to change focus from Author
        // Postcondition: If entered value is valid text, focus will change,
        //                else focus will remain and error provider message set
        private void Author_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(authorTxt.Text))
            {
                e.Cancel = true;
                errorProvider4.SetError(authorTxt, "Please enter a book author.");
                authorTxt.SelectAll();
            }
        }

        //  Precondition: LoanPeriod validating succeeded
        //  Postcondition: any error message set for LoanPeriod
        //                 will be cleared and focus will be allowed to change
        private void LoanPeriod_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loanPeriodTxt.Text))
            {
                errorProvider5.SetError(loanPeriodTxt, "");
            }
        }

        // Precondition:  Attempting to change focus from LoanPeriod
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void LoanPeriod_Validating(object sender, CancelEventArgs e)
        {
            int number;// used to represent the number entered by the user

            if (string.IsNullOrEmpty(loanPeriodTxt.Text))// tests to make sure that the textbox isn't left empty
            {
                e.Cancel = true;
                errorProvider5.SetError(loanPeriodTxt, "Please enter a book copyright year.");
                loanPeriodTxt.SelectAll();
            }
            else if (!int.TryParse(loanPeriodTxt.Text, out number))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider5.SetError(loanPeriodTxt, "Enter an integer!"); // Set error message

                loanPeriodTxt.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (number < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    errorProvider5.SetError(loanPeriodTxt, "Enter a non-negative integer!"); // Set error message

                    loanPeriodTxt.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }

        //  Precondition: CallNum validating succeeded
        //  Postcondition: any error message set for CallNum
        //                 will be cleared and focus will be allowed to change
        private void CallNum_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(callNumberTxt.Text))
            {
                errorProvider6.SetError(callNumberTxt, "");
            }
        }

        // Precondition:  Attempting to change focus from CallNum
        // Postcondition: If entered value is valid text, focus will change,
        //                else focus will remain and error provider message set
        private void CallNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(callNumberTxt.Text))
            {
                e.Cancel = true;
                errorProvider6.SetError(callNumberTxt, "Please enter a book call number.");
                callNumberTxt.SelectAll();
            }
        }
    }
}
