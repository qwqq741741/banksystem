namespace WindowsFormsApp1
{
    partial class QueryForm
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
            this.querytextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.querypasswdtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Querybutton = new System.Windows.Forms.Button();
            this.querybackbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // querytextBox
            // 
            this.querytextBox.Location = new System.Drawing.Point(110, 49);
            this.querytextBox.Name = "querytextBox";
            this.querytextBox.Size = new System.Drawing.Size(126, 21);
            this.querytextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passwd";
            // 
            // querypasswdtextBox
            // 
            this.querypasswdtextBox.Location = new System.Drawing.Point(110, 88);
            this.querypasswdtextBox.Name = "querypasswdtextBox";
            this.querypasswdtextBox.Size = new System.Drawing.Size(126, 21);
            this.querypasswdtextBox.TabIndex = 3;
            this.querypasswdtextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please enter the account and password:";
            // 
            // Querybutton
            // 
            this.Querybutton.Location = new System.Drawing.Point(45, 166);
            this.Querybutton.Name = "Querybutton";
            this.Querybutton.Size = new System.Drawing.Size(75, 23);
            this.Querybutton.TabIndex = 5;
            this.Querybutton.Text = "Query";
            this.Querybutton.UseVisualStyleBackColor = true;
            this.Querybutton.Click += new System.EventHandler(this.querybutton_Click);
            // 
            // querybackbutton
            // 
            this.querybackbutton.Location = new System.Drawing.Point(160, 165);
            this.querybackbutton.Name = "querybackbutton";
            this.querybackbutton.Size = new System.Drawing.Size(75, 23);
            this.querybackbutton.TabIndex = 6;
            this.querybackbutton.Text = "Back";
            this.querybackbutton.UseVisualStyleBackColor = true;
            this.querybackbutton.Click += new System.EventHandler(this.querybackbutton_Click);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 252);
            this.Controls.Add(this.querybackbutton);
            this.Controls.Add(this.Querybutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.querypasswdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.querytextBox);
            this.Controls.Add(this.label1);
            this.Name = "QueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox querytextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox querypasswdtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Querybutton;
        private System.Windows.Forms.Button querybackbutton;
    }
}