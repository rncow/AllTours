using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllTours.Properties;

namespace AllTours
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
       

        //public void AddLabel (Order order, int i)
        //{ 
        //    Label label = new Label();
        //    label.Left = 10;
        //    label.Top = 10 + 50 * i;
        //    label.Name = "lbl" + i;
        //    label.Text = "Клиент " + order.client.name + "\n" + order.client.phone + "\n" + order.client.email;
        //    label.AutoSize = true;
        //    Controls.Add(label);
        //    label.Refresh();

        //    Label label2 = new Label();
        //    label2.Left = 180;
        //    label2.Top = 10 + 50 * i;
        //    label2.Name = "lbl2." + i;
        //    if (order.isOrderPaid) label2.Text = "Дата и время заказа: " + order.orderTime + "\nВыбранный тур: " + order.tour.name + "\nСтатус: оплачен";
        //    else label2.Text = "Дата и время заказа: " + order.orderTime + "\nВыбранный тур: " + order.tour.name + "\nСтатус: не оплачен";
        //    label2.AutoSize = true;
        //    Controls.Add(label2);
        //    label2.Refresh();

        //    Label label3 = new Label();
        //    label3.Left = 420;
        //    label3.Top = 10 + 50 * i;
        //    label3.Name = "lbl3." + i;
        //    label3.Text = "ID билета: " + order.client.ticket.id + "\nТип билета: " + order.client.ticket.ticketType.ToString();
        //    label3.AutoSize = true;
        //    Controls.Add(label3);
        //    label3.Refresh();
        //}
        DBConnector db = new DBConnector();
        Simulation generation;
        
        private void Button1_Click(object sender, EventArgs e)
        {
            generation.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            generation.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Counter.id = int.Parse(Settings.Default["ID"].ToString());
            generation = new Simulation();
            generation.label = label1;
            label1.Text = "" + Counter.id;
        }

    }
}
