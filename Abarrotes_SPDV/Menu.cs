using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Abarrotes_SPDV
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
            tmr_hora.Enabled = true;
        }

        frm_ventas v = new frm_ventas();
        frm_clientes c = new frm_clientes();
        frm_productos p = new frm_productos();
        frm_proveedores pv = new frm_proveedores();
        frm_pedidos pe = new frm_pedidos();
        frm_inventario i = new frm_inventario();
        Frm_Reportes r = new Frm_Reportes();

        #region'Fecha y Hora'
        private void frm_menu_Load(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
            Conexion cnx = new Conexion();
            

        }

        private void tmr_hora_Tick(object sender, EventArgs e)
        {
            
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            r.Hide();
            i.Hide();
            pe.Hide();
            pv.Hide();
            p.Hide();
            c.Hide();
            v.Hide();
            v.Show();
            v.DesktopLocation = new Point(305, 178);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            r.Hide();
            i.Hide();
            pe.Hide();
            pv.Hide();
            p.Hide();
            v.Hide();
            c.Hide();
            c.Show();
            c.DesktopLocation = new Point(305, 190);
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            r.Hide();
            i.Hide();
            pe.Hide();
            pv.Hide();
            c.Hide();
            v.Hide();
            p.Hide();
            p.Show();
            p.DesktopLocation = new Point(305, 178);
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            r.Hide();
            i.Hide();
            pe.Hide();
            p.Hide();
            c.Hide();
            v.Hide();
            pv.Hide();
            pv.Show();
            pv.DesktopLocation = new Point(305, 178);
        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            r.Hide();
            i.Hide();
            pv.Hide();
            p.Hide();
            c.Hide();
            v.Hide();
            pe.Hide();
            pe.Show();
            pe.DesktopLocation = new Point(305, 178);
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            r.Hide();
            pe.Hide();
            pv.Hide();
            p.Hide();
            c.Hide();
            v.Hide();
            i.Hide();
            i.Show();
            i.DesktopLocation = new Point(305, 190);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r.Hide();
            pe.Hide();
            pv.Hide();
            p.Hide();
            c.Hide();
            v.Hide();
            i.Hide();
            r.Show();
            r.DesktopLocation = new Point(305, 190);
        }
    }
}
