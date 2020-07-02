using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //necesario para conectarme a BD SQL, buscar necesario para cada motor de BD
using BaseDatos.Entidades;
using System.Configuration;


namespace BaseDatos
{
    public class GestionBD
    {
        SqlConnection conexion;
        SqlCommand comando;
        
        public List<EstadoHerramienta> listaEstados()
        {

            SqlDataReader datos;
            List<EstadoHerramienta> listadoretorno;
            //paso1--se crea la conexion
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-L77V4MS\SQL2020;Initial Catalog=Ferreteria;Integrated Security=True";

            //paso2--se configura el comando
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from EstadoHerramienta";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandTimeout = 0;

            //paso 3---ejecutar comanado
            conexion.Open();
            datos = comando.ExecuteReader();//estp ejecuta el select

            //paso 4--config estrutura
            listadoretorno = new List<EstadoHerramienta>();
            while (datos.Read())
            {
                EstadoHerramienta objetoTipo = new EstadoHerramienta();
                objetoTipo.IdEstado = datos.GetInt32(0);
                objetoTipo.desEstado = datos.GetString(1);
                listadoretorno.Add(objetoTipo);
            }
            return listadoretorno;
        }

        public List<TipoHerramienta> listaHerramienta()
        {

            SqlDataReader datos;
            List<TipoHerramienta> listadoretorno;
            //paso1--se crea la conexion
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-L77V4MS\SQL2020;Initial Catalog=Ferreteria;Integrated Security=True";

            //paso2--se configura el comando
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from TipoHerramienta";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandTimeout = 0;

            //paso 3---ejecutar comanado
            conexion.Open();
            datos = comando.ExecuteReader();//estp ejecuta el select

            //paso 4--config estrutura
            listadoretorno = new List<TipoHerramienta>();
            while (datos.Read())
            {
                TipoHerramienta objetoTipo = new TipoHerramienta();
                objetoTipo.codTipo = datos.GetInt32(0);
                objetoTipo.desTipo = datos.GetString(1);
                listadoretorno.Add(objetoTipo);
            }
            return listadoretorno;
        }

        public bool registroHerramienta(Herramientas objHerramienta)
        {
            int control = -1;
            bool respuesta = false;
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-L77V4MS\SQL2020;Initial Catalog=Ferreteria;Integrated Security=True";

            using (SqlConnection cnx = new SqlConnection( @"Data Source = DESKTOP - L77V4MS\SQL2020; Initial Catalog = Ferreteria; Integrated Security = True"))// NO TENGO APP.CONFIG PARA MODIFICAR LA CONEXION, QUE SE HACE EN ESOS CASO?
            {
                comando = new SqlCommand();
                comando.Connection = cnx;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INsert into Herramientas(codHerramienta, nomHerramienta) values(@codHerramienta,@nomHerramienta)";

                SqlParameter objParametro = new SqlParameter();
                //objParametro.ParameterName = "@codHerramienta";
                //objParametro.SqlDbType = System.Data.SqlDbType.Int;
                //objParametro.Size = 30;
                //objParametro.Value = objHerramienta.codHerramienta;


                comando.Parameters.Add(new SqlParameter("codHerramienta", objHerramienta.codHerramienta));

                //otra forma

                comando.Parameters.Add(new SqlParameter("nomHerramienta", objHerramienta.nomHerramienta));
                cnx.Open();

                control = comando.ExecuteNonQuery();

            }

            if (control > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }

    }
}




