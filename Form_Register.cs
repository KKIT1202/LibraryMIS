using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Librarian2._0._1
{
    public partial class Form_Register : Form
    {
        string DataConn = Properties.Settings.Default.conn;//連線SQL路徑 (MS SQL)
        string LocalDB_conn = Properties.Settings.Default.conn;//連線SQL路徑
        public string sqlSearch = "";//SQL語法
        public string sqlInsert = "";//SQL語法

        public Form_Register()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 註冊按鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(LocalDB_conn))
            {
                sqlSearch = $"Select * From names Where mail like '{TB_Mail.Text}'";
                sqlInsert = $"INSERT INTO names VALUES ('{TB_Name.Text}','{TB_Mail.Text}','{TB_PassWord.Text}')";

                cn.ConnectionString = LocalDB_conn;
                cn.Open();
                SqlCommand cmdSearch = new SqlCommand(sqlSearch, cn);
                cmdSearch.Parameters.Clear();
                SqlDataReader dataReader_Search = cmdSearch.ExecuteReader();
                if (dataReader_Search.HasRows == false)
                {
                    cmdSearch.Dispose();//釋放
                    dataReader_Search.Close();//關閉Read

                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, cn);
                    SqlDataReader dataReader_Insert = cmdInsert.ExecuteReader();
                    dataReader_Insert.Read();
                    dataReader_Insert.Close();
                    cmdInsert.Dispose();
                    LB_State.Text = "註冊成功";
                    TB_Mail.Enabled = false;
                    TB_Name.Enabled = false;
                    TB_PassWord.Enabled = false;
                    CB_Agree.Enabled = false;
                    BTN_Submit.Enabled = false;
                }
                else
                {
                    MessageBox.Show("該信箱已被註冊");
                }
                cn.Close();
            }
        }

        /// <summary>
        /// 關閉建立帳號視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 同意相關條例_勾選
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Agree_CheckedChanged(object sender, EventArgs e)
        {
            BTN_Submit.Enabled = CB_Agree.Checked;
        }
    }
}
