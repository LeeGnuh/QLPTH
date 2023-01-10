using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }
        private void loadListViewRoom()
        {
            RoomBLL roomBLL = new RoomBLL();
            List<Room> ListRoom = roomBLL.getAllRoom();

            lvRoom.Items.Clear();

            foreach (Room room in ListRoom)
            {
                ListViewItem lvi = new ListViewItem(room.id_room + "");

                lvi.SubItems.Add(room.room_name + "");
                lvi.SubItems.Add(room.building + "");
                lvi.SubItems.Add(room.floor + "");

                lvRoom.Items.Add(lvi);

                lvi.Tag = room;
            }
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            loadListViewRoom();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Room room = new Room();

            room.id_room = int.Parse(txt_id_room.Text);
            room.room_name = txt_room_name.Text;
            room.building = txt_building.Text;
            room.floor = txt_floor.Text;

            RoomBLL roomBLL = new RoomBLL();
            bool kq = roomBLL.addRoom_Object(room);

            if (kq)
            {
                loadListViewRoom();
            }
            else
            {
                noti("Thêm");
            } 
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Room room = new Room();

            room.id_room = int.Parse(txt_id_room.Text);
            room.room_name = txt_room_name.Text;
            room.building = txt_building.Text;
            room.floor = txt_floor.Text;

            RoomBLL roomBLL = new RoomBLL();
            bool kq = roomBLL.changeRoom_At_Object(room.id_room, room);

            if (kq)
            {
                loadListViewRoom();
            }
            else
            {
                noti("Sửa");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvRoom.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvRoom.SelectedItems[0];
                Room room = lvi.Tag as Room;
                RoomBLL roomBLL = new RoomBLL();

                bool kq = roomBLL.deleteAt(room.id_room);

                if (kq)
                {
                    loadListViewRoom();
                }
            }
        }

        private void lvRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvRoom.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvRoom.SelectedItems[0];
                Room room = lvi.Tag as Room;

                txt_id_room.Text = room.id_room.ToString();
                txt_room_name.Text = room.room_name.ToString();
                txt_building.Text = room.building.ToString();
                txt_floor.Text = room.floor.ToString();             
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            RoomBLL roomBLL = new RoomBLL();         
            List<Room> ListRoom = roomBLL.searchRoom_Name(txt_search.Text);

            lvRoom.Items.Clear();

            foreach (Room room in ListRoom)
            {
                ListViewItem lvi = new ListViewItem(room.id_room + "");

                lvi.SubItems.Add(room.room_name + "");
                lvi.SubItems.Add(room.building + "");
                lvi.SubItems.Add(room.floor + "");

                lvRoom.Items.Add(lvi);

                lvi.Tag = room;
            }
        }

        private void lvRoom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ComputerForm computerForm = new ComputerForm();
            computerForm.id = int.Parse(txt_id_room.Text);
            computerForm.ShowDialog();
            this.Show();
        }
        private void noti(string s)
        {
            MessageBox.Show(s+" không thành công", "Thông báo");
        }
    }
}
