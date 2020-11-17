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
    public class D_Libros
    {
        SqlConnection cnxn =
            new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public DataTable D_Listado()
        {
            SqlCommand cmd = new SqlCommand("SP_LISTAR_LIBROS", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Buscar()
        {
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_LIBRO", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnxn.Open();
            cmd.Parameters.AddWithValue("@ID_SIGNATURA", E_Libros.Id_Signatura);
            cmd.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            cnxn.Close();
            return tabla;
        }

        public void D_Guardar()
        {
            SqlCommand cmd = new SqlCommand("SP_AGREGAR_LIBRO", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnxn.Open();
            cmd.Parameters.AddWithValue("@ID_SIGNATURA", E_Libros.Id_Signatura);
            cmd.Parameters.AddWithValue("@TITULO", E_Libros.Titulo);
            cmd.Parameters.AddWithValue("@SUBTITULO", E_Libros.Subtitulo);
            cmd.Parameters.AddWithValue("@AUTOR", E_Libros.Autor);
            cmd.Parameters.AddWithValue("@EDITORIAL", E_Libros.Editorial);
            cmd.Parameters.AddWithValue("@GENERO", E_Libros.Genero);
            cmd.Parameters.AddWithValue("@AÑO_PUBLICACION", E_Libros.Año_publicacion);

            cmd.ExecuteNonQuery();

            cnxn.Close();
        }

        public void D_Editar()
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_ESTUDIANTE", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnxn.Open();
            cmd.Parameters.AddWithValue("@ID_SIGNATURA", E_Libros.Id_Signatura);
            cmd.Parameters.AddWithValue("@TITULO", E_Libros.Titulo);
            cmd.Parameters.AddWithValue("@SUBTITULO", E_Libros.Subtitulo);
            cmd.Parameters.AddWithValue("@AUTOR", E_Libros.Autor);
            cmd.Parameters.AddWithValue("@EDITORIAL", E_Libros.Editorial);
            cmd.Parameters.AddWithValue("@GENERO", E_Libros.Genero);
            cmd.Parameters.AddWithValue("@AÑO_PUBLICACION", E_Libros.Año_publicacion);

            cmd.ExecuteNonQuery();

            cnxn.Close();
        }


        public void D_Borrar()
        {
            SqlCommand cmd = new SqlCommand("SP_BORRAR_LIBRO", cnxn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cnxn.Open();

            cmd.Parameters.AddWithValue("@ID_SIGNATURA", E_Libros.Id_Signatura);

            cmd.ExecuteNonQuery();
            cnxn.Close();
        }


    }

}
