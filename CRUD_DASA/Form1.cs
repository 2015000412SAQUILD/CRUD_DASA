using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_DASA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "DASA" && textBox2.Text == "12345")
            {
                Crud frm = new Crud();
                this.Hide();
                frm.Show();
                MessageBox.Show("Los datos ingresados son correctos, bienvenido!");
                
            }
            else
            {
                MessageBox.Show("Algun campo ingresado no es correcto");
            }
        }
    }
}
