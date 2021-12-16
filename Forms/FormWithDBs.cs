using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllTours.Forms
{
    public partial class FormWithDBs : Form
    {
        public FormWithDBs()
        {
            InitializeComponent();
        }

        private void ClientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.megaDatabaseDataSet);

        }

        private void FormWithDBs_Load(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.megaDatabaseDataSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "megaDatabaseDataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.megaDatabaseDataSet.Tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "megaDatabaseDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.megaDatabaseDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "megaDatabaseDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.megaDatabaseDataSet.Clients);

        }

        public void LoadData()
        {
            this.ticketsTableAdapter.Fill(this.megaDatabaseDataSet.Tickets);
            this.clientsTableAdapter.Fill(this.megaDatabaseDataSet.Clients);
            //this.tableAdapterManager.UpdateAll(this.megaDatabaseDataSet);
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
