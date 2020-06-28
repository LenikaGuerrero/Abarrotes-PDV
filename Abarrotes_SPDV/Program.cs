using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abarrotes_SPDV
{
    static class Program
    {
        public static int Evento=0;
        public static int Metodo = 0;
        //Datos del Producto
        public static string cod_producto;
        public static string descripción;
        public static string marca;
        public static string categoria;
        public static string departamento;
        public static double cantidad=0;
        public static double precio_compra=0;
        public static string iva;
        public static double precio_unitario=0;
        public static double precio_publico;

        //Datos del Cliente
        public static string cod_cliente;
        public static string nombre_cliente;
        public static string ap_paterno;
        public static string ap_materno;
        public static string telefono;
        public static string direc_cliente;

        //Datos del Proveedor
        public static string cod_prod;
        public static string cod_prov;

        //Venta_Cartera
        public static double total_venta;
        public static string num_venta;

        //reportes
        public static int indicador_reporte;

        //Cartera
        public static double adeudo;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_menu());
        }
    }
}
