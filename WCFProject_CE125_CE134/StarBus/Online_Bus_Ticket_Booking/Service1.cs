using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Online_Bus_Ticket_Booking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        bool IService1.AddBus(Bus b)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "insert into Bus(source,destination,dept_time,arrival_time,bus_no,price) values (@source,@destination,@dept_time,@arrival_time,@bus_no,@price)";
            SqlParameter para = new SqlParameter("@source",b.Source);
            SqlParameter para1 = new SqlParameter("@destination", b.Destination);
            SqlParameter para2 = new SqlParameter("@dept_time", b.Dept_time);
            SqlParameter para3 = new SqlParameter("@arrival_time", b.Arrival_time);
            SqlParameter para4 = new SqlParameter("@bus_no",b.Bus_no);
            SqlParameter para5 = new SqlParameter("@price", b.Price);

            cmd.Parameters.Add(para);
            cmd.Parameters.Add(para1);
            cmd.Parameters.Add(para2);
            cmd.Parameters.Add(para3);
            cmd.Parameters.Add(para4);
            cmd.Parameters.Add(para5);
            cnn.Open();
            int reader = cmd.ExecuteNonQuery();
            cnn.Close();
            if (reader == 0)
            {
                return false;
            }
            return true;
        }

        bool IService1.DeleteBus(int id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from Bus where id=@id";
            SqlParameter para = new SqlParameter("@id", id);

            cmd.Parameters.Add(para);
            cnn.Open();
            int reader = cmd.ExecuteNonQuery();
            cnn.Close();
            if (reader == 0)
            {
                NotFoundFolt nf = new NotFoundFolt();
                nf.Exception = "No record found with given ID";
                throw new FaultException<NotFoundFolt>(nf);
            }
            return true;
        }

        DataSet IService1.GetAllBus()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Bus",
               @"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "Bus");
            return ds;
        }

        Bus IService1.GetBus(int id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from Bus where id=@id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Bus bs = new Bus();
            if (reader.Read())
            {
                bs.ID = reader.GetInt32(0);
                bs.Source = reader.GetString(1);
                bs.Destination = reader.GetString(2);
                bs.Dept_time = reader.GetDateTime(3);
                bs.Arrival_time = reader.GetDateTime(4);
                bs.Bus_no = reader.GetInt32(5);
                bs.Price = reader.GetInt32(6);

            }
            else
            {
                NotFoundFolt nf = new NotFoundFolt();
                nf.Exception = "No record found with given ID";
                throw new FaultException<NotFoundFolt>(nf);
            }
            reader.Close();
            cnn.Close();
            return bs;
        }

        Bus IService1.UpdateBus(Bus b)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "update Bus set source=@source,destination=@destination,dept_time=@dept_time,arrival_time=@arrival_time,bus_no=@bus_no,price=@price where id=@id";
            SqlParameter para6 = new SqlParameter("@id", b.ID);
            SqlParameter para = new SqlParameter("@source", b.Source);
            SqlParameter para1 = new SqlParameter("@destination", b.Destination);
            SqlParameter para2 = new SqlParameter("@dept_time", b.Dept_time);
            SqlParameter para3 = new SqlParameter("@arrival_time", b.Arrival_time);
            SqlParameter para4 = new SqlParameter("@bus_no", b.Bus_no);
            SqlParameter para5 = new SqlParameter("@price", b.Price);

            cmd.Parameters.Add(para);
            cmd.Parameters.Add(para1);
            cmd.Parameters.Add(para2);
            cmd.Parameters.Add(para3);
            cmd.Parameters.Add(para4);
            cmd.Parameters.Add(para5);
            cmd.Parameters.Add(para6);
            cnn.Open();
            int reader = cmd.ExecuteNonQuery();
            cnn.Close();
            if (reader == 0)
            {
                NotFoundFolt nf = new NotFoundFolt();
                nf.Exception = "Some issue found in updating the product please try after some time!!";
                throw new FaultException<NotFoundFolt>(nf);
            }
            return b;
        }
        bool IService1.AddTicket(Ticket t)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "insert into Ticket(c_name,phone_no,c_to,c_from,dept_time,arrival_time,total_seat,seat_num,amount,status,email) values (@c_name,@phone_no,@c_to,@c_from,@dept_time,@arrival_time,@total_seat,@seat_num,@amount,@status,@email)";
            SqlParameter para = new SqlParameter("@c_name", t.C_name);
            SqlParameter para1 = new SqlParameter("@phone_no",t.Phone_no);
            SqlParameter para2 = new SqlParameter("@c_to", t.C_to);
            SqlParameter para3 = new SqlParameter("@c_from", t.C_from);
            SqlParameter para4 = new SqlParameter("@dept_time", t.Dept_time);
            SqlParameter para5 = new SqlParameter("@arrival_time", t.Arrival_time);
            SqlParameter para6 = new SqlParameter("@total_seat", t.Total_seat);
            SqlParameter para7 = new SqlParameter("@seat_num", t.Seat_num);
            SqlParameter para8 = new SqlParameter("@amount", t.Amount);
            SqlParameter para9 = new SqlParameter("@status", t.Status);
            SqlParameter para10 = new SqlParameter("@email", t.Email);
            

            cmd.Parameters.Add(para);
            cmd.Parameters.Add(para1);
            cmd.Parameters.Add(para2);
            cmd.Parameters.Add(para3);
            cmd.Parameters.Add(para4);
            cmd.Parameters.Add(para5);
            cmd.Parameters.Add(para6);
            cmd.Parameters.Add(para7);
            cmd.Parameters.Add(para8);
            cmd.Parameters.Add(para9);
            cmd.Parameters.Add(para10);
            cnn.Open();
            int reader = cmd.ExecuteNonQuery();
            cnn.Close();
            if (reader == 0)
            {
                return false;
            }
            return true;
        }

        bool IService1.DeleteTicket(int id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from Ticket where id=@id";
            SqlParameter para = new SqlParameter("@id", id);

            cmd.Parameters.Add(para);
            cnn.Open();
            int reader = cmd.ExecuteNonQuery();
            cnn.Close();
            if (reader == 0)
            {
                NotFoundFolt nf = new NotFoundFolt();
                nf.Exception = "No record found with given ID";
                throw new FaultException<NotFoundFolt>(nf);
            }
            return true;
        }

        DataSet IService1.GetAllTicket()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Ticket",
               @"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "Ticket");
            return ds;
        }

        DataSet IService1.GetCustTicket(string email)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "select * from Ticket where email=@email";
                SqlParameter p = new SqlParameter("@email", email);
                cmd.Parameters.Add(p);
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                var ls = new List<Ticket>();

                while(reader.Read())
                {
                    Ticket tc = new Ticket();
                    tc.ID = reader.GetInt32(0);
                    tc.C_name = reader.GetString(1);
                    tc.Phone_no = reader.GetString(2);
                    tc.C_to = reader.GetString(3);
                    tc.C_from = reader.GetString(4);
                    tc.Dept_time = reader.GetDateTime(5);
                    tc.Arrival_time = reader.GetDateTime(6);
                    tc.Total_seat = reader.GetInt32(7);
                    tc.Seat_num = reader.GetString(8);
                    tc.Amount = reader.GetInt32(9);
                    tc.Status = (bool)reader.GetSqlBoolean(10);
                    tc.Email = reader.GetString(11);
                    ls.Add(tc);
                }
                
                reader.Close();
                cnn.Close();
                DataSet converted = ToDataSet(ls);
                return converted;
            }
            catch(Exception e)
            {
                Console.WriteLine("Err");
                return new DataSet();
            }
        }
        public static DataSet ToDataSet<Ticket>(IList<Ticket> list)
        {

            Type elementType = typeof(Ticket);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                t.Columns.Add(propInfo.Name, propInfo.PropertyType);
            }

            //go through each property on T and add each value to the table
            foreach (Ticket item in list)
            {
                DataRow row = t.NewRow();
                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null);
                }

                //This line was missing:
                t.Rows.Add(row);
            }


            return ds;
        }
        Ticket IService1.GetTicket(int id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from Ticket where id=@id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Ticket tc = new Ticket();
            if (reader.Read())
            {
                tc.ID = reader.GetInt32(0);
                tc.C_name = reader.GetString(1);
                tc.Phone_no = reader.GetString(2);
                tc.C_to = reader.GetString(3);
                tc.C_from = reader.GetString(4);
                tc.Dept_time = reader.GetDateTime(5);
                tc.Arrival_time = reader.GetDateTime(6);
                tc.Total_seat = reader.GetInt32(7);
                tc.Seat_num= reader.GetString(8);
                tc.Amount = reader.GetInt32(9);
                tc.Status = (bool)reader.GetSqlBoolean(10);
                tc.Email = reader.GetString(11);

            }
            else
            {
                NotFoundFolt nf = new NotFoundFolt();
                nf.Exception = "No record found with given ID";
                throw new FaultException<NotFoundFolt>(nf);
            }
            reader.Close();
            cnn.Close();
            return tc; 
        }

        Ticket IService1.UpdateTicket(Ticket t)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "update Ticket set c_name=@c_name,phone_no=@phone_no,c_to=@c_to,c_from=@c_from,dept_time=@dept_time,arrival_time=@arrival_time,total_seat=@total_seat,seat_num=@seat_num,amount=@amount,status=@status,email=@email where id=@id";

            SqlParameter para11 = new SqlParameter("@id", t.ID);
            SqlParameter para = new SqlParameter("@c_name", t.C_name);
            SqlParameter para1 = new SqlParameter("@phone_no", t.Phone_no);
            SqlParameter para2 = new SqlParameter("@c_to", t.C_to);
            SqlParameter para3 = new SqlParameter("@c_from", t.C_from);
            SqlParameter para4 = new SqlParameter("@dept_time", t.Dept_time);
            SqlParameter para5 = new SqlParameter("@arrival_time", t.Arrival_time);
            SqlParameter para6 = new SqlParameter("@total_seat", t.Total_seat);
            SqlParameter para7 = new SqlParameter("@seat_num", t.Seat_num);
            SqlParameter para8 = new SqlParameter("@amount", t.Amount);
            SqlParameter para9 = new SqlParameter("@status", t.Status);
            SqlParameter para10 = new SqlParameter("@email", t.Email);


            cmd.Parameters.Add(para11);
            cmd.Parameters.Add(para);
            cmd.Parameters.Add(para1);
            cmd.Parameters.Add(para2);
            cmd.Parameters.Add(para3);
            cmd.Parameters.Add(para4);
            cmd.Parameters.Add(para5);
            cmd.Parameters.Add(para6);
            cmd.Parameters.Add(para7);
            cmd.Parameters.Add(para8);
            cmd.Parameters.Add(para9);
            cmd.Parameters.Add(para10);
            

            cnn.Open();
            int reader = cmd.ExecuteNonQuery();
            cnn.Close();
            if (reader == 0)
            {
                NotFoundFolt nf = new NotFoundFolt();
                nf.Exception = "Some issue found in updating the product please try after some time!!";
                throw new FaultException<NotFoundFolt>(nf);
            }
            return t;
        }
        bool IService1.AddPayment(Payment p)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ES1GCVKG\MSSQLSERVER01;Initial Catalog=Nidhi;Integrated Security=True-");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "insert into Payment(name,type,date,cvv,amount,card_no) values (@name,@type,@date,@cvv,@amount,@card_no)";
                SqlParameter para = new SqlParameter("@name", p.Name);
                SqlParameter para1 = new SqlParameter("@type", p.Type);
                SqlParameter para2 = new SqlParameter("@date", p.Date);
                SqlParameter para3 = new SqlParameter("@cvv", p.Cvv);
                SqlParameter para4 = new SqlParameter("@amount", p.Amount);
                SqlParameter para5 = new SqlParameter("@card_no", p.Card_no);

                cmd.Parameters.Add(para);
                cmd.Parameters.Add(para1);
                cmd.Parameters.Add(para2);
                cmd.Parameters.Add(para3);
                cmd.Parameters.Add(para4);
                cmd.Parameters.Add(para5);
                cnn.Open();
                int reader = cmd.ExecuteNonQuery();
                cnn.Close();
                if (reader == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e){
                Console.WriteLine("dghd");
                return false;
            }
        }
    }
}
