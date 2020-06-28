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
    public partial class frm_productos : Form
    {
        public frm_productos()
        {
            InitializeComponent();
        }

        bool v = false;
        Conexion c = new Conexion();

        public void limpiar()
        {
            txt_codigo.Text = "";
            txt_marca.Text = "";
            cmb_clasificacion.Text = "Pieza";
            cmb_departamento.Text = "Abarrotes";
            txt_codigo.Enabled = true;
            txt_marca.Enabled = true;
            cmb_clasificacion.Enabled = true;
            cmb_departamento.Enabled = true;
            btn_guardar.Enabled = false;
            txt_pcompra.Text = "";
            txt_minimo.Text = "";
            txt_cantidad.Text = "";
            cmb_impuesto.Text = "IVA 16%";
            txt_ppublico.Enabled = false;
            txt_descrip.Text = "";
            btn_limpiar.Enabled = false;
            Program.Evento = 0;
            v = false;
            txt_codigo.Focus();
            cmb_proveedor.Text = "";
            
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

        } //----

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            
            if (dgv_productos.SelectedRows.Count > 0)
            {
                limpiar();
                
                txt_codigo.Enabled = false;
                txt_marca.Enabled = false;
                cmb_clasificacion.Enabled = false;
                cmb_departamento.Enabled = false;
                btn_guardar.Enabled = true;
                

                string cod;
                v = true;
                txt_codigo.Text=dgv_productos.CurrentRow.Cells[0].Value.ToString();
                
                txt_marca.Text = dgv_productos.CurrentRow.Cells[2].Value.ToString();
                txt_descrip.Text = dgv_productos.CurrentRow.Cells[1].Value.ToString();
                cmb_clasificacion.Text = dgv_productos.CurrentRow.Cells[3].Value.ToString();
                cmb_departamento.Text = dgv_productos.CurrentRow.Cells[4].Value.ToString();
                cod = txt_codigo.Text;
                
                c.modificar_datos_productos(cod, txt_cantidad, txt_minimo, txt_pcompra, txt_ppublico, txt_punitario, cmb_impuesto);
                cmb_proveedor.Text = c.empresa(txt_codigo.Text);
               
            }
            else
            {
                MessageBox.Show("Necesita Seleccionar un Pedido de la Tabla");
                v = false;
            }
        }

        private void frm_productos_Load(object sender, EventArgs e)
        {
            
            limpiar();
            c.tabla_producto(dgv_productos);
            
            Program.Evento = 0;
            //c.empresa_proveedor(cmb_proveedor);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string desc, cat, dpto, marca, cant, pc, pu, pp, aviso, cod, iva,c_pv;
            if (txt_codigo.Text == "" || txt_marca.Text == "" || txt_descrip.Text == "" || txt_pcompra.Text == ""||txt_ppublico.Text==""||txt_minimo.Text==""||txt_cantidad.Text=="")
            {
                MessageBox.Show("Ingrese todos los datos para guardar");
            }
            else
            {
                cod = Convert.ToString(txt_codigo.Text);
                marca = Convert.ToString(txt_marca.Text);
                cant = Convert.ToString(txt_cantidad.Text);
                pc = Convert.ToString(txt_pcompra.Text);
                pu = Convert.ToString(txt_punitario.Text);
                pp = Convert.ToString(txt_ppublico.Text);
                aviso = Convert.ToString(txt_minimo.Text);
                iva = Convert.ToString(cmb_impuesto.Text);
                desc = Convert.ToString(txt_descrip.Text);
                cat = Convert.ToString(cmb_clasificacion.Text);
                dpto = Convert.ToString(cmb_departamento.Text);
                if (cmb_proveedor.Text == "")
                {
                    c_pv = "NULL";
                }
                else c_pv = Convert.ToString(cmb_proveedor.Text);

                if (v == true)
                {
                    
                    c.modificar_producto(dgv_productos,cod,marca,cant,pc,iva,desc,pu,pp,aviso,c.codigo_proveedor(c_pv));
                    c.tabla_producto(dgv_productos);
                    limpiar();
                    
                }
                else
                {
                    Program.Evento = 2;
                    if (c.c_producto(txt_marca.Text) > 0)
                    {
                        MessageBox.Show("El nombre del Producto ya existe, favor de ingresar uno nuevo");
                        txt_marca.Text = ""; 
                    }
                    else
                    {
                        
                        c.Agregar_Producto(cod, desc, marca, cat, dpto, cant, pc, iva, pu, pp, aviso,c.codigo_proveedor(c_pv));
                        MessageBox.Show("Producto Agregado con Exito");
                        c.tabla_producto(dgv_productos);
                        limpiar();
                       
                    }
                }
            }
        }

        private void txt_ppublico_TextChanged(object sender, EventArgs e)//PRECIO DEL PRODUCTO AL PUBLICO
        {
            if (txt_ppublico.Text != null || txt_ganancia.Text != null)
            {
                double g = 0;
                if (txt_ppublico.Text != "")
                {
                    if (Convert.ToDouble(txt_ppublico.Text) != 0)
                    {
                        g = Convert.ToDouble(txt_ppublico.Text) - Convert.ToDouble(txt_punitario.Text);
                        txt_ganancia.Text = Convert.ToString(g);

                    }
                    else MessageBox.Show("Ingrese un valor mayor a 0(cero)");

                }
                else txt_ganancia.Text = "";
            }
            else
            {
                if (txt_pcompra == null) MessageBox.Show("Necesita llenar el precio de venta");
            }

        }

        private void cmb_impuesto_SelectedIndexChanged(object sender, EventArgs e)//IMPUESTO AGREGADO
        {
            if (txt_pcompra == null || txt_pcompra.Text == "")
            {
                txt_pcompra.Text = "";

            }
            else
            {
                if (cmb_impuesto.Text == "IVA 16%"&& txt_pcompra.Text != ".")
                {
                    double pc = 0, pu = 0;
                    pc = Convert.ToDouble(txt_pcompra.Text) * 0.16;
                    pu = Convert.ToDouble(txt_pcompra.Text) + pc;
                    txt_iva.Text = "0.16";
                    txt_punitario.Text = Convert.ToString(pu);
                    txt_ppublico.Enabled = true;
                }
                else
                {
                    txt_iva.Text = "0";
                    txt_punitario.Text = txt_pcompra.Text;
                    txt_ppublico.Enabled = true;
                }
            }
        }

        private void txt_pcompra_TextChanged(object sender, EventArgs e)//PRECIO DE COMPRA DEL PRODUCTO(PRECIO PROVEEDOR)
        {
            if (txt_pcompra.Text == "" || txt_pcompra.Text == null)
            {
                txt_iva.Text = "";
                txt_punitario.Text = "";
                txt_ppublico.Text = "";
                txt_ppublico.Enabled = false;
            }
            else
            {
                
                if (cmb_impuesto.Text == "IVA 16%" && txt_pcompra.Text != ".")
                {
                    double pc = 0, pu = 0;
                    pc = Convert.ToDouble(txt_pcompra.Text) * 0.16;
                    pu = Convert.ToDouble(txt_pcompra.Text) + pc;
                    txt_iva.Text = "0.16";
                    txt_punitario.Text = Convert.ToString(pu);
                    txt_ppublico.Enabled = true;
                }
                else
                {
                    txt_iva.Text = "0";
                    txt_punitario.Text = txt_pcompra.Text;
                    txt_ppublico.Enabled = true;
                }
            }
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_productos.Rows.Count > 0)
            {
                dgv_productos.Rows[dgv_productos.CurrentRow.Index].Selected = true;
            }
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            if (v == false)
            {
                Program.Evento = 1;
                if (c.c_producto(txt_codigo.Text) > 0)
                {
                    MessageBox.Show("El Código del Producto ya existe, favor de ingresar uno nuevo");
                    txt_codigo.Text = "";
                    txt_codigo.Focus();
                }
                if (txt_marca.Text != "")
                {
                    btn_guardar.Enabled = false;
                    btn_limpiar.Enabled = true;
                }
                else
                {
                    btn_limpiar.Enabled = false;
                    btn_guardar.Enabled = false;
                }
            }
            else
            {             
                 btn_limpiar.Enabled = true;
                 btn_guardar.Enabled = true;
 
             }
         
               
            
        }

        private void txt_descrip_TextChanged(object sender, EventArgs e)
        {
            if (v == false)
            {
                
                
                if (txt_codigo.Text != "")
                {
                    btn_guardar.Enabled = true;
                    btn_limpiar.Enabled = true;
                }
                else
                {
                    btn_limpiar.Enabled = false;
                    btn_guardar.Enabled = false;
                }
            }
            else
            {
                btn_limpiar.Enabled = true;
                btn_guardar.Enabled = true;

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            limpiar();
            if (dgv_productos.SelectedRows.Count > 0)
            {

                string cod;
                cod = dgv_productos.CurrentRow.Cells[0].Value.ToString();
                
                if (MessageBox.Show("¿Está Seguro que Desea Eliminar este Producto?", "Productos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("El Producto se Eliminará de todas las Tablas ¿Continuar?", "Productos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.eliminar_producto(dgv_productos, cod);
                        MessageBox.Show("Producto Eliminado con Exito");
                        c.tabla_producto(dgv_productos);
                        
                    }
                }
                
            }
            
            else
            {
                MessageBox.Show("Necesita Seleccionar un Pedido de la Tabla");
            }
            
        }

        private void pbx_buscar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frm_productos_Activated(object sender, EventArgs e)
        {
            cmb_proveedor.Items.Add("");
            txt_buscar.Text = "";
            c.tabla_producto(dgv_productos);
            txt_codigo.Focus();
            c.empresa_proveedor(cmb_proveedor);

        }

        private void txt_marca_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txt_descrip.Text, "[^a-zA-Z áéíóúñÁÉÍÓÚ]"))
            //{
            //    MessageBox.Show("Favor de  introducir únicamente letras.", "Verifique bien los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_descrip.Text = "";
            //}
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_productos_Deactivate(object sender, EventArgs e)
        {
            Program.Metodo = 0;
            cmb_proveedor.Items.Clear();
        }

        private void txt_pcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_ppublico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }
    }
}
