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
    public partial class Visualizar_Reporte : Form
    {
        public Visualizar_Reporte()
        {
            InitializeComponent();
        }

        private void Visualizar_Reporte_Load(object sender, EventArgs e)
        {
            //this.report_Ventas.RefreshReport();
            report_Productos.Visible = false;
            //report_Ventas.Visible = false;
            if (Program.indicador_reporte == 1)
            {
             
               
                this.report_Productos.RefreshReport();
                report_Productos.Visible = true;
            }
            //if (Program.indicador_reporte == 2)
            //{
            //    this.report_Ventas.RefreshReport();
            //    report_Ventas.Visible = true;
            //}
        }
    }
}
