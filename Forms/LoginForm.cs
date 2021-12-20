using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        { 
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm.ReleaseCapture();
            DragForm.PostMessage(this.Handle, DragForm.WM_SYSCOMMAND, DragForm.DOMOVE, 0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
