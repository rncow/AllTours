using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using AllTours.Properties;

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

                db.Insert($"INSERT INTO Clients VALUES ({Counter.id}, N'{tempClient.name}', '{tempClient.phone}', '{tempClient.email}');");
                db.Insert($"INSERT INTO Tickets VALUES ({Counter.id}, '{tempOrder.ticket.id}', N'{tempOrder.ticket.ticketType}');");
                db.Insert($"INSERT INTO Orders VALUES ({Counter.id}, {Counter.id}, {Counter.id}, '{tempOrder.orderTime}', N'{tempOrder.tour.name}', 1, 1);");

                label.Invoke(new Action(() => label.Text = "temptest" + i));
                i++;
                Counter.id++;

                Thread.Sleep(1000);
                //сохранение значения счётчика
                Settings.Default["ID"] = Counter.id;
                Settings.Default.Save();
            }
        }

    }

}
