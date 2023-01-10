using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AccountDAL : DataAccessDAL
    {
        List<Account> ListAcc = new List<Account>();
        public List<Account> getAllAcc()
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from Account";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Account acc = new Account();

                acc.id_acc = reader.GetInt32(0);               
                acc.username = reader.GetString(1);
                acc.password = reader.GetString(2);
                acc.id_per = reader.GetInt32(3);
                acc.full_name = reader.GetString(4);
                acc.acc_ban = reader.GetBoolean(5);

                ListAcc.Add(acc);
            }
            reader.Close();
            return ListAcc;
        }
        public List<Account> select_id(int id)
        {
            List<Account> list = new List<Account>();

            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from Account Where id_acc = @id";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Account acc = new Account();

                acc.id_acc = reader.GetInt32(0);
                acc.username = reader.GetString(1);
                acc.password = reader.GetString(2);
                acc.id_per = reader.GetInt32(3);
                acc.full_name = reader.GetString(4);
                acc.acc_ban = reader.GetBoolean(5);

                list.Add(acc);
            }
            reader.Close();
            return list;
        }

        public bool deleteAt(int id)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from Account where id_acc = @id";
            commnand.Connection = conn;

            commnand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }

        public bool addAcc_Object(Account Acc)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into Account Values(@Uname,@pass,@id_per,@FName,@ban)";
            command.Connection = conn;

            command.Parameters.Add("@Uname", SqlDbType.VarChar).Value = Acc.username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = Acc.password;
            command.Parameters.Add("@id_per", SqlDbType.Int).Value = Acc.id_per;
            command.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = Acc.full_name;
            command.Parameters.Add("@ban", SqlDbType.Bit).Value = Acc.acc_ban;

            int kq = command.ExecuteNonQuery();

            return kq > 0;

        }
        public bool changeAcc_At_Object(int id, Account Acc)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE Account SET username = @Uname, password = @pass, id_per = @id_per, full_name = @Fname, acc_ban = @ban WHERE id_acc = @id";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Uname", SqlDbType.VarChar).Value = Acc.username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = Acc.password;
            command.Parameters.Add("@id_per", SqlDbType.Int).Value = Acc.id_per;
            command.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = Acc.full_name;
            command.Parameters.Add("@ban", SqlDbType.Bit).Value = Acc.acc_ban;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }
        public int user_login(string username, string pass)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from Account Where username = @uname";
            command.Connection = conn;

            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;

            SqlDataReader reader = command.ExecuteReader();
            Account acc = new Account();

            while (reader.Read())
            {
                acc.id_acc = reader.GetInt32(0);
                acc.username = reader.GetString(1);
                acc.password = reader.GetString(2);
                acc.id_per = reader.GetInt32(3);
                acc.full_name = reader.GetString(4);
                acc.acc_ban = reader.GetBoolean(5);                                
            }
            reader.Close();
            if (acc != null) if (acc.password == pass) return acc.id_per;
            return 0;          
        }
        public string check_per(int id)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from permision Where id_per = @id";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataReader reader = command.ExecuteReader();

            int id_per;
            string per = "";

            while (reader.Read())
            {
                id_per = reader.GetInt32(0);
                per = reader.GetString(1);                
            }
            reader.Close();
            return per;
         }
    }
}
