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
    public class D_Prestamos
    {
        SqlConnection cnxn =
            new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public DataTable D_Listado()
        {
            SqlCommand cmd = new SqlCommand("SP_LISTAR_PRESTAMOS", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Buscar()
        {
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_PRESTAMO", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnxn.Open();
            cmd.Parameters.AddWithValue("@ID_P", E_Prestamos.Id_P);
            cmd.Parameters.AddWithValue("@ID_MATRICULA", E_Prestamos.Id_Matricula);
            cmd.Parameters.AddWithValue("@ID_SIGNATURA", E_Prestamos.Id_Signatura1);
            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cnxn.Close();
            return tabla;
        }

        public void D_Guardar()
        {
            SqlCommand cmd = new SqlCommand("SP_AGREGAR_PRESTAMO", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnxn.Open();
            cmd.Parameters.AddWithValue("@ID_P", E_Prestamos.Id_P);
            cmd.Parameters.AddWithValue("@ID_MATRICULA", E_Prestamos.Id_Matricula);
            cmd.Parameters.AddWithValue("@ID_SIGNATURA", E_Prestamos.Id_Signatura1);
            cmd.Parameters.AddWithValue("@F_PRESTAMO", E_Prestamos.F_Prestamo);

            cmd.ExecuteNonQuery();

            cnxn.Close();
        }

        public void D_Editar()
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_ESTUDIANTE", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnxn.Open();
            cmd.Parameters.AddWithValue("@ID_P", E_Prestamos.Id_P);
            cmd.Parameters.AddWithValue("@ID_MATRICULA", E_Prestamos.Id_Matricula);
            cmd.Parameters.AddWithValue("@ID_SIGNATURA", E_Prestamos.Id_Signatura1);
            cmd.Parameters.AddWithValue("@F_PRESTAMO", E_Prestamos.F_Prestamo);

            cmd.ExecuteNonQuery();

            cnxn.Close();
        }


        public void D_Borrar()
        {
            SqlCommand cmd = new SqlCommand("SP_BORRAR_PRESTAMO", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnxn.Open();

            cmd.Parameters.AddWithValue("@ID_P", E_Prestamos.Id_P);
            cmd.Parameters.AddWithValue("@ID_MATRICULA", E_Prestamos.Id_Matricula);

            cmd.ExecuteNonQuery();
            cnxn.Close();
        }




    }

}