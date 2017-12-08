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
    public partial class AddMoneyForm : Form
    {
        public AddMoneyForm()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string username = this.addmoneynametextBox.Text.Trim();
            string passwd = this.addmoneypasswdtextBox.Text.Trim();
            int  money = Convert.ToInt16(this.addmoneynumtxb.Text.Trim());
            DbClass dbc = new DbClass();
            if (dbc.CheckUser(username) == true) 
            {
                dbc.addmoney(username, passwd, money);
                string operation = "Place money：" + money.ToString();
                int rid = dbc.getmaxrid() + 1;
                dbc.insertinotRecord(rid, ClerkInfoClass.ClerkID, username, operation);
            }
            else
            {
                MessageBox.Show("The account does not exist, please retype!");
            }

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form1 = new MainForm();
            form1.Show();
        }
    }
}
