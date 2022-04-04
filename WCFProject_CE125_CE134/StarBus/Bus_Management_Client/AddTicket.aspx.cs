using Bus_Management_Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bus_Management_Client
{
    public partial class AddTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Bus_Management_Client.ServiceReference1.Service1Client bm = new Bus_Management_Client.ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            Ticket t = new ServiceReference1.Ticket();
            t.C_name = TextBox1.Text;
            t.Phone_no = TextBox2.Text;
            t.C_to = TextBox3.Text;
            t.C_from = TextBox4.Text;
            t.Dept_time = DateTime.Parse(TextBox5.Text);
            t.Arrival_time = DateTime.Parse(TextBox6.Text);
            t.Total_seat = int.Parse(TextBox7.Text);
            t.Seat_num = TextBox8.Text;
            t.Email= TextBox9.Text;
            t.Status = true;
            t.Amount = int.Parse(TextBox10.Text);



            bm.AddTicket(t);
            Response.Redirect("Payment.aspx");
        }
    }
}