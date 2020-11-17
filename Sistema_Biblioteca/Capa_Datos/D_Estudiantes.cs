using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_Datos
{
    public class D_Estudiantes
    {
        SqlConnection cnxn =
            new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public DataTable D_Listado()
        {
            SqlCommand cmd = new SqlCommand("SP_LISTAR_ESTUDIANTES", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Buscar()
        {
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_ESTUDIANTE", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnxn.Open();
            cmd.Parameters.AddWithValue("@ID_MATRICULA", E_Estudiantes.Id_Matricula);
            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cnxn.Close();
            return tabla;
        }

        public void D_Guardar()
        {
            SqlCommand cmd = new SqlCommand("SP_AGREGAR_ESTUDIANTE", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnxn.Open();
            cmd.Parameters.AddWithValue("@ID_MATRICULA", E_Estudiantes.Id_Matricula);
            cmd.Parameters.AddWithValue("@NOMBRE", E_Estudiantes.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", E_Estudiantes.Apellido);
            cmd.Parameters.AddWithValue("@TELEFONO", E_Estudiantes.Telefono);
            cmd.Parameters.AddWithValue("@DIRECCION", E_Estudiantes.Direccion);
            cmd.Parameters.AddWithValue("@TIPO_IDENTIFICACION", E_Estudiantes.Tipo_Identificacion);
            cmd.Parameters.AddWithValue("@NUM_IDENTIFICACION", E_Estudiantes.Num_Identificacion);

            cmd.ExecuteNonQuery();

            cnxn.Close();
        }

        public void D_Editar()
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_ESTUDIANTE", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnxn.Open();
            cmd.Parameters.AddWithValue("@ID_MATRICULA", E_Estudiantes.Id_Matricula);
            cmd.Parameters.AddWithValue("@NOMBRE", E_Estudiantes.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", E_Estudiantes.Apellido);
            cmd.Parameters.AddWithValue("@TELEFONO", E_Estudiantes.Telefono);
            cmd.Parameters.AddWithValue("@DIRECCION", E_Estudiantes.Direccion);
            cmd.Parameters.AddWithValue("@TIPO_IDENTIFICACION", E_Estudiantes.Tipo_Identificacion);
            cmd.Parameters.AddWithValue("@NUM_IDENTIFICACION", E_Estudiantes.Num_Identificacion);

            cmd.ExecuteNonQuery();

            cnxn.Close();
        }


        public void D_Borrar()
        {
            SqlCommand cmd = new SqlCommand("SP_BORRAR_ESTUDIANTE", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnxn.Open();

            cmd.Parameters.AddWithValue("@ID_MATRICULA", E_Estudiantes.Id_Matricula);

            cmd.ExecuteNonQuery();
            cnxn.Close();
        }




    }

}

