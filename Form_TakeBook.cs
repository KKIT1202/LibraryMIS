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
    public partial class Form_TakeBook : Form
    {
        string DataConn = Properties.Settings.Default.conn;//連線SQL路徑 (MS SQL)
        string LocalDB_conn = Properties.Settings.Default.conn;//連線SQL路徑
        string sqlSearch = "";//SQL語法
        string sqlUpdate = "";//SQL語法
        string sql_log_Insert = "";//SQL語法

        /// <summary>
        /// 載入視窗同時帶入 user & ID
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserID"></param>
        public Form_TakeBook(string UserName , string UserID)
        {
            InitializeComponent();
            LB_UserName.Text = UserName;
            LB_UserID.Text = UserID;
        }

        /// <summary>
        /// 借書按鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_TakeBook_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(LocalDB_conn))
            {
                sqlSearch = $"SELECT * FROM books WHERE booksID like '{TB_BookID.Text}'";
                sqlUpdate = $"UPDATE books SET state = '借出中' ,lastTakeDate = CONVERT(varchar(100), GETDATE(), 23),lastTakeTime = CONVERT(varchar(100), GETDATE(), 108),nameID = '{LB_UserID.Text}',takeName = '{LB_UserName.Text}' FROM books WHERE booksID like '{TB_BookID.Text}'";
                
                cn.ConnectionString = LocalDB_conn;
                cn.Open();
                SqlCommand cmd_Search = new SqlCommand(sqlSearch, cn);
                SqlDataReader dataReader_search = cmd_Search.ExecuteReader();
                dataReader_search.Read();//往下讀取一筆
                try
                {
                    if (dataReader_search["state"].ToString() == "未借出")
                    {
                        LB_BookName.Text = dataReader_search["bookName"].ToString();
                        cmd_Search.Dispose();//需要先結束上一個Read才可以做cmd
                        dataReader_search.Close();//需要先結束上一個Read才可以做cmd
                        SqlCommand cmd_Update = new SqlCommand(sqlUpdate, cn);
                        SqlDataReader dataReader_update = cmd_Update.ExecuteReader();
                        dataReader_update.Read();//往下讀取一筆
                        cmd_Update.Dispose();//釋放記憶體
                        dataReader_update.Close();//關閉搜尋結果

                        sql_log_Insert = $"INSERT INTO logs VALUES ('{TB_BookID.Text}','{LB_BookName.Text}','{LB_UserID.Text}','{LB_UserName.Text}',CONVERT(varchar(100), GETDATE(),120),NULL,NULL)";
                        SqlCommand cmd_logs_Insert = new SqlCommand(sql_log_Insert, cn);
                        SqlDataReader dataReader_logs_Insert = cmd_logs_Insert.ExecuteReader();
                        dataReader_logs_Insert.Read();
                        cmd_logs_Insert.Dispose();
                        dataReader_logs_Insert.Close();
                        MessageBox.Show("借出完成");
                    }
                    else
                    {
                        cmd_Search.Dispose();//釋放記憶體
                        dataReader_search.Close();//關閉搜尋結果
                        MessageBox.Show("書籍借出中");
                    }
                }
                catch
                {
                    MessageBox.Show("查無此書");
                }
                
                cn.Close();  
            }
        }

        /// <summary>
        /// 結束借書視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_End_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
