using AllTours.Classes;
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
    public partial class SimulationProperties : Form
    {
        public SimulationProperties()
        {
            InitializeComponent();
        }

        private void SimulationProperties_Load(object sender, EventArgs e)
        {
            label2.Text = "*Для обеспечения безопасности работы\n приложения (и вашего компьютера)\n минимальная доступная скорость\n генерации - 100мс.";
            textBox1.Text = SimProperties.generationSpeed.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out SimProperties.generationSpeed) && Convert.ToInt32(textBox1.Text) >= 100) {
                SimProperties.generationSpeed = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Скорость генерации изменена", "Succeful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Некорректный ввод.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
