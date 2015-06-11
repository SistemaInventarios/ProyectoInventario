using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoInventario
{
    class Gestion
    {
        private Conexion conn = new Conexion();

        public void AgregarProducto(string nombre, int cantidad, int precio, string empresa)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insert into producto(nombre, cantidad, precio, empresa)values(@Nombre,@Cantidad,@Precio,@Empresa)", conn.conector);
            da.InsertCommand.Parameters.Add(new SqlParameter("@Nombre", nombre));
            // da.InsertCommand.Parameters.Add(new SqlParameter("@dig_veri", codigo_verificador));
            da.InsertCommand.Parameters.Add(new SqlParameter("@Cantidad", cantidad));
            da.InsertCommand.Parameters.Add(new SqlParameter("@Precio", precio));
            da.InsertCommand.Parameters.Add(new SqlParameter("@Empresa", empresa));
            da.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public void ActualizarProducto(int id, string nombre, int cantidad, int precio, string empresa)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("update producto set nombre = @Nombre, cantidad = @Cantidad, precio = @Precio, empresa = @Empresa where id = @Id", conn.conector);

            da.UpdateCommand.Parameters.Add(new SqlParameter("@Id", id));
            
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Nombre", nombre));
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Cantidad", cantidad));
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Precio", precio));
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Empresa", empresa));
            da.UpdateCommand.ExecuteNonQuery();

            conn.desconectar();

        }
        public void EliminarProducto(int id)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("Delete from producto where id = @Id", conn.conector);
            da.DeleteCommand.Parameters.Add(new SqlParameter("@Id", id));
            da.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();

        }
        public DataTable BuscarProducto(string nombre)
        {
            int cant_filas = 0;
            conn.conectar();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM producto WHERE nombre like @Nombre", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Nombre", nombre + "%"));
            // AddWithValue("@tags", "%" + tag + "%");


            cant_filas = da.Fill(dt);
            conn.desconectar();
            return dt;
        }

        public DataTable mostrarProducto()
        {

            conn.conectar();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("(select * from producto)", conn.conector);
            da.Fill(dt);
            conn.desconectar();
            return dt;

        }

        public void AgregarProveedor(string nombre, string direccion, int telefono, string email, int codigo_postal)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insert into proveedor(nombre, direccion, telefono, email, codigo_postal)values(@Nombre,@Direccion,@Telefono,@Email,@Codigo_postal)", conn.conector);
            da.InsertCommand.Parameters.Add(new SqlParameter("@Nombre", nombre));
            // da.InsertCommand.Parameters.Add(new SqlParameter("@dig_veri", codigo_verificador));
            da.InsertCommand.Parameters.Add(new SqlParameter("@Direccion", direccion));
            da.InsertCommand.Parameters.Add(new SqlParameter("@Telefono", telefono));
            da.InsertCommand.Parameters.Add(new SqlParameter("@Email", email));
            da.InsertCommand.Parameters.Add(new SqlParameter("@Codigo_postal", codigo_postal));
            da.InsertCommand.ExecuteNonQuery();
            conn.desconectar();
        }
        public void ActualizarProveedor(int id, string nombre, string direccion, int telefono, string email, int codigo_postal)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = new SqlCommand("update proveedor set nombre = @Nombre, direccion = @Direccion, telefono = @Telefono, email = @Email, codigo_postal = @Codigo_postal where id = @Id", conn.conector);

            da.UpdateCommand.Parameters.Add(new SqlParameter("@Id", id));
            
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Nombre", nombre));
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Direccion", direccion));
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Telefono", telefono));
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Email", email));
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Codigo_postal", codigo_postal));
            da.UpdateCommand.ExecuteNonQuery();

            conn.desconectar();

        }
        public void EliminarProveedor(int id)
        {
            conn.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("Delete from proveedor where id = @Id", conn.conector);
            da.DeleteCommand.Parameters.Add(new SqlParameter("@Id", id));
            da.DeleteCommand.ExecuteNonQuery();
            conn.desconectar();

        }
        public DataTable BuscarProveedor(string nombre)
        {
            int cant_filas = 0;
            conn.conectar();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM proveedor WHERE nombre like @Nombre", conn.conector);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Nombre", nombre + "%"));
            // AddWithValue("@tags", "%" + tag + "%");


            cant_filas = da.Fill(dt);
            conn.desconectar();
            return dt;
        }

        public DataTable mostrarProveedor()
        {

            conn.conectar();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("(select * from proveedor)", conn.conector);
            da.Fill(dt);
            conn.desconectar();
            return dt;

        }
    }
}
