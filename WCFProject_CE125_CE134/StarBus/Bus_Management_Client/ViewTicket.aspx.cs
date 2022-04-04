using Bus_Management_Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bus_Management_Client
{
    public partial class ViewTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Ticket Booked!!";
            if (!IsPostBack)
            {

                BindData();

            }
        }
        
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Bus_Management_Client.ServiceReference1.Service1Client pr = new Bus_Management_Client.ServiceReference1.Service1Client("BasicHttpBinding_IService1");

            int ID = (int)e.Keys["Id"];
            Ticket t = new Ticket();
            string c_name= (string)e.NewValues["c_name"]; ;
            string phone_no= (string)e.NewValues["phone_no"]; ;
            string c_to= (string)e.NewValues["c_to"]; ;
            string c_from= (string)e.NewValues["c_from"]; ;
            DateTime dept_time = DateTime.Parse((string)e.NewValues["dept_time"]);
            DateTime arrival_time = DateTime.Parse((string)e.NewValues["arrival_time"]);
            int total_seat= int.Parse((string)e.NewValues["total_seat"]); ;
            string seat_num= (string)e.NewValues["source"]; ;
            int amount= int.Parse((string)e.NewValues["amount"]); ;
            Boolean status=bool.Parse((string)e.NewValues["status"]);
            string email= (string)e.NewValues["source"]; ;
            Label1.Text = "Hello";
            t.ID = ID;
            t.C_name = c_name;
            t.Phone_no = phone_no;
            t.C_to = c_to;
            t.C_from = c_from;
            t.Dept_time = dept_time;
            t.Arrival_time = arrival_time;
            t.Total_seat = total_seat;
            t.Seat_num = seat_num;
            t.Amount = amount;
            t.Status = status;
            t.Email = email;
            pr.UpdateTicket(t);
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Bus_Management_Client.ServiceReference1.Service1Client pr = new Bus_Management_Client.ServiceReference1.Service1Client("BasicHttpBinding_IService1");

            int ID = (int)e.Keys["Id"];
            pr.DeleteTicket(ID);
            // Delete here the database record for the selected patientID

            BindData();
        }
        private void BindData()
        {
            Bus_Management_Client.ServiceReference1.Service1Client bs = new Bus_Management_Client.ServiceReference1.Service1Client("BasicHttpBinding_IService1");

            DataSet ds = bs.GetAllTicket();
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}