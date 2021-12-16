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
using AllTours.Forms;
using AllTours.Properties;

namespace AllTours
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

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

            //заполнение выпадающего списка c турами
            for (int i = 0; i < ListTours.listTours.Count; i++)
            {
                comboBox1.Items.Add(ListTours.listTours[i].name);
            }
            //заполнение выпадающего списка c типами билетов
            for (int i = 0; i < Enum.GetNames(typeof(TicketType)).Length; i++)
            {
                comboBox2.Items.Add((TicketType)i);
            }

            //выпадающие списки теперь ReadOnly
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            //начальное отображение времени при загрузки
            label3.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        //очистка БД
        private void Button3_Click(object sender, EventArgs e)
        {
            db.Connect();
            db.ClearAllInfo();
            db.Close();
        }

        //открытие формы с таблицами БД
        private void Button4_Click(object sender, EventArgs e)
        {
            FormWithDBs form = new FormWithDBs();
            form.ShowDialog();
        }

        //обновление показа времени
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        public void ButtonEnableCheck ()
        {
            if (textBoxName.Text == "" || textBoxPhone.Text == "" || textBoxEmail.Text == "" ||
                textBoxOrderPrice.Text == "" || selectedTicket == null || selectedTour == null ||
                !checkBoxIsOrderPaid.Checked)
                buttonAddOrder.Enabled = false;
            else
                buttonAddOrder.Enabled = true;
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableCheck();
        }
        private void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableCheck();
        }
        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableCheck();
        }
        private void TextBoxOrderPrice_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableCheck();
        }
        public string selectedTour;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTicket = comboBox1.SelectedItem.ToString();
            ButtonEnableCheck();
        }
        public string selectedTicket;
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTour = comboBox2.SelectedItem.ToString();
            ButtonEnableCheck();
        }

        private void CheckBoxIsOrderPaid_CheckedChanged(object sender, EventArgs e)
        {
            ButtonEnableCheck();
        }
    }
}
