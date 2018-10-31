namespace LibraryItems
{
    partial class Patron_Form
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
            this.patron_Name_Label = new System.Windows.Forms.Label();
            this.patron_ID_Label = new System.Windows.Forms.Label();
            this.patronNameInputTxt = new System.Windows.Forms.TextBox();
            this.patronIDInputTxt = new System.Windows.Forms.TextBox();
            this.OK_Butoon = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // patron_Name_Label
            // 
            this.patron_Name_Label.AutoSize = true;
            this.patron_Name_Label.Location = new System.Drawing.Point(35, 27);
            this.patron_Name_Label.Name = "patron_Name_Label";
            this.patron_Name_Label.Size = new System.Drawing.Size(38, 13);
            this.patron_Name_Label.TabIndex = 0;
            this.patron_Name_Label.Text = "Name:";
            // 
            // patron_ID_Label
            // 
            this.patron_ID_Label.AutoSize = true;
            this.patron_ID_Label.Location = new System.Drawing.Point(52, 73);
            this.patron_ID_Label.Name = "patron_ID_Label";
            this.patron_ID_Label.Size = new System.Drawing.Size(21, 13);
            this.patron_ID_Label.TabIndex = 1;
            this.patron_ID_Label.Text = "ID:";
            // 
            // patronNameInputTxt
            // 
            this.patronNameInputTxt.Location = new System.Drawing.Point(94, 20);
            this.patronNameInputTxt.Name = "patronNameInputTxt";
            this.patronNameInputTxt.Size = new System.Drawing.Size(100, 20);
            this.patronNameInputTxt.TabIndex = 2;
            this.patronNameInputTxt.Validating += new System.ComponentModel.CancelEventHandler(this.patronNameInput_Validating);
            this.patronNameInputTxt.Validated += new System.EventHandler(this.patronName_Validated);
            // 
            // patronIDInputTxt
            // 
            this.patronIDInputTxt.Location = new System.Drawing.Point(94, 66);
            this.patronIDInputTxt.Name = "patronIDInputTxt";
            this.patronIDInputTxt.Size = new System.Drawing.Size(100, 20);
            this.patronIDInputTxt.TabIndex = 3;
            this.patronIDInputTxt.Validating += new System.ComponentModel.CancelEventHandler(this.patronID_Validating);
            this.patronIDInputTxt.Validated += new System.EventHandler(this.patronID_Validated);
            // 
            // OK_Butoon
            // 
            this.OK_Butoon.Location = new System.Drawing.Point(38, 124);
            this.OK_Butoon.Name = "OK_Butoon";
            this.OK_Butoon.Size = new System.Drawing.Size(75, 23);
            this.OK_Butoon.TabIndex = 4;
            this.OK_Butoon.Text = "Okay";
            this.OK_Butoon.UseVisualStyleBackColor = true;
            this.OK_Butoon.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(173, 124);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Patron_Form
            // 
            this.AcceptButton = this.OK_Butoon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Butoon);
            this.Controls.Add(this.patronIDInputTxt);
            this.Controls.Add(this.patronNameInputTxt);
            this.Controls.Add(this.patron_ID_Label);
            this.Controls.Add(this.patron_Name_Label);
            this.Name = "Patron_Form";
            this.Text = "Patron Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patron_Name_Label;
        private System.Windows.Forms.Label patron_ID_Label;
        private System.Windows.Forms.TextBox patronNameInputTxt;
        private System.Windows.Forms.TextBox patronIDInputTxt;
        private System.Windows.Forms.Button OK_Butoon;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}