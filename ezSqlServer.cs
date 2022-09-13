using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

/// <summary>
/// SQL Server ADO.Net 自定公用功能類別
/// </summary>
public class ezSqlServer : IDisposable
{
    #region 解構子
    private bool disposed = false;
    private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
    /// <summary>
    /// 解構子,實現IDisposable中的Dispose方法
    /// </summary>
    public void Dispose()
    {
        SqlConnection.ClearAllPools();
        //必須為true
        Dispose(true);
        //通知垃圾回收機制不再調用終端子（析構器）
        GC.SuppressFinalize(this);
    }
    /// <summary>
    /// 解構子
    /// </summary>
    /// <param name="disposing">disposing</param>
    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;
        //解構時要執行的其它程式
        if (disposing)
        {
            Close();
            handle.Dispose();
        }
        //讓類別知道自己已經被釋放
        disposed = true;
    }
    /// <summary>
    /// ezSqlServer 解構子
    /// </summary>
    ~ezSqlServer()
    {
        //必須為false
        Dispose(false);
    }
    #endregion
    #region 建構子
    /// <summary>
    /// ezSqlServer 建構子
    /// </summary>
    public ezSqlServer()
    {
        SetConstructor();
        Open();
    }
    /// <summary>
    /// ezSqlServer 建構子,指定自定的連線名稱
    /// </summary>
    /// <param name="sConnName"></param>
    public ezSqlServer(string sConnName)
    {
        SetConstructor();
        ConnName = sConnName;
    }
    #endregion
    #region 屬性
    /// <summary>
    /// 連線名稱內部變數
    /// </summary>
    private string _ConnName = "";
    /// <summary>
    /// SqlConnection 連線物件
    /// </summary>
    public SqlConnection conn { get; set; }
    /// <summary>
    /// SqlCommand 命令
    /// </summary>
    public SqlCommand cmd { get; set; }
    /// <summary>
    /// 連線名稱變數
    /// </summary>
    public string ConnName
    {
        get { return (string.IsNullOrEmpty(_ConnName)) ? "dbconn" : _ConnName; }
        set { _ConnName = value; Open(); }
    }
    /// <summary>
    /// SQL 指令
    /// </summary>
    public string CommandText
    {
        get { return cmd.CommandText; }
        set { cmd.CommandText = value; }
    }
    /// <summary>
    /// 命令模式
    /// </summary>
    public CommandType CommandType
    {
        get { return cmd.CommandType; }
        set { cmd.CommandType = value; Open(); }
    }
    /// <summary>
    /// 回傳執行後是否有記錄
    /// </summary>
    public bool HasRows
    {
        get
        {
            bool bln_hasrows = false;
            ErrorMessage = "";
            try
            {
                CheckConnect();
                SqlDataReader dr = cmd.ExecuteReader();
                bln_hasrows = dr.HasRows;
                dr.Close();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            return bln_hasrows;
        }
    }
    /// <summary>
    /// 執行後有錯誤時的錯誤訊息
    /// </summary>
    public string ErrorMessage { get; set; }
    #endregion
    #region 函數
    /// <summary>
    /// 連線
    /// </summary>
    public bool Open()
    {
        bool bln_open = false;
        if (conn.State == ConnectionState.Open) conn.Close();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings[ConnName].ConnectionString;
        bln_open = Connect();
        return bln_open;
    }

    /// <summary>
    /// 設定連線物件執行連線
    /// </summary>
    public bool Connect()
    {
        bool bln_connect = false;
        try
        {
            if (conn.State == ConnectionState.Open) Close();
            conn.Open();
            cmd.Connection = conn;
            bln_connect = true;
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message;
            bln_connect = false;
            Close();
        }
        return bln_connect;
    }

    /// <summary>
    /// 檢查是否有連線,如果為關閉狀態則連線
    /// </summary>
    public bool CheckConnect()
    {
        bool bln_check = true;
        if (conn.State == ConnectionState.Closed) bln_check = Open();
        return bln_check;
    }
    /// <summary>
    /// 取得指定欄位的字串型態值
    /// </summary>
    /// <param name="sColName">指定欄位</param>
    /// <returns></returns>
    public string GetValueString(string sColName)
    {
        ErrorMessage = "";
        string str_value = "";
        try
        {
            if (CheckConnect())
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    str_value = (dr[sColName] == null) ? "" : dr[sColName].ToString();
                }
                dr.Close();
            }
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message.ToString();
        }
        return str_value;
    }
    /// <summary>
    /// 取得指定欄位的整數型態值
    /// </summary>
    /// <param name="sColName">指定欄位</param>
    /// <returns></returns>
    public int GetValueInt(string sColName)
    {
        ErrorMessage = "";
        int int_value = 0;
        try
        {
            string str_value = GetValueString(sColName);
            if (string.IsNullOrEmpty(str_value)) str_value = "0";
            if (!int.TryParse(str_value, out int_value)) int_value = 0;
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message.ToString();
        }
        return int_value;
    }
    /// <summary>
    /// 取得指定欄位的數字型態值
    /// </summary>
    /// <param name="sColName">指定欄位</param>
    /// <returns></returns>
    public decimal GetValueDecimal(string sColName)
    {
        ErrorMessage = "";
        decimal dec_value = 0;
        try
        {
            string str_value = GetValueString(sColName);
            if (string.IsNullOrEmpty(str_value)) str_value = "0";
            if (!decimal.TryParse(str_value, out dec_value)) dec_value = 0;
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message.ToString();
        }
        return dec_value;
    }
    /// <summary>
    /// 取得指定欄位的日期型態值
    /// </summary>
    /// <param name="sColName">指定欄位</param>
    /// <returns></returns>
    public DateTime GetValueDateTime(string sColName)
    {
        ErrorMessage = "";
        DateTime dtm_value = DateTime.MinValue;
        try
        {
            string str_value = GetValueString(sColName);
            if (!DateTime.TryParse(str_value, out dtm_value)) dtm_value = DateTime.MinValue;
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message.ToString();
        }
        return dtm_value;
    }
    /// <summary>
    /// 執行 SQL 指令並取回 DataTable,並自動關閉資料庫連線
    /// </summary>
    /// <returns></returns>
    public DataTable GetDataTable()
    {
        return GetDataTable(true);
    }

    /// <summary>
    /// 執行 SQL 指令並取回 DataTable
    /// </summary>
    /// <param name="bClose">執行後關閉資料庫</param>
    /// <returns></returns>
    public DataTable GetDataTable(bool bClose)
    {
        ErrorMessage = "";
        DataSet dsReturn = new DataSet();
        DataTable dtReturn = new DataTable();
        try
        {
            dsReturn = GetDataSet(bClose);
            dtReturn = dsReturn.Tables[0];
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message.ToString();
        }
        return dtReturn;
    }
    /// <summary>
    /// 執行 SQL 指令並取回 DataSet,並自動關閉資料庫連線
    /// </summary>
    /// <returns></returns>
    public DataSet GetDataSet()
    {
        return GetDataSet(true);
    }

    /// <summary>
    /// 執行 SQL 指令並取回 DataSet
    /// </summary>
    /// <param name="bClose">執行後關閉資料庫</param>
    /// <returns></returns>
    public DataSet GetDataSet(bool bClose)
    {
        ErrorMessage = "";
        DataSet dsReturn = new DataSet();
        try
        {
            CheckConnect();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dsReturn);
            adapter.Dispose();
        }
        catch (SqlException ex)
        {
            ErrorMessage = ex.Message.ToString();
        }
        if (bClose) Close();
        return dsReturn;
    }
    #endregion
    #region 事件
    private void SetConstructor()
    {
        conn = new SqlConnection();
        cmd = new SqlCommand();
    }
    /// <summary>
    /// 關閉連線
    /// </summary>
    public void Close()
    {
        conn.Close();
    }
    /// <summary>
    /// 加入參數
    /// </summary>
    /// <param name="sParameter">參數名稱</param>
    /// <param name="oValue">參數值</param>
    /// <param name="bClear">是否先清除所有參數再加入</param>
    public void ParametersAdd(string sParameter, object oValue, bool bClear)
    {
        if (bClear) cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue(sParameter, oValue);
    }
    /// <summary>
    /// 執行 SQL 命令不回傳值
    /// </summary>
    /// <param name="bClose">是否關閉連線</param>
    public void ExecuteNonQuery(bool bClose)
    {
        ErrorMessage = "";
        try
        {
            if (CheckConnect())
            {
                cmd.ExecuteNonQuery();
                if (bClose) Close();
            }
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message.ToString();
        }
    }
    /// <summary>
    /// 設定 StoreProcedure
    /// </summary>
    /// <param name="sProcedureName">StoreProcedure 名稱</param>
    public void SetProcedure(string sProcedureName)
    {
        CommandType = CommandType.StoredProcedure;
        CommandText = sProcedureName;
    }

    /// <summary>
    /// 執行 StoreProcedure
    /// </summary>
    public void ExecuteProcedure(bool bClose)
    {
        ExecuteNonQuery(bClose);
        CommandType = CommandType.Text;
    }
    #endregion
}