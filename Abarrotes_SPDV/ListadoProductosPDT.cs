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
    public partial class frm_listproductoPDT : Form
    {
        public frm_listproductoPDT()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string nombre_producto, codigo_producto;
            nombre_producto = Convert.ToString(txt_buscar.Text);
            codigo_producto = Convert.ToString(txt_buscar.Text);
            c.busqueda_proveedores_pdt(dgv_productospdt, codigo_producto, nombre_producto);
        }

        private void frm_listproductoPDT_Load(object sender, EventArgs e)
        {
            c.tabla_proveedores_pdt(dgv_productospdt);
        }

        private void dgv_productospdt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_productospdt.Rows.Count > 0)
            {
                dgv_productospdt.Rows[dgv_productospdt.CurrentRow.Index].Selected = true;
            }
        }

        private void dgv_productospdt_DoubleClick(object sender, EventArgs e)
        {
            Program.cod_prod = dgv_productospdt.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void frm_listproductoPDT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Metodo = 1;
        }

        private void frm_listproductoPDT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Metodo = 1;
        }
    }
}
