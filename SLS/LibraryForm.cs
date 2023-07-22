using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLS
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
            gbBookOrEbook.Visible = false;
            lblURL.Visible = false;
            tbURL.Visible = false;
            lblClone.Visible = false;
            tbNumOfClones.Visible = false;
            lblVolume.Visible = false;
            tbVolume.Visible = false;
            lblIssue.Visible = false;
            tbIssue.Visible = false;

            #region
            tbID.Leave += tbID_MouseLeave;
            #endregion
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItems.Text == "Book")
            {
                gbBookOrEbook.Visible = true;
                lblVolume.Visible = false;
                tbVolume.Visible = false;
                lblIssue.Visible = false;
                tbIssue.Visible = false;
            }
            if (cbItems.Text == "Magazine") {
                gbBookOrEbook.Visible = false;
                lblVolume.Visible = true;
                tbVolume.Visible = true;
                lblIssue.Visible = true;
                tbIssue.Visible = true;
                lblURL.Visible = false;
                tbURL.Visible = false;
            }
            if (cbItems.Text == "Journal") {
                gbBookOrEbook.Visible = false;
                lblVolume.Visible = false;
                tbVolume.Visible = false;
                lblIssue.Visible = false;
                tbIssue.Visible = false;
                lblURL.Visible = false;
                tbURL.Visible = false;
            }

        }

        private void rbEbook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEbook.Checked) {
                lblURL.Visible = true;
                tbURL.Visible = true;
            }
            else {
                lblURL.Visible = false;
                tbURL.Visible = false;
            }
        }

        private void cbClone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbClone.Checked)
            {
                lblClone.Visible = true;
                tbNumOfClones.Visible = true;
            }
            else {
                lblClone.Visible = false;
                tbNumOfClones.Visible = false;
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbURL.Clear();
            tbTitle.Clear();
            tbISBN.Clear();
            tbAuthor.Clear();
            tbGenre.Clear();
            tbVolume.Clear();
            tbIssue.Clear();
            tbNumOfClones.Clear();
            rbBook.Checked = false;
            rbEbook.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (cbItems.Text == "Book") {
                if (rbBook.Checked)
                {
                    if (!cbClone.Checked){
                       
                        LibraryItem book = new Book(tbID.Text, tbISBN.Text, tbTitle.Text, tbAuthor.Text, tbGenre.Text, cbLocation.Text);
                    }
                    else {
                        
                        string ID = tbID.Text.Remove(0,1);
                        int numOfClones = int.Parse(tbNumOfClones.Text);
                        int intID = int.Parse(ID);
                        int start = 0;
                        
                        while (start <= numOfClones) {
                            
                            
                            LibraryItem book = new Book( "B" + intID.ToString(), tbISBN.Text, tbTitle.Text, tbAuthor.Text, tbGenre.Text, cbLocation.Text);
                            intID++;
                            start++;
                        }    
                    }
                }
                else {
                    if (!cbClone.Checked)
                    {

                        LibraryItem ebook = new Ebook(tbID.Text, tbISBN.Text, tbTitle.Text, tbAuthor.Text, tbGenre.Text, cbLocation.Text, tbURL.Text);
                    }
                    else {
                        string ID = tbID.Text.Remove(0, 1);
                        int numOfClones = int.Parse(tbNumOfClones.Text);
                        int intID = int.Parse(ID);
                        int start = 0;

                        if (start <= numOfClones)
                        {
                            LibraryItem ebook = new Ebook("E" + intID.ToString(), tbISBN.Text, tbTitle.Text, tbAuthor.Text, tbGenre.Text, cbLocation.Text, tbURL.Text);
                            intID++;
                            start++;
                        }
                    } 
                }
            }
            if (cbItems.Text == "Magazine") {
                if (!cbClone.Checked)
                {

                    LibraryItem magazine = new Magazine(tbID.Text, tbISBN.Text, tbTitle.Text, tbAuthor.Text, tbGenre.Text, cbLocation.Text, tbVolume.Text, tbIssue.Text);
                }
                else {
                    string ID = tbID.Text.Remove(0, 1);
                    int numOfClones = int.Parse(tbNumOfClones.Text);
                    int intID = int.Parse(ID);
                    int start = 0;

                    while (start <= numOfClones)
                    {
                        LibraryItem magazine = new Magazine("M" + intID.ToString(), tbISBN.Text, tbTitle.Text, tbAuthor.Text, tbGenre.Text, cbLocation.Text, tbVolume.Text, tbIssue.Text);
                        intID++;
                        start++;
                    }
                }
                
            }
            if (cbItems.Text == "Journal") {
                if (!cbClone.Checked)
                {

                    LibraryItem journal = new Journal(tbID.Text, tbISBN.Text, tbTitle.Text, tbAuthor.Text, tbGenre.Text, cbLocation.Text);
                }
                else {
                    string ID = tbID.Text.Remove(0, 1);
                    int numOfClones = int.Parse(tbNumOfClones.Text);
                    int intID = int.Parse(ID);
                    int start = 0;

                    while (start <= numOfClones)
                    {
                        LibraryItem magazine = new Magazine("J" + intID.ToString(), tbISBN.Text, tbTitle.Text, tbAuthor.Text, tbGenre.Text, cbLocation.Text, tbVolume.Text, tbIssue.Text);
                        intID++;
                        start++;
                    }
                }
                
            }

            //Putting form information into the database
            int clone = 1;

            if (cbClone.Checked)
            {
                int cloneNo = int.Parse(tbNumOfClones.Text);

                Utility.SaveLibraryItems(tbISBN.Text, tbTitle.Text, tbAuthor.Text, tbGenre.Text, cbLocation.Text, tbURL.Text, tbVolume.Text, tbIssue.Text, cloneNo);
            }
            else {
                Utility.SaveLibraryItems(tbISBN.Text, tbTitle.Text, tbAuthor.Text, tbGenre.Text, cbLocation.Text, tbURL.Text, tbVolume.Text, tbIssue.Text, clone);
            }
            


        }

        private void tbID_MouseLeave(object sender, EventArgs e)
        {
            if (cbItems.Text == "Book")
            {
                if (rbBook.Checked)
                {
                    if (!tbID.Text.StartsWith("B"))
                    {
                        MessageBox.Show("ID number must start with the letter: B");
                        tbID.Clear();
                    }
                }
            }
            if (rbEbook.Checked)
            {
                if (!tbID.Text.StartsWith("E"))
                {
                    MessageBox.Show("ID number must start with the letter: E");
                    tbID.Clear();
                }
            }

            if (cbItems.Text == "Magazine")
            {
                if (!tbID.Text.StartsWith("M"))
                {
                    MessageBox.Show("ID number must start with the letter: M");
                    tbID.Clear();
                    tbID.Focus();
                }
            }
            if (cbItems.Text == "Journal")
            {
                if (!tbID.Text.StartsWith("J"))
                {
                    MessageBox.Show("ID number must start with the letter: J");
                    tbID.Clear();
                    tbID.Focus();
                }
            }
        }

        
    }
}
