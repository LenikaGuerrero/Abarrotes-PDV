using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abarrotes_SPDV
{
    public partial class Frm_Reportes : Form
    {
        public Frm_Reportes()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();

        private void Frm_Reportes_Load(object sender, EventArgs e)
        {
            Program.indicador_reporte = 0;
           btn_reporte.Visible = false;
            
        }

        private void btn_productos_CheckedChanged(object sender, EventArgs e)
        {
            
            c.Productos_Finales(dataGridView1);
        }

        private void btn_Total_CheckedChanged(object sender, EventArgs e)
        {
            
            c.Ventas_Finales(dataGridView1);
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            if(btn_productos.Checked==true || btn_Total.Checked==true)
            {
                if (btn_productos.Checked == true)
                {
                    Program.indicador_reporte = 1;
                    Visualizar_Reporte viz = new Visualizar_Reporte();
                    viz.ShowDialog();
                }
                if (btn_Total.Checked == true)
                {
                    Program.indicador_reporte = 2;
                    Visualizar_Reporte viz = new Visualizar_Reporte();
                    viz.ShowDialog();
                }
            }
        }
    }
}
