using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Libros
    {
        private static string id_Signatura;
        private static string titulo;
        private static string subtitulo;
        private static string autor;
        private static string editorial;
        private static string genero;
        private static int año_publicacion;

        public static string Id_Signatura { get => id_Signatura; set => id_Signatura = value; }
        public static string Titulo { get => titulo; set => titulo = value; }
        public static string Subtitulo { get => subtitulo; set => subtitulo = value; }
        public static string Autor { get => autor; set => autor = value; }
        public static string Editorial { get => editorial; set => editorial = value; }
        public static string Genero { get => genero; set => genero = value; }
        public static int Año_publicacion { get => año_publicacion; set => año_publicacion = value; }
    }
}
