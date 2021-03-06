using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTours
{
    public class Generator
    {
        public static Client GenerateClient()
        {
            Random rnd = new Random();
            return new Client()
            {
                name = ((Names)rnd.Next(Enum.GetNames(typeof(Names)).Length)).ToString(),
                phone = "+79" + rnd.Next(100000000, 999999999),
                email = ((EmailFirstParts)rnd.Next(Enum.GetNames(typeof(EmailFirstParts)).Length)).ToString()
                        + ((EmailFirstParts)rnd.Next(Enum.GetNames(typeof(EmailFirstParts)).Length)).ToString()
                        + rnd.Next(1, 99)
                        + "@" + ((EmailSecondParts)rnd.Next(Enum.GetNames(typeof(EmailSecondParts)).Length)).ToString() + ".ru"
            };
        }
        public static Ticket GenerateTicket()
        {
            Random rnd = new Random();
            string temp = null;
            for (int i = 0; i < 20; i++) temp += rnd.Next(0, 9);
            return new Ticket()
            {
                id = temp,
                ticketType = ((TicketType)rnd.Next(Enum.GetNames(typeof(TicketType)).Length)),
            };
        }
        public static Order GenerateOrder(Client client)
        {
            Random rnd = new Random();
            int temp = rnd.Next(0, ListTours.listTours.Count);
            int temp2 = rnd.Next(0, 4000);
            Order order = new Order()
            {
                orderTime = DateTime.Now,
                client = client,
                tour = ListTours.listTours[temp],
            };
            order.price = order.tour.cost + temp2;
            if (order.tour is BusinessTour) { 
                ((BusinessTour)order.tour).organization = "organizationName";
            }
            return order;
        }
    }
}
