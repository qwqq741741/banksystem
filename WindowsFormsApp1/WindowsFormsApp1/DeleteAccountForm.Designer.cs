namespace WindowsFormsApp1
{
    partial class DeleteAccountForm
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
            this.deleteAccountCancelButton = new System.Windows.Forms.Button();
            this.deleteAccounOKButton = new System.Windows.Forms.Button();
            this.deleteAccountPasswd = new System.Windows.Forms.TextBox();
            this.deleteAccountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteAccountCancelButton
            // 
            this.deleteAccountCancelButton.Location = new System.Drawing.Point(197, 206);
            this.deleteAccountCancelButton.Name = "deleteAccountCancelButton";
            this.deleteAccountCancelButton.Size = new System.Drawing.Size(75, 23);
            this.deleteAccountCancelButton.TabIndex = 11;
            this.deleteAccountCancelButton.Text = "Cancel";
            this.deleteAccountCancelButton.UseVisualStyleBackColor = true;
            this.deleteAccountCancelButton.Click += new System.EventHandler(this.deleteAccountCancelButton_Click);
            // 
            // deleteAccounOKButton
            // 
            this.deleteAccounOKButton.Location = new System.Drawing.Point(81, 206);
            this.deleteAccounOKButton.Name = "deleteAccounOKButton";
            this.deleteAccounOKButton.Size = new System.Drawing.Size(75, 23);
            this.deleteAccounOKButton.TabIndex = 10;
            this.deleteAccounOKButton.Text = "Confirm";
            this.deleteAccounOKButton.UseVisualStyleBackColor = true;
            this.deleteAccounOKButton.Click += new System.EventHandler(this.LoginAccounOKButton_Click);
            // 
            // deleteAccountPasswd
            // 
            this.deleteAccountPasswd.Location = new System.Drawing.Point(144, 134);
            this.deleteAccountPasswd.Name = "deleteAccountPasswd";
            this.deleteAccountPasswd.Size = new System.Drawing.Size(128, 21);
            this.deleteAccountPasswd.TabIndex = 9;
            this.deleteAccountPasswd.UseSystemPasswordChar = true;
            // 
            // deleteAccountTextBox
            // 
            this.deleteAccountTextBox.Location = new System.Drawing.Point(144, 84);
            this.deleteAccountTextBox.Name = "deleteAccountTextBox";
            this.deleteAccountTextBox.Size = new System.Drawing.Size(128, 21);
            this.deleteAccountTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Passwd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter the accounts and passwords to be destroyed!";
            // 
            // DeleteAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteAccountCancelButton);
            this.Controls.Add(this.deleteAccounOKButton);
            this.Controls.Add(this.deleteAccountPasswd);
            this.Controls.Add(this.deleteAccountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "DeleteAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteAccountCancelButton;
        private System.Windows.Forms.Button deleteAccounOKButton;
        private System.Windows.Forms.TextBox deleteAccountPasswd;
        private System.Windows.Forms.TextBox deleteAccountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}