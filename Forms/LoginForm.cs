using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllTours
{
    public partial class LoginForm : Form
    {
        DBConnector db = new DBConnector();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (db.Login(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

    }
}
