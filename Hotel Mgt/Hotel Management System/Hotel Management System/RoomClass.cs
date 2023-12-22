using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    class RoomClass
    {
        DBConnect connect = new DBConnect();

        public DataTable getRoomType()
        {
            string selectQuery = "SELECT * FROM `category`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //add
        public bool addRoom(string no, int type, string phone, string status)
        {
            string insertQuerry = "INSERT INTO `room`(`RoomId`, `RoomType`, `RoomPhone`, `RoomStatus`) VALUES (@no,@type,@ph,@sts)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        public DataTable getRoomList()
        {
            string selectQuery = "SELECT * FROM `room`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //edit
        public bool editRoom(string no, int type, string phone, string status)
        {
            string editQuerry = "UPDATE `room` SET `RoomType`=@type,`RoomPhone`=@ph,`RoomStatus`=@sts WHERE `RoomId`=@no";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
            
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        //delete
        public bool removeRoom(string id)
        {
            string insertQuerry = "DELETE FROM `room` WHERE `RoomId`=@id";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }
    }
}
