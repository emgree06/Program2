/*
 * Grading ID: Z9435
 * Program 2
 * CIS 200-01
 * Due Date: 3/10/17
 * Description: The purpose of the check_out class is to cellect information about which item was checked out and by whom.
 *              This information is then sent back to the main form and the CheckOut method is called. This form also
 *              forces the user to choose an item and a patron in order for an item to be checked out.
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
    public partial class Check_Out : Form
    {
        //  precondition: A library has library items and patrons contained in it
        //  postcondition: The Check_Out form has been initialized with library items and patrons
        public Check_Out(Library _lib)// requires an item
        {
            InitializeComponent();

            var items = _lib.GetItemsList();// retrieves items from the LibraryItem list in class Library

            foreach (LibraryItem item in items)// iterates through the list and only displays the attributes of title and callnumber
            {
                item_ComboBox.Items.Add(item.Title + " , " + item.CallNumber);
            }

            var patron = _lib.GetPatronsList();// retrieves patrons from the LibraryPatron list in class Library

            foreach (LibraryPatron p in patron)
            {
                patron_ComboBox.Items.Add(p);
            }
           
        }

        internal int Selected_Item // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Index value for Selected_Item is returned
            get { return item_ComboBox.SelectedIndex; }

            // Precondition:  None
            // Postcondition: Index value for Selected_Item is set to specified value
            set { item_ComboBox.SelectedIndex = value; }
        }

        internal int Selected_Patron // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Index value for Selected_Return_Item is returned
            get { return patron_ComboBox.SelectedIndex; }

            // Precondition:  None
            // Postcondition: Index value for Selected_Patron is set to specified value
            set { patron_ComboBox.SelectedIndex = value; }
        }

        //  Precondition: the user has clicked on the cancelBtn
        //  postcondition: if left-click the dialog box is dismissed with a Cancel result
        private void CnclBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }


        //  Precondition: item_ComboBox validating succeeded
        //  Postcondition: any error message set for item_ComboBox
        //                 will be cleared and focus will be allowed to change
        private void item_ComboBox_Validated(object sender, EventArgs e)
        {
            if (item_ComboBox.SelectedIndex >= 0)// Index must be equal to or greater than starting position in the list
            {
                errorProvider1.SetError(item_ComboBox, "");
            }
        }


        // Precondition:  Attempting to change focus from item_ComboBox
        // Postcondition: If value is within the list range, focus will change,
        //                else focus will remain and error provider message set
        private void item_ComboBox_Validating(object sender, CancelEventArgs e)
        {
            
            if (item_ComboBox.SelectedIndex == -1)// if index is less than starting position 0 then an errorprovider alerts the user
            {
                e.Cancel = true;
                errorProvider1.SetError(item_ComboBox, "Please select an item to be checked out");
            }
        }

        // Precondition:  User has clicked on the OKBtn
        // Postcondition: If all controls on form validate, Patron_Form is dismissed with OK result
        private void ok_Button_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //  Precondition: patron_ComboBox validating succeeded
        //  Postcondition: any error message set for patron_ComboBox
        //                 will be cleared and focus will be allowed to change
        private void patron_combobox_Validated(object sender, EventArgs e)
        {
            if (patron_ComboBox.SelectedIndex >= 0)// Index must be equal to or greater than starting position in the list
            {
                errorProvider2.SetError(patron_ComboBox, "");
            }
        }

        // Precondition:  Attempting to change focus from patron_ComboBox
        // Postcondition: If value is within the list range, focus will change,
        //                else focus will remain and error provider message set
        private void patron_combobox_Validating(object sender, CancelEventArgs e)
        {
            if (patron_ComboBox.SelectedIndex == -1)// if index is less than starting position 0 then an errorprovider alerts the user
            {
                e.Cancel = true;
                errorProvider2.SetError(patron_ComboBox, "Please select a patron to check out an item");
            }
        }
    }
}
