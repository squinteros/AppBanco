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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("user") && textBox2.Text.Equals("123"))
            {
                this.Hide();
                var regCliente = new IngresoCliente();
                regCliente.Closed += (s, args) => this.Close();
                regCliente.Show();
            }

            else if (textBox1.Text.Equals("super") && textBox2.Text.Equals("123"))
            {
                this.Hide();
                var regEjec = new IngresoEjecutivo();
                regEjec.Closed += (s, args) => this.Close();
                regEjec.Show();
            }

            if (textBox1.Text.Equals("admin") && textBox2.Text.Equals("123"))
            {
                this.Hide();
                var regSuper = new IngresoSupervisor();
                regSuper.Closed += (s, args) => this.Close();
                regSuper.Show();
            }
        }
    }
}
