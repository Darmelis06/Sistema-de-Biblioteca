using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Prestamos
    {
        private static int id_P;
        private static int id_Matricula;
        private static String Id_Signatura;
        private static DateTime f_Prestamo;

        public static int Id_P { get => id_P; set => id_P = value; }
        public static int Id_Matricula { get => id_Matricula; set => id_Matricula = value; }
        public static string Id_Signatura1 { get => Id_Signatura; set => Id_Signatura = value; }
        public static DateTime F_Prestamo { get => f_Prestamo; set => f_Prestamo = value; }
    }
}
