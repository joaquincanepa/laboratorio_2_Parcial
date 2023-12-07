using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanepaJoaquinParcial
{
    public static class Estilos
    {
        static float tamanioLetra;

        public static float TamanioLetra { get => tamanioLetra; set => tamanioLetra = value; }

        public static void ActualizarTamanioFuente(Form form)
        {
            CambiarTamanoFuente(tamanioLetra, form);
        }

        public static void CargarEstilosDeljson()
        {

            try
            {
                SerializadorJson<ConfigApp> json = new SerializadorJson<ConfigApp>("configuracionParcial.json");
                ConfigApp cfg = json.Deserializar();
                if (cfg is not null)
                {
                    tamanioLetra = cfg.Tamanio;
                }
                else
                {
                    tamanioLetra = 10f;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el archivo");
            }
        }


        public static void CambiarTamanoFuente(float tamano, Form form)
        {
            tamanioLetra = tamano;
            CambiarFuenteFormulario(form, tamano);
        }

        private static void CambiarFuenteFormulario(Control control, float tamano)
        {


            if (control is Label || control is GroupBox || control is RadioButton || control is Button
                || control is DataGridView || control is ToolStrip || control is MenuStrip || control is TextBox)
            {
                control.Font = new Font(control.Font.FontFamily, tamano, control.Font.Style);
            }
            foreach (Control childControl in control.Controls)
            {
                CambiarFuenteFormulario(childControl, tamano);
            }
        }

        public static void GuardarConfiguracion()
        {
            try
            {
                SerializadorJson<ConfigApp> json = new SerializadorJson<ConfigApp>("configuracionParcial.json");
                ConfigApp cfg = new ConfigApp(tamanioLetra);
                json.Serializar(cfg);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo crear el archivo");
            }

        }
    }
}

