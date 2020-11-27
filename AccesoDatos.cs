using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Sistema_de_facturacion_2020_2
{
    class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void AbrirBd()
        {
            try
            {
                //conexion = new SqlConnection("Data Source=DESKTOP-M6DBLTR; Initial Catalog=[DbFacturas];Integrated Security=true");
                SqlConnection conexion = new SqlConnection(@"Data Source=.;Initial Catalog=DbFacturas;Integrated Security=True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pana fallo conexion, se le olvido programar abriendo base de datos?"+ ex);
            }
        }

        public void CerrarBd()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception pp)
            {
                MessageBox.Show("Pana fallo cerrando la conexion, se le olvido programar cerrando base de datos?" + pp);
            }
        }

        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=.;Initial Catalog=DbFacturas;Integrated Security=True");
                conexion.Open();
                string strEmpleado="";
                //string sentencia = $"SELECT e.strNombre, e.IdRolEmpleado FROM TblSeguridad s JOIN TblEmpleado e ON s.IdEmpleado  WHERE StrUsuario= '{StrUsuario}' and StrClave = '{StrClave}'";
                string sentencia = $"SELECT e.strNombre, e.IdRolEmpleado From TblSeguridad s JOIN TblEmpleado e ON s.IdEmpleado = e.IdEmpleado WHERE StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'";
   
                AbrirBd();
                cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 10;
                LectorDatos = cmd.ExecuteReader();

                while (LectorDatos.Read())
                {
                    strEmpleado = Convert.ToString(LectorDatos.GetValue(0));
                }
                if (LectorDatos != null)
                {
                    LectorDatos.Close();
                }
                return strEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la lectura de los datos : " + ex );
                return "";
            }
        }

        public DataTable CargaTabla(string tabla, string strCondicion)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=.;Initial Catalog=DbFacturas;Integrated Security=True");
                conexion.Open();
                AbrirBd();
                string Sql = "SELECT * FROM " + tabla + " " + strCondicion;
                da = new SqlDataAdapter(Sql, conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                //CerrarBd();
                return dt;
             }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo la consulta : " + ex.ToString());
                return null;
            }
        }

        public string EjecutarComando(string sentencia)
        {
            string salida = "los datos se actualizaron correctamente";
            try 
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=.;Initial Catalog=DbFacturas;Integrated Security=True");
                conexion.Open();
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                //CerrarBd();
                if (retornado > 0)
                {
                    salida = "ok";
                }
                else
                {
                    salida = "fallo";
                }
            }
            catch(Exception ex)
            {
                salida = "fallo insercion" + ex;
            }
            return salida;
        }


    }
}
