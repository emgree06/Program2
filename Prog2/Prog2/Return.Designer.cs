namespace LibraryItems
{
    partial class Return
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
            this.return_Item_ComboBox = new System.Windows.Forms.ComboBox();
            this.return_Label = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ok_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // return_Item_ComboBox
            // 
            this.return_Item_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.return_Item_ComboBox.FormattingEnabled = true;
            this.return_Item_ComboBox.Location = new System.Drawing.Point(50, 94);
            this.return_Item_ComboBox.Name = "return_Item_ComboBox";
            this.return_Item_ComboBox.Size = new System.Drawing.Size(195, 21);
            this.return_Item_ComboBox.TabIndex = 0;
            this.return_Item_ComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.return_Item_ComboBox_Validating);
            this.return_Item_ComboBox.Validated += new System.EventHandler(this.return_Item_ComboBox_Validated);
            // 
            // return_Label
            // 
            this.return_Label.AutoSize = true;
            this.return_Label.Location = new System.Drawing.Point(47, 48);
            this.return_Label.Name = "return_Label";
            this.return_Label.Size = new System.Drawing.Size(110, 13);
            this.return_Label.TabIndex = 1;
            this.return_Label.Text = "Select Item to Return:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ok_Button
            // 
            this.ok_Button.Location = new System.Drawing.Point(36, 176);
            this.ok_Button.Name = "ok_Button";
            this.ok_Button.Size = new System.Drawing.Size(75, 23);
            this.ok_Button.TabIndex = 2;
            this.ok_Button.Text = "OK";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(this.ok_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(150, 176);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 3;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CnclBtn_MouseDown);
            // 
            // Return
            // 
            this.AcceptButton = this.ok_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.ok_Button);
            this.Controls.Add(this.return_Label);
            this.Controls.Add(this.return_Item_ComboBox);
            this.Name = "Return";
            this.Text = "Return";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox return_Item_ComboBox;
        private System.Windows.Forms.Label return_Label;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button ok_Button;
    }
}