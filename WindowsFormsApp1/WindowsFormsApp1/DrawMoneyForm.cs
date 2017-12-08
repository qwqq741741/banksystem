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
    public partial class DrawMoneyForm : Form
    {
        public DrawMoneyForm()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form1 = new MainForm();
            form1.Show();
        }

        private void drawmoneybutton_Click(object sender, EventArgs e)
        {
            string name = this.drawmoneynametextBox.Text.Trim();
            string passwd = this.drawmoneypasswdtextBox.Text.Trim();
            int money = Convert.ToInt16(this.drawmoneynumbertextBox.Text.Trim());
            DbClass dbClass = new DbClass();
            
            if (dbClass.CheckUser(name) == false)
            {
                MessageBox.Show("The account does not exist, please retype!");
            }
            else
            {
                if (dbClass.queryaccount(name, passwd) < money)
                {
                    MessageBox.Show("I'm sorry, the maximum amount of money is beyond the limit!");
                    this.drawmoneynumbertextBox.Clear();
                }
                else
                {
                    dbClass.drawmoney(name, passwd, money);
                    string operation = "Draw money：" + money.ToString();
                    int rid = dbClass.getmaxrid() + 1;
                    dbClass.insertinotRecord(rid, ClerkInfoClass.ClerkID,name,operation);
                }
                
            }
        }
    }
}
