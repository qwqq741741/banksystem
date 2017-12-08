namespace WindowsFormsApp1
{
    partial class ClerkEnter
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
            this.ClerkIdTextBox = new System.Windows.Forms.TextBox();
            this.ClerkpasswdTextBox = new System.Windows.Forms.TextBox();
            this.clerkloginbutton = new System.Windows.Forms.Button();
            this.clerklogoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmployeePasswd";
            // 
            // ClerkIdTextBox
            // 
            this.ClerkIdTextBox.Location = new System.Drawing.Point(136, 55);
            this.ClerkIdTextBox.Name = "ClerkIdTextBox";
            this.ClerkIdTextBox.Size = new System.Drawing.Size(114, 21);
            this.ClerkIdTextBox.TabIndex = 2;
            // 
            // ClerkpasswdTextBox
            // 
            this.ClerkpasswdTextBox.Location = new System.Drawing.Point(136, 96);
            this.ClerkpasswdTextBox.Name = "ClerkpasswdTextBox";
            this.ClerkpasswdTextBox.Size = new System.Drawing.Size(114, 21);
            this.ClerkpasswdTextBox.TabIndex = 3;
            this.ClerkpasswdTextBox.UseSystemPasswordChar = true;
            // 
            // clerkloginbutton
            // 
            this.clerkloginbutton.Location = new System.Drawing.Point(37, 164);
            this.clerkloginbutton.Name = "clerkloginbutton";
            this.clerkloginbutton.Size = new System.Drawing.Size(75, 23);
            this.clerkloginbutton.TabIndex = 4;
            this.clerkloginbutton.Text = "Entry";
            this.clerkloginbutton.UseVisualStyleBackColor = true;
            this.clerkloginbutton.Click += new System.EventHandler(this.clerkloginbutton_Click);
            // 
            // clerklogoutbutton
            // 
            this.clerklogoutbutton.Location = new System.Drawing.Point(175, 164);
            this.clerklogoutbutton.Name = "clerklogoutbutton";
            this.clerklogoutbutton.Size = new System.Drawing.Size(75, 23);
            this.clerklogoutbutton.TabIndex = 5;
            this.clerklogoutbutton.Text = "Quit";
            this.clerklogoutbutton.UseVisualStyleBackColor = true;
            this.clerklogoutbutton.Click += new System.EventHandler(this.clerklogoutbutton_Click);
            // 
            // ClerkEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 224);
            this.Controls.Add(this.clerklogoutbutton);
            this.Controls.Add(this.clerkloginbutton);
            this.Controls.Add(this.ClerkpasswdTextBox);
            this.Controls.Add(this.ClerkIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClerkEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeEnter";
            this.Load += new System.EventHandler(this.ClerkEnter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClerkIdTextBox;
        private System.Windows.Forms.TextBox ClerkpasswdTextBox;
        private System.Windows.Forms.Button clerkloginbutton;
        private System.Windows.Forms.Button clerklogoutbutton;
    }
}