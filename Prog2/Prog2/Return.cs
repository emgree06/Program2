/*
 * Grading ID: Z9435
 * Program 2
 * CIS 200-01
 * Due Date: 3/10/17
 * Description: The return class allows the user to return a checkedout item. The an item must be selected to be returned and
 *              for the dialog box to return the result OK to the main form.
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
    public partial class Return : Form
    {
        //  precondition: A book has been checked out
        //  postcondition: Once the form has been created the user will be able to return checked out items
        public Return(Library _lib)// requires a library item
        {
            InitializeComponent();

            var items = _lib.GetItemsList();// Get the list of LibraryItems from class Library

            foreach (LibraryItem item in items)// iterates through the LibraryItems list
            {
                return_Item_ComboBox.Items.Add(item.Title + " , " + item.CallNumber);// will display only title and call number attributes
            }

        }

        internal int Selected_Return_Item // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Index value for Selected_Return_Item is returned
            get { return return_Item_ComboBox.SelectedIndex; }

            // Precondition:  None
            // Postcondition: Index value for Selected_Return_Item is set to specified value
            set { return_Item_ComboBox.SelectedIndex = value; }
        }

        //  Precondition: the user has clicked on the cancelBtn
        //  postcondition: if left-click the dialog box is dismissed with a Cancel result
        private void CnclBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition:  User has clicked on the OKBtn
        // Postcondition: If all controls on form validate, Patron_Form is dismissed with OK result
        private void ok_Button_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //  Precondition: return_Item_ComboBox validating succeeded
        //  Postcondition: any error message set for return_Item_ComboBox
        //                 will be cleared and focus will be allowed to change
        private void return_Item_ComboBox_Validated(object sender, EventArgs e)
        {
            if (return_Item_ComboBox.SelectedIndex >= 0)// Index must be equal to or greater than starting position in the list
            {
                errorProvider1.SetError(return_Item_ComboBox, "");// clears error if statement is true
            }
        }

        // Precondition:  Attempting to change focus from return_Item_ComboBox
        // Postcondition: If value is within the list range, focus will change,
        //                else focus will remain and error provider message set
        private void return_Item_ComboBox_Validating(object sender, CancelEventArgs e)
        {

            if (return_Item_ComboBox.SelectedIndex == -1)// if index is less than starting position 0 then an errorprovider alerts the user
            {
                e.Cancel = true;
                errorProvider1.SetError(return_Item_ComboBox, "Please select an item to be returned");
            }
        }
    }
}
