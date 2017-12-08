namespace WindowsFormsApp1
{
    partial class AddMoneyForm
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
            this.addmoneynametextBox = new System.Windows.Forms.TextBox();
            this.addmoneypasswdtextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addmoneynumtxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwd";
            // 
            // addmoneynametextBox
            // 
            this.addmoneynametextBox.Location = new System.Drawing.Point(127, 28);
            this.addmoneynametextBox.Name = "addmoneynametextBox";
            this.addmoneynametextBox.Size = new System.Drawing.Size(123, 21);
            this.addmoneynametextBox.TabIndex = 2;
            // 
            // addmoneypasswdtextBox
            // 
            this.addmoneypasswdtextBox.Location = new System.Drawing.Point(127, 79);
            this.addmoneypasswdtextBox.Name = "addmoneypasswdtextBox";
            this.addmoneypasswdtextBox.Size = new System.Drawing.Size(123, 21);
            this.addmoneypasswdtextBox.TabIndex = 3;
            this.addmoneypasswdtextBox.UseSystemPasswordChar = true;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(37, 202);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 6;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(175, 202);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number";
            // 
            // addmoneynumtxb
            // 
            this.addmoneynumtxb.Location = new System.Drawing.Point(127, 119);
            this.addmoneynumtxb.Name = "addmoneynumtxb";
            this.addmoneynumtxb.Size = new System.Drawing.Size(123, 21);
            this.addmoneynumtxb.TabIndex = 9;
            // 
            // AddMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 277);
            this.Controls.Add(this.addmoneynumtxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.addmoneypasswdtextBox);
            this.Controls.Add(this.addmoneynametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addmoneynametextBox;
        private System.Windows.Forms.TextBox addmoneypasswdtextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addmoneynumtxb;
    }
}