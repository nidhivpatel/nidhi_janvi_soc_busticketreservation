using Bus_Management_Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bus_Management_Client
{
    public partial class AddBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Bus_Management_Client.ServiceReference1.Service1Client bm = new Bus_Management_Client.ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            Bus b = new ServiceReference1.Bus();
            b.Source = TextBox1.Text;
            b.Destination = TextBox2.Text;
            b.Dept_time = DateTime.Parse(TextBox3.Text);
            b.Arrival_time= DateTime.Parse(TextBox4.Text);
            b.Bus_no = int.Parse(TextBox5.Text);
            b.Price = int.Parse(TextBox6.Text);

            bm.AddBus(b);
            Response.Redirect("Update_delete_bus.aspx");
        }
    }
}