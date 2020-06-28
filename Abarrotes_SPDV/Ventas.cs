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
    public partial class frm_ventas : Form
    {
        Conexion c = new Conexion();
        List<int> coddigoventa = new List<int>();
        List<string> codproducto = new List<string>();
        List<double> cantidad = new List<double>();
        List<string> categoria = new List<string>();
        List<double> precio = new List<double>();
        List<double> sub_total = new List<double>();

        List<double> cantida_inventario = new List<double>();
        double total = 0;


        public frm_ventas()
        {
            InitializeComponent();
        }



        //Realizar Venta
        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_vpago.Text != "")
            {

                double pago, total;
                pago = Convert.ToDouble(txt_vpago.Text);
                total = Convert.ToDouble(txt_vtotal.Text);
                if (pago >= total)
                {
                    c.Ingresar_venta(Convert.ToInt32(c.revisar_ventas(Metodo_ObtenerFecha())), "Efectivo", Metodo_ObtenerFecha(), total);
                    for (int i = 0; i < codproducto.Count; i++)
                    {
                        c.Agregar_Detalle_Venta(c.Consulta_codigo_Venta(), codproducto[i], cantidad[i], categoria[i], precio[i], sub_total[i]);
                        double cuenta = cantida_inventario[i] - cantidad[i];
                        c.Modificar_Cantidad_Inventario(cuenta, codproducto[i]);
                        dataGridView1.Rows.Clear();
                        txt_vtotal.Clear();
                        total = 0;
                        txt_vtotal.Text = "0";
                        coddigoventa.Clear();
                        cuenta = 0;
                    }
                    codproducto.Clear();
                    cantidad.Clear();
                    categoria.Clear();
                    precio.Clear();
                    sub_total.Clear();

                    txt_vpago.Clear();

                    cantida_inventario.Clear();



                    txt_vesxistencia.Clear();
                    Program.cod_producto = "";
                    Program.precio_publico = 0;
                    txt_vprecio.Text = "";
                    txt_vcodigo.Focus();
                    Program.Metodo = 0;
                    button5.Enabled = false;
                    

                }
                else
                {
                    MessageBox.Show("Ingrese un valor mayor que el Total");
                }
            }
            else MessageBox.Show("Ingrese Todos los campos para poder realizar la Venta");
        }

        //Texbox Codigo
        private void txt_vcodigo_TextChanged(object sender, EventArgs e)
        {
            txt_vcodigo.CharacterCasing = CharacterCasing.Upper;
            
            if (c.producto_inv_registrado(txt_vcodigo.Text) > 0)
            {
                c.llenarDatos_Productos_Para_Ventas(txt_vcodigo.Text, txt_vinventario, txt_vprecio, lbl_vtipo);
                txt_vesxistencia.Text = txt_vinventario.Text;
                if (txt_vinventario.Text == "0")
                {
                    MessageBox.Show("No hay producto en inventario, modifique la cantidad de existencia");
                    txt_vesxistencia.Clear();
                    txt_vinventario.Clear();
                    txt_vcantidad.Clear();
                    txt_vprecio.Clear();
                    lbl_vtipo.Text = "Tipo";
                    txt_importa.Clear();
                }

            }
            else
            {
                txt_vesxistencia.Clear();
                txt_vinventario.Clear();
                txt_vcantidad.Clear();
                txt_vprecio.Clear();
                lbl_vtipo.Text = "Tipo";
                txt_importa.Clear();
            }
        }

        //Texbox Cantidad
        private void txt_vcantidad_TextChanged(object sender, EventArgs e)
        {
            if (txt_vcantidad.Text != "" && txt_vcantidad.Text != "." && txt_vinventario.Text != "" && txt_vprecio.Text != "")
            {
                txt_vesxistencia.Text = Convert.ToString(Convert.ToDouble(txt_vinventario.Text) - Convert.ToDouble(txt_vcantidad.Text));
                txt_importa.Text = Convert.ToString(Convert.ToDouble(txt_vprecio.Text) * Convert.ToDouble(txt_vcantidad.Text));
                if (Convert.ToDouble(txt_vcantidad.Text) > Convert.ToDouble(txt_vinventario.Text))
                {
                    MessageBox.Show("No hay mas producto, favor de ingresar la cantidad correcta");
                    txt_vcantidad.Focus();
                }
            }
            else
            {
                txt_vesxistencia.Text = txt_vinventario.Text;
                txt_importa.Clear();
            }

        }

        //Cartera
        private void btn_vcartera_Click_1(object sender, EventArgs e)
        {
            frm_cartera cartera = new frm_cartera();
            //marcador_cartera = 1;
            Program.Evento = 1;
            Program.num_venta = Convert.ToString(c.revisar_ventas(Metodo_ObtenerFecha()));
            Program.total_venta = total;
            cartera.ShowDialog();

        }

        //Limpiar (BOTON)
        private void button1_Click(object sender, EventArgs e)
        {
            
            txt_vcodigo.Clear();
            txt_vcantidad.Clear();
            txt_vesxistencia.Clear();
            txt_vinventario.Clear();
            txt_vprecio.Text="0";
            txt_importa.Clear();
            txt_vtotal.Text = "0";
            total = 0;

        }

        //Cargar Formulario
        private void frm_ventas_Load(object sender, EventArgs e)
        {
            Program.cod_producto = "";
            txt_vtotal.Text = "0";
            label7.Text = "No.Venta:" + Convert.ToString(c.revisar_ventas(Metodo_ObtenerFecha()));
            Program.cod_producto = "";
            total = 0;
        }

        //Texbox Pago
        private void txt_vpago_TextChanged(object sender, EventArgs e)
        {

            if (txt_vpago.Text != "" && txt_vpago.Text != ".") txt_vcambio.Text = Convert.ToString(Convert.ToDouble(txt_vpago.Text) - Convert.ToDouble(txt_vtotal.Text));
            else txt_vcambio.Text = "";


        }

        //Eliminar Producto
        private void button3_Click(object sender, EventArgs e) 
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < codproducto.Count; i++)
                {
                    if (codproducto[i] == dataGridView1.CurrentRow.Cells[0].Value.ToString())
                    {
                        total = total - Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                        txt_vtotal.Text = Convert.ToString(total);
                        codproducto.RemoveAt(i);
                        cantidad.RemoveAt(i);
                        categoria.RemoveAt(i);
                        precio.RemoveAt(i);
                        sub_total.RemoveAt(i);

                        cantida_inventario.RemoveAt(i);

                        int fil = dataGridView1.CurrentRow.Index;
                        dataGridView1.Rows.RemoveAt(fil);
                    }
                }
            }
            else
            {
                MessageBox.Show("Necesita seleccionar un producto de la Tabla");
            }
        }

        string Metodo_ObtenerFecha()
        {
            string fecha;
            fecha = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            return fecha;
        }

        //Activar Formulario
        private void frm_ventas_Activated(object sender, EventArgs e)
        {
            
            txt_vcodigo.Text = Program.cod_producto;
            txt_vprecio.Text = Convert.ToString(Program.precio_publico);
            if (Program.Evento == 5)
            {
                c.Ingresar_venta(Convert.ToInt32(c.revisar_ventas(Metodo_ObtenerFecha())), "Credito", Metodo_ObtenerFecha(), total);
                for (int i = 0; i < codproducto.Count; i++)
                {
                    c.Agregar_Detalle_Venta(c.Consulta_codigo_Venta(), codproducto[i], cantidad[i], categoria[i], precio[i], sub_total[i]);
                    double cuenta = cantida_inventario[i] - cantidad[i];
                    c.Modificar_Cantidad_Inventario(cuenta, codproducto[i]);
                    dataGridView1.Rows.Clear();
                    txt_vtotal.Clear();
                    total = 0;
                    txt_vtotal.Text = "0";
                    cuenta = 0;
                    cantidad.Clear();
                    cantida_inventario.Clear();
                    
                }
            }
        }

        //Desactivar Formulario
        private void frm_ventas_Deactivate(object sender, EventArgs e)
        {
            Program.cod_producto = "";
            Program.precio_publico = 0;
            txt_vprecio.Text = "";
            txt_vcodigo.Focus();
            txt_vcambio.Text = "";
            txt_vpago.Text = "";
            Program.Metodo = 0;

        }

        //Agregar
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            double cantidadcompara = 0;
            if (txt_vinventario.Text != "")
            {
                if (txt_vcantidad.Text != "")
                {
                    cantidadcompara = Convert.ToDouble(txt_vcantidad.Text);
                    if (cantidadcompara > 0)
                    {
                        codproducto.Add(txt_vcodigo.Text);
                        cantidad.Add(Convert.ToDouble(txt_vcantidad.Text));
                        categoria.Add(lbl_vtipo.Text);
                        precio.Add(Convert.ToDouble(txt_vprecio.Text));
                        sub_total.Add(Convert.ToDouble(txt_importa.Text));

                        cantida_inventario.Add(Convert.ToDouble(txt_vinventario.Text));

                        dataGridView1.Rows.Add(txt_vcodigo.Text, c.Obtener_Descripcion_Producto(txt_vcodigo.Text), txt_vcantidad.Text, lbl_vtipo.Text, txt_vprecio.Text, txt_importa.Text);
                        total = total + Convert.ToDouble(txt_importa.Text);
                        txt_vtotal.Text = Convert.ToString(total);
                        txt_vcodigo.Clear();
                        txt_vcantidad.Clear();
                        txt_vesxistencia.Clear();
                        txt_vinventario.Clear();
                        txt_vprecio.Text = "0";
                        txt_importa.Clear();
                    }
                    else MessageBox.Show("Ingresar una cantidad mayor a cero");
                }
                else MessageBox.Show("Faltan datos por ingresar"); 
            }
            else MessageBox.Show("Falta agregar productos");
            txt_vcodigo.Focus();
        }

        //Seleccion celdas
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
            }
        }

        //Textbox Total
        private void txt_vtotal_TextChanged(object sender, EventArgs e)
        {
            if (txt_vtotal.Text != "0")
            {
                button5.Enabled = true;
                txt_vpago.Enabled = true;
                btn_vcartera.Enabled = true;
            }
            else
            {
                txt_vtotal.Text = "0";
                total = 0;
                button5.Enabled = false;
                txt_vpago.Enabled = false;
                btn_vcartera.Enabled = false;
            }
        }

        //
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        //Buscar
        private void pbx_buscar_Click(object sender, EventArgs e)
        {
            frm_listproductos lp = new frm_listproductos();
            lp.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            coddigoventa.Clear();
            codproducto.Clear();
            cantidad.Clear();
            categoria.Clear();
            precio.Clear();
            sub_total.Clear();
            dataGridView1.Rows.Clear();
            total = 0;
            txt_vtotal.Text = "0";
            Program.cod_producto = "";
            Program.precio_publico = 0;
            txt_vprecio.Text = "";
            txt_vcodigo.Focus();
            Program.Metodo = 0;
            button5.Enabled = false;
            txt_vpago.Clear();
            txt_vtotal.Clear();
        }

        private void txt_vcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Codigo(e);
        }

        private void txt_vcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_vpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_vesxistencia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
