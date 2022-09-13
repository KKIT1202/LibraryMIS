namespace Librarian2._0._1
{
    partial class Form_ReturnBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_BookName = new System.Windows.Forms.Label();
            this.LB_UserID = new System.Windows.Forms.Label();
            this.LB_UserName = new System.Windows.Forms.Label();
            this.BTN_End = new System.Windows.Forms.Button();
            this.LB_Title_BookName = new System.Windows.Forms.Label();
            this.LB_Title_BooksNO = new System.Windows.Forms.Label();
            this.LB_Title_ID = new System.Windows.Forms.Label();
            this.TB_BookID = new System.Windows.Forms.TextBox();
            this.LB_Title_User = new System.Windows.Forms.Label();
            this.BTN_ReturnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_BookName
            // 
            this.LB_BookName.AutoSize = true;
            this.LB_BookName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_BookName.Location = new System.Drawing.Point(150, 290);
            this.LB_BookName.Name = "LB_BookName";
            this.LB_BookName.Size = new System.Drawing.Size(117, 26);
            this.LB_BookName.TabIndex = 19;
            this.LB_BookName.Text = "未輸入書號";
            // 
            // LB_UserID
            // 
            this.LB_UserID.AutoSize = true;
            this.LB_UserID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_UserID.Location = new System.Drawing.Point(150, 117);
            this.LB_UserID.Name = "LB_UserID";
            this.LB_UserID.Size = new System.Drawing.Size(75, 26);
            this.LB_UserID.TabIndex = 18;
            this.LB_UserID.Text = "未登入";
            // 
            // LB_UserName
            // 
            this.LB_UserName.AutoSize = true;
            this.LB_UserName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_UserName.Location = new System.Drawing.Point(150, 53);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(75, 26);
            this.LB_UserName.TabIndex = 17;
            this.LB_UserName.Text = "未登入";
            // 
            // BTN_End
            // 
            this.BTN_End.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_End.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_End.Location = new System.Drawing.Point(282, 420);
            this.BTN_End.Name = "BTN_End";
            this.BTN_End.Size = new System.Drawing.Size(112, 52);
            this.BTN_End.TabIndex = 16;
            this.BTN_End.Text = "結束";
            this.BTN_End.UseVisualStyleBackColor = false;
            this.BTN_End.Click += new System.EventHandler(this.BTN_End_Click);
            // 
            // LB_Title_BookName
            // 
            this.LB_Title_BookName.AutoSize = true;
            this.LB_Title_BookName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_BookName.Location = new System.Drawing.Point(54, 290);
            this.LB_Title_BookName.Name = "LB_Title_BookName";
            this.LB_Title_BookName.Size = new System.Drawing.Size(80, 26);
            this.LB_Title_BookName.TabIndex = 15;
            this.LB_Title_BookName.Text = "書名 ：";
            // 
            // LB_Title_BooksNO
            // 
            this.LB_Title_BooksNO.AutoSize = true;
            this.LB_Title_BooksNO.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_BooksNO.Location = new System.Drawing.Point(54, 198);
            this.LB_Title_BooksNO.Name = "LB_Title_BooksNO";
            this.LB_Title_BooksNO.Size = new System.Drawing.Size(80, 26);
            this.LB_Title_BooksNO.TabIndex = 14;
            this.LB_Title_BooksNO.Text = "書號 ：";
            // 
            // LB_Title_ID
            // 
            this.LB_Title_ID.AutoSize = true;
            this.LB_Title_ID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_ID.Location = new System.Drawing.Point(54, 117);
            this.LB_Title_ID.Name = "LB_Title_ID";
            this.LB_Title_ID.Size = new System.Drawing.Size(75, 26);
            this.LB_Title_ID.TabIndex = 13;
            this.LB_Title_ID.Text = "I  D  ：";
            // 
            // TB_BookID
            // 
            this.TB_BookID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_BookID.Location = new System.Drawing.Point(155, 195);
            this.TB_BookID.Name = "TB_BookID";
            this.TB_BookID.Size = new System.Drawing.Size(344, 35);
            this.TB_BookID.TabIndex = 12;
            // 
            // LB_Title_User
            // 
            this.LB_Title_User.AutoSize = true;
            this.LB_Title_User.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_User.Location = new System.Drawing.Point(54, 53);
            this.LB_Title_User.Name = "LB_Title_User";
            this.LB_Title_User.Size = new System.Drawing.Size(96, 26);
            this.LB_Title_User.TabIndex = 11;
            this.LB_Title_User.Text = "使用者：";
            // 
            // BTN_ReturnBook
            // 
            this.BTN_ReturnBook.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_ReturnBook.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_ReturnBook.Location = new System.Drawing.Point(113, 420);
            this.BTN_ReturnBook.Name = "BTN_ReturnBook";
            this.BTN_ReturnBook.Size = new System.Drawing.Size(112, 52);
            this.BTN_ReturnBook.TabIndex = 10;
            this.BTN_ReturnBook.Text = "還書";
            this.BTN_ReturnBook.UseVisualStyleBackColor = false;
            this.BTN_ReturnBook.Click += new System.EventHandler(this.BTN_ReturnBook_Click);
            // 
            // Form_ReturnBook
            // 
            this.AcceptButton = this.BTN_ReturnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(514, 581);
            this.Controls.Add(this.LB_BookName);
            this.Controls.Add(this.LB_UserID);
            this.Controls.Add(this.LB_UserName);
            this.Controls.Add(this.BTN_End);
            this.Controls.Add(this.LB_Title_BookName);
            this.Controls.Add(this.LB_Title_BooksNO);
            this.Controls.Add(this.LB_Title_ID);
            this.Controls.Add(this.TB_BookID);
            this.Controls.Add(this.LB_Title_User);
            this.Controls.Add(this.BTN_ReturnBook);
            this.Name = "Form_ReturnBook";
            this.Text = "Form_ReturnBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_BookName;
        private System.Windows.Forms.Label LB_UserID;
        private System.Windows.Forms.Label LB_UserName;
        private System.Windows.Forms.Button BTN_End;
        private System.Windows.Forms.Label LB_Title_BookName;
        private System.Windows.Forms.Label LB_Title_BooksNO;
        private System.Windows.Forms.Label LB_Title_ID;
        private System.Windows.Forms.TextBox TB_BookID;
        private System.Windows.Forms.Label LB_Title_User;
        private System.Windows.Forms.Button BTN_ReturnBook;
    }
}