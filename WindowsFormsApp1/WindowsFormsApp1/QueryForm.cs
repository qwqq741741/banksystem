using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void querybackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form1 = new MainForm();
            form1.Show();
        }

        private void querybutton_Click(object sender, EventArgs e)
        {
            int money = 0;
            String accountname = this.querytextBox.Text.Trim();
            string accountpasswd = this.querypasswdtextBox.Text.Trim();
            DbClass dbquery = new DbClass();
            if (dbquery.CheckUser(accountname) == false)
            {
                MessageBox.Show("The account does not exist, please retype!");
                this.querytextBox.Clear();
                this.querypasswdtextBox.Clear();
                this.querytextBox.Focus();
            }
            else
            {
                
                money = dbquery.queryaccount(accountname,accountpasswd);
                string phone= dbquery.queryphone(accountname, accountpasswd);
                string address = dbquery.queryaddress(accountname, accountpasswd);
                if (money == -1)
                {
                    MessageBox.Show("The password is incorrect, please reenter it!");
                    this.querypasswdtextBox.Clear();
                    this.querytextBox.Focus();
                }
                else
                {
                    string balance = money.ToString();
                    MessageBox.Show("Account balance:" + money.ToString()+"\n"+"\n"+"Phone："+phone+"\n"+"Address："+address, "Query result");
                }
               
            }
        }
    }
}
