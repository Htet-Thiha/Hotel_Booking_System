using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class RoomForm : BaseForm 
    {
        public RoomForm()
        {
            InitializeComponent();
            roomStatusBox.DataSource = new List<string> { "booked", "available", "checkIn" };
            var roomTypes = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Deluxe_Room"),
                new KeyValuePair<int, string>(2, "Premier_Room"),
                new KeyValuePair<int, string>(3, "Executive_Suite"),
                new KeyValuePair<int, string>(4, "Presidential_Suite"),
                new KeyValuePair<int, string>(5, "Family_Room"),              
            };
            roomTypeBox.DataSource = roomTypes;
            roomTypeBox.DisplayMember = "Value";
            roomTypeBox.ValueMember = "Key";

        }
        int roomTypeId;
        int roomId;
        RoomType roomType = new RoomType();
        Room room = new Room();

        private void RoomForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hBS_DBDataSet3.tblRoom' table. You can move, or remove it, as needed.
            this.tblRoomTableAdapter.Fill(this.hBS_DBDataSet3.tblRoom);

        }

        private void roomDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (roomDataGridView.CurrentRow != null)
            {
                DataGridViewRow row = roomDataGridView.CurrentRow;

                RoomNoLbl.Text = row.Cells["roomnoDataGridViewTextBoxColumn"].Value.ToString();
                RoomNoBox.Text = row.Cells["roomnoDataGridViewTextBoxColumn"].Value.ToString();
                roomStatusBox.SelectedItem = row.Cells["statusDataGridViewTextBoxColumn"].Value.ToString();
                roomTypeId = Convert.ToInt32(row.Cells["roomTypeIdDataGridViewTextBoxColumn"].Value);
                roomId = Convert.ToInt32(row.Cells["roomIDDataGridViewTextBoxColumn"].Value);
                roomTypeBox.SelectedValue = roomTypeId;
                if (roomTypeId > 0) 
                {
                    DataRow selectedRoomType = roomType.GetRoomTypeById(roomTypeId);

                    roomTypeLbl.Text = selectedRoomType["room_type"].ToString();
                    roomPriceLbl.Text = selectedRoomType["price_per_night"].ToString();
                    maxPersonLbl.Text = selectedRoomType["max_person"].ToString();
                    extraAvailableLbl.Text = selectedRoomType["extra_available"].ToString();
                    extraPriceLbl.Text = selectedRoomType["extra_fee"].ToString();
                    serviceLbl.Text = selectedRoomType["service"].ToString();



                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string roomNo = RoomNoBox.Text;
            string roomStatus = roomStatusBox.SelectedValue.ToString();
            int roomTypeId = Convert.ToInt32(roomTypeBox.SelectedValue);

            if (string.IsNullOrEmpty(roomNo) || string.IsNullOrEmpty(roomStatus) || roomTypeId < 1)
            {
                MessageBox.Show("Room can't be added. Please fill all fields correctly.");
                return;
            }
            Room room1 = new Room(roomNo, roomTypeId, roomStatus);
            room1.AddRoom();
            LoadRooms();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string roomNo = RoomNoBox.Text;
            string roomStatus = roomStatusBox.SelectedValue.ToString();
            int roomTypeId = Convert.ToInt32(roomTypeBox.SelectedValue);

            if (string.IsNullOrEmpty(roomNo) || string.IsNullOrEmpty(roomStatus) || roomTypeId < 1 || roomId < 1)
            {
                MessageBox.Show("Room can't be updated. Please fill all fields correctly.");
                return;
            }
            Room room = new Room();
            room.UpdateRoom(roomId, roomNo, roomTypeId, roomStatus);
            LoadRooms();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (roomId < 1)
            {
                MessageBox.Show("Room can't be delete.");
                return;
            }
            
            room.DeleteRoom(roomId);
            LoadRooms();
        }

        private void LoadRooms()
        {
            DataSet ds = room.GetRooms();
            roomDataGridView.DataSource = ds.Tables["tblRoom"];
        }

    }
}
