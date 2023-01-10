namespace GUI
{
    partial class ComputerForm
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txt_comp_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_comp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvComputer = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_id_room = new System.Windows.Forms.ComboBox();
            this.ComputerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPTHDataSet1 = new GUI.QLPTHDataSet1();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.ComputerTableAdapter = new GUI.QLPTHDataSet1TableAdapters.roomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(107, 156);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 25);
            this.btn_Search.TabIndex = 55;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tìm kiếm";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã máy";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã phòng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên máy";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng thái";
            this.columnHeader4.Width = 100;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(72, 119);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(152, 22);
            this.txt_search.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Trạng thái máy";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(583, 116);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(156, 36);
            this.btnChange.TabIndex = 48;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(583, 158);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(156, 36);
            this.btnDel.TabIndex = 49;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(583, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 36);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_comp_name
            // 
            this.txt_comp_name.Location = new System.Drawing.Point(376, 142);
            this.txt_comp_name.Name = "txt_comp_name";
            this.txt_comp_name.Size = new System.Drawing.Size(152, 22);
            this.txt_comp_name.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tên máy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tên phòng";
            // 
            // txt_id_comp
            // 
            this.txt_id_comp.Enabled = false;
            this.txt_id_comp.Location = new System.Drawing.Point(376, 70);
            this.txt_id_comp.Name = "txt_id_comp";
            this.txt_id_comp.Size = new System.Drawing.Size(152, 22);
            this.txt_id_comp.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mã máy";
            // 
            // lvComputer
            // 
            this.lvComputer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvComputer.FullRowSelect = true;
            this.lvComputer.GridLines = true;
            this.lvComputer.HideSelection = false;
            this.lvComputer.Location = new System.Drawing.Point(12, 233);
            this.lvComputer.Name = "lvComputer";
            this.lvComputer.Size = new System.Drawing.Size(758, 258);
            this.lvComputer.TabIndex = 41;
            this.lvComputer.UseCompatibleStateImageBehavior = false;
            this.lvComputer.View = System.Windows.Forms.View.Details;
            this.lvComputer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvComputer_MouseClick);
            this.lvComputer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvComputer_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "QUẢN LÝ MÁY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_id_room
            // 
            this.cb_id_room.DataSource = this.ComputerBindingSource;
            this.cb_id_room.DisplayMember = "room_name";
            this.cb_id_room.Enabled = false;
            this.cb_id_room.FormattingEnabled = true;
            this.cb_id_room.Location = new System.Drawing.Point(376, 108);
            this.cb_id_room.Name = "cb_id_room";
            this.cb_id_room.Size = new System.Drawing.Size(152, 24);
            this.cb_id_room.TabIndex = 56;
            this.cb_id_room.ValueMember = "id_room";
            // 
            // ComputerBindingSource
            // 
            this.ComputerBindingSource.DataMember = "room";
            this.ComputerBindingSource.DataSource = this.qLPTHDataSet1;
            // 
            // qLPTHDataSet1
            // 
            this.qLPTHDataSet1.DataSetName = "QLPTHDataSet1";
            this.qLPTHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cb_status.Location = new System.Drawing.Point(376, 177);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(152, 24);
            this.cb_status.TabIndex = 57;
            // 
            // ComputerTableAdapter
            // 
            this.ComputerTableAdapter.ClearBeforeFill = true;
            // 
            // ComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.cb_id_room);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt_comp_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id_comp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvComputer);
            this.Controls.Add(this.label1);
            this.Name = "ComputerForm";
            this.Text = "Máy";
            this.Load += new System.EventHandler(this.ComputerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComputerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txt_comp_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_comp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_id_room;
        private System.Windows.Forms.ComboBox cb_status;
        private QLPTHDataSet1 qLPTHDataSet1;
        private System.Windows.Forms.BindingSource ComputerBindingSource;
        private QLPTHDataSet1TableAdapters.roomTableAdapter ComputerTableAdapter;
    }
}