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
    public partial class Crud : Form
    {
        public Crud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.nombre = textBox2.Text;
            persona.tipo = textBox3.Text;
            persona.marca = textBox4.Text;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            int result = personaDAL.AgregarPersona(persona);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar");
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
            RefreshPantalla();
        }
           
       
        

        private void Crud_Load(object sender, EventArgs e)
        {
            RefreshPantalla();
        }

        public void RefreshPantalla()
        {
            dataGridView1.DataSource = personaDAL.PresentarRegistro();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
            textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["tipo"].Value);
            textBox4.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["marca"].Value);
            textBox5.Text = ((decimal)dataGridView1.CurrentRow.Cells["precio"].Value).ToString("F2");
            textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["stock"].Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.nombre = textBox2.Text;
            persona.tipo = textBox3.Text;
            persona.marca = textBox4.Text;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            if (id != null)
            {
                int result = personaDAL.AgregarPersona(persona);

                if (result > 0)
                {
                    MessageBox.Show("Exito al guardar");
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
                RefreshPantalla();
            }
            else
            {
                persona.id = id;
                int result = personaDAL.modificarPersona(persona);
                if (result > 0)
                {
                    MessageBox.Show("Exito al modificar");
                }
                else
                {
                    MessageBox.Show("Error al modidficar");
                }
                RefreshPantalla();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                int resultado = personaDAL.EliminarPersona(id);
                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }
               }
            RefreshPantalla() ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reporte rm1 = new Reporte();
            rm1.ShowDialog();
        }
    }
}
