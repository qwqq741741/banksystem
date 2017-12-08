using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginAccountForm : Form
    {
        public LoginAccountForm()
        {
            InitializeComponent();
        }

        private void LoginAccounOKButton_Click(object sender, EventArgs e)
        {
            DbClass db = new DbClass();
            /*if (db.CheckTableIsExist() == false) {
                db.createTable();
            }*/
            string accountname = this.LoginAccountTextBox.Text.Trim();
            string accountpasswd = this.LoginAccountPasswd.Text.Trim();
            string accounttelephonenumber = this.telephonenumber.Text.Trim();
            string accountaddress = this.address.Text.Trim();
            if (accountname != null && accountpasswd != null && accounttelephonenumber != null && accountaddress != null)
            {
                int money = 0;
                if (db.CheckUser(accountname) == true)
                {
                    MessageBox.Show("The account has been registered!", "Prompt");
                    this.LoginAccountTextBox.Clear();
                    this.LoginAccountPasswd.Clear();
                    this.LoginAccountTextBox.Focus();
                }
                else
                {
                    db.addtoaccounttable(accountname, accountpasswd, money,accounttelephonenumber,accountaddress);
                    string operation = "Create an account：" + accountname;
                    int rid = db.getmaxrid() + 1;
                    db.insertinotRecord(rid,ClerkInfoClass.ClerkID,accountname,operation);
                }
            }
            else
            {
                MessageBox.Show("The input is free, please standardize the input!");
            }
            
        }
        
        private void LoginAccountCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form1 = new MainForm();
            form1.Show();
        }

        private void LoginAccountPasswd_Leave(object sender, EventArgs e)
        {
            int passwdlength = this.LoginAccountPasswd.Text.Length;
            if (passwdlength != 6)
            {
                this.LoginAccountPasswd.Clear();
                this.LoginAccountPasswd.Focus();
                MessageBox.Show("The password must be 6, please reenter it!", "Prompt");
            }
           
        }
        private void telephonenumber_Leave(object sender, EventArgs e)
        {
            int length = this.telephonenumber.Text.Length;
            if (length != 10)
            {
                this.telephonenumber.Clear();
                this.telephonenumber.Focus();
                MessageBox.Show("The phone is 10. Please reenter it!", "Prompt");
            }
        }
    }
}
