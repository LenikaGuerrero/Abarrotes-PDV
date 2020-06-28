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
    public partial class frm_pedidos : Form
    {
        public frm_pedidos()
        {
            InitializeComponent();
        }
        string prod;
        bool v = false;

        Conexion c = new Conexion();

        public void limpiar()
        {
            v = false;
            txt_cantidad.Text = "";
            txt_descripcion.Text = "";
            txt_empresa.Text = "";
            txt_producto.Text = "";
            txt_cantidad.Enabled = false;
            txt_descripcion.Enabled = false;
            txt_empresa.Enabled = false;
            pbx_buscar.Enabled = true;
            btn_limpiar.Enabled = false;
            btn_guardar.Enabled = false;
            txt_producto.Enabled = true;
            dpk_fecha.ResetText();
        }

        private void mtc_calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
           
            
            c.busqueda_pedido(dgv_dia,(mtc_calendario.SelectionStart.Year.ToString() + "-" + mtc_calendario.SelectionStart.Month.ToString() + "-" +
              mtc_calendario.SelectionStart.Day.ToString()));
          
        }

        private void frm_pedidos_Load(object sender, EventArgs e)
        {
            c.tabla_pedido(dgv_general);
            Program.cod_producto = "";
            Program.descripción = "";
            string fecha;
            fecha = mtc_calendario.TodayDate.Year.ToString() + "-" + mtc_calendario.TodayDate.Month.ToString() + "-" +
                mtc_calendario.TodayDate.Day.ToString();
            c.busqueda_pedido(dgv_dia, fecha);

            
            limpiar();

        }

        private void frm_pedidos_Activated(object sender, EventArgs e)
        {
            c.tabla_pedido(dgv_general);
            txt_producto.Text = Program.cod_producto;
            txt_descripcion.Text = Program.descripción;
            prod = Convert.ToString(txt_producto.Text);
            c.proveedor(txt_empresa, prod);
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_producto.Text == "" || txt_descripcion.Text == "" || txt_empresa.Text == "" || txt_cantidad.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos para guardar");
            }
            else
            {
                double cant = 0;
                cant = Convert.ToDouble(txt_cantidad.Text);
                if (cant==0 || cant>100)
                {
                    MessageBox.Show("Favor de Ingresar un numero menor o igual a 100");
                    txt_cantidad.Focus();
                }
                else if (v == true)
                {
                    
                    string fe, cd, fecha, fs;
                    DateTime f;
                    fecha = dgv_dia.CurrentRow.Cells[2].Value.ToString();
                    f = Convert.ToDateTime(fecha);
                    fe = Convert.ToString(f.Year.ToString() + "-" + f.Month.ToString() + "-" + f.Day.ToString());

                    fs = (mtc_calendario.SelectionStart.Year.ToString() + "-" + mtc_calendario.SelectionStart.Month.ToString() + "-" +
                       mtc_calendario.SelectionStart.Day.ToString());

                    cd = txt_producto.Text;
                    if (Program.Evento == 2)
                    {
                        cant = 0;
                        cant = Convert.ToDouble(txt_cantidad.Text);
                        c.modificar_pedidos_cantidad(dgv_dia, cant, cd, fe);
                        c.busqueda_pedido(dgv_dia,fs);
                        c.tabla_pedido(dgv_general);
                       
                    }
                    if (Program.Evento == 1)
                    {
                       
                        string n_fecha;
                        n_fecha = dpk_fecha.Value.Year.ToString() + "-" + dpk_fecha.Value.Month.ToString() + "-" + dpk_fecha.Value.Day.ToString();
                        c.modificar_pedidos_fecha(dgv_dia, n_fecha, cd, fe);
                        c.busqueda_pedido(dgv_dia, fs);
                        c.tabla_pedido(dgv_general);
                        
                        
                    }

                }
                else
                {
                    cant = 0;
                    string fecha,fs,emp;
                    fs = (mtc_calendario.SelectionStart.Year.ToString() + "-" + mtc_calendario.SelectionStart.Month.ToString() + "-" +
                          mtc_calendario.SelectionStart.Day.ToString());

                    cant = Convert.ToDouble(txt_cantidad.Text);
                    fecha = dpk_fecha.Value.Year.ToString() + "-" + dpk_fecha.Value.Month.ToString() + "-" + dpk_fecha.Value.Day.ToString();
                    prod = txt_producto.Text;
                    emp = txt_empresa.Text;
                    c.Agregar_Pedido(prod, cant, fecha,c.codigo_proveedor(emp));
                    MessageBox.Show("Pedido Agregado con Exito");
                    c.tabla_pedido(dgv_general);
                    c.busqueda_pedido(dgv_dia, fs);
                    limpiar();
                }
                c.tabla_pedido(dgv_general);
            }
            c.tabla_pedido(dgv_general);
        }

        private void txt_producto_TextChanged(object sender, EventArgs e)
        {
            string P;
            Program.cod_producto = txt_producto.Text;
            Program.descripción = c.Obtener_Descripcion_Producto(Program.cod_producto);
            txt_descripcion.Text = Program.descripción;
            P = txt_producto.Text;
            

            if (Program.descripción != "")
            {
                c.proveedor(txt_empresa, P);
                txt_cantidad.Enabled = true;
                btn_limpiar.Enabled = true;
                btn_guardar.Enabled = true;
            }
            else
            {
                txt_cantidad.Text = "";
                txt_empresa.Text = "";
                txt_cantidad.Enabled = false;
                btn_limpiar.Enabled = false;
                btn_guardar.Enabled = false;
            }



        }

        private void dgv_dia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_dia.Rows.Count > 0)
            {
                dgv_dia.Rows[dgv_dia.CurrentRow.Index].Selected = true;
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            
            if (dgv_dia.SelectedRows.Count > 0)
            {
                limpiar();
                btn_limpiar.Enabled = true;
                txt_producto.Enabled = false;
                txt_descripcion.Enabled = false;
                txt_empresa.Enabled = false;
                txt_cantidad.Enabled = true;
                pbx_buscar.Enabled = false;
                btn_guardar.Enabled = true;
                string cod, fecha;


                txt_descripcion.Text = dgv_dia.CurrentRow.Cells[0].Value.ToString();
                txt_cantidad.Text = dgv_dia.CurrentRow.Cells[1].Value.ToString();
                fecha = dgv_dia.CurrentRow.Cells[2].Value.ToString();
                dpk_fecha.Value = Convert.ToDateTime(fecha);
                txt_empresa.Text = dgv_dia.CurrentRow.Cells[3].Value.ToString();
                cod = c.cod_producto(Convert.ToString(txt_descripcion.Text));
                txt_producto.Text = cod;

                v = true;

            }
            else
            {
                MessageBox.Show("Necesita Seleccionar un Pedido de la Tabla: DIA");
            }
        }

        private void dpk_fecha_ValueChanged(object sender, EventArgs e)
        {
            if (v == true)
            {
                Program.Evento = 1;
            }

        }





        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
            if (dgv_dia.SelectedRows.Count > 0)
            {
                string cod, fecha,fe,fs;
                DateTime f;
                fs = (mtc_calendario.SelectionStart.Year.ToString() + "-" + mtc_calendario.SelectionStart.Month.ToString() + "-" +
                      mtc_calendario.SelectionStart.Day.ToString());

                fecha = dgv_dia.CurrentRow.Cells[2].Value.ToString();
                f = Convert.ToDateTime(fecha);
                fe = Convert.ToString(f.Year.ToString() + "-" + f.Month.ToString() + "-" + f.Day.ToString());
                cod=c.cod_producto(dgv_dia.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show("¿Está Seguro que Desea Eliminar este Pedido?", "Pedidos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.eliminar_pedidos(dgv_dia, cod, fe);
                    MessageBox.Show("Pedido Eliminado");
                    c.busqueda_pedido(dgv_dia, fs);
                    c.tabla_pedido(dgv_general);
                }
            }
            else
            {
                MessageBox.Show("Necesita Seleccionar un Pedido de la Tabla: DIA");
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv_general_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_dia.Rows.Count > 0)
            {
                dgv_dia.Rows[dgv_dia.CurrentRow.Index].Selected = true;
            }
        }

        private void frm_pedidos_Deactivate(object sender, EventArgs e)
        {
            Program.cod_producto = "";
            Program.Metodo = 0;

        }

        private void pbx_buscar_Click(object sender, EventArgs e)
        {
            frm_listproductos lp = new frm_listproductos();
            lp.ShowDialog();
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtc_calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            

        }

        private void txt_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Codigo(e);
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

            if (v == true)
            {
                Program.Evento = 2;
            }
        }
    
    }
}
