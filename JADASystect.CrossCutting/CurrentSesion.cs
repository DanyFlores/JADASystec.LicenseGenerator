using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JADASystect.CrossCutting
{
    public static class CurrentSesion
    {
        public static Guid IdCuentaUsuario { get; set; }
        public static int IdRol { get; set; }
        public static Guid IdEmpleado { get; set; }
        public static string Nombres { get; set; }
        public static int IdTurnoEmpleado { get; set; }
        public static int IdSucursal { get; set; }
        public static string NombreSucursal { get; set; }
        public static string Direccion { get; set; }
        public static string Telefono { get; set; }
        public static string RFC { get; set; }
        public static DateTime FechaSystem { get; set; } = DateTime.Now;
        public static bool ActFechaSystem { get; set; } = false;
        //Permisos de usuario
        public static string[] ReglasUsuario { get; set; }
        public static bool PermisoUsuario(string ValidarReglas)
        {
            string[] ReglaVerificar = ValidarReglas.Split(',');
            foreach (var item in ReglaVerificar)
            {
                if (item != "" && ReglasUsuario.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
