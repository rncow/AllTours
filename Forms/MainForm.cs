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
        
        //запустить генерацию
        private void Button1_Click(object sender, EventArgs e)
        {
            generation.Start();
            generation.label = label;
        }

        //остановить генерацию
        private void Button2_Click(object sender, EventArgs e)
        {
            generation.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Counter.id = int.Parse(Settings.Default["ID"].ToString());
            generation = new Simulation();

            //заполнение выпадающего списка c типами билетов
            for (int i = 0; i < Enum.GetNames(typeof(TicketType)).Length; i++)
            {
                comboBox2.Items.Add((TicketType)i);
            }

            //выпадающие списки теперь ReadOnly
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
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

        //проверка на доступность кнопки. Кнопка будет доступна только тогда, когда все необходимые поля будут заполнены
        public void ButtonEnableCheck ()
        {
            if (textBoxName.Text == "" || textBoxPhone.Text == "" || textBoxEmail.Text == "" ||
                textBoxOrderPrice.Text == "" || selectedTicket == null || selectedTour == null ||
                !checkBoxIsOrderPaid.Checked)
                buttonAddOrder.Enabled = false;
            else
                buttonAddOrder.Enabled = true;
        }
        //отслеживание изменений
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
            selectedTour = comboBox1.SelectedItem.ToString();
            ButtonEnableCheck();
        }
        public string selectedTicket;
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTicket = comboBox2.SelectedItem.ToString();
            ButtonEnableCheck();
        }

        private void CheckBoxIsOrderPaid_CheckedChanged(object sender, EventArgs e)
        {
            ButtonEnableCheck();
        }
        //конец отслеживаемых полей

        //создать и добавить заказ в бд
        private void ButtonAddOrder_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxOrderPrice.Text, out int test))
            {
                if (selectedTourType == "Business")
                {
                    generation.CreateOrderFromForm(textBoxName.Text, textBoxPhone.Text, textBoxEmail.Text, selectedTour, textBoxOrderPrice.Text, selectedTicket, textBoxOrganization.Text);
                }
                else if (selectedTourType == "Exclusive")
                {
                    generation.CreateOrderFromForm(textBoxName.Text, textBoxPhone.Text, textBoxEmail.Text, selectedTour, textBoxOrderPrice.Text, selectedTicket, textBoxExclusive.Text);
                }
                else
                {
                    generation.CreateOrderFromForm(textBoxName.Text, textBoxPhone.Text, textBoxEmail.Text, selectedTour, textBoxOrderPrice.Text, selectedTicket, "");
                }
                MessageBox.Show("Заказ создан и добавлен в БД", "Succeful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Некорректный ввод.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //отслеживание выбора типа тура
        string selectedTourType;
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTourType = "";
            if (comboBox3.SelectedItem.ToString() != "Classic")
            {
                selectedTourType = comboBox3.SelectedItem.ToString();
            }   
            FillComboBoxWithTours(selectedTourType);
            ShowTextBox(selectedTourType);
        }

        //заполнение combobox'а в зависимости от выбранного типа тура
        public void FillComboBoxWithTours(string selectedTourType)
        {
            if (!comboBox1.Enabled) comboBox1.Enabled = true;
            comboBox1.Items.Clear();
            for (int i = 0; i < ListTours.listTours.Count; i++)
            {
                if ($"AllTours.{selectedTourType}Tour" == ListTours.listTours[i].GetType().ToString())
                comboBox1.Items.Add(ListTours.listTours[i].name);
            }
        }
        //отображение скрытых полей (для туров business и exclusive)
        public void ShowTextBox(string selectedTourType)
        {
            //задание значения false для того чтобы после перевыбора типа тура поля не оставались видимыми
            if (textBoxOrganization.Visible)
            {
                textBoxOrganization.Visible = false;
                textBoxOrganization.Text = "";
                labelOrganization.Visible = false;
            }
            if (textBoxExclusive.Visible)
            {
                textBoxExclusive.Visible = false;
                textBoxExclusive.Text = "";
                labelExclusive.Visible = false;
            }
            //определение, какое поле будет отображаться
            if (selectedTourType == "Business") {
                textBoxOrganization.Visible = true;
                labelOrganization.Visible = true;
            }
            if (selectedTourType == "Exclusive") {
                textBoxExclusive.Visible = true;
                labelExclusive.Visible = true;
            }
        }

        //открыть окно с настройками генерации
        private void Button5_Click(object sender, EventArgs e)
        {
            SimulationProperties form = new SimulationProperties();
            form.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm.ReleaseCapture();
            DragForm.PostMessage(this.Handle, DragForm.WM_SYSCOMMAND, DragForm.DOMOVE, 0);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
