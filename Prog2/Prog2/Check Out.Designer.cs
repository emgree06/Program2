namespace LibraryItems
{
    partial class Check_Out
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
            this.selectItem_Label = new System.Windows.Forms.Label();
            this.item_ComboBox = new System.Windows.Forms.ComboBox();
            this.select_Patron_Label = new System.Windows.Forms.Label();
            this.patron_ComboBox = new System.Windows.Forms.ComboBox();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.ok_Button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // selectItem_Label
            // 
            this.selectItem_Label.AutoSize = true;
            this.selectItem_Label.Location = new System.Drawing.Point(39, 40);
            this.selectItem_Label.Name = "selectItem_Label";
            this.selectItem_Label.Size = new System.Drawing.Size(63, 13);
            this.selectItem_Label.TabIndex = 0;
            this.selectItem_Label.Text = "Select Item:";
            // 
            // item_ComboBox
            // 
            this.item_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.item_ComboBox.FormattingEnabled = true;
            this.item_ComboBox.Location = new System.Drawing.Point(42, 69);
            this.item_ComboBox.Name = "item_ComboBox";
            this.item_ComboBox.Size = new System.Drawing.Size(272, 21);
            this.item_ComboBox.TabIndex = 1;
            this.item_ComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.item_ComboBox_Validating);
            this.item_ComboBox.Validated += new System.EventHandler(this.item_ComboBox_Validated);
            // 
            // select_Patron_Label
            // 
            this.select_Patron_Label.AutoSize = true;
            this.select_Patron_Label.Location = new System.Drawing.Point(43, 128);
            this.select_Patron_Label.Name = "select_Patron_Label";
            this.select_Patron_Label.Size = new System.Drawing.Size(74, 13);
            this.select_Patron_Label.TabIndex = 2;
            this.select_Patron_Label.Text = "Select Patron:";
            // 
            // patron_ComboBox
            // 
            this.patron_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patron_ComboBox.FormattingEnabled = true;
            this.patron_ComboBox.Location = new System.Drawing.Point(46, 166);
            this.patron_ComboBox.Name = "patron_ComboBox";
            this.patron_ComboBox.Size = new System.Drawing.Size(175, 21);
            this.patron_ComboBox.TabIndex = 3;
            this.patron_ComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.patron_combobox_Validating);
            this.patron_ComboBox.Validated += new System.EventHandler(this.patron_combobox_Validated);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(211, 209);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.cancel_Button.TabIndex = 5;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CnclBtn_MouseDown);
            // 
            // ok_Button
            // 
            this.ok_Button.Location = new System.Drawing.Point(46, 209);
            this.ok_Button.Name = "ok_Button";
            this.ok_Button.Size = new System.Drawing.Size(75, 23);
            this.ok_Button.TabIndex = 6;
            this.ok_Button.Text = "OK";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(this.ok_Button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Check_Out
            // 
            this.AcceptButton = this.ok_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 256);
            this.Controls.Add(this.ok_Button);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.patron_ComboBox);
            this.Controls.Add(this.select_Patron_Label);
            this.Controls.Add(this.item_ComboBox);
            this.Controls.Add(this.selectItem_Label);
            this.Name = "Check_Out";
            this.Text = "Check Out";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectItem_Label;
        private System.Windows.Forms.Label select_Patron_Label;
        internal System.Windows.Forms.ComboBox item_ComboBox;
        internal System.Windows.Forms.ComboBox patron_ComboBox;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button ok_Button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}