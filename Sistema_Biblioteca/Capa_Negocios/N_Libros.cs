﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;
using System.Data;

namespace Capa_Negocios
{
    public class N_Libros
    {
        D_Libros ObjDatos = new D_Libros();
        public void Guardando_N()
        {
            ObjDatos.D_Guardar();
        }

        public void Buscando_N()
        {
            ObjDatos.D_Buscar();
        }

        public void Mostrando_N()
        {
            ObjDatos.D_Listado();
        }

        public void Editando_N()
        {
            ObjDatos.D_Editar();
        }

        public void Borrando_N()
        {
            ObjDatos.D_Borrar();
        }



    }
}
