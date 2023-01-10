namespace GUI
{
    partial class AccountForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lvAcc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_acc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_full_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_per = new System.Windows.Forms.ComboBox();
            this.permisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPTHDataSet = new GUI.QLPTHDataSet();
            this.permisionTableAdapter = new GUI.QLPTHDataSetTableAdapters.permisionTableAdapter();
            this.cb_ban = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.permisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lvAcc
            // 
            this.lvAcc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvAcc.FullRowSelect = true;
            this.lvAcc.GridLines = true;
            this.lvAcc.HideSelection = false;
            this.lvAcc.Location = new System.Drawing.Point(12, 233);
            this.lvAcc.Name = "lvAcc";
            this.lvAcc.Size = new System.Drawing.Size(758, 258);
            this.lvAcc.TabIndex = 1;
            this.lvAcc.UseCompatibleStateImageBehavior = false;
            this.lvAcc.View = System.Windows.Forms.View.Details;
            this.lvAcc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvAccount_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã tài khoản";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đăng nhập";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mật khẩu";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại tài khoản";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên người dùng";
            this.columnHeader5.Width = 116;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tình trạng";
            this.columnHeader6.Width = 73;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(614, 130);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(156, 36);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(614, 172);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(156, 36);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(614, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 36);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(133, 171);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(152, 22);
            this.txt_password.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(133, 136);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(152, 22);
            this.txt_username.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên đăng nhập";
            // 
            // txt_id_acc
            // 
            this.txt_id_acc.Enabled = false;
            this.txt_id_acc.Location = new System.Drawing.Point(133, 99);
            this.txt_id_acc.Name = "txt_id_acc";
            this.txt_id_acc.Size = new System.Drawing.Size(152, 22);
            this.txt_id_acc.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bị cấm";
            // 
            // txt_full_name
            // 
            this.txt_full_name.Location = new System.Drawing.Point(431, 100);
            this.txt_full_name.Name = "txt_full_name";
            this.txt_full_name.Size = new System.Drawing.Size(152, 22);
            this.txt_full_name.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tên người dùng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Loại tài khoản";
            // 
            // cb_per
            // 
            this.cb_per.DataSource = this.permisionBindingSource;
            this.cb_per.DisplayMember = "name_per";
            this.cb_per.FormattingEnabled = true;
            this.cb_per.Location = new System.Drawing.Point(431, 171);
            this.cb_per.Name = "cb_per";
            this.cb_per.Size = new System.Drawing.Size(152, 24);
            this.cb_per.TabIndex = 21;
            this.cb_per.ValueMember = "id_per";
            // 
            // permisionBindingSource
            // 
            this.permisionBindingSource.DataMember = "permision";
            this.permisionBindingSource.DataSource = this.qLPTHDataSet;
            // 
            // qLPTHDataSet
            // 
            this.qLPTHDataSet.DataSetName = "QLPTHDataSet";
            this.qLPTHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // permisionTableAdapter
            // 
            this.permisionTableAdapter.ClearBeforeFill = true;
            // 
            // cb_ban
            // 
            this.cb_ban.FormattingEnabled = true;
            this.cb_ban.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cb_ban.Location = new System.Drawing.Point(431, 136);
            this.cb_ban.Name = "cb_ban";
            this.cb_ban.Size = new System.Drawing.Size(152, 24);
            this.cb_ban.TabIndex = 22;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.cb_ban);
            this.Controls.Add(this.cb_per);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_full_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id_acc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvAcc);
            this.Controls.Add(this.label1);
            this.Name = "AccountForm";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.permisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvAcc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_acc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_full_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_per;
        private QLPTHDataSet qLPTHDataSet;
        private System.Windows.Forms.BindingSource permisionBindingSource;
        private QLPTHDataSetTableAdapters.permisionTableAdapter permisionTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cb_ban;
    }
}