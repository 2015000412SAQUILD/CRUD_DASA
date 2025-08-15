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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aceitesconexion.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.aceitesconexion.productos);

            this.reportViewer1.RefreshReport();
        }
    }
}
