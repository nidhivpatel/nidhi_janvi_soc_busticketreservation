using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bus_Ticket_Booking
{
    [DataContract]
    class Payment
    {
        int id;
        string name;
        int card_no;
        string type;
        DateTime date;
        int cvv;
        int amount;

        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public int Card_no
        {
            get { return card_no; }
            set { card_no = value; }
        }

        [DataMember]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        [DataMember]
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        [DataMember]
        public int Cvv
        {
            get { return cvv; }
            set { cvv = value; }
        }


        [DataMember]
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        

    }
}
