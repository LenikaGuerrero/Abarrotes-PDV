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
    public partial class frm_mod_clientes : Form
    {
        public frm_mod_clientes()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        
        string co, nom, app, apm, dir, tel;

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            txt_codigo.CharacterCasing = CharacterCasing.Upper;
            if (Program.Evento == 2)
            {
                if (c.c_cliente(txt_codigo.Text) > 0)
                {
                    MessageBox.Show("El Código del Cliente ya existe, favor de ingresar uno nuevo");
                    txt_codigo.Text = "";
                    txt_codigo.Focus();
                }
            }      
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Codigo(e);
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Telefono(e);
        }

        private void txt_apmaterno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_apmaterno.Text, "[^a-zA-Z áéíóúñÁÉÍÓÚ]"))
            {
                MessageBox.Show("Favor de  introducir únicamente letras.", "Verifique bien los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_apmaterno.Text = "";
            }
        }

        private void txt_appaterno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_appaterno.Text, "[^a-zA-Z áéíóúñÁÉÍÓÚ]"))
            {
                MessageBox.Show("Favor de  introducir únicamente letras.", "Verifique bien los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_appaterno.Text = "";
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_nombre.Text, "[^a-zA-Z áéíóúñÁÉÍÓÚ]"))
            {
                MessageBox.Show("Favor de  introducir únicamente letras.", "Verifique bien los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nombre.Text = "";
            }
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            

                if (Program.Evento == 2)
                {
                co = txt_codigo.Text;
                nom = txt_nombre.Text;
                app = txt_appaterno.Text;
                apm = txt_apmaterno.Text;
                tel = txt_telefono.Text;
                dir = txt_direccion.Text;
                if (txt_codigo.Text == "" || txt_nombre.Text == "" || txt_appaterno.Text == "" || txt_apmaterno.Text == "" || txt_telefono.Text == "" || txt_direccion.Text == "")
                    {
                        MessageBox.Show("Ingrese Todos los Campos");
                    }
                     else
                    {
                    c.Agregar_Clientes(co, nom, app, apm, tel, dir);
                    MessageBox.Show("Cliente Registrado con Exito");
                    this.Close();
                    }
                }
            
                if (Program.Evento == 1)
                {
                co = txt_codigo.Text;
                nom = txt_nombre.Text;
                app = txt_appaterno.Text;
                apm = txt_apmaterno.Text;
                tel = txt_telefono.Text;
                dir = txt_direccion.Text;
                if (txt_codigo.Text == "" || txt_nombre.Text == "" || txt_appaterno.Text == "" || txt_apmaterno.Text == "" || txt_telefono.Text == "" || txt_direccion.Text == "")
                    {
                    MessageBox.Show("Ingrese Todos los Campos");
                    }
                    else
                    {
                        c.Modificar_Cliente(nom,app,apm,tel,dir,co);
                        MessageBox.Show("Cliente Modificado con Exito");
                        this.Close();
                    }
                }
        
        }

        private void frm_mod_clientes_Load(object sender, EventArgs e)
        {
            txt_codigo.Enabled = true;
            if (Program.Evento == 1)
            {
                txt_codigo.Enabled = false;
                txt_nombre.Text = Program.nombre_cliente;
                txt_codigo.Text = Program.cod_cliente;
                txt_direccion.Text = Program.direc_cliente;
                txt_telefono.Text = Program.telefono;
                txt_appaterno.Text = Program.ap_paterno;
                txt_apmaterno.Text = Program.ap_materno;

            }
            if (Program.Evento == 2)
            {
                txt_nombre.Text = "";
                txt_codigo.Text = "";
                txt_direccion.Text = "";
                txt_telefono.Text = "";
                txt_appaterno.Text = "";
                txt_apmaterno.Text = "";
            }
        }
    }
}
