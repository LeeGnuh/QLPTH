namespace GUI
{
    partial class ScheduceForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txt_num_of_less = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lesson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvScheduce = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_id_subj = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPTHDataSet4 = new GUI.QLPTHDataSet4();
            this.cb_id_room = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPTHDataSet5 = new GUI.QLPTHDataSet5();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.qLPTHDataSet3 = new GUI.QLPTHDataSet3();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new GUI.QLPTHDataSet3TableAdapters.teacherTableAdapter();
            this.subjectTableAdapter = new GUI.QLPTHDataSet4TableAdapters.subjectTableAdapter();
            this.roomTableAdapter = new GUI.QLPTHDataSet5TableAdapters.roomTableAdapter();
            this.cb_id_tea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tiết bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tên phòng";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(614, 124);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(156, 36);
            this.btnChange.TabIndex = 31;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(614, 166);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(156, 36);
            this.btnDel.TabIndex = 32;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(614, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 36);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_num_of_less
            // 
            this.txt_num_of_less.Location = new System.Drawing.Point(413, 168);
            this.txt_num_of_less.Name = "txt_num_of_less";
            this.txt_num_of_less.Size = new System.Drawing.Size(152, 22);
            this.txt_num_of_less.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên môn học";
            // 
            // txt_lesson
            // 
            this.txt_lesson.Location = new System.Drawing.Point(413, 133);
            this.txt_lesson.Name = "txt_lesson";
            this.txt_lesson.Size = new System.Drawing.Size(152, 22);
            this.txt_lesson.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên giảng viên";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(133, 76);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(152, 22);
            this.txt_id.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã ";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tiết bắt đầu";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày học";
            this.columnHeader5.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã phòng";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã môn học";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã giảng viên";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // lvScheduce
            // 
            this.lvScheduce.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvScheduce.FullRowSelect = true;
            this.lvScheduce.GridLines = true;
            this.lvScheduce.HideSelection = false;
            this.lvScheduce.Location = new System.Drawing.Point(12, 233);
            this.lvScheduce.Name = "lvScheduce";
            this.lvScheduce.Size = new System.Drawing.Size(758, 258);
            this.lvScheduce.TabIndex = 24;
            this.lvScheduce.UseCompatibleStateImageBehavior = false;
            this.lvScheduce.View = System.Windows.Forms.View.Details;
            this.lvScheduce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvScheduce_MouseClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "QUẢN LÝ THỜI KHÓA BIỂU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Số tiết";
            // 
            // cb_id_subj
            // 
            this.cb_id_subj.DataSource = this.subjectBindingSource;
            this.cb_id_subj.DisplayMember = "subj_name";
            this.cb_id_subj.FormattingEnabled = true;
            this.cb_id_subj.Location = new System.Drawing.Point(133, 148);
            this.cb_id_subj.Name = "cb_id_subj";
            this.cb_id_subj.Size = new System.Drawing.Size(152, 24);
            this.cb_id_subj.TabIndex = 38;
            this.cb_id_subj.ValueMember = "id_subj";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.qLPTHDataSet4;
            // 
            // qLPTHDataSet4
            // 
            this.qLPTHDataSet4.DataSetName = "QLPTHDataSet4";
            this.qLPTHDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_id_room
            // 
            this.cb_id_room.DataSource = this.roomBindingSource;
            this.cb_id_room.DisplayMember = "room_name";
            this.cb_id_room.FormattingEnabled = true;
            this.cb_id_room.Location = new System.Drawing.Point(133, 183);
            this.cb_id_room.Name = "cb_id_room";
            this.cb_id_room.Size = new System.Drawing.Size(152, 24);
            this.cb_id_room.TabIndex = 41;
            this.cb_id_room.ValueMember = "id_room";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "room";
            this.roomBindingSource.DataSource = this.qLPTHDataSet5;
            // 
            // qLPTHDataSet5
            // 
            this.qLPTHDataSet5.DataSetName = "QLPTHDataSet5";
            this.qLPTHDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtp_time
            // 
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_time.Location = new System.Drawing.Point(413, 99);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(152, 22);
            this.dtp_time.TabIndex = 42;
            // 
            // qLPTHDataSet3
            // 
            this.qLPTHDataSet3.DataSetName = "QLPTHDataSet3";
            this.qLPTHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.qLPTHDataSet3;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // cb_id_tea
            // 
            this.cb_id_tea.DataSource = this.teacherBindingSource;
            this.cb_id_tea.DisplayMember = "tea_name";
            this.cb_id_tea.FormattingEnabled = true;
            this.cb_id_tea.Location = new System.Drawing.Point(133, 112);
            this.cb_id_tea.Name = "cb_id_tea";
            this.cb_id_tea.Size = new System.Drawing.Size(152, 24);
            this.cb_id_tea.TabIndex = 43;
            this.cb_id_tea.ValueMember = "id_tea";
            // 
            // ScheduceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.cb_id_tea);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.cb_id_room);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_id_subj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt_num_of_less);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_lesson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvScheduce);
            this.Controls.Add(this.label1);
            this.Name = "ScheduceForm";
            this.Text = "Thời khóa biểu";
            this.Load += new System.EventHandler(this.ScheduceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txt_num_of_less;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lesson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvScheduce;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_id_subj;
        private System.Windows.Forms.ComboBox cb_id_room;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private QLPTHDataSet3 qLPTHDataSet3;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private QLPTHDataSet3TableAdapters.teacherTableAdapter teacherTableAdapter;
        private QLPTHDataSet4 qLPTHDataSet4;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private QLPTHDataSet4TableAdapters.subjectTableAdapter subjectTableAdapter;
        private QLPTHDataSet5 qLPTHDataSet5;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private QLPTHDataSet5TableAdapters.roomTableAdapter roomTableAdapter;
        private System.Windows.Forms.ComboBox cb_id_tea;
    }
}