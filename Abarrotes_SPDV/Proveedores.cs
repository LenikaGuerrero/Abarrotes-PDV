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
    public partial class frm_proveedores : Form
    {
        public frm_proveedores()
        {
            InitializeComponent();
        }

        Conexion c = new Conexion();
        bool v = false;

        private void btn_nuevo_Click(object sender, EventArgs e) //-----------------------
        {
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            limpiar();
            if (dgv_proveedores.SelectedRows.Count > 0)
            {

                txt_nombre.Text = dgv_proveedores.CurrentRow.Cells[0].Value.ToString();
                txt_telefono.Text = dgv_proveedores.CurrentRow.Cells[1].Value.ToString();
                txt_nomempresa.Text = dgv_proveedores.CurrentRow.Cells[2].Value.ToString();
                txt_dirempresa.Text = dgv_proveedores.CurrentRow.Cells[3].Value.ToString();

                v = true;
                btn_guardar.Enabled = true;
                btn_Limpiar.Enabled = true;
                pbx_buscar.Enabled = false;
                txt_producto.Enabled = false;
            }
            else
            {
                MessageBox.Show("Necesita Seleccionar un Proveedor de la Tabla");
            }
            //c.tabla_proveedores(dgv_proveedores);
            //c.tabla_proveedores_pdt(dgv_pendiente);
            
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string nombre_prov, nombre_empresa;
            nombre_prov = Convert.ToString(txt_buscar.Text);
            nombre_empresa = Convert.ToString(txt_buscar.Text);
            c.busqueda_proveedores(dgv_proveedores,nombre_prov, nombre_empresa);
        }

        private void frm_proveedores_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            limpiar();
            c.tabla_proveedores(dgv_proveedores);
            c.tabla_proveedores_pdt(dgv_pendiente);
            v = false;
            
        }

        public void limpiar()
        {
            txt_producto.Enabled = false;
            txt_producto.Text = "";
            txt_nombre.Text = "";
            Program.cod_prod = "";
            txt_telefono.Text = "";
            txt_nomempresa.Text = "";
            txt_dirempresa.Text = "";
            btn_guardar.Enabled = false;
            btn_Limpiar.Enabled = false;
            v = false;
            pbx_buscar.Enabled = false;
            Program.Evento = 0;
            
            
        }

        private void dgv_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            c.tabla_proveedores_pdt(dgv_pendiente);
            if (dgv_proveedores.Rows.Count > 0)
            {
                dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Selected = true;
            }
        }

        private void dgv_pendiente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            c.tabla_proveedores(dgv_proveedores);
            if (dgv_pendiente.Rows.Count > 0)
            {
                dgv_pendiente.Rows[dgv_pendiente.CurrentRow.Index].Selected = true;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void pbx_buscar_Click(object sender, EventArgs e)
        {
            frm_listproductoPDT pdt = new frm_listproductoPDT();
            pdt.ShowDialog();

        }

        private void frm_proveedores_Activated(object sender, EventArgs e)
        {
            if (Program.Metodo != 1) limpiar();

            v = false;
            txt_producto.Text = Program.cod_prod;
            
            c.tabla_proveedores_pdt(dgv_pendiente);
            c.tabla_proveedores(dgv_proveedores);
        }

        private void frm_proveedores_Deactivate(object sender, EventArgs e)
        {
            if(Program.Metodo!=1)limpiar();
            
        }

        private void txt_producto_TextChanged(object sender, EventArgs e)
        {
            btn_guardar.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           
            if (txt_nombre.Text == "" || txt_telefono.Text == "" || txt_dirempresa.Text == "" || txt_nomempresa.Text == "" )
            {
                MessageBox.Show("Ingrese todos los datos para guardar");
            }
            else
            {
                string nom, tel, emp, dir,telefono,prod;
                nom = txt_nombre.Text;
                tel = txt_telefono.Text;
                emp = txt_nomempresa.Text;
                dir = txt_dirempresa.Text;
               
                if (v == true)
                {
                    telefono= dgv_proveedores.CurrentRow.Cells[1].Value.ToString();
                    c.Modificar_Proveedor(nom, tel, emp, dir, telefono);
                    MessageBox.Show("Proveedor Modificado con Exito");
                    c.tabla_proveedores(dgv_proveedores);
                    c.tabla_proveedores_pdt(dgv_pendiente);
                }
                else
                {
                    if (Program.Metodo == 1)
                    {
                        prod = txt_producto.Text;
                        if (txt_producto.Text == "")
                        {
                            MessageBox.Show("Seleccione un Producto para asignarle proveedor");
                        }
                        else
                        {
                            string c_pv;
                            c_pv=c.codigo_proveedor(emp);
                            c.proveedor_a_producto(c_pv, prod);
                            txt_producto.Text = "";
                            limpiar();
                        }

                    }
                    else
                    {
                        c.Agregar_Proveedor(nom, tel, emp, dir);
                        c.tabla_proveedores(dgv_proveedores);
                        c.tabla_proveedores_pdt(dgv_pendiente);
                        limpiar();
                    }
                    
                }

                limpiar();
                c.tabla_proveedores(dgv_proveedores);
                c.tabla_proveedores_pdt(dgv_pendiente);
            }
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            if (v == false)
            {
                if (txt_nombre.Text == "")
                {
                    btn_Limpiar.Enabled = true;
                    btn_guardar.Enabled = false;
                }
                else
                {
                    btn_Limpiar.Enabled = true;
                    btn_guardar.Enabled = true;
                }
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_nombre.Text, "[^a-zA-Z áéíóúñÁÉÍÓÚ]"))
            {
                MessageBox.Show("Favor de  introducir únicamente letras.", "Verifique bien los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nombre.Text = "";
            }
            if (v == false)
            {
                if (txt_telefono.Text == "")
                {
                    btn_Limpiar.Enabled = true;
                    btn_guardar.Enabled = false;
                }
                else
                {
                    btn_Limpiar.Enabled = true;
                    btn_guardar.Enabled = true;
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
            if (dgv_proveedores.SelectedRows.Count > 0)
            {



                string c_pv,emp;
                emp = dgv_proveedores.CurrentRow.Cells[2].Value.ToString();
                c_pv = c.codigo_proveedor(emp);
                if (c.c_proveedor(c_pv) > 0)
                {
                    MessageBox.Show("El Proveedor no se puede eliminar,tiene productos que requieren su atención.\n"+"Para poder eliminar un proveedor es necesario eliminar el producto");

                }
                else
                {
                    string telefono;
                    telefono = dgv_proveedores.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show("¿Está Seguro que Desea Eliminar este Proveedor?", "Proveedores.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        c.eliminar_proveedor(dgv_proveedores, telefono);
                        MessageBox.Show("Proveedor Eliminado con Exito");
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Necesita Seleccionar a un Proveedor de la Tabla");

                limpiar();
                c.tabla_proveedores(dgv_proveedores);
                c.tabla_proveedores_pdt(dgv_pendiente);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            Program.Metodo = 1;
            Program.Evento = 0;
            txt_producto.Text = "";
            if (dgv_proveedores.SelectedRows.Count > 0)
            {
                txt_nombre.Text = dgv_proveedores.CurrentRow.Cells[0].Value.ToString();
                txt_telefono.Text = dgv_proveedores.CurrentRow.Cells[1].Value.ToString();
                txt_nomempresa.Text = dgv_proveedores.CurrentRow.Cells[2].Value.ToString();
                txt_dirempresa.Text = dgv_proveedores.CurrentRow.Cells[3].Value.ToString();

                
                btn_guardar.Enabled = false;
                btn_Limpiar.Enabled = true;
                pbx_buscar.Enabled = true;
                txt_producto.Enabled = false;
                txt_nombre.Enabled = false;
                txt_telefono.Enabled = false;
                txt_nomempresa.Enabled = false;
                txt_dirempresa.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Necesita Seleccionar un Proveedor para poder asignarlo a un producto");
                limpiar();
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Telefono(e);
        }
    }
}
