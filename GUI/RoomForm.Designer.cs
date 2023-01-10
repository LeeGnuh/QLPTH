namespace GUI
{
    partial class RoomForm
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
            this.txt_floor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txt_building = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_room_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_room = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRoom = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_floor
            // 
            this.txt_floor.Location = new System.Drawing.Point(376, 178);
            this.txt_floor.Name = "txt_floor";
            this.txt_floor.Size = new System.Drawing.Size(152, 22);
            this.txt_floor.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tầng";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(583, 118);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(156, 36);
            this.btnChange.TabIndex = 31;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(583, 160);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(156, 36);
            this.btnDel.TabIndex = 32;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(583, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 36);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_building
            // 
            this.txt_building.Location = new System.Drawing.Point(376, 144);
            this.txt_building.Name = "txt_building";
            this.txt_building.Size = new System.Drawing.Size(152, 22);
            this.txt_building.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tòa nhà";
            // 
            // txt_room_name
            // 
            this.txt_room_name.Location = new System.Drawing.Point(376, 109);
            this.txt_room_name.Name = "txt_room_name";
            this.txt_room_name.Size = new System.Drawing.Size(152, 22);
            this.txt_room_name.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên phòng";
            // 
            // txt_id_room
            // 
            this.txt_id_room.Enabled = false;
            this.txt_id_room.Location = new System.Drawing.Point(376, 72);
            this.txt_id_room.Name = "txt_id_room";
            this.txt_id_room.Size = new System.Drawing.Size(152, 22);
            this.txt_id_room.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã phòng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tầng";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tòa nhà";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên phòng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phòng";
            this.columnHeader1.Width = 100;
            // 
            // lvRoom
            // 
            this.lvRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvRoom.FullRowSelect = true;
            this.lvRoom.GridLines = true;
            this.lvRoom.HideSelection = false;
            this.lvRoom.Location = new System.Drawing.Point(12, 235);
            this.lvRoom.Name = "lvRoom";
            this.lvRoom.Size = new System.Drawing.Size(758, 258);
            this.lvRoom.TabIndex = 24;
            this.lvRoom.UseCompatibleStateImageBehavior = false;
            this.lvRoom.View = System.Windows.Forms.View.Details;
            this.lvRoom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvRoom_MouseClick);
            this.lvRoom.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvRoom_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "QUẢN LÝ PHÒNG MÁY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(72, 121);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(152, 22);
            this.txt_search.TabIndex = 38;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(107, 158);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 25);
            this.btn_Search.TabIndex = 39;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_floor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt_building);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_room_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id_room);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvRoom);
            this.Controls.Add(this.label1);
            this.Name = "RoomForm";
            this.Text = "Phòng máy";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_floor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txt_building;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_room_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_room;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Search;
    }
}