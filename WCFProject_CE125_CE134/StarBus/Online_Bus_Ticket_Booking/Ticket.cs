using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bus_Ticket_Booking
{
    [DataContract]
    class Ticket
    {
        int id;
        string c_name;
        string phone_no;
        string c_to;
        string c_from;
        DateTime dept_time;
        DateTime arrival_time;
        int total_seat;
        string seat_num;
        int amount;
        Boolean status;
        string email;

        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string C_name
        {
            get { return c_name; }
            set { c_name = value; }
        }

        [DataMember]
        public string Phone_no
        {
            get { return phone_no; }
            set { phone_no = value; }
        }


        [DataMember]
        public string C_to
        {
            get { return c_to; }
            set { c_to= value; }
        }
        [DataMember]
        public string C_from
        {
            get { return c_from; }
            set { c_from = value; }
        }

        [DataMember]
        public DateTime Dept_time
        {
            get { return dept_time; }
            set { dept_time = value; }
        }

        [DataMember]
        public DateTime Arrival_time
        {
            get { return arrival_time; }
            set { arrival_time = value; }
        }
        [DataMember]
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        [DataMember]
        public int Total_seat
        {
            get { return total_seat; }
            set { total_seat = value; }
        }
        [DataMember]
        public string Seat_num
        {
            get { return seat_num; }
            set { seat_num = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }
        
    }
}
