using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Librarian2._0._1
{
    public partial class indexForm : Form
    {
        
        string DataConn = Properties.Settings.Default.conn;//連線SQL路徑 (MS SQL)
        string LocalDB_conn = Properties.Settings.Default.localDB;//連線SQL路徑 (Local DB)
        SqlConnection cn = new SqlConnection();//data參數
        public string sqlSearch = "";//SQL語法

        DataSet DataSetLibrary = new DataSet();
        

        public indexForm()
        {
            InitializeComponent();
            Size = new Size(1200, 720);
        }
        /// <summary>
        /// 畫面載入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void indexForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(LocalDB_conn))
            {
                cn.ConnectionString = LocalDB_conn;
                cn.Open();
                SqlDataAdapter books = new SqlDataAdapter("SELECT TOP 100 * FROM books", cn);
                books.Fill(DataSetLibrary, "books");
                cn.Close();
                DGV_Show.DataSource = DataSetLibrary.Tables["books"];
            }
        }


        /// <summary>
        /// 搜尋按鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Seach_Click(object sender, EventArgs e)
        {
            DataShow();
        }


        /// <summary>
        /// 清除搜尋
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            TB_Search.Text = "";
        }


        /// <summary>
        /// 登入按鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BTN_Login_Click(object sender, EventArgs e)
        {
            string Mail = TB_Mail.Text;//存取mail
            string Password = TB_PassWord.Text;//存取密碼
            string showname = "", showID = "", DBpassword = "";
            sqlSearch = $"Select * From names Where mail like '{Mail}'";
            //------------------------------------------------------------//
            if (Mail != "" && Password != "")
            {
                using (SqlConnection cn = new SqlConnection(LocalDB_conn))
                {
                    cn.ConnectionString = LocalDB_conn;
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sqlSearch, cn);//新增查詢(SELECT,連線)
                    SqlDataReader dataReader = cmd.ExecuteReader();//執行查詢指令
                    try
                    {
                        if (dataReader != null)
                        {
                            dataReader.Read();//讀取一筆
                            DBpassword = dataReader["password"].ToString();
                            showID = dataReader["nameID"].ToString();
                            showname = dataReader["name"].ToString();
                        }
                    }
                    catch
                    {

                    }
                    dataReader.Close();
                    cn.Close();

                    if (Password == DBpassword)
                    {
                        LB_Name.Text = showname;
                        LB_ID.Text = showID;
                        BTN_Register_Edit.Text = "編輯個人資料";
                        BTN_Login.Enabled = false;
                        BTN_TakeBook.Enabled = true;
                        BTN_ReturnBook.Enabled = true;
                        MessageBox.Show($"登入成功\n\nI D：{showID}\n使用者：{showname}");
                        if (showID == "1")
                        {
                            Size = new Size(1600, 720);
                            AcceptButton = BTN_CRUD_Select;
                        }
                    }
                    else if (Password != DBpassword && Password != null)
                    {
                        MessageBox.Show("帳號或密碼錯誤");
                    }
                }
            }
            else
            {
                MessageBox.Show("帳號或密碼請勿空白");
            }
        }


        /// <summary>
        /// 切換使用者按鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_SwitchUser_Click(object sender, EventArgs e)
        {
            TB_Mail.Text = "";
            TB_PassWord.Text = "";
            BTN_Register_Edit.Text = "註冊";
            LB_Name.Text = "未登入";
            LB_ID.Text = "未登入";
            BTN_Login.Enabled = true;
            BTN_TakeBook.Enabled = false;
            BTN_ReturnBook.Enabled = false;
            Size = new Size(1200, 720);
            AcceptButton = BTN_Seach;
        }


        /// <summary>
        /// 借書按鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_TakeBook_Click(object sender, EventArgs e)
        {
            Form_TakeBook form_TakeBook = new Form_TakeBook(LB_Name.Text , LB_ID.Text);
            form_TakeBook.Show();
        }


        /// <summary>
        /// 還書按鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ReturnBook_Click(object sender, EventArgs e)
        {
            Form_ReturnBook form_ReturnBook = new Form_ReturnBook(LB_Name.Text, LB_ID.Text);
            form_ReturnBook.Show();
        }


        /// <summary>
        /// 註冊or編輯個人資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Register_Edit_Click(object sender, EventArgs e)
        {
            if (BTN_Register_Edit.Text == "註冊")
            {
                Form_Register form_Register = new Form_Register();
                form_Register.Show();
            }
            else if (BTN_Register_Edit.Text == "編輯個人資料")
            {
                Form_Edit form_Edit = new Form_Edit(TB_Mail.Text,LB_Name.Text);
                form_Edit.Show();
            }
        }


        /// <summary>
        /// 管理者查詢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CRUD_Select_Click(object sender, EventArgs e)
        {
            string sqlSelect = $"SELECT * FROM books WHERE booksID like '{TB_BookID.Text}'";
            using (SqlConnection cn = new SqlConnection(LocalDB_conn))
            {
                try
                {
                    cn.ConnectionString = LocalDB_conn;
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sqlSelect, cn);
                    SqlDataReader sql_Select_Reader = cmd.ExecuteReader();
                    sql_Select_Reader.Read();
                    TB_BookName.Text = sql_Select_Reader["bookName"].ToString();
                    CBB_BookType.Text = sql_Select_Reader["type"].ToString();
                    cmd.Dispose();
                    sql_Select_Reader.Close();
                    cn.Close();
                }
                catch
                {
                    MessageBox.Show("查無此書，請確認書籍ID是否正確");
                }
            }
        }


        /// <summary>
        /// 管理者查詢清除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CRUD_Clear_Click(object sender, EventArgs e)
        {
            TB_BookID.Text = "";
            TB_BookName.Text = "";
            CBB_BookType.Text = "";
        }


        /// <summary>
        /// 管理者修改書籍資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            string OldBookName = "";
            string OldbBookType = "";
            string sqlSelect = $"SELECT * FROM books WHERE booksID like '{TB_BookID.Text}'";
            using (SqlConnection cn = new SqlConnection(LocalDB_conn))
            {
                try
                {
                    cn.ConnectionString = LocalDB_conn;
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sqlSelect, cn);
                    SqlDataReader sql_Select_Reader = cmd.ExecuteReader();
                    sql_Select_Reader.Read();
                    OldBookName = sql_Select_Reader["bookName"].ToString();
                    OldbBookType = sql_Select_Reader["type"].ToString();
                    cmd.Dispose();
                    sql_Select_Reader.Close();
                    /*---------------------查詢結束，修改開始---------------------*/
                    if (TB_BookName.Text != "" && CBB_BookType.Text != "" &&
                        (TB_BookName.Text != OldBookName || CBB_BookType.Text != OldbBookType))
                    {
                        string sqlUpdate = $"UPDATE books SET bookName = '{TB_BookName.Text}',type = '{CBB_BookType.Text}' FROM books WHERE booksID like '{TB_BookID.Text}'";
                        try
                        {
                            SqlCommand Update_cmd = new SqlCommand(sqlUpdate, cn);
                            SqlDataReader sql_Update_Reader = Update_cmd.ExecuteReader();

                            Update_cmd.Dispose();
                            sql_Update_Reader.Close();
                            MessageBox.Show($"修改成功\n書名改為：{TB_BookName.Text}\n類別：{CBB_BookType.Text}");
                            DataShow();
                        }
                        catch
                        {
                            MessageBox.Show("查無此書，請確認書籍ID是否正確");
                        }
                    }
                    else if (TB_BookName.Text == "" || CBB_BookType.Text == "")
                    {
                        MessageBox.Show("錯誤：書名或類別請勿空白!");
                    }
                    else if (TB_BookName.Text == OldBookName || CBB_BookType.Text == OldbBookType)
                    {
                        MessageBox.Show("無修改任何資料");
                    }
                    cn.Close();
                }
                catch
                {
                    MessageBox.Show("查無此書，請確認書籍ID是否正確");
                }
            }
        }


        /// <summary>
        /// 管理者新增書籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Create_Click(object sender, EventArgs e)
        {
            string sqlInsert = $"INSERT INTO books VALUES ('{TB_BookID.Text}','{TB_BookName.Text}','{CBB_BookType.Text}','未借出',NULL,NULL,NULL,NULL,NULL,NULL)";
            string sqlSelect = $"SELECT * FROM books WHERE booksID like '{TB_BookID.Text}'";
            using (SqlConnection cn = new SqlConnection(LocalDB_conn))
            {
                try
                {
                    cn.ConnectionString = LocalDB_conn;
                    cn.Open();
                    SqlCommand Select_cmd = new SqlCommand(sqlSelect, cn);
                    SqlDataReader sql_Select_Reader = Select_cmd.ExecuteReader();
                    if(sql_Select_Reader.HasRows == false)
                    {
                        Select_cmd.Dispose();//搜尋cmd釋放
                        sql_Select_Reader.Close();//搜尋read關閉
                        if (TB_BookID.Text != "" && TB_BookName.Text != "" && CBB_BookType.Text != "")
                        {
                            SqlCommand cmdInsert = new SqlCommand(sqlInsert, cn);
                            SqlDataReader dataReader_Insert = cmdInsert.ExecuteReader();
                            dataReader_Insert.Read();
                            dataReader_Insert.Close();
                            cmdInsert.Dispose();
                            MessageBox.Show($"新增成功\n書號：{TB_BookID.Text}\n書名：{TB_BookName.Text}\n類型：{CBB_BookType.Text}");
                            DataShow();
                        }
                        else
                        {
                            MessageBox.Show("新增資料不完整");
                        }
                    }
                    else
                    {
                        MessageBox.Show("書號已存在，無法新增");
                    }
                    Select_cmd.Dispose();
                    sql_Select_Reader.Close();

                    cn.Close();
                    /*---------------------查詢結束，新增開始---------------------*/
                }
                catch
                {   
                }
            }
        }


        /// <summary>
        /// 管理者刪除書籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            string sqlDelete = $"DELETE FROM books WHERE booksID like '{TB_BookID.Text}'";
            string sqlSelect = $"SELECT * FROM books WHERE booksID like '{TB_BookID.Text}'";
            using (SqlConnection cn = new SqlConnection(LocalDB_conn))
            {
                try
                {
                    cn.ConnectionString = LocalDB_conn;
                    cn.Open();
                    SqlCommand Select_cmd = new SqlCommand(sqlSelect, cn);
                    SqlDataReader sql_Select_Reader = Select_cmd.ExecuteReader();
                    if (sql_Select_Reader.HasRows != false)
                    {
                        sql_Select_Reader.Read();
                        string bookID = sql_Select_Reader["booksID"].ToString();
                        string bookName = sql_Select_Reader["bookName"].ToString();
                        string booktype = sql_Select_Reader["type"].ToString();

                        Select_cmd.Dispose();//搜尋cmd釋放
                        sql_Select_Reader.Close();//搜尋read關閉
                        if (TB_BookID.Text != "")
                        {
                            var DeleteSubmit = MessageBox.Show($"刪除書籍資料\n書號：{bookID}\n書名：{bookName}\n類型：{booktype}", "刪除確認", MessageBoxButtons.YesNo);
                            if(DeleteSubmit == DialogResult.Yes)
                            {
                                SqlCommand cmdDelete = new SqlCommand(sqlDelete, cn);
                                SqlDataReader dataReader_Delete = cmdDelete.ExecuteReader();
                                dataReader_Delete.Read();
                                dataReader_Delete.Close();
                                cmdDelete.Dispose();
                                TB_BookID.Text = "";
                                TB_BookName.Text = "";
                                CBB_BookType.Text = "";
                                MessageBox.Show("刪除成功");
                                DataShow();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("書號不存在，無法刪除");
                    }
                    Select_cmd.Dispose();
                    sql_Select_Reader.Close();

                    cn.Close();
                    /*---------------------查詢結束，新增開始---------------------*/
                }
                catch
                {
                }
            }
        }


        /// <summary>
        /// 刷新顯示
        /// </summary>
        public void DataShow()
        {
            DataTable SearchTable = new DataTable();
            using (SqlConnection cn = new SqlConnection(LocalDB_conn))
            {
                sqlSearch = $"SELECT * FROM books WHERE bookName like '%{TB_Search.Text}%'";

                cn.ConnectionString = LocalDB_conn;
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlSearch, cn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                SearchTable.Load(dataReader);
                cmd.Dispose();


                cn.Close();

                DGV_Show.DataSource = SearchTable;
            }
        }


        /// <summary>
        /// 分類篩選事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBB_UseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable SearchTable = new DataTable();
            using (SqlConnection cn = new SqlConnection(LocalDB_conn))
            {
                sqlSearch = $"SELECT * FROM books WHERE type like '%{CBB_UseType.Text}%'";

                cn.ConnectionString = LocalDB_conn;
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlSearch, cn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                SearchTable.Load(dataReader);
                cmd.Dispose();


                cn.Close();

                DGV_Show.DataSource = SearchTable;
            }
        }
    }
}
