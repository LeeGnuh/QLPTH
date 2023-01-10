namespace GUI
{
    partial class StatusForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txt_lession = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_status = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvStatus = new System.Windows.Forms.ListView();
            this.permisionTableAdapter = new GUI.QLPTHDataSetTableAdapters.permisionTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_id_comp = new System.Windows.Forms.ComboBox();
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPTHDataSet2 = new GUI.QLPTHDataSet2();
            this.txt_detail = new System.Windows.Forms.RichTextBox();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.computerTableAdapter = new GUI.QLPTHDataSet2TableAdapters.computerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tóm tắt tính trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tên máy";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(614, 130);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(156, 36);
            this.btnChange.TabIndex = 31;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(614, 172);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(156, 36);
            this.btnDel.TabIndex = 32;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(614, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 36);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_lession
            // 
            this.txt_lession.Location = new System.Drawing.Point(134, 155);
            this.txt_lession.Name = "txt_lession";
            this.txt_lession.Size = new System.Drawing.Size(152, 22);
            this.txt_lession.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tiết học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Thời gian";
            // 
            // txt_id_status
            // 
            this.txt_id_status.Enabled = false;
            this.txt_id_status.Location = new System.Drawing.Point(134, 83);
            this.txt_id_status.Name = "txt_id_status";
            this.txt_id_status.Size = new System.Drawing.Size(152, 22);
            this.txt_id_status.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã trạng thái";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tình trạng";
            this.columnHeader5.Width = 216;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã máy";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tiết học";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thời gian";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã trạng thái";
            this.columnHeader1.Width = 90;
            // 
            // lvStatus
            // 
            this.lvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvStatus.FullRowSelect = true;
            this.lvStatus.GridLines = true;
            this.lvStatus.HideSelection = false;
            this.lvStatus.Location = new System.Drawing.Point(12, 233);
            this.lvStatus.Name = "lvStatus";
            this.lvStatus.Size = new System.Drawing.Size(758, 258);
            this.lvStatus.TabIndex = 24;
            this.lvStatus.UseCompatibleStateImageBehavior = false;
            this.lvStatus.View = System.Windows.Forms.View.Details;
            this.lvStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvStatus_MouseClick);
            // 
            // permisionTableAdapter
            // 
            this.permisionTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "LỊCH SỬ TRẠNG THÁI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_id_comp
            // 
            this.cb_id_comp.DataSource = this.computerBindingSource;
            this.cb_id_comp.DisplayMember = "comp_name";
            this.cb_id_comp.Enabled = false;
            this.cb_id_comp.FormattingEnabled = true;
            this.cb_id_comp.Location = new System.Drawing.Point(134, 190);
            this.cb_id_comp.Name = "cb_id_comp";
            this.cb_id_comp.Size = new System.Drawing.Size(152, 24);
            this.cb_id_comp.TabIndex = 38;
            this.cb_id_comp.ValueMember = "id_comp";
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataMember = "computer";
            this.computerBindingSource.DataSource = this.qLPTHDataSet2;
            // 
            // qLPTHDataSet2
            // 
            this.qLPTHDataSet2.DataSetName = "QLPTHDataSet2";
            this.qLPTHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_detail
            // 
            this.txt_detail.Location = new System.Drawing.Point(326, 120);
            this.txt_detail.Name = "txt_detail";
            this.txt_detail.Size = new System.Drawing.Size(263, 94);
            this.txt_detail.TabIndex = 39;
            this.txt_detail.Text = "";
            // 
            // dtp_time
            // 
            this.dtp_time.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_time.Location = new System.Drawing.Point(134, 121);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(152, 22);
            this.dtp_time.TabIndex = 40;
            // 
            // computerTableAdapter
            // 
            this.computerTableAdapter.ClearBeforeFill = true;
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.txt_detail);
            this.Controls.Add(this.cb_id_comp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt_lession);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvStatus);
            this.Controls.Add(this.label1);
            this.Name = "StatusForm";
            this.Text = "Trạng thái";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txt_lession;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvStatus;
        private QLPTHDataSetTableAdapters.permisionTableAdapter permisionTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_id_comp;
        private System.Windows.Forms.RichTextBox txt_detail;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private QLPTHDataSet2 qLPTHDataSet2;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private QLPTHDataSet2TableAdapters.computerTableAdapter computerTableAdapter;
    }
}