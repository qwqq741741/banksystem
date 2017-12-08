using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DbClass
    {
        string strConnection = "Integrated Security=SSPI;Initial Catalog=bank1;Data Source=YLMF-1611271519;User ID=YLMF-1611271519\\Administrator;";
        //static string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
        /***************************************
       
        * Here is the management of the user accounts
        * All of the accounts can not be registered , so we just add some accouts in our database.
        ****************************************/
        public bool CheckBankClerkTableIsExist()
        {
            int i1 = 0;
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = "SELECT COUNT(*) as row FROM sys.objects WHERE type='U' AND name='BankClerk'";
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    i1 = Convert.ToInt32(ds.Tables[0].Rows[0]["row"].ToString());

                }
                catch { }
                if (i1 == 1)
                {
                    
                    return true;
                }
                else
                {
                    createBankClerkTable();
                    

                    return false;
                }
            }
        }
        //Crate a BankClerk table
        public void createBankClerkTable()
        {
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = "use bank1 create table BankClerk(clerkid char(20) primary key, passwd char(20) not null,name char(10) not null); ";
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {

                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    objConnection.Close();
                }
                catch { }

            }
        }
        //Adjust the account and password
        public bool CheckBank(string id, string passwd)
        {
            object i = null;
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("SELECT clerkid  FROM  dbo.BankClerk WHERE  clerkid = '{0} ' AND passwd='{1}' ",id,passwd);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    i = ds.Tables[0].Rows[0]["clerkid"].ToString();
                    objConnection.Close();
                }
                catch { }
                if (i != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //Get the name of the account
        public string queryclerkname(string id, string passwd)
        {
            string s = null;
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("SELECT name  FROM  dbo.BankClerk WHERE  clerkid = '{0} ' AND passwd='{1}' ", id, passwd);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    s = ds.Tables[0].Rows[0]["name"].ToString();
                    objConnection.Close();
                }
                catch { }
                if (s != null)
                {

                    return s;
                }
                else
                {

                    return null;
                }
            }
        }
        /***************************************
        ****************************************/
        //Adujst if there is a table named "account" in the database
        public bool CheckTableIsExist()
        {
            int i1 = 0;
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = "SELECT COUNT(*) as row FROM sys.objects WHERE type='U' AND name='account'";
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    i1 = Convert.ToInt32(ds.Tables[0].Rows[0]["row"].ToString());
                    
                }
                catch { }
                if (i1 == 1)
                {
                    //MessageBox.Show("yes", "yes");
                    return true;
                }
                else
                {
                    createTable();
                    //MessageBox.Show("no", "no");

                    return false;
                }
            }
        }
        //Create an account table
        public void createTable()
        {
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = "use bank1 create table account(account char(20) primary key,passwd char(20) not null,money smallint not null,phone char(11) not null,address varchar(100) not null); ";
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {

                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    objConnection.Close();
                }
                catch { }

            }
        }
        //Queery the account
        public bool CheckUser(String id)
        {
            object i =null;
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("SELECT account  FROM  dbo.account WHERE  account = '{0} '", id);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    i = ds.Tables[0].Rows[0]["account"].ToString();
                    objConnection.Close();
                }
                catch { }
                if (i !=null)
                {
                    //MessageBox.Show("cunzai", "yes");
                    return true;
                }
                else
                {
                    //createTable();
                    //MessageBox.Show("no", "no");
                    return false;
                }
            }
        }
        //Register
        public void addtoaccounttable(string name,string passwd,int money,string phone,string address)
        {
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("use bank1 insert into dbo.account(account, passwd, money, phone, address) values('{0}', '{1}', {2}, '{3}', '{4}'); ", name,passwd,money,phone,address);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    objConnection.Close();
                    MessageBox.Show("Login was successful", "Prompt");
                }
                catch { }
            }
        }
        //The balance
        public int queryaccount(string name,string passwd)
        {
            int m=-1;
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("SELECT money  FROM  dbo.account WHERE  account = '{0}' AND passwd='{1}';", name,passwd);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    m =Convert.ToInt16(ds.Tables[0].Rows[0]["money"].ToString());
                    objConnection.Close();
                }
                catch { }
                if (m>=0)
                {
                    
                    return m;
                }
                else
                {
                   
                    return -1;
                }
            }
        }
        //Phone numbr
        public string queryphone(string name, string passwd)
        {
            string s = null;
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("SELECT phone  FROM  dbo.account WHERE  account = '{0}' AND passwd='{1}';", name, passwd);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    s = ds.Tables[0].Rows[0]["phone"].ToString();
                    objConnection.Close();
                }
                catch { }
                if (s != null)
                {

                    return s;
                }
                else
                {

                    return null;
                }
            }
        }
        //Address
        public string queryaddress(string name, string passwd)
        {
            string s = null;
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("SELECT address  FROM  dbo.account WHERE  account = '{0}' AND passwd='{1}';", name, passwd);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    s = ds.Tables[0].Rows[0]["address"].ToString();
                    objConnection.Close();
                }
                catch { }
                if (s != null)
                {

                    return s;
                }
                else
                {

                    return null;
                }
            }
        }
        //Save money
        public void addmoney(string name, string passwd, int money)
        {
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("update dbo.account set money = money + {2} where account = '{0}' and passwd = '{1}'; ", name, passwd, money);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    objConnection.Close();
                    int  finalmoney = queryaccount(name, passwd);
                    MessageBox.Show("Current balance：" + finalmoney);
                }
                catch { }
            }
        }
        public void drawmoney(string name, string passwd, int money)
        {
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("update dbo.account set money = money - {2} where account = '{0}' and passwd = '{1}'; ", name, passwd, money);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    objConnection.Close();
                    int finalmoney = queryaccount(name, passwd);
                    MessageBox.Show("Current balance：" + finalmoney);
                }
                catch { }
            }
        }
        public void deleteAccount(string name, string passwd)
        {
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("delete from dbo.account where account = '{0}' and passwd = '{1}'; ", name, passwd);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    objConnection.Close();
                }
                catch { }
            }
        }
        /**********************************************
         *********************************************/
        public bool CheckRecordTableIsExist()
        {
            int i1 = 0;
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = "SELECT COUNT(*) as row FROM sys.objects WHERE type='U' AND name='Record'";
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    i1 = Convert.ToInt32(ds.Tables[0].Rows[0]["row"].ToString());

                }
                catch { }
                if (i1 == 1)
                {

                    return true;
                }
                else
                {
                    createRecordTable();
                    return false;
                }
            }
        }
        //Create a Record table
        public void createRecordTable()
        {
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = "use bank1 " +
                "create table Record" +
                "(rid int primary key, " +
                "clerkid char(20), " +
                "account char(20), " +
                "operation varchar(100));" ;
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {

                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    objConnection.Close();
                }
                catch { }

            }
        }
        //Recording
        public void startinsertinotRecord(int rid, string clerkid, string account, string operation)
        {
            string sql = string.Format("insert into dbo.Record(rid, clerkid, account, operation) " +
                "values({0}, '{1}', '{2}', '{3}'); ", rid, clerkid, account, operation);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    objConnection.Close();
                }
                catch { }
            }
        }
        //
        public void insertinotRecord(int rid,string clerkid,string account,string operation)
        {
            string sql = string.Format("insert into dbo.Record(rid, clerkid, account, operation) " +
                "values({0}, '{1}', '{2}', '{3}'); ",rid,clerkid,account,operation);
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    objConnection.Close();
                }
                catch { }
            }
        }
        //
        public int getmaxrid()
        {
            int m = -1;
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("select MAX(rid) as rid from dbo.Record;");
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    m = Convert.ToInt16(ds.Tables[0].Rows[0]["rid"].ToString());
                    objConnection.Close();
                }
                catch { }
                if (m >= 0)
                {

                    return m;
                }
                else
                {

                    return -1;
                }
            }
        }

    }
}
