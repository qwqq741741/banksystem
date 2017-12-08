namespace WindowsFormsApp1
{
    partial class LoginAccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginAccountTextBox = new System.Windows.Forms.TextBox();
            this.LoginAccountPasswd = new System.Windows.Forms.TextBox();
            this.LoginAccounOKButton = new System.Windows.Forms.Button();
            this.LoginAccountCancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.telephonenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwd";
            // 
            // LoginAccountTextBox
            // 
            this.LoginAccountTextBox.Location = new System.Drawing.Point(184, 44);
            this.LoginAccountTextBox.Name = "LoginAccountTextBox";
            this.LoginAccountTextBox.Size = new System.Drawing.Size(128, 21);
            this.LoginAccountTextBox.TabIndex = 2;
            // 
            // LoginAccountPasswd
            // 
            this.LoginAccountPasswd.Location = new System.Drawing.Point(184, 94);
            this.LoginAccountPasswd.Name = "LoginAccountPasswd";
            this.LoginAccountPasswd.Size = new System.Drawing.Size(128, 21);
            this.LoginAccountPasswd.TabIndex = 3;
            this.LoginAccountPasswd.UseSystemPasswordChar = true;
            this.LoginAccountPasswd.Leave += new System.EventHandler(this.LoginAccountPasswd_Leave);
            // 
            // LoginAccounOKButton
            // 
            this.LoginAccounOKButton.Location = new System.Drawing.Point(108, 276);
            this.LoginAccounOKButton.Name = "LoginAccounOKButton";
            this.LoginAccounOKButton.Size = new System.Drawing.Size(75, 23);
            this.LoginAccounOKButton.TabIndex = 4;
            this.LoginAccounOKButton.Text = "Confirm";
            this.LoginAccounOKButton.UseVisualStyleBackColor = true;
            this.LoginAccounOKButton.Click += new System.EventHandler(this.LoginAccounOKButton_Click);
            // 
            // LoginAccountCancelButton
            // 
            this.LoginAccountCancelButton.Location = new System.Drawing.Point(237, 276);
            this.LoginAccountCancelButton.Name = "LoginAccountCancelButton";
            this.LoginAccountCancelButton.Size = new System.Drawing.Size(75, 23);
            this.LoginAccountCancelButton.TabIndex = 5;
            this.LoginAccountCancelButton.Text = "Cancel";
            this.LoginAccountCancelButton.UseVisualStyleBackColor = true;
            this.LoginAccountCancelButton.Click += new System.EventHandler(this.LoginAccountCancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phonenumber";
            // 
            // telephonenumber
            // 
            this.telephonenumber.Location = new System.Drawing.Point(184, 146);
            this.telephonenumber.Name = "telephonenumber";
            this.telephonenumber.Size = new System.Drawing.Size(128, 21);
            this.telephonenumber.TabIndex = 9;
            this.telephonenumber.Leave += new System.EventHandler(this.telephonenumber_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(184, 193);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(128, 21);
            this.address.TabIndex = 11;
            // 
            // LoginAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 332);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telephonenumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginAccountCancelButton);
            this.Controls.Add(this.LoginAccounOKButton);
            this.Controls.Add(this.LoginAccountPasswd);
            this.Controls.Add(this.LoginAccountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginAccountTextBox;
        private System.Windows.Forms.TextBox LoginAccountPasswd;
        private System.Windows.Forms.Button LoginAccounOKButton;
        private System.Windows.Forms.Button LoginAccountCancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telephonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address;
    }
}