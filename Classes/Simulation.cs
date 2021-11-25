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
        Client tempClient = new Client();
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
            _isActive = false;
        }

        
        public void MainGeneration()
        {
            while (_isActive)
            {
                //появляется клиент
                tempClient = Generator.GenerateClient();
                //создается заказ
                Generator.GenerateOrder(tempClient);
                //некая логика оплаты
                tempClient.order.isOrderPaid = true;
                //если заказ оплачен, то билет выдан
                if (tempClient.order.isOrderPaid) tempClient.ticket = Generator.GenerateTicket();

                label.Invoke(new Action(() => label.Text = "temptest" + i));
                i++;
                Thread.Sleep(1000);
            }
        }

    }

}
