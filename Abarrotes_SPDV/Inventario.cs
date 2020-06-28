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
    public partial class frm_inventario : Form
    {
        public frm_inventario()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            frm_listproductos lp = new frm_listproductos();
            lp.ShowDialog();
        }
        Conexion c = new Conexion();

        string seleccion, valor;

        private void frm_inventario_Load(object sender, EventArgs e)
        {
            c.tabla_inventario(dgv_inventario);
            cmb_buscar.Text = "Todo";
            Program.Evento = 0;
        }

        private void cmb_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cmb_buscar.SelectedIndex)
            {
                case 0://Nombre
                    Program.Evento = 1;
                    txt_buscar.Visible = true;
                    txt_buscar.Text = "";
                    
                    cmb_departamento.Visible = false;
                    
                    cmb_categoria.Visible = false;
                    
                    
                    break;
                case 1: //Marca
                    Program.Evento = 2;
                    txt_buscar.Text = "";
                    txt_buscar.Visible = true;
                    cmb_categoria.Visible = false;
                    cmb_categoria.Text = "";
                    cmb_departamento.Visible = false;
                    cmb_departamento.Text = "";
                    
                    break;
                case 2: //Categoria
                    cmb_categoria.Text = "";
                    
                    cmb_categoria.Visible = true;
                    txt_buscar.Visible = false;
                    txt_buscar.Text = "";
                    cmb_departamento.Visible = false;

                    break;
                case 3: //Dpto
                    Program.Evento = 3;

                    cmb_categoria.Text = "";
                    cmb_departamento.Text = "";
                    cmb_categoria.Visible = false;
                    cmb_categoria.Text = "";
                    txt_buscar.Visible = false;
                    txt_buscar.Text = "";
                    cmb_departamento.Visible = true;
                    
                    break;
                case 4: //Cant Existente
                    Program.Evento = 4;
                    txt_buscar.Text = "";
                    txt_buscar.Visible = true;
                    cmb_categoria.Visible = false;
                    cmb_categoria.Text = "";
                    cmb_departamento.Visible = false;
                    cmb_departamento.Text = "";
                    
                    break;
                case 5: //TODO
                    Program.Evento = 0;
                    c.tabla_inventario(dgv_inventario);
                    txt_buscar.Visible = false;
                    txt_buscar.Text = "";
                    cmb_categoria.Visible = false;
                    cmb_categoria.Text = "";
                    cmb_departamento.Visible = false;
                    cmb_departamento.Text = "";
                    c.tabla_inventario(dgv_inventario);
                    break;
                default:
                    c.tabla_inventario(dgv_inventario);
                    break;
            }
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = "categoria";

            valor = "'%" + cmb_categoria.Text + "%'";
            c.busqueda_inventario(dgv_inventario, seleccion, valor);
           

        }

        private void cmb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = "departamento";
            valor = "'%" + cmb_departamento.Text + "%'";
            c.busqueda_inventario(dgv_inventario, seleccion, valor);

        }

        private void dgv_inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_inventario.Rows.Count > 0)
            {
                dgv_inventario.Rows[dgv_inventario.CurrentRow.Index].Selected = true;
            }
        }

        private void frm_inventario_Deactivate(object sender, EventArgs e)
        {
            Program.Metodo = 0;
        }

        private void frm_inventario_Activated(object sender, EventArgs e)
        {
            c.tabla_inventario(dgv_inventario);
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

            if (txt_buscar.Text != "")
            {
                if (Program.Evento == 1)
                {
                    seleccion = "descripcion";
                    valor = "'%" + txt_buscar.Text + "%'";
                    c.busqueda_inventario(dgv_inventario, seleccion, valor);
                }
                if (Program.Evento == 2)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txt_buscar.Text, "[^a-zA-Z áéíóúñÁÉÍÓÚ]"))
                    {
                        MessageBox.Show("Favor de  introducir únicamente letras.", "Verifique bien los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_buscar.Text = "";
                    }
                    seleccion = "Marca";
                    valor = "'%" + txt_buscar.Text + "%'";
                    c.busqueda_inventario(dgv_inventario, seleccion, valor);

                }
                if (Program.Evento == 4)
                {
                    seleccion = "cantidad";
                    valor = "'" + txt_buscar.Text + "'";
                    c.busqueda_inventario(dgv_inventario, seleccion, valor);

                }
            }
            else
            {
                c.tabla_inventario(dgv_inventario);
            }
            
        }
    }
}
