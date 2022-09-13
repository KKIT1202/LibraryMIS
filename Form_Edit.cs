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
    public partial class Form_Edit : Form
    {
        string DataConn = Properties.Settings.Default.conn;//連線SQL路徑 (MS SQL)
        string LocalDB_conn = Properties.Settings.Default.conn;//連線SQL路徑

        public string sqlUpdate = "";//SQL語法

        /// <summary>
        /// 載入視窗同時帶入 Mail & 姓名
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="name"></param>
        public Form_Edit(string mail,string name)
        {
            InitializeComponent();
            LB_Mail.Text = mail;//載入Mail
            TB_NewName.Text = name;//載入姓名
        }


        /// <summary>
        /// 儲存按鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(LocalDB_conn))
            {

                sqlUpdate = $"UPDATE names SET name = '{TB_NewName.Text}' ,password = '{TB_NewPassWord.Text}' FROM names WHERE mail like '{LB_Mail.Text}'";

                cn.ConnectionString = LocalDB_conn;
                cn.Open();
                if (TB_NewPassWord.Text != "" && TB_NewName.Text != "")
                {
                    var YesNO = MessageBox.Show("確認資料是否正確", "儲存確認", MessageBoxButtons.YesNo);
                    if (YesNO == DialogResult.Yes)
                    {
                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, cn);
                        SqlDataReader dataReader_Update = cmdUpdate.ExecuteReader();
                        cmdUpdate.Dispose();
                        dataReader_Update.Close();
                        LB_Save.Text = "儲存完成";
                    }
                }
                else
                {
                    MessageBox.Show("密碼 或 姓名 不得為空白!");
                }
                cn.Close();
            }
        }


        /// <summary>
        /// 關閉編輯個人資料視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
