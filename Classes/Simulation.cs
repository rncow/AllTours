using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using AllTours.Properties;
using AllTours.Classes;

namespace AllTours
{
    public class Simulation
    {
        Client tempClient = new Client();
        Order tempOrder = new Order();
        DBConnector db = new DBConnector();
        bool _isActive;
        public Label label;
        int i = 0;

        public void Start()
        {
            if (!_isActive)
            {
                _isActive = true;
                Task.Run(() => MainGeneration());
            }
        }

        public void Stop()
        {
            if (_isActive)
            {
                _isActive = false;
                db.Close();
            }
        }


        public void MainGeneration()
        {
            // загрузка счетчика
            Counter.id = int.Parse(Settings.Default["ID"].ToString());
            db.Connect();
            while (_isActive)
            {
                //появляется клиент
                tempClient = Generator.GenerateClient();
                //создается заказ
                tempOrder = Generator.GenerateOrder(tempClient);
                //некая логика оплаты
                tempOrder.isOrderPaid = true;
                //если заказ оплачен, то билет выдан
                if (tempOrder.isOrderPaid) tempOrder.ticket = Generator.GenerateTicket();
                //добавить информацию в БД
                db.AddInfoIntoDatabase(tempOrder);
                Counter.id++;
                //сохранение значения счётчика
                Settings.Default["ID"] = Counter.id;
                Settings.Default.Save();
                

                label.Invoke(new Action(() => label.Text = "temptest" + i));
                i++;
                

                Thread.Sleep(SimProperties.generationSpeed);
            }
        }
        public void CreateOrderFromForm(string name, string phone, string email, string tour, string price, string ticket, string details)
        {
            Order order = new Order();
            order.orderTime = DateTime.Now;
            order.client = new Client();
            order.client.name = name;
            order.client.phone = phone;
            order.client.email = email;
            //получение тура по называнию тура
            for (int i = 0; i < ListTours.listTours.Count; i++)
                if (tour == ListTours.listTours[i].name)
                    order.tour = ListTours.listTours[i];
            order.price = Convert.ToInt32(price);
            order.ticket = Generator.GenerateTicket();
            //получение типа билета по названию типа
            for (int i = 0; i < Enum.GetNames(typeof(TicketType)).Length; i++)
                if (ticket == Enum.GetName(typeof(TicketType), i))
                    order.ticket.ticketType = (TicketType)Enum.GetValues(typeof(TicketType)).GetValue(i);
            if (order.tour is BusinessTour)
                ((BusinessTour)order.tour).organization = details;
            if (order.tour is ExclusiveTour)
                ((ExclusiveTour)order.tour).exclusiveDetails = details;
            //загрузка счётчика
            Counter.id = int.Parse(Settings.Default["ID"].ToString());
            Counter.id++;
            //сохранение значения счётчика
            Settings.Default["ID"] = Counter.id;
            Settings.Default.Save();
            db.Connect();
            db.AddInfoIntoDatabase(order);
            db.Close();
        }
        
    }

}
