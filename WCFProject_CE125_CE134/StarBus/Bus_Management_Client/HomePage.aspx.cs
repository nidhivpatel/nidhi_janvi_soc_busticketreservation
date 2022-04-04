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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "WELCOME TO STAR BUS!!";
            if (!IsPostBack)
            {

                BindData();

            }

        }
        protected void Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddTicket.aspx");
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
            Bus b = new Bus();
            string source = (string)e.NewValues["source"];
            string destination = (string)e.NewValues["destination"];
            DateTime dept_time = DateTime.Parse((string)e.NewValues["dept_time"]);
            DateTime arrival_time = DateTime.Parse((string)e.NewValues["arrival_time"]);
            int bus_no = int.Parse((string)e.NewValues["bus_no"]);
            int price = int.Parse((string)e.NewValues["price"]);
            Label1.Text = "Hello";
            b.ID = ID;
            b.Source = source;
            b.Destination = destination;
            b.Dept_time = dept_time;
            b.Arrival_time = arrival_time;
            b.Bus_no = bus_no;
            b.Price = price;
            pr.UpdateBus(b);
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Bus_Management_Client.ServiceReference1.Service1Client pr = new Bus_Management_Client.ServiceReference1.Service1Client("BasicHttpBinding_IService1");

            int ID = (int)e.Keys["Id"];
            pr.DeleteBus(ID);
            // Delete here the database record for the selected patientID

            BindData();
        }
        private void BindData()
        {
            Bus_Management_Client.ServiceReference1.Service1Client bs = new Bus_Management_Client.ServiceReference1.Service1Client("BasicHttpBinding_IService1");

            DataSet ds = bs.GetAllBus();
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

    }
}