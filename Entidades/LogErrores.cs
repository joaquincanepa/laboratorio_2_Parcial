using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class LogErrores
    {
        private static readonly string archivoLog = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Registro_errores.txt");

        public static void RegistrarError(string descripcion, string clase, string metodo)
        {
            string fechaHora = DateTime.Now.ToString();
            string mensaje = $"{fechaHora} - {descripcion} - Clase: {clase} - Método: {metodo}";

            using (StreamWriter writer = new StreamWriter(archivoLog, true))
            {
                writer.WriteLine(mensaje);
            }
        }
    }
}
