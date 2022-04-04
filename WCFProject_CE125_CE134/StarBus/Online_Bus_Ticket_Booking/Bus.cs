using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bus_Ticket_Booking
{
    [DataContract]
    class Bus
    {
        int id;
        string source;
        string destination;
        DateTime dept_time;
        DateTime arrival_time;
        int bus_no;
        int price;
        

        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        [DataMember]
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
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
        public int Bus_no
        {
            get { return bus_no; }
            set { bus_no = value; }
        }
        [DataMember]
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
