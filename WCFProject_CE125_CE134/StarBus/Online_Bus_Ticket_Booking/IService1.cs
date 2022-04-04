using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Online_Bus_Ticket_Booking
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    interface IService1
    {
        [OperationContract]
        bool AddBus(Bus b);

        [OperationContract]
        Bus UpdateBus(Bus b);

        [OperationContract]
        [FaultContract(typeof(NotFoundFolt))]
        bool DeleteBus(int id);
        [OperationContract]
        Bus GetBus(int id);
        [OperationContract]
        DataSet GetAllBus();

        [OperationContract]
        bool AddTicket(Ticket t);

        [OperationContract]
        Ticket  UpdateTicket(Ticket t);

        [OperationContract]
        [FaultContract(typeof(NotFoundFolt))]
        bool DeleteTicket(int id);
        [OperationContract]
        Ticket  GetTicket(int id);
        [OperationContract]
        DataSet GetAllTicket();

        [OperationContract]
        DataSet GetCustTicket(string email);

        [OperationContract]
        bool AddPayment(Payment p);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class NotFoundFolt
    {
        private string exception;

        [DataMember]
        public String Exception { get; set; }
    }
}
