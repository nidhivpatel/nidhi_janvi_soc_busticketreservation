using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bus_Management_Client
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            Bus_Management_Client.ServiceReference1.Service1Client bm = new Bus_Management_Client.ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            ServiceReference1.Payment p = new ServiceReference1.Payment();
            p.Name= TextBox1.Text;
            p.Card_no= int.Parse(TextBox2.Text);
            p.Type = TextBox3.Text;
            p.Date = DateTime.Parse(TextBox4.Text);
            p.Cvv = int.Parse(TextBox5.Text);
            p.Amount = int.Parse(TextBox6.Text);

            bm.AddPayment(p);

            Response.Redirect("PrintTicket.aspx");
        }
    }
}