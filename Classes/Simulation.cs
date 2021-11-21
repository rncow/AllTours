using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AllTours
{
    public class Simulation
    {
        List<Client> clients = new List<Client>();
        bool _isActive;
        public Label label;


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
            _isActive = false;
        }

        
        public void MainGeneration()
        {
            while (_isActive)
            {
                //появляется клиент
                clients.Add(Generator.GenerateClient());
                //создается заказ
                Generator.GenerateOrder(clients.Last());
                //некая логика оплаты
                clients.Last().order.isOrderPaid = true;
                //если заказ оплачен, то билет выдан
                if (clients.Last().order.isOrderPaid) clients.Last().ticket = Generator.GenerateTicket();

                label.Invoke(new Action(() => label.Text = "asd"));

                Thread.Sleep(2000);
            }
        }

    }

}
