namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Querymoneybutton = new System.Windows.Forms.Button();
            this.Addmoneybutton = new System.Windows.Forms.Button();
            this.Getmoneybutton = new System.Windows.Forms.Button();
            this.Loginaccountbutton = new System.Windows.Forms.Button();
            this.Delaccountbutton = new System.Windows.Forms.Button();
            this.Okbutton = new System.Windows.Forms.Button();
            this.Tuichubutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Querymoneybutton
            // 
            this.Querymoneybutton.Location = new System.Drawing.Point(85, 49);
            this.Querymoneybutton.Name = "Querymoneybutton";
            this.Querymoneybutton.Size = new System.Drawing.Size(119, 23);
            this.Querymoneybutton.TabIndex = 0;
            this.Querymoneybutton.Text = "QueryInformation";
            this.Querymoneybutton.UseVisualStyleBackColor = true;
            this.Querymoneybutton.Click += new System.EventHandler(this.querymoneybutton_Click);
            // 
            // Addmoneybutton
            // 
            this.Addmoneybutton.Location = new System.Drawing.Point(287, 49);
            this.Addmoneybutton.Name = "Addmoneybutton";
            this.Addmoneybutton.Size = new System.Drawing.Size(119, 23);
            this.Addmoneybutton.TabIndex = 1;
            this.Addmoneybutton.Text = "Deposit";
            this.Addmoneybutton.UseVisualStyleBackColor = true;
            this.Addmoneybutton.Click += new System.EventHandler(this.addmoneybutton_Click);
            // 
            // Getmoneybutton
            // 
            this.Getmoneybutton.Location = new System.Drawing.Point(287, 105);
            this.Getmoneybutton.Name = "Getmoneybutton";
            this.Getmoneybutton.Size = new System.Drawing.Size(119, 23);
            this.Getmoneybutton.TabIndex = 2;
            this.Getmoneybutton.Text = "DrawMoney";
            this.Getmoneybutton.UseVisualStyleBackColor = true;
            this.Getmoneybutton.Click += new System.EventHandler(this.getmoneybutton_Click);
            // 
            // Loginaccountbutton
            // 
            this.Loginaccountbutton.Location = new System.Drawing.Point(85, 164);
            this.Loginaccountbutton.Name = "Loginaccountbutton";
            this.Loginaccountbutton.Size = new System.Drawing.Size(119, 23);
            this.Loginaccountbutton.TabIndex = 3;
            this.Loginaccountbutton.Text = "RegisteredAccount";
            this.Loginaccountbutton.UseVisualStyleBackColor = true;
            this.Loginaccountbutton.Click += new System.EventHandler(this.loginaccountbutton_Click);
            // 
            // Delaccountbutton
            // 
            this.Delaccountbutton.Location = new System.Drawing.Point(287, 164);
            this.Delaccountbutton.Name = "Delaccountbutton";
            this.Delaccountbutton.Size = new System.Drawing.Size(119, 23);
            this.Delaccountbutton.TabIndex = 4;
            this.Delaccountbutton.Text = "DeleteAccount";
            this.Delaccountbutton.UseVisualStyleBackColor = true;
            this.Delaccountbutton.Click += new System.EventHandler(this.delaccountbutton_Click);
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(108, 227);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 23);
            this.Okbutton.TabIndex = 5;
            this.Okbutton.Text = "Confirm";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // Tuichubutton
            // 
            this.Tuichubutton.Location = new System.Drawing.Point(307, 227);
            this.Tuichubutton.Name = "Tuichubutton";
            this.Tuichubutton.Size = new System.Drawing.Size(75, 23);
            this.Tuichubutton.TabIndex = 6;
            this.Tuichubutton.Text = "Quit";
            this.Tuichubutton.UseVisualStyleBackColor = true;
            this.Tuichubutton.Click += new System.EventHandler(this.tuichubutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "QueryRecord";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tuichubutton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.Delaccountbutton);
            this.Controls.Add(this.Loginaccountbutton);
            this.Controls.Add(this.Getmoneybutton);
            this.Controls.Add(this.Addmoneybutton);
            this.Controls.Add(this.Querymoneybutton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Querymoneybutton;
        private System.Windows.Forms.Button Addmoneybutton;
        private System.Windows.Forms.Button Getmoneybutton;
        private System.Windows.Forms.Button Loginaccountbutton;
        private System.Windows.Forms.Button Delaccountbutton;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Button Tuichubutton;
        private System.Windows.Forms.Button button1;
    }
}

