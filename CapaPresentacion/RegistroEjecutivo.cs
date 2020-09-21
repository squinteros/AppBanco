using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RegistroSupervisor : Form
    {
        public RegistroSupervisor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
            textBox2.Undo();
            textBox3.Undo();
            textBox4.Undo();
            textBox5.Undo();
            textBox6.Undo();
            textBox7.Undo();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var log = new Login();
            log.Show();
        }
    }
}
