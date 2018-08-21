﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.FE;

namespace Sistema
{
    static class Program
    {
        public static int Permiso;
        public static int Usuario;
        public static int Contraseña;


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConexionBD.AbrirConeccion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ingreso());
            ConexionBD.cerrarConeccion();

        }
    }
}
