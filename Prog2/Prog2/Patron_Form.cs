/*
 * Grading ID: Z9435
 * Program 2
 * CIS 200-01
 * Due Date: 3/10/17
 * Description: The purpose of the patron class is to allow the user to enter a patron to the library. The form
 *              collect information such as patron name and patron ID. The form must have both in order for a
 *              patron to be successfully entered into the library.
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
    public partial class Patron_Form : Form
    {
        //  precondition: None
        //  postcondition: the patron form has been initialized
        public Patron_Form()
        {
            InitializeComponent();
        }

        internal string InputValue_Name // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in patronNameInputTxt is returned
            get { return patronNameInputTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in patronNameInputTxt is set to specified value
            set { patronNameInputTxt.Text = value; }
        }

        internal string InputValue_ID // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in patronIDInputTxt is returned
            get { return patronIDInputTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in patronIDInputTxt is set to specified value
            set { patronIDInputTxt.Text = value; }
        }

        //  Precondition: the user has clicked on the cancelBtn
        //  postcondition: if left-click the dialog box is dismissed with a Cancel result
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition:  User has clicked on the OKBtn
        // Postcondition: If all controls on form validate, Patron_Form is dismissed with OK result
        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition:  patronID_Validating succeeded
        // Postcondition: Any error message set for patronID is cleared
        //                Focus is allowed to change
        private void patronID_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(patronIDInputTxt.Text))
                errorProvider2.SetError(patronIDInputTxt, "");

        }

        // Precondition:  Attempting to change focus from patronID
        // Postcondition: If entered value is valid text, focus will change,
        //                else focus will remain and error provider message set
        private void patronID_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(patronIDInputTxt.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(patronIDInputTxt, "Please enter a patron ID");
                patronIDInputTxt.SelectAll();
            }
        }

        // Precondition:  patronName_Validating succeeded
        // Postcondition: Any error message set for patronName is cleared
        //                Focus is allowed to change
        private void patronName_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(patronNameInputTxt.Text))
            {
                errorProvider1.SetError(patronNameInputTxt, "");
            }
        }

        // Precondition:  Attempting to change focus from patronNameInput
        // Postcondition: If entered value is valid text, focus will change,
        //                else focus will remain and error provider message set
        private void patronNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(patronNameInputTxt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(patronNameInputTxt, "Please enter a patron first and last name.");
                patronNameInputTxt.SelectAll();
            }
        }
    }
}
