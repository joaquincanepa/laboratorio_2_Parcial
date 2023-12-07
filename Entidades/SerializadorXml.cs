using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
//using System.Windows.Forms;


namespace Entidades
{   
    public class SerializadorXml<T> : ISerializador<T> where T : class, new()
    {
        private StreamWriter writer;
        private StreamReader reader;
        public XmlSerializer serializer;

        private string path;

        /// <summary>
        ///  genera el directorio para guardar el archivo
        /// </summary>
        /// <param name="archivo"></param>
        public SerializadorXml(string archivo)
        {
            this.path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);//de esta manera lo envio al escritorio
            this.serializer = new XmlSerializer(typeof(T));
        }

        /// <summary>
        ///  deserializa objeto q contega
        /// </summary>
        /// <returns></returns>
        public T Deserializar()
        {
            T aux = new T();
            try
            {
                using (this.reader = new StreamReader(this.path))
                {
                    this.serializer = new XmlSerializer(typeof(T));

                    aux = (T)this.serializer.Deserialize(this.reader);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return aux;
        }
        /// <summary>
        ///  serializa cualquier objeto que reciba
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Serializar(T item)
        {
            bool retorno = false;
            try
            {
                using (StringWriter stringWriter = new StringWriter())
                {
                    this.serializer.Serialize(stringWriter, item);
                    string xmlString = stringWriter.ToString();
                    File.WriteAllText(this.path, xmlString);
                }
                retorno = true;
            }
            catch (InvalidOperationException ex)
            {
                retorno = false;
            }
            catch (Exception ex)
            {
                retorno = false;
            }
            return retorno;

        }

    }
}
