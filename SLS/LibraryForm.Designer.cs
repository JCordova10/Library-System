namespace SLS
{
    partial class LibraryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.cbClone = new System.Windows.Forms.CheckBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbEbook = new System.Windows.Forms.RadioButton();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.gbBookOrEbook = new System.Windows.Forms.GroupBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.tbNumOfClones = new System.Windows.Forms.TextBox();
            this.lblClone = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbISBN = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbIssue = new System.Windows.Forms.TextBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.gbBookOrEbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Items.AddRange(new object[] {
            "Book",
            "Magazine",
            "Journal"});
            this.cbItems.Location = new System.Drawing.Point(118, 48);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(204, 21);
            this.cbItems.TabIndex = 0;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // cbClone
            // 
            this.cbClone.AutoSize = true;
            this.cbClone.Location = new System.Drawing.Point(103, 516);
            this.cbClone.Name = "cbClone";
            this.cbClone.Size = new System.Drawing.Size(76, 17);
            this.cbClone.TabIndex = 1;
            this.cbClone.Text = "Clone Item";
            this.cbClone.UseVisualStyleBackColor = true;
            this.cbClone.CheckedChanged += new System.EventHandler(this.cbClone_CheckedChanged);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(923, 48);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(123, 51);
            this.btnClearForm.TabIndex = 2;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(311, 635);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(329, 42);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Location = new System.Drawing.Point(6, 33);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(50, 17);
            this.rbBook.TabIndex = 4;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = true;
            // 
            // rbEbook
            // 
            this.rbEbook.AutoSize = true;
            this.rbEbook.Location = new System.Drawing.Point(6, 56);
            this.rbEbook.Name = "rbEbook";
            this.rbEbook.Size = new System.Drawing.Size(56, 17);
            this.rbEbook.TabIndex = 5;
            this.rbEbook.TabStop = true;
            this.rbEbook.Text = "eBook";
            this.rbEbook.UseVisualStyleBackColor = true;
            this.rbEbook.CheckedChanged += new System.EventHandler(this.rbEbook_CheckedChanged);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(419, 238);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(100, 20);
            this.tbURL.TabIndex = 8;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(115, 32);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(66, 13);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Pick an Item";
            // 
            // gbBookOrEbook
            // 
            this.gbBookOrEbook.Controls.Add(this.rbBook);
            this.gbBookOrEbook.Controls.Add(this.rbEbook);
            this.gbBookOrEbook.Location = new System.Drawing.Point(108, 92);
            this.gbBookOrEbook.Name = "gbBookOrEbook";
            this.gbBookOrEbook.Size = new System.Drawing.Size(200, 100);
            this.gbBookOrEbook.TabIndex = 10;
            this.gbBookOrEbook.TabStop = false;
            this.gbBookOrEbook.Text = "Book or eBook";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(353, 241);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(60, 13);
            this.lblURL.TabIndex = 11;
            this.lblURL.Text = "Enter URL ";
            // 
            // tbNumOfClones
            // 
            this.tbNumOfClones.Location = new System.Drawing.Point(192, 546);
            this.tbNumOfClones.Name = "tbNumOfClones";
            this.tbNumOfClones.Size = new System.Drawing.Size(26, 20);
            this.tbNumOfClones.TabIndex = 12;
            // 
            // lblClone
            // 
            this.lblClone.AutoSize = true;
            this.lblClone.Location = new System.Drawing.Point(98, 553);
            this.lblClone.Name = "lblClone";
            this.lblClone.Size = new System.Drawing.Size(88, 13);
            this.lblClone.TabIndex = 13;
            this.lblClone.Text = "Enter # of clones";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(100, 274);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Title";
            // 
            // lbISBN
            // 
            this.lbISBN.AutoSize = true;
            this.lbISBN.Location = new System.Drawing.Point(100, 305);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(72, 13);
            this.lbISBN.TabIndex = 15;
            this.lbISBN.Text = "ISBN Number";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(100, 330);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 16;
            this.lblAuthor.Text = "Author";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(100, 359);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 17;
            this.lblGenre.Text = "Genre";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(100, 390);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(82, 13);
            this.lblLocation.TabIndex = 18;
            this.lblLocation.Text = "Library Location";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(100, 416);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 19;
            this.lblVolume.Text = "Volume";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(203, 267);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 34;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(203, 298);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(100, 20);
            this.tbISBN.TabIndex = 27;
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(203, 409);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(100, 20);
            this.tbVolume.TabIndex = 29;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(203, 330);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbAuthor.TabIndex = 30;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(203, 356);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(100, 20);
            this.tbGenre.TabIndex = 31;
            // 
            // tbIssue
            // 
            this.tbIssue.Location = new System.Drawing.Point(203, 435);
            this.tbIssue.Name = "tbIssue";
            this.tbIssue.Size = new System.Drawing.Size(100, 20);
            this.tbIssue.TabIndex = 33;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(100, 442);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(32, 13);
            this.lblIssue.TabIndex = 32;
            this.lblIssue.Text = "Issue";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(100, 241);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(86, 13);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "Enter ID Number";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(203, 241);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 35;
            this.tbID.MouseLeave += new System.EventHandler(this.tbID_MouseLeave);
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "First Floor",
            "Second Floor",
            "Third Floor"});
            this.cbLocation.Location = new System.Drawing.Point(203, 382);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(100, 21);
            this.cbLocation.TabIndex = 37;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 800);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbIssue);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lbISBN);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblClone);
            this.Controls.Add(this.tbNumOfClones);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.gbBookOrEbook);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.cbClone);
            this.Controls.Add(this.cbItems);
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.gbBookOrEbook.ResumeLayout(false);
            this.gbBookOrEbook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.CheckBox cbClone;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbEbook;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.GroupBox gbBookOrEbook;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox tbNumOfClones;
        private System.Windows.Forms.Label lblClone;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbIssue;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbLocation;
    }
}