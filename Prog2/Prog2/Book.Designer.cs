namespace LibraryItems
{
    partial class Book
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
            this.components = new System.ComponentModel.Container();
            this.ttitleLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.loanPeriodLabel = new System.Windows.Forms.Label();
            this.callNumLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.publisherTxt = new System.Windows.Forms.TextBox();
            this.copyrightTxt = new System.Windows.Forms.TextBox();
            this.loanPeriodTxt = new System.Windows.Forms.TextBox();
            this.callNumberTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // ttitleLabel
            // 
            this.ttitleLabel.AutoSize = true;
            this.ttitleLabel.Location = new System.Drawing.Point(48, 37);
            this.ttitleLabel.Name = "ttitleLabel";
            this.ttitleLabel.Size = new System.Drawing.Size(30, 13);
            this.ttitleLabel.TabIndex = 0;
            this.ttitleLabel.Text = "Title:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(24, 73);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(53, 13);
            this.publisherLabel.TabIndex = 1;
            this.publisherLabel.Text = "Publisher:";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(23, 108);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(54, 13);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright:";
            // 
            // loanPeriodLabel
            // 
            this.loanPeriodLabel.AutoSize = true;
            this.loanPeriodLabel.Location = new System.Drawing.Point(12, 151);
            this.loanPeriodLabel.Name = "loanPeriodLabel";
            this.loanPeriodLabel.Size = new System.Drawing.Size(67, 13);
            this.loanPeriodLabel.TabIndex = 3;
            this.loanPeriodLabel.Text = "Loan Period:";
            // 
            // callNumLabel
            // 
            this.callNumLabel.AutoSize = true;
            this.callNumLabel.Location = new System.Drawing.Point(12, 188);
            this.callNumLabel.Name = "callNumLabel";
            this.callNumLabel.Size = new System.Drawing.Size(67, 13);
            this.callNumLabel.TabIndex = 4;
            this.callNumLabel.Text = "Call Number:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(36, 225);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 5;
            this.authorLabel.Text = "Author:";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(103, 30);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(100, 20);
            this.TitleTxt.TabIndex = 6;
            this.TitleTxt.Validating += new System.ComponentModel.CancelEventHandler(this.TitleInput_Validating);
            this.TitleTxt.Validated += new System.EventHandler(this.TitleInput_Validated);
            // 
            // publisherTxt
            // 
            this.publisherTxt.Location = new System.Drawing.Point(103, 66);
            this.publisherTxt.Name = "publisherTxt";
            this.publisherTxt.Size = new System.Drawing.Size(100, 20);
            this.publisherTxt.TabIndex = 7;
            this.publisherTxt.Validating += new System.ComponentModel.CancelEventHandler(this.PublisherInput__Validating);
            this.publisherTxt.Validated += new System.EventHandler(this.PublisherInput_Validated);
            // 
            // copyrightTxt
            // 
            this.copyrightTxt.Location = new System.Drawing.Point(103, 105);
            this.copyrightTxt.Name = "copyrightTxt";
            this.copyrightTxt.Size = new System.Drawing.Size(100, 20);
            this.copyrightTxt.TabIndex = 8;
            this.copyrightTxt.Validating += new System.ComponentModel.CancelEventHandler(this.Copyright_Validating);
            this.copyrightTxt.Validated += new System.EventHandler(this.Copyright_Validated);
            // 
            // loanPeriodTxt
            // 
            this.loanPeriodTxt.Location = new System.Drawing.Point(103, 144);
            this.loanPeriodTxt.Name = "loanPeriodTxt";
            this.loanPeriodTxt.Size = new System.Drawing.Size(100, 20);
            this.loanPeriodTxt.TabIndex = 9;
            this.loanPeriodTxt.Validating += new System.ComponentModel.CancelEventHandler(this.LoanPeriod_Validating);
            this.loanPeriodTxt.Validated += new System.EventHandler(this.LoanPeriod_Validated);
            // 
            // callNumberTxt
            // 
            this.callNumberTxt.Location = new System.Drawing.Point(103, 181);
            this.callNumberTxt.Name = "callNumberTxt";
            this.callNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.callNumberTxt.TabIndex = 10;
            this.callNumberTxt.Validating += new System.ComponentModel.CancelEventHandler(this.CallNum_Validating);
            this.callNumberTxt.Validated += new System.EventHandler(this.CallNum_Validated);
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(103, 218);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(100, 20);
            this.authorTxt.TabIndex = 11;
            this.authorTxt.Validating += new System.ComponentModel.CancelEventHandler(this.Author_Validating);
            this.authorTxt.Validated += new System.EventHandler(this.Author_Validated);
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(51, 281);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 12;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(163, 281);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 13;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // Book
            // 
            this.AcceptButton = this.OK_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.callNumberTxt);
            this.Controls.Add(this.loanPeriodTxt);
            this.Controls.Add(this.copyrightTxt);
            this.Controls.Add(this.publisherTxt);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.callNumLabel);
            this.Controls.Add(this.loanPeriodLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.ttitleLabel);
            this.Name = "Book";
            this.Text = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ttitleLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label loanPeriodLabel;
        private System.Windows.Forms.Label callNumLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.TextBox publisherTxt;
        private System.Windows.Forms.TextBox copyrightTxt;
        private System.Windows.Forms.TextBox loanPeriodTxt;
        private System.Windows.Forms.TextBox callNumberTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}