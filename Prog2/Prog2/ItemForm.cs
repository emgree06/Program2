/*
 * Grading ID: Z9435
 * Program 2
 * CIS 200-01
 * Due Date: 3/10/17
 * Description: The ItemForm class recieves information from all the dialog boxes contained within the form.
 *              The ItemForm class takes the dialog box result recieved and displays it as output for the user
 *              to see.
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
    public partial class ItemForm : Form
    {
        private Library _lib; //field to create HAS-A relationship with Library class and Form1 class
        
        //  precondition: none
        // Postcondition: ItemForm has been itinialized
        public ItemForm()
        {
            InitializeComponent();

            _lib = new Library();// create library items
            
            //Adding LibraryItems
            _lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright");
            _lib.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
                "AB73 ZF", "IP Thief");
            _lib.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
                "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
                LibraryMovie.MPAARatings.PG);
            _lib.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
                "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            _lib.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
                "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            _lib.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
                "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            _lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
                "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            _lib.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
                "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9A", 16, 7);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9B", 16, 8);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9C", 16, 9);
            _lib.AddLibraryMagazine("     VB Magazine    ", "    UofL Mags   ", 2018, 14,
                "MA21 5V", 1, 1);

            //Adding Patrons
            _lib.AddPatron("Ima Reader", "12345");
            _lib.AddPatron("Jane Doe", "11223");
            _lib.AddPatron("   John Smith   ", "   654321   ");
            _lib.AddPatron("James T. Kirk", "98765");
            _lib.AddPatron("Jean-Luc Picard", "33456");

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grade ID: Z9435 \nDue Date: 3/10/2018\nProg: 2", "About");// used to show general information about programmer and program
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();// used to terminate the entire application
        }

        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patron_Form patron_Form = new Patron_Form();// instantiates the patron_form
            DialogResult result;// retrieves the dialog result
            string name;//  used for string input from the patron dialog box specifically the patron name
            string id;//    used for string input from the patron dialog box specifically the patron ID

            result = patron_Form.ShowDialog();

            if(result == DialogResult.OK)// if the user clicks okay on the patron form dialog box
            {
                name = patron_Form.InputValue_Name;
                id = patron_Form.InputValue_ID;
                _lib.AddPatron(name, id);
            }

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book book_Form = new Book();// instantiates the book form
            DialogResult result;// dialog result from the book form

            string title;// title of the book
            string publisher;// publisher of the book
            string copyright;// copyright of the book
            string loanperiod;// loan period for the book
            string callnum;// call number of the book
            string author;// author of the book

            result = book_Form.ShowDialog();

            if (result == DialogResult.OK)
            {
                title = book_Form.InputBook_Title;
                publisher = book_Form.InputBook_Publisher;
                copyright = book_Form.InputBook_Copyright;
                loanperiod = book_Form.InputBook_LoanPeriod;
                callnum = book_Form.InputBook_CallNum;
                author = book_Form.InputBook_Author;
  
                _lib.AddLibraryBook(title, publisher, int.Parse(copyright), int.Parse(loanperiod), callnum, author);
            }
        }

        private void patronListReport_Clicked(object sender, EventArgs e)
        {
            string n = Environment.NewLine;

            //LINQ that selects that patron in the patrons list
            var patrons =
                from p in _lib.GetPatronsList()
                select p;

            displayTxt.Text = $"The number of patrons in the library: {_lib.GetPatronCount().ToString()}" + n;

            foreach (var p in _lib._patrons)
            {
                
                displayTxt.Text += n + $"{p}{n}";
            }
        }

        private void Prog1(object sender, EventArgs e)
        {

        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string n = Environment.NewLine;

            //LINQ that selects each item in the items list
            var items =
                from i in _lib.GetItemsList()
                select i;

            displayTxt.Text = $"The number of items in the library: {_lib.GetItemCount()}"+ n;

            foreach(LibraryItem i in _lib._items)
            {
               
               displayTxt.Text += n + $"{i}{n}" + n;
            }
        }

        private void checkedOutItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string n = Environment.NewLine;

            //LINQ that selects items that are checked out
            var items =
              from i in _lib._items
              where i.IsCheckedOut()
              select i;

            displayTxt.Text = $"The number of items that are checked out is: {_lib.GetCheckedOutCount()}{n}";

            foreach(LibraryItem i in items)
            {

                displayTxt.Text += n + $"{i}{n}";
            }
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_Out checkout_Form = new Check_Out(_lib);// instantiates the check_out form
            DialogResult result;// the dialog result
            int patron;// the library patron
            int item;// the library item
            result = checkout_Form.ShowDialog();


            if (result == DialogResult.OK)
            {
                patron = checkout_Form.Selected_Patron;
                item = checkout_Form.Selected_Item;
                _lib.CheckOut(item, patron);
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return return_Form = new Return(_lib);// instantiates the return form
            DialogResult result;// the dialog result
            int item;// the library item
            result = return_Form.ShowDialog();


            if (result == DialogResult.OK)
            {
                item = return_Form.Selected_Return_Item;
                _lib.ReturnToShelf(item);
            }
        }
    }
}
