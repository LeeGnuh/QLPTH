namespace GUI
{
    partial class MenuForm
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
            this.btn_Room = new System.Windows.Forms.Button();
            this.btn_Scheduce = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Room
            // 
            this.btn_Room.Location = new System.Drawing.Point(42, 34);
            this.btn_Room.Name = "btn_Room";
            this.btn_Room.Size = new System.Drawing.Size(120, 78);
            this.btn_Room.TabIndex = 0;
            this.btn_Room.Text = "Phòng máy";
            this.btn_Room.UseVisualStyleBackColor = true;
            this.btn_Room.Click += new System.EventHandler(this.btn_Room_Click);
            // 
            // btn_Scheduce
            // 
            this.btn_Scheduce.Location = new System.Drawing.Point(196, 34);
            this.btn_Scheduce.Name = "btn_Scheduce";
            this.btn_Scheduce.Size = new System.Drawing.Size(120, 78);
            this.btn_Scheduce.TabIndex = 0;
            this.btn_Scheduce.Text = "Thời khóa biểu";
            this.btn_Scheduce.UseVisualStyleBackColor = true;
            this.btn_Scheduce.Click += new System.EventHandler(this.btn_Scheduce_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Location = new System.Drawing.Point(42, 137);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(120, 78);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Text = "Tài khoản";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(196, 137);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(120, 78);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 243);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Account);
            this.Controls.Add(this.btn_Scheduce);
            this.Controls.Add(this.btn_Room);
            this.Name = "MenuForm";
            this.Text = "Quản lý phòng thực hành";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Room;
        private System.Windows.Forms.Button btn_Scheduce;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Logout;
    }
}