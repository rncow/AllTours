using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTours
{

    public class Client
    {
        public string name;
        public string phone;
        public string email;

        
    }

    public class Order
    {
        public DateTime orderTime;
        public Client client;
        public Tour tour;
        public Ticket ticket;
        public int price;
        public bool isOrderPaid;
        
    }

    public class Ticket
    {
        public string id;
        public TicketType ticketType;
    }

    public static class Counter
    {
        public static int id;
    }
}
