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
    public partial class frm_listproductos : Form
    {
        public frm_listproductos()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_buscar.Text, "[^a-zA-Z áéíóúñÁÉÍÓÚ]"))
            {
                MessageBox.Show("Favor de  introducir únicamente letras.", "Verifique bien los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_buscar.Text = "";
            }
            string nombre_producto, codigo_producto;
            nombre_producto = Convert.ToString(txt_buscar.Text);
            codigo_producto = Convert.ToString(txt_buscar.Text);
            c.busqueda_productos(dgv_productos, nombre_producto, codigo_producto);
        }

        private void frm_listproductos_Load(object sender, EventArgs e)
        {
            c.tabla_producto_notnull(dgv_productos);
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_productos.Rows.Count > 0)
            {
                dgv_productos.Rows[dgv_productos.CurrentRow.Index].Selected = true;
            }
        }

        private void dgv_productos_DoubleClick(object sender, EventArgs e)
        {
            
            Program.cod_producto=dgv_productos.CurrentRow.Cells[0].Value.ToString();
            Program.descripción=dgv_productos.CurrentRow.Cells[1].Value.ToString();
            Program.marca=dgv_productos.CurrentRow.Cells[2].Value.ToString();
            Program.categoria=dgv_productos.CurrentRow.Cells[3].Value.ToString();
            Program.departamento=dgv_productos.CurrentRow.Cells[4].Value.ToString();
            Program.precio_publico = Convert.ToDouble(dgv_productos.CurrentRow.Cells[5].Value.ToString());
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
