namespace WindowsFormsApp1
{
    partial class DrawMoneyForm
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
            this.cancelbutton = new System.Windows.Forms.Button();
            this.drawmoneybutton = new System.Windows.Forms.Button();
            this.drawmoneynumbertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drawmoneypasswdtextBox = new System.Windows.Forms.TextBox();
            this.drawmoneynametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(201, 245);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 15;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // drawmoneybutton
            // 
            this.drawmoneybutton.Location = new System.Drawing.Point(63, 245);
            this.drawmoneybutton.Name = "drawmoneybutton";
            this.drawmoneybutton.Size = new System.Drawing.Size(75, 23);
            this.drawmoneybutton.TabIndex = 14;
            this.drawmoneybutton.Text = "Draw";
            this.drawmoneybutton.UseVisualStyleBackColor = true;
            this.drawmoneybutton.Click += new System.EventHandler(this.drawmoneybutton_Click);
            // 
            // drawmoneynumbertextBox
            // 
            this.drawmoneynumbertextBox.Location = new System.Drawing.Point(153, 148);
            this.drawmoneynumbertextBox.Name = "drawmoneynumbertextBox";
            this.drawmoneynumbertextBox.Size = new System.Drawing.Size(123, 21);
            this.drawmoneynumbertextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amount";
            // 
            // drawmoneypasswdtextBox
            // 
            this.drawmoneypasswdtextBox.Location = new System.Drawing.Point(153, 105);
            this.drawmoneypasswdtextBox.Name = "drawmoneypasswdtextBox";
            this.drawmoneypasswdtextBox.Size = new System.Drawing.Size(123, 21);
            this.drawmoneypasswdtextBox.TabIndex = 11;
            this.drawmoneypasswdtextBox.UseSystemPasswordChar = true;
            // 
            // drawmoneynametextBox
            // 
            this.drawmoneynametextBox.Location = new System.Drawing.Point(153, 54);
            this.drawmoneynametextBox.Name = "drawmoneynametextBox";
            this.drawmoneynametextBox.Size = new System.Drawing.Size(123, 21);
            this.drawmoneynametextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Passwd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Account";
            // 
            // DrawMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 353);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.drawmoneybutton);
            this.Controls.Add(this.drawmoneynumbertextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drawmoneypasswdtextBox);
            this.Controls.Add(this.drawmoneynametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "DrawMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawMoneyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button drawmoneybutton;
        private System.Windows.Forms.TextBox drawmoneynumbertextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drawmoneypasswdtextBox;
        private System.Windows.Forms.TextBox drawmoneynametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}