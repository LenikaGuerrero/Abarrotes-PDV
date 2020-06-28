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
    public partial class frm_clientes : Form
    {
        public frm_clientes()
        {
            InitializeComponent();
        }

        frm_mod_clientes mc = new frm_mod_clientes();
        Conexion c = new Conexion();

        private void btn_cartera_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.SelectedRows.Count > 0)
            {
                frm_cartera car = new frm_cartera();
                Program.Evento = 2;
                Program.nombre_cliente = dgv_clientes.CurrentRow.Cells[1].Value.ToString();
                car.ShowDialog();

            }
            else
            {
                MessageBox.Show("Necesita Seleccionar un Cliente de la Tabla");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.SelectedRows.Count > 0)
            {
                Program.cod_cliente = dgv_clientes.CurrentRow.Cells[0].Value.ToString();
                Program.nombre_cliente = dgv_clientes.CurrentRow.Cells[1].Value.ToString();
                Program.ap_paterno = dgv_clientes.CurrentRow.Cells[2].Value.ToString();
                Program.ap_materno = dgv_clientes.CurrentRow.Cells[3].Value.ToString();
                Program.telefono = dgv_clientes.CurrentRow.Cells[4].Value.ToString();
                Program.direc_cliente = dgv_clientes.CurrentRow.Cells[5].Value.ToString();

                Program.Evento = 1;
                mc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Necesita Seleccionar un Cliente de la Tabla");
                
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
                Program.Evento = 2;
                mc.ShowDialog();

        }

        private void mst_clientes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        #region'Menustrip_Busqueda por Abecedario' 
        private void tsm_a_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "A";
            c.tablaclientes(dgv_clientes, bus);
        }
        private void tsm_b_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);

            string bus = "B";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_c_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "C";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_d_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "D";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_e_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "E";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_f_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "F";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_g_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "G";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_h_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "H";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_i_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "I";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_j_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "J";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_k_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "K";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_l_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "L";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_m_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "M";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_n_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "N";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_o_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "O";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_p_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "P";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_q_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "Q";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_r_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "R";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_s_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "S";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_t_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "T";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_u_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "U";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_v_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "V";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_y_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "Y";
            c.tablaclientes(dgv_clientes, bus);
        }

        private void tsm_z_Click(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            string bus = "Z";
            c.tablaclientes(dgv_clientes, bus);
        }
        #endregion 

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            Program.Evento = 0;
            Program.cod_cliente = "";
            Program.nombre_cliente = "";
            Program.ap_paterno = "";
            Program.ap_materno = "";
            Program.telefono = "";
            Program.direc_cliente = "";
            txt_adeudo.Text = "0";
    }

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
            string nombre, app, apm;
            nombre = Convert.ToString(txt_buscar.Text);
            app = Convert.ToString(txt_buscar.Text);
            apm = Convert.ToString(txt_buscar.Text);
            txt_adeudo.Text = "";
            c.busqueda_clientes(dgv_clientes, nombre, app, apm);
           
        }

        private void frm_clientes_Activated(object sender, EventArgs e)
        {
            c.tabla_clientes(dgv_clientes);
            txt_adeudo.Text = "0";
        }

        private void dgv_clientes_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.Rows.Count > 0)
            {
                dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Selected = true;
            }
            Program.cod_cliente = dgv_clientes.CurrentRow.Cells[0].Value.ToString();
            txt_adeudo.Text = c.Adeudo_Cartera(Program.cod_cliente);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.SelectedRows.Count > 0)
            {
                if (txt_adeudo.Text != "0")
                {
                     MessageBox.Show("No se puede Eliminar este cliente, tiene Adeudo en Cartera","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_adeudo.Text = "";
                }
                else
                {
                    Program.cod_cliente = dgv_clientes.CurrentRow.Cells[0].Value.ToString();
                    if (MessageBox.Show("¿Está Seguro que Desea Eliminar al Cliente Seleccionado?", "Clientes.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Está apunto de Eliminar¿Desea Continuar?", "Pedidos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            
                            c.Eliminar_Cliente(Program.cod_cliente);
                           
                        }
                    }
                }
                c.tabla_clientes(dgv_clientes);
                txt_adeudo.Text = "0";
            }
            else
            {
                MessageBox.Show("Necesita Seleccionar un Cliente de la Tabla");
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
            c.tabla_clientes(dgv_clientes);
            txt_buscar.Focus();
            txt_adeudo.Text = "0";
        }

        private void frm_clientes_Deactivate(object sender, EventArgs e)
        {
            Program.Metodo = 0;
        }
    }
}
