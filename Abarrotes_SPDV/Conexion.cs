using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Abarrotes_SPDV
{
    class Conexion
    {
        SqlConnection cn;       //crear conexion
        SqlCommand cmd;         //comando de sql(Consultas)
        SqlDataReader dr;       //Lee los datos de la base de datos
        SqlDataAdapter da;      //Adapta la info. al DataGridView
        DataTable dt;           //tabla de sql
        //ITH
        public Conexion() //CONEXION A LA BASE DE DATOS
        {
            //Data Source=192.168.0.17,1433;Initial Catalog=Abarrotes;user id=servidor;password=server!123      <----- SERVIDOR
            //Data Source=.;Initial Catalog=Abarrotes;Integrated Security=True                                  <----- LOCAL

            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Abarrotes;Integrated Security=True"); //Ruta de la Base de datos
                cn.Open();                                                                                  //Comprueba la ruta y abre la base de datos
                Console.WriteLine("Base de Datos Conectada");                                               //Mensaje a consola que si se hizo la conexion correctamente
                cn.Close();                                                                                 //cierra la conexion por posibles errores
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró conectar con la base de datos: " + ex.ToString());
            }
        }

        /*Las tablas que aparecen en los formularios son consultas de SQL, se decide que seleccionar de la tabla
        para mostrarse en el datagrid, o bien, buscar algo en especifico de la tabla que no aparece en el formulario*/ 

        #region 'Detalle De Ventas'

        public int revisar_ventas(string fecha)// este metodo es para consultar si esta un el producto registrado comparado mediante el codigo
        {
            int contador = 0;
            try
            {
                cn.Open();
                cmd = new SqlCommand("select  Top 1 no_venta from Venta where Fecha_Venta = '" + fecha + "' order by no_venta desc ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    contador = (Convert.ToInt32(dr["no_venta"].ToString())) + 1;
                }
                else contador = 1;
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public string Agregar_Detalle_Venta(int cod_venta, string cod_producto, double cantidad,string categoria, double precio, double sub_total)
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("Insert into Detalle_Venta values(" + cod_venta + ",'" + cod_producto + "'," + cantidad + ",'" + categoria + "'," + precio + "," + sub_total + ")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public void llenarDatos_Productos_Para_Ventas(string codigo_producto, TextBox inventario, TextBox precio, Label tipo)
        {
            string categoria = null;
            try
            {
                cn.Open();
                cmd = new SqlCommand("Select cantidad, precio_publico, categoria from Inventario where cod_producto='" + codigo_producto + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    inventario.Text = dr["cantidad"].ToString();
                    precio.Text = dr["precio_publico"].ToString();
                    categoria = dr["categoria"].ToString();

                }
                if (categoria == "Pieza") tipo.Text = "Pza";
                else tipo.Text = "Kg";
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }

        public string Obtener_Descripcion_Producto(string codigo_producto)// SE UTILIZA PARA SABER LA DESCRIPCION DEL PRODUCTO USANDO EL CODIGO 
        {
            string cosa="";
            try
            {
                cn.Open();
                cmd = new SqlCommand("select descripcion from Inventario where cod_producto='"+ codigo_producto+"'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cosa = dr["descripcion"].ToString();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
            return cosa;
        }

        public int producto_inv_registrado(string id)// este metodo es para consultar si esta un el producto registrado comparado mediante el codigo
        {
            int contador = 0;
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT* FROM Inventario WHERE cod_producto='" + id + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public void Ingresar_venta(int no_venta,string tipo_venta,string fecha_venta,double total)
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("Insert into Venta values(" + no_venta + ",'" + tipo_venta + "','" + fecha_venta + "'," + total + ")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
        }

        public int Consulta_codigo_Venta()// 
        {
            int cosa =0;
            try
            {
                cn.Open();
                cmd = new SqlCommand("select TOP 1 cod_venta from Venta order by cod_venta desc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cosa = Convert.ToInt32(dr["cod_venta"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
            return cosa;
        }

        public void Modificar_Cantidad_Inventario(double cantidad,string codigo)
        {
         
            try
            {
             
                cn.Open();
                cmd = new SqlCommand("UPDATE Inventario set cantidad="+cantidad+" where cod_producto='"+codigo+"'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                //---------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
           
        }
        
        #endregion

        #region'Productos'

        public void busqueda_productos(DataGridView dtg, string nombre_producto, string codigo_producto)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT cod_producto,descripcion,categoria,departamento,precio_publico FROM Inventario WHERE descripcion like'%" + nombre_producto + "%' or cod_producto like'%" + codigo_producto + "%'", cn);
                dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
        }

        public void tabla_producto(DataGridView dgv)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT cod_producto,descripcion,marca,categoria,departamento,precio_publico AS precio FROM Inventario", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
        }

        public void modificar_datos_productos(String codigo_producto, TextBox cant, TextBox aviso,TextBox precio_c, TextBox precio_p, TextBox precio_u,ComboBox iva)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT cantidad,precio_compra,precio_publico,IVA,precio_unitario, aviso_cantidad FROM Inventario WHERE cod_producto like '%"+codigo_producto+"%'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cant.Text = dr["cantidad"].ToString();
                    aviso.Text = dr["aviso_cantidad"].ToString();
                    precio_c.Text = dr["precio_compra"].ToString();
                    precio_p.Text = dr["precio_publico"].ToString();
                    precio_u.Text = dr["precio_unitario"].ToString();
                    iva.Text= dr["IVA"].ToString();
                    
                    
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
            
        }

        public void modificar_producto(DataGridView dgv, string cod, string marca, string cant, string pc, string iva, string desc,string pu,string pp,string aviso,string cod_pv)
        {
            try
            {
                
                    cn.Open();
                   // da = new SqlDataAdapter("UPDATE Inventario  set cod_proveedor=NULL WHERE cod_proveedor in (select cod_proveedor from Proveedor where Telefono=" + telefono + ")", cn);
                    da = new SqlDataAdapter("UPDATE Inventario SET Marca='"+marca+"',cantidad="+cant+",precio_compra="+pc+",IVA='"+iva+ "',descripcion='" + desc + "',precio_unitario=" + pu+",precio_publico="+pp+",aviso_cantidad="+aviso+",cod_proveedor="+cod_pv+" WHERE cod_producto like '%"+cod+"%'", cn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    cn.Close();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
        }

        public int c_producto (string cod)
        {

            int contador = 0;
            try
            {
                
                if (Program.Evento == 1)
                {
                    cn.Open();
                    cmd = new SqlCommand("SELECT * FROM Inventario WHERE cod_producto='" + cod + "'", cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        contador++;
                    }
                    dr.Close();
                    cn.Close();
                }
                
                    if (Program.Evento == 2)
                    {
                        cn.Open();
                        cmd = new SqlCommand("SELECT * FROM Inventario WHERE descripcion='" + cod + "'", cn);
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            contador++;
                        }
                        dr.Close();
                        cn.Close();
                    }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public void Agregar_Producto(string cod,string desc, string marca,string cat,string dpto, string cant, string pc, string iva, string pu, string pp, string aviso ,string cod_pv) //GUARDAR PRODUCTO
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("INSERT INTO Inventario VALUES('"+cod+"','"+desc+"','"+marca+"','"+cat+"','"+dpto+"',"+cant+","+pc+",'"+iva+"',"+pu+","+pp+","+aviso+","+cod_pv+")", cn);
                
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            
        }

        public void eliminar_producto(DataGridView dgv, string cod)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("DELETE FROM Detalle_Venta WHERE cod_producto ='" + cod + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
                cn.Open();
                da = new SqlDataAdapter("DELETE FROM Pedido WHERE cod_producto='" + cod + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
                cn.Open();
                da = new SqlDataAdapter("DELETE FROM Inventario WHERE cod_producto = '" + cod + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
        }

        public void empresa_proveedor(ComboBox pv)
        {

            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT Empresa FROM Proveedor", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pv.Items.Add(dr["Empresa"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los Proveedores " + ex.ToString());
            }
            
        }

        public string codigo_proveedor(string emp)//BUSCAR CODIGO DEL PROVEEDOR POR LA EMPRESA
        {
            
            try
            {
                
               
                    cn.Open();
                    cmd = new SqlCommand("SELECT cod_proveedor FROM Proveedor WHERE Empresa ='" + emp + "';", cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        emp = dr["cod_proveedor"].ToString();
                    }
                    dr.Close();
                    cn.Close();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los Proveedores " + ex.ToString());
            }
            return emp;
        }

        public string empresa(string cod_prod)//BUSCAR CODIGO DEL PROVEEDOR POR EL COD. DEL PRODUCTO
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Empresa from Proveedor as p inner join Inventario as i on p.cod_proveedor=i.cod_proveedor WHERE i.cod_producto='"+cod_prod+"';", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cod_prod= dr["Empresa"].ToString();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los Proveedores " + ex.ToString());
            }
            return cod_prod;
        }

        public void tabla_producto_notnull(DataGridView dgv)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT cod_producto,descripcion,marca,categoria,departamento,precio_publico AS precio FROM Inventario WHERE cod_proveedor is not null", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
        }

        #endregion

        #region'Clientes'

        public void busqueda_clientes(DataGridView dtg, string nombre, string app,string apm)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT cod_cliente,Nombre,Ap_Paterno,Ap_Materno,Telefono,Direccion FROM Cliente WHERE Nombre like '%" + nombre+"%'or Ap_Paterno like'%"+app+"%' or Ap_Materno like '%"+apm+"%'", cn);
                dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
        }

        public void tabla_clientes(DataGridView dgv)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT cod_cliente,Nombre,Ap_Paterno,Ap_Materno,Telefono,Direccion FROM Cliente", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        public void tabla_listadoclientes(DataGridView dgv)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT cod_cliente,Nombre,Ap_Paterno,Ap_Materno,Telefono,Direccion FROM Cliente", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        public void tablaclientes(DataGridView dgv, string menu)
        {
            try
            {
              
                cn.Open();
                da = new SqlDataAdapter("SELECT cod_cliente,Nombre,Ap_Paterno,Ap_Materno,Telefono,Direccion FROM Cliente WHERE Nombre like '" + menu+"%%'", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();


                //da = new SqlDataAdapter(, cn);
                //dt = new DataTable();
                //da.Fill(dt);
                //dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        } 

        public string Agregar_Clientes(string cod_cliente, string nombre, string app, string apm, string telefono, string direc)
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into Cliente values('" + cod_cliente + "','" + nombre + "','" + app + "','" + apm + "'," + telefono + ",'" + direc + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public void Modificar_Cliente(string nombre, string app, string apm, string telefono, string dir, string cod)
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE Cliente SET Nombre='"+nombre+"',Ap_Paterno='"+app+"',Ap_Materno='"+apm+"',Telefono="+telefono+",Direccion='"+dir+"' WHERE cod_cliente='"+cod+"'", cn);
                dt = new DataTable();
                cmd.ExecuteNonQuery();
                cn.Close();
                
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }

        }

        public void Eliminar_Cliente(string cod_cliente)
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("DELETE FROM Cliente WHERE cod_cliente='" + cod_cliente + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
        }

        public int c_cliente(string cod)
        {

            int contador = 0;
            try
            {

               
                    cn.Open();
                    cmd = new SqlCommand("SELECT * FROM Cliente WHERE cod_cliente='" + cod + "'", cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        contador++;
                    }
                    dr.Close();
                    cn.Close();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }


        #endregion

        #region 'Proveedores'
        #region ' '
        public void busqueda_proveedores(DataGridView dgv,string nombre_prov,string nombre_empresa)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT Nombre,Telefono,Empresa,Direccion_Emp AS Direccion_Empresa FROM Proveedor WHERE Nombre like '%"+nombre_prov+"%' or Empresa like '%"+nombre_empresa+"%'", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        public void tabla_proveedores(DataGridView dgv)
        {
            try
            {

                cn.Open();
                da = new SqlDataAdapter("SELECT Nombre,Telefono,Empresa,Direccion_Emp AS Direccion_Empresa FROM Proveedor", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        public void tabla_proveedores_pdt(DataGridView dgv)
        {
            try
            {

                cn.Open();
                da = new SqlDataAdapter("SELECT cod_producto,descripcion FROM Inventario WHERE cod_proveedor is null", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        public void busqueda_proveedores_pdt(DataGridView dgv, string cod_prod,string nombre)
        {
            try
            {

                cn.Open();
                da = new SqlDataAdapter("SELECT cod_producto,descripcion FROM Pendiente WHERE cod_producto like '%"+cod_prod+"%' or descripcion like '%"+nombre+"%'", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }
        #endregion
        public void Agregar_Proveedor(string nombre, string telefono, string empresa, string dir) 
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("INSERT INTO Proveedor VALUES('"+nombre+"','"+telefono+"','"+empresa+"','"+dir+"')", cn);
                dt = new DataTable();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
        }

        public void Modificar_Proveedor(string nombre, string telefono, string empresa, string dir,string tel) //GUARDAR PROVEEDOR
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE Proveedor SET Nombre='"+nombre+"',Telefono="+tel+",Empresa='"+empresa+"',Direccion_Emp='"+dir+"' WHERE Telefono='"+telefono+"'", cn);
                dt = new DataTable();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }

        }

        public void proveedor_a_producto(string cod_prov,string cod_prod)
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE Inventario SET cod_proveedor="+cod_prov+" WHERE cod_producto='"+cod_prod+"'", cn);
                dt = new DataTable();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }

        }

        public int c_proveedor(string cod)
        {

            int contador = 0;
            try
            {
                cn.Open();
                cmd = new SqlCommand("select * from Inventario WHERE cod_proveedor=" +cod, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   contador++;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public void eliminar_proveedor(DataGridView dgv, string telefono)
        {
            try
            {

                cn.Open();
                da = new SqlDataAdapter("DELETE Proveedor FROM Proveedor WHERE Telefono=" + telefono, cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }


        #endregion

        #region'Inventario'

        public void busqueda_inventario(DataGridView dgv, string seleccion, string valor)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT cod_producto,descripcion,Marca,categoria,departamento,cantidad,precio_compra,IVA,precio_unitario,precio_publico,aviso_cantidad,cod_proveedor FROM Inventario WHERE " + seleccion+" like "+valor, cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        public void tabla_inventario(DataGridView dgv)
        {
            try
            {

                cn.Open();
                da = new SqlDataAdapter("SELECT cod_producto,descripcion,Marca,categoria,departamento,cantidad,precio_compra,IVA,precio_unitario,precio_publico,aviso_cantidad,cod_proveedor FROM Inventario", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        #endregion

        #region'Pedidos'

        public void busqueda_pedido(DataGridView dgv, string fecha) //TABLA DE BUSQUEDA POR DÍA (CALENDARIO)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT i.descripcion AS Nombre,p.Cantidad,p.Fecha_Pedido AS 'Fecha de Pedido',pr.Empresa,pr.Telefono FROM Pedido as p INNER JOIN Proveedor as pr on pr.cod_proveedor = p.cod_proveedor INNER JOIN Inventario as i on i.cod_producto = p.cod_producto WHERE p.Fecha_Pedido ='"+ fecha+"'", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        public void tabla_pedido(DataGridView dgv)//TABLA GENERAL
        {
            try
            {

                cn.Open();
                da = new SqlDataAdapter("SELECT i.descripcion AS Nombre,p.Cantidad,p.Fecha_Pedido AS 'Fecha de Pedido',pr.Empresa,pr.Telefono FROM Pedido as p INNER JOIN Proveedor as pr on pr.cod_proveedor = p.cod_proveedor INNER JOIN Inventario as i on i.cod_producto = p.cod_producto; ", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        public void proveedor(TextBox prov,string producto)//BUSCAR NOMBRE DE LA EMPRESA POR EL COD. DEL PRODUCTO
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Empresa from Proveedor as p inner join Inventario as i on p.cod_proveedor=i.cod_proveedor WHERE i.cod_producto='" + producto+"';", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    prov.Text=(dr["Empresa"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los Proveedores " + ex.ToString());
            }
        }



        public string Agregar_Pedido(string cod_producto, double cantidad, string fecha,string cod_prov) //GUARDAR PEDIDO
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("insert into Pedido values('" + cod_producto+ "'," +cantidad+ ",'" +fecha+ "'," +cod_prov+")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string cod_producto(string des)//BUSCAR CODIGO DEL PRODUCTO POR SU DESCRIPCION(NOMBRE)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT cod_producto FROM Inventario WHERE Descripcion like '%"+des+"%'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    des = dr["cod_producto"].ToString();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los Proveedores " + ex.ToString());
            }
            return des;
        }

        public void modificar_pedidos_cantidad(DataGridView dgv,double n_valor,string cod,string fecha)
        {
            try
            {
                if (Program.Evento == 2)
                {
                    cn.Open();
                    da = new SqlDataAdapter("UPDATE Pedido SET Cantidad="+n_valor+" WHERE cod_producto='"+cod+"' AND Fecha_Pedido='"+fecha+"'", cn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    cn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        public void modificar_pedidos_fecha(DataGridView dgv, string n_fecha, string cod, string fecha)
        {
            try
            {
                if (Program.Evento == 1)
                {
                    cn.Open();
                    da = new SqlDataAdapter("UPDATE Pedido SET Fecha_Pedido='"+n_fecha+"' WHERE cod_producto='"+cod+"' AND Fecha_Pedido='"+fecha+"'", cn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    cn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }

        public void eliminar_pedidos(DataGridView dgv,string cod,string fecha)
        {
            try
            {
               
                    cn.Open();
                    da = new SqlDataAdapter("DELETE Pedido FROM Pedido WHERE cod_producto='"+cod+"' AND Fecha_Pedido='"+fecha+"'", cn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    cn.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }

        }


        #endregion

        #region 'Cartera'
        public void Codigo_cartera(string codigo_cliente, DataGridView dgt)
        {
            string cosa = "";
            try
            {
                cn.Open();
                da = new SqlDataAdapter("select fecha, cargo, abono, adeudo from Cartera where cod_cliente='" + codigo_cliente + "'", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgt.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
        }

        public string Adeudo_Cartera(string codigo_cliente)
        {
            string cosa = "";
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Top 1 adeudo from Cartera where cod_cliente='" + codigo_cliente + "' order by cartera_auto desc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cosa = dr["adeudo"].ToString();
                }
                else cosa = "0";
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
            return cosa;
        }

        public void Ingresar_Cartera(string no_venta, string codigo_cliente, string fecha, double cargo, double abono, double adeudo)
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("Insert into Cartera values('" + no_venta + "','" + codigo_cliente + "','" + fecha + "'," + cargo + "," + abono + "," + adeudo + ")", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
        }

        public void Eliminar_Cartera(string cod_cliente)
        {
            string salida = "Se registro con exito";
            try
            {
                cn.Open();
                cmd = new SqlCommand("Delete  from Cartera where cod_cliente='" + cod_cliente + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
        }
        #endregion

        #region 'Avisos'

        #endregion

        public void Productos_Finales(DataGridView dtg)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT  V.no_venta, d.cod_producto, p.descripcion, d.cantidad, d.categoria, d.precio, d.sub_total FROM Detalle_Venta AS d INNER JOIN Inventario AS p ON d.cod_producto = p.cod_producto INNER JOIN Venta AS V ON V.cod_venta = d.cod_venta WHERE(V.fecha_venta = CONVERT(date, SYSDATETIME()))", cn);
                dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
        }
        public void Ventas_Finales(DataGridView dtg)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT        no_venta, tipo_venta, fecha_venta, total, cod_venta FROM            Venta", cn);
                dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar consulta" + ex.ToString());
            }
        }

    }
}
