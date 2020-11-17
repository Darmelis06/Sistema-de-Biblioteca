using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Estudiantes
    {
        private static int id_Matricula;
        private static string nombre;
        private static string apellido;
        private static int telefono;
        private static string direccion;
        private static string tipo_Identificacion;
        private static string num_Identificacion;

        public static int Id_Matricula { get => id_Matricula; set => id_Matricula = value; }
        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Apellido { get => apellido; set => apellido = value; }
        public static int Telefono { get => telefono; set => telefono = value; }
        public static string Direccion { get => direccion; set => direccion = value; }
        public static string Tipo_Identificacion { get => tipo_Identificacion; set => tipo_Identificacion = value; }
        public static string Num_Identificacion { get => num_Identificacion; set => num_Identificacion = value; }
    }
}

