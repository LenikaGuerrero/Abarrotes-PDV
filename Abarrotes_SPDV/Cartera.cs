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
    public partial class frm_cartera : Form
    {
        Conexion c = new Conexion();
        public frm_cartera()
        {
            InitializeComponent();
        }


        private void btn_nuevocliente_Click(object sender, EventArgs e)
        {
            frm_mod_clientes mc = new frm_mod_clientes();
            mc.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            frm_listclientes lc = new frm_listclientes();
            lc.ShowDialog();
        }

        private void frm_cartera_Load(object sender, EventArgs e)
        {
            if (Program.Evento == 1)
            {
                txt_cantidad.Text = Convert.ToString(Program.total_venta);
                cmb_car_abono.SelectedIndex = 0;
                txt_cantidad.Enabled = false;
                cmb_car_abono.Enabled = false;
                txt_adeudo.Enabled = false;
                txt_nuevoadeudo.Enabled = false;
                txt_nombre.Enabled = false;
            }
            else
            {
                if (Program.Evento == 2)
                {

                    btn_buscar.Enabled = false;
                    txt_adeudo.Enabled = false;
                    txt_nuevoadeudo.Enabled = false;
                    txt_nombre.Enabled = false;
                    txt_nombre.Text = Program.nombre_cliente;
                }
            }
        }

        private void cmb_car_abono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_cantidad.Text != "") if (txt_adeudo.Text != "" && txt_cantidad.Text != "" && cmb_car_abono.Text == "Cargo") txt_nuevoadeudo.Text = Convert.ToString((Convert.ToDouble(txt_adeudo.Text)) + (Convert.ToDouble(txt_cantidad.Text)));
                else if (txt_adeudo.Text != "" && txt_cantidad.Text != "" && cmb_car_abono.Text == "Abono") txt_nuevoadeudo.Text = Convert.ToString((Convert.ToDouble(txt_adeudo.Text)) - (Convert.ToDouble(txt_cantidad.Text)));

            if (txt_adeudo.Text == "0")
            {
                if (cmb_car_abono.SelectedIndex == 1)
                {
                    txt_cantidad.Enabled = false;
                }
                else txt_cantidad.Enabled = true;
            }
            else
            {
                txt_cantidad.Enabled = true;
            }
        }

        private void frm_cartera_Activated(object sender, EventArgs e)
        {
            txt_nombre.Text = Program.nombre_cliente;
            c.Codigo_cartera(Program.cod_cliente, dgvc);
            txt_adeudo.Text = c.Adeudo_Cartera(Program.cod_cliente);
        }

        private void txt_adeudo_TextChanged(object sender, EventArgs e)
        {
            if (txt_adeudo.Text != "" && txt_cantidad.Text != "" && cmb_car_abono.SelectedIndex == 0)
            {
                txt_nuevoadeudo.Text = Convert.ToString((Convert.ToDouble(txt_adeudo.Text)) + (Convert.ToDouble(txt_cantidad.Text)));
            }
            else if (txt_adeudo.Text != "" && txt_cantidad.Text != "" && cmb_car_abono.SelectedIndex == 1) txt_nuevoadeudo.Text = Convert.ToString((Convert.ToDouble(txt_adeudo.Text)) - (Convert.ToDouble(txt_cantidad.Text)));
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            double nuevoadeudo = 0;
            if (txt_nuevoadeudo.Text != "") nuevoadeudo = Convert.ToDouble(txt_nuevoadeudo.Text);

            if (nuevoadeudo >= 0)
            {
                if (Program.Evento != 1) Program.num_venta = "0";
                if (cmb_car_abono.Text == "Cargo")
                {
                    if (txt_cantidad.Text != "0")
                    {
                        if (cmb_car_abono.Text == "Cargo" && txt_cantidad.Text != "" && txt_nuevoadeudo.Text != "" && txt_nombre.Text != "")
                        {
                            c.Ingresar_Cartera(Program.num_venta, Program.cod_cliente, Metodo_ObtenerFecha(), Convert.ToDouble(txt_cantidad.Text), 0, Convert.ToDouble(txt_nuevoadeudo.Text));
                            MessageBox.Show("Registro exitoso");
                            if (Program.Evento == 1) { Program.Evento = 5; }
                            txt_nombre.Text = Program.nombre_cliente;
                            c.Codigo_cartera(Program.cod_cliente, dgvc);
                            txt_adeudo.Text = c.Adeudo_Cartera(Program.cod_cliente);
                            txt_nombre.Text = Program.nombre_cliente;
                            MetodoLimpieza();

                        }
                        else MessageBox.Show("Faltan datos por llenar");
                    }
                    else { MessageBox.Show("No se puede cargar la cantidad de 0"); MetodoLimpieza(); }

                }
                else if (cmb_car_abono.Text == "Abono")
                {
                    if (txt_cantidad.Text == "0") { MessageBox.Show("No se puede abonar la cantidad de 0"); MetodoLimpieza(); }
                    else
                    if (cmb_car_abono.Text == "Abono" && txt_cantidad.Text != "" && txt_adeudo.Text != "" && txt_adeudo.Text != "0" && txt_nombre.Text != "")
                    {
                        c.Ingresar_Cartera(Program.num_venta, Program.cod_cliente, Metodo_ObtenerFecha(), 0, Convert.ToDouble(txt_cantidad.Text), Convert.ToDouble(txt_nuevoadeudo.Text));
                        Program.Evento = 0;
                        txt_adeudo.Text = c.Adeudo_Cartera(Program.cod_cliente);
                        txt_nombre.Text = Program.nombre_cliente;

                        if (txt_adeudo.Text == "0") { c.Eliminar_Cartera(Program.cod_cliente); MessageBox.Show("La deuda ha sido saldada"); txt_cantidad.Enabled = false; }
                        else MessageBox.Show("Registro exitoso");
                        txt_nombre.Text = Program.nombre_cliente;
                        c.Codigo_cartera(Program.cod_cliente, dgvc);
                        MetodoLimpieza();

                    }
                    else MessageBox.Show("Faltan datos por llenar");
                }
                else MessageBox.Show("Faltan datos por llenar");
            }
            else MessageBox.Show("No se permiten cantidades negativas");

        }
        string Metodo_ObtenerFecha()
        {
            string fecha;
            fecha = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            return fecha;
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "") txt_nuevoadeudo.Text = "";
            else
            if (txt_adeudo.Text != "" && txt_cantidad.Text != "" && cmb_car_abono.Text == "Cargo") txt_nuevoadeudo.Text = Convert.ToString((Convert.ToDouble(txt_adeudo.Text)) + (Convert.ToDouble(txt_cantidad.Text)));
            else if (txt_adeudo.Text != "" && txt_cantidad.Text != "" && cmb_car_abono.Text == "Abono") txt_nuevoadeudo.Text = Convert.ToString((Convert.ToDouble(txt_adeudo.Text)) - (Convert.ToDouble(txt_cantidad.Text)));

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_nombre.Text, "[^a-zA-Z áéíóúñÁÉÍÓÚ]"))
            {
                MessageBox.Show("Favor de  introducir únicamente letras.", "Verifique bien los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nombre.Text = "";
            }
        }
        void MetodoLimpieza()
        {
            cmb_car_abono.Text = "";
            txt_cantidad.Clear(); txt_nuevoadeudo.Clear();
        }

        private void frm_cartera_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.nombre_cliente = "";
            Program.cod_cliente = "";
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
