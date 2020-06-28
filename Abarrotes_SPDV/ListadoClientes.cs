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
    public partial class frm_listclientes : Form
    {
        public frm_listclientes()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frm_listclientes_Load(object sender, EventArgs e)
        {
            c.tabla_listadoclientes(dgv_clientes);
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_buscar.Text, "[^a-zA-Z áéíóúñÁÉÍÓÚ]"))
            {
                MessageBox.Show("Favor de  introducir únicamente letras.", "Verifique bien los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_buscar.Text = "";
            }
            string nombre, app, apm;
            nombre = Convert.ToString(txt_buscar.Text);
            app = Convert.ToString(txt_buscar.Text);
            apm = Convert.ToString(txt_buscar.Text);
            c.busqueda_clientes(dgv_clientes, nombre, app, apm);
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_clientes.Rows.Count > 0)
            {
                dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Selected = true;
            }
        }

        private void dgv_clientes_DoubleClick(object sender, EventArgs e)
        {
            Program.cod_cliente = dgv_clientes.CurrentRow.Cells[0].Value.ToString();
            Program.nombre_cliente = dgv_clientes.CurrentRow.Cells[1].Value.ToString();
            Program.ap_paterno = dgv_clientes.CurrentRow.Cells[2].Value.ToString();
            Program.ap_materno = dgv_clientes.CurrentRow.Cells[3].Value.ToString();
            Program.telefono = dgv_clientes.CurrentRow.Cells[4].Value.ToString();
            Program.direc_cliente = dgv_clientes.CurrentRow.Cells[5].Value.ToString();
            this.Close();
        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
