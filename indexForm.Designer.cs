namespace Librarian2._0._1
{
    partial class indexForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.BTN_Seach = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.PB_Grass = new System.Windows.Forms.PictureBox();
            this.TB_Mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PassWord = new System.Windows.Forms.TextBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_SwitchUser = new System.Windows.Forms.Button();
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.LB_Title_User = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.LB_Title_ID = new System.Windows.Forms.Label();
            this.LB_ID = new System.Windows.Forms.Label();
            this.BTN_TakeBook = new System.Windows.Forms.Button();
            this.BTN_ReturnBook = new System.Windows.Forms.Button();
            this.BTN_Register_Edit = new System.Windows.Forms.Button();
            this.BTN_Create = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.TB_BookID = new System.Windows.Forms.TextBox();
            this.LB_BookID = new System.Windows.Forms.Label();
            this.LB_BookName = new System.Windows.Forms.Label();
            this.TB_BookName = new System.Windows.Forms.TextBox();
            this.LB_BookType = new System.Windows.Forms.Label();
            this.BTN_CRUD_Select = new System.Windows.Forms.Button();
            this.CBB_BookType = new System.Windows.Forms.ComboBox();
            this.BTN_CRUD_Clear = new System.Windows.Forms.Button();
            this.CBB_UseType = new System.Windows.Forms.ComboBox();
            this.LB_Title_Type = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Grass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::Librarian2._0._1.Properties.Resources.BooksSearch;
            this.PB_Logo.Location = new System.Drawing.Point(113, -4);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(150, 108);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 0;
            this.PB_Logo.TabStop = false;
            // 
            // TB_Search
            // 
            this.TB_Search.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_Search.Location = new System.Drawing.Point(289, 25);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(524, 33);
            this.TB_Search.TabIndex = 1;
            // 
            // BTN_Seach
            // 
            this.BTN_Seach.BackColor = System.Drawing.Color.LightSalmon;
            this.BTN_Seach.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Seach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Seach.Location = new System.Drawing.Point(830, 23);
            this.BTN_Seach.Name = "BTN_Seach";
            this.BTN_Seach.Size = new System.Drawing.Size(125, 35);
            this.BTN_Seach.TabIndex = 2;
            this.BTN_Seach.Text = "書籍搜尋";
            this.BTN_Seach.UseVisualStyleBackColor = false;
            this.BTN_Seach.Click += new System.EventHandler(this.BTN_Seach_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.Color.LightSalmon;
            this.BTN_Cancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Cancel.Location = new System.Drawing.Point(978, 23);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(125, 35);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "清除結果";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // PB_Grass
            // 
            this.PB_Grass.Image = global::Librarian2._0._1.Properties.Resources.Grass;
            this.PB_Grass.Location = new System.Drawing.Point(2, 474);
            this.PB_Grass.Name = "PB_Grass";
            this.PB_Grass.Size = new System.Drawing.Size(293, 212);
            this.PB_Grass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Grass.TabIndex = 4;
            this.PB_Grass.TabStop = false;
            // 
            // TB_Mail
            // 
            this.TB_Mail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_Mail.Location = new System.Drawing.Point(443, 525);
            this.TB_Mail.Name = "TB_Mail";
            this.TB_Mail.Size = new System.Drawing.Size(370, 29);
            this.TB_Mail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(303, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "   E - m a i l：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(303, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "PassWord：";
            // 
            // TB_PassWord
            // 
            this.TB_PassWord.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_PassWord.Location = new System.Drawing.Point(443, 569);
            this.TB_PassWord.Name = "TB_PassWord";
            this.TB_PassWord.PasswordChar = '*';
            this.TB_PassWord.Size = new System.Drawing.Size(370, 29);
            this.TB_PassWord.TabIndex = 8;
            // 
            // BTN_Login
            // 
            this.BTN_Login.BackColor = System.Drawing.Color.LightSalmon;
            this.BTN_Login.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Login.Location = new System.Drawing.Point(884, 519);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(100, 35);
            this.BTN_Login.TabIndex = 9;
            this.BTN_Login.Text = "登入";
            this.BTN_Login.UseVisualStyleBackColor = false;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // BTN_SwitchUser
            // 
            this.BTN_SwitchUser.BackColor = System.Drawing.Color.LightSalmon;
            this.BTN_SwitchUser.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_SwitchUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_SwitchUser.Location = new System.Drawing.Point(1003, 519);
            this.BTN_SwitchUser.Name = "BTN_SwitchUser";
            this.BTN_SwitchUser.Size = new System.Drawing.Size(100, 35);
            this.BTN_SwitchUser.TabIndex = 11;
            this.BTN_SwitchUser.Text = "登出";
            this.BTN_SwitchUser.UseVisualStyleBackColor = false;
            this.BTN_SwitchUser.Click += new System.EventHandler(this.BTN_SwitchUser_Click);
            // 
            // DGV_Show
            // 
            this.DGV_Show.BackgroundColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Show.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Show.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Show.GridColor = System.Drawing.Color.Sienna;
            this.DGV_Show.Location = new System.Drawing.Point(62, 100);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.RowTemplate.Height = 24;
            this.DGV_Show.Size = new System.Drawing.Size(1041, 368);
            this.DGV_Show.TabIndex = 12;
            // 
            // LB_Title_User
            // 
            this.LB_Title_User.AutoSize = true;
            this.LB_Title_User.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_User.Location = new System.Drawing.Point(360, 625);
            this.LB_Title_User.Name = "LB_Title_User";
            this.LB_Title_User.Size = new System.Drawing.Size(79, 26);
            this.LB_Title_User.TabIndex = 13;
            this.LB_Title_User.Text = "User：";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Name.Location = new System.Drawing.Point(445, 625);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(75, 26);
            this.LB_Name.TabIndex = 14;
            this.LB_Name.Text = "未登入";
            // 
            // LB_Title_ID
            // 
            this.LB_Title_ID.AutoSize = true;
            this.LB_Title_ID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_ID.Location = new System.Drawing.Point(618, 625);
            this.LB_Title_ID.Name = "LB_Title_ID";
            this.LB_Title_ID.Size = new System.Drawing.Size(60, 26);
            this.LB_Title_ID.TabIndex = 15;
            this.LB_Title_ID.Text = "I D：";
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_ID.Location = new System.Drawing.Point(698, 625);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(75, 26);
            this.LB_ID.TabIndex = 16;
            this.LB_ID.Text = "未登入";
            // 
            // BTN_TakeBook
            // 
            this.BTN_TakeBook.BackColor = System.Drawing.Color.ForestGreen;
            this.BTN_TakeBook.Enabled = false;
            this.BTN_TakeBook.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_TakeBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_TakeBook.Location = new System.Drawing.Point(884, 568);
            this.BTN_TakeBook.Name = "BTN_TakeBook";
            this.BTN_TakeBook.Size = new System.Drawing.Size(100, 35);
            this.BTN_TakeBook.TabIndex = 17;
            this.BTN_TakeBook.Text = "借出";
            this.BTN_TakeBook.UseVisualStyleBackColor = false;
            this.BTN_TakeBook.Click += new System.EventHandler(this.BTN_TakeBook_Click);
            // 
            // BTN_ReturnBook
            // 
            this.BTN_ReturnBook.BackColor = System.Drawing.Color.Orange;
            this.BTN_ReturnBook.Enabled = false;
            this.BTN_ReturnBook.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_ReturnBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_ReturnBook.Location = new System.Drawing.Point(1003, 568);
            this.BTN_ReturnBook.Name = "BTN_ReturnBook";
            this.BTN_ReturnBook.Size = new System.Drawing.Size(100, 35);
            this.BTN_ReturnBook.TabIndex = 18;
            this.BTN_ReturnBook.Text = "歸還";
            this.BTN_ReturnBook.UseVisualStyleBackColor = false;
            this.BTN_ReturnBook.Click += new System.EventHandler(this.BTN_ReturnBook_Click);
            // 
            // BTN_Register_Edit
            // 
            this.BTN_Register_Edit.BackColor = System.Drawing.Color.MediumBlue;
            this.BTN_Register_Edit.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Register_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Register_Edit.Location = new System.Drawing.Point(884, 616);
            this.BTN_Register_Edit.Name = "BTN_Register_Edit";
            this.BTN_Register_Edit.Size = new System.Drawing.Size(219, 35);
            this.BTN_Register_Edit.TabIndex = 19;
            this.BTN_Register_Edit.Text = "註冊";
            this.BTN_Register_Edit.UseVisualStyleBackColor = false;
            this.BTN_Register_Edit.Click += new System.EventHandler(this.BTN_Register_Edit_Click);
            // 
            // BTN_Create
            // 
            this.BTN_Create.BackColor = System.Drawing.Color.SaddleBrown;
            this.BTN_Create.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Create.Location = new System.Drawing.Point(1225, 568);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(100, 35);
            this.BTN_Create.TabIndex = 20;
            this.BTN_Create.Text = "新增";
            this.BTN_Create.UseVisualStyleBackColor = false;
            this.BTN_Create.Click += new System.EventHandler(this.BTN_Create_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.SaddleBrown;
            this.BTN_Delete.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Delete.Location = new System.Drawing.Point(1437, 568);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(100, 35);
            this.BTN_Delete.TabIndex = 21;
            this.BTN_Delete.Text = "刪除";
            this.BTN_Delete.UseVisualStyleBackColor = false;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.BackColor = System.Drawing.Color.SaddleBrown;
            this.BTN_Update.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Update.Location = new System.Drawing.Point(1331, 568);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(100, 35);
            this.BTN_Update.TabIndex = 22;
            this.BTN_Update.Text = "修改";
            this.BTN_Update.UseVisualStyleBackColor = false;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // TB_BookID
            // 
            this.TB_BookID.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_BookID.Location = new System.Drawing.Point(1225, 129);
            this.TB_BookID.Name = "TB_BookID";
            this.TB_BookID.Size = new System.Drawing.Size(303, 33);
            this.TB_BookID.TabIndex = 23;
            // 
            // LB_BookID
            // 
            this.LB_BookID.AutoSize = true;
            this.LB_BookID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_BookID.Location = new System.Drawing.Point(1220, 100);
            this.LB_BookID.Name = "LB_BookID";
            this.LB_BookID.Size = new System.Drawing.Size(114, 26);
            this.LB_BookID.TabIndex = 24;
            this.LB_BookID.Text = "Book ID：";
            // 
            // LB_BookName
            // 
            this.LB_BookName.AutoSize = true;
            this.LB_BookName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_BookName.Location = new System.Drawing.Point(1220, 259);
            this.LB_BookName.Name = "LB_BookName";
            this.LB_BookName.Size = new System.Drawing.Size(148, 26);
            this.LB_BookName.TabIndex = 26;
            this.LB_BookName.Text = "BookName：";
            // 
            // TB_BookName
            // 
            this.TB_BookName.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_BookName.Location = new System.Drawing.Point(1225, 288);
            this.TB_BookName.Name = "TB_BookName";
            this.TB_BookName.Size = new System.Drawing.Size(303, 33);
            this.TB_BookName.TabIndex = 25;
            // 
            // LB_BookType
            // 
            this.LB_BookType.AutoSize = true;
            this.LB_BookType.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_BookType.Location = new System.Drawing.Point(1220, 395);
            this.LB_BookType.Name = "LB_BookType";
            this.LB_BookType.Size = new System.Drawing.Size(136, 26);
            this.LB_BookType.TabIndex = 28;
            this.LB_BookType.Text = "BookType：";
            // 
            // BTN_CRUD_Select
            // 
            this.BTN_CRUD_Select.BackColor = System.Drawing.Color.Chocolate;
            this.BTN_CRUD_Select.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_CRUD_Select.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_CRUD_Select.Location = new System.Drawing.Point(1225, 527);
            this.BTN_CRUD_Select.Name = "BTN_CRUD_Select";
            this.BTN_CRUD_Select.Size = new System.Drawing.Size(143, 35);
            this.BTN_CRUD_Select.TabIndex = 29;
            this.BTN_CRUD_Select.Text = "書籍查詢";
            this.BTN_CRUD_Select.UseVisualStyleBackColor = false;
            this.BTN_CRUD_Select.Click += new System.EventHandler(this.BTN_CRUD_Select_Click);
            // 
            // CBB_BookType
            // 
            this.CBB_BookType.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBB_BookType.FormattingEnabled = true;
            this.CBB_BookType.Items.AddRange(new object[] {
            "資訊",
            "機械",
            "電子",
            "餐飲",
            "多媒體",
            "歷史",
            "語文",
            "外語",
            "政治",
            "小說",
            "漫畫",
            "地理",
            "教育",
            "心理",
            "汽機車修護",
            "化學",
            "物理",
            "醫學",
            "管理",
            "金融"});
            this.CBB_BookType.Location = new System.Drawing.Point(1225, 434);
            this.CBB_BookType.Name = "CBB_BookType";
            this.CBB_BookType.Size = new System.Drawing.Size(303, 34);
            this.CBB_BookType.TabIndex = 30;
            // 
            // BTN_CRUD_Clear
            // 
            this.BTN_CRUD_Clear.BackColor = System.Drawing.Color.Chocolate;
            this.BTN_CRUD_Clear.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_CRUD_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_CRUD_Clear.Location = new System.Drawing.Point(1394, 527);
            this.BTN_CRUD_Clear.Name = "BTN_CRUD_Clear";
            this.BTN_CRUD_Clear.Size = new System.Drawing.Size(143, 35);
            this.BTN_CRUD_Clear.TabIndex = 31;
            this.BTN_CRUD_Clear.Text = "清除";
            this.BTN_CRUD_Clear.UseVisualStyleBackColor = false;
            this.BTN_CRUD_Clear.Click += new System.EventHandler(this.BTN_CRUD_Clear_Click);
            // 
            // CBB_UseType
            // 
            this.CBB_UseType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBB_UseType.FormattingEnabled = true;
            this.CBB_UseType.Items.AddRange(new object[] {
            "資訊",
            "機械",
            "電子",
            "餐飲",
            "多媒體",
            "歷史",
            "語文",
            "外語",
            "政治",
            "小說",
            "漫畫",
            "地理",
            "教育",
            "心理",
            "汽機車修護",
            "化學",
            "物理",
            "醫學",
            "管理",
            "金融"});
            this.CBB_UseType.Location = new System.Drawing.Point(634, 65);
            this.CBB_UseType.Name = "CBB_UseType";
            this.CBB_UseType.Size = new System.Drawing.Size(179, 29);
            this.CBB_UseType.TabIndex = 32;
            this.CBB_UseType.SelectedIndexChanged += new System.EventHandler(this.CBB_UseType_SelectedIndexChanged);
            // 
            // LB_Title_Type
            // 
            this.LB_Title_Type.AutoSize = true;
            this.LB_Title_Type.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Type.Location = new System.Drawing.Point(555, 68);
            this.LB_Title_Type.Name = "LB_Title_Type";
            this.LB_Title_Type.Size = new System.Drawing.Size(75, 26);
            this.LB_Title_Type.TabIndex = 33;
            this.LB_Title_Type.Text = "類型：";
            // 
            // indexForm
            // 
            this.AcceptButton = this.BTN_Seach;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1584, 681);
            this.Controls.Add(this.LB_Title_Type);
            this.Controls.Add(this.CBB_UseType);
            this.Controls.Add(this.BTN_CRUD_Clear);
            this.Controls.Add(this.CBB_BookType);
            this.Controls.Add(this.BTN_CRUD_Select);
            this.Controls.Add(this.LB_BookType);
            this.Controls.Add(this.LB_BookName);
            this.Controls.Add(this.TB_BookName);
            this.Controls.Add(this.LB_BookID);
            this.Controls.Add(this.TB_BookID);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Create);
            this.Controls.Add(this.BTN_Register_Edit);
            this.Controls.Add(this.BTN_ReturnBook);
            this.Controls.Add(this.BTN_TakeBook);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.LB_Title_ID);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.LB_Title_User);
            this.Controls.Add(this.DGV_Show);
            this.Controls.Add(this.BTN_SwitchUser);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.TB_PassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Mail);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Seach);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.PB_Grass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "indexForm";
            this.Text = "圖書管理員";
            this.Load += new System.EventHandler(this.indexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Grass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Button BTN_Seach;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.PictureBox PB_Grass;
        private System.Windows.Forms.TextBox TB_Mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_PassWord;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_SwitchUser;
        private System.Windows.Forms.DataGridView DGV_Show;
        private System.Windows.Forms.Label LB_Title_User;
        private System.Windows.Forms.Label LB_Title_ID;
        private System.Windows.Forms.Button BTN_TakeBook;
        private System.Windows.Forms.Button BTN_ReturnBook;
        public System.Windows.Forms.Label LB_ID;
        public System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Button BTN_Register_Edit;
        private System.Windows.Forms.Button BTN_Create;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.TextBox TB_BookID;
        private System.Windows.Forms.Label LB_BookID;
        private System.Windows.Forms.Label LB_BookName;
        private System.Windows.Forms.TextBox TB_BookName;
        private System.Windows.Forms.Label LB_BookType;
        private System.Windows.Forms.Button BTN_CRUD_Select;
        private System.Windows.Forms.ComboBox CBB_BookType;
        private System.Windows.Forms.Button BTN_CRUD_Clear;
        private System.Windows.Forms.ComboBox CBB_UseType;
        private System.Windows.Forms.Label LB_Title_Type;
    }
}

