using Entidades.SQL;

namespace Entidades
{
    public static class Sistema
    {
        static void Main()
        {

        }
        public static List<Usuario> ListaDeUsuarios = new List<Usuario>();
        public static Usuario usuarioConectado;
        public static Usuario UsuarioConectado { get => usuarioConectado; }
        public static ControlStock controlStock;
        public static List<Skate> ListaDeSkate = new List<Skate>();
        public static List<Roller>ListaDeRoller = new List<Roller>();
        public static List<SkateEnsamblado> listaDeSkateEnsamblados = new List<SkateEnsamblado>();
        public static List<RollerEmpaquetado> listaDeRollerEmpaquetados= new List<RollerEmpaquetado>();
        static Sistema()
        {
            CargarUsuarios();
            controlStock = ControlStock.GetInstance(); // Obtener la instancia existente
        }

        private static void CargarUsuarios()
        {
            List<Usuario> usuarios = Conexion.Leer();
            ListaDeUsuarios.AddRange(usuarios);
            ListaDeUsuarios.Add(new Supervisor("supervisor", "Canepa", new DateTime(1999, 12, 04), "42175984", "@supervisor", "a", 1));
            ListaDeUsuarios.Add(new Operario("Joaquin","Gonzalez", DateTime.Now,"42175974","@operario","a",1 ));
            //ListaDeSkate.Add(new Skate(2,8,1,2));
        }
        /// <summary>
        /// Valida si un usuario y contraseña son válidos en la lista de usuarios del sistema.
        /// </summary>
        /// <param name="nombreusuario">Nombre de usuario</param>
        /// <param name="password">Contraseña</param>
        /// <param name="usuarioValido">Usuario validado, en caso de ser válido</param>
        /// <returns>True si el usuario y contraseña son válidos, False en caso contrario</returns>
        public static bool ValidarUsuario(string nombreusuario, string password)
        {

            foreach (Usuario usuario in ListaDeUsuarios)
            {
                if (usuario.ValidarUsuario(nombreusuario, password))
                {
                    usuarioConectado = usuario;
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Crea un nuevo usuario supervisor con los datos proporcionados y realiza varias validaciones.
        /// </summary>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="apellido">El apellido del usuario.</param>
        /// <param name="fechaNacimiento">La fecha de nacimiento del usuario.</param>
        /// <param name="dni">El número de DNI del usuario.</param>
        /// <param name="email">La dirección de correo electrónico del usuario.</param>
        /// <param name="password">La contraseña del usuario.</param>
        /// <returns>
        /// Devuelve un mensaje de error si alguna de las validaciones no se cumple, de lo contrario, retorna null.
        /// - "Por favor, complete todos los campos." si algunos de los campos requeridos están vacíos o contienen solo espacios en blanco.
        /// - "El DNI debe ser numérico y tener 8 dígitos." si el DNI no es válido.
        /// - "El email debe contener un símbolo '@'." si el correo electrónico no es válido.
        /// - "El DNI o el email ya están registrados para otro usuario." si el DNI o el correo electrónico ya existen en la base de datos.
        /// - "La fecha de nacimiento debe ser mayor o igual a 17 años." si el usuario es menor de 17 años.
        /// </returns>
        public static string CrearUsuarioSupervisor(string nombre, string apellido, DateTime fechaNacimiento, string dni, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                return "Por favor, complete todos los campos.";
            }

            if (!ValidarDNI(dni))
            {
                return "El DNI debe ser numérico y tener 8 dígitos.";
            }

            if (!ValidarEmail(email))
            {
                return "El email debe contener un símbolo '@'.";
            }
            bool dniEmailValidos = ValidarDniEmailRepetidos(dni, email);
            if (!dniEmailValidos)
            {
                return "El DNI o el email ya están registrados para otro usuario.";
            }

            DateTime fechaMinima = DateTime.Today.AddYears(-17);

            if (fechaNacimiento > fechaMinima)
            {
                return "La fecha de nacimiento debe ser mayor o igual a 17 años.";
            }
            return null;
        }

        /// <summary>
        /// Valida si un número de DNI o una dirección de correo electrónico ya están registrados en la lista de usuarios existente.
        /// </summary>
        /// <param name="dni">El número de DNI a validar.</param>
        /// <param name="email">La dirección de correo electrónico a validar.</param>
        /// <returns>
        /// Devuelve "true" si ni el DNI ni el correo electrónico están registrados en la lista de usuarios.
        /// Devuelve "false" si el DNI o el correo electrónico ya existen en la lista de usuarios.
        /// </returns>
        public static bool ValidarDniEmailRepetidos(string dni, string email)
        {
            foreach (Usuario usuario in ListaDeUsuarios)
            {
                if (usuario.Dni == dni)
                {
                    return false;
                }

                if (usuario.Email == email)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Valida si un número de DNI es un valor numérico de 8 dígitos.
        /// </summary>
        /// <param name="dni">El número de DNI a validar.</param>
        /// <returns>
        /// Devuelve "true" si el DNI es un valor numérico de 8 dígitos, o "false" en caso contrario.
        /// </returns>
        public static bool ValidarDNI(string dni)
        {
            int dniNumerico;
            return int.TryParse(dni, out dniNumerico) && dni.Length == 8;
        }

        /// <summary>
        /// Valida si una dirección de correo electrónico contiene el símbolo "@".
        /// </summary>
        /// <param name="email">La dirección de correo electrónico a validar.</param>
        /// <returns>
        /// Devuelve "true" si la dirección de correo electrónico contiene el símbolo "@", o "false" en caso contrario.
        /// </returns>
        public static bool ValidarEmail(string email)
        {
            return email.Contains("@");
        }
        /// <summary>
        /// Genera un número de serie único utilizando el tipo GUID.
        /// </summary>
        /// <returns>
        /// Devuelve un número de serie único generado a partir de un GUID.
        /// </returns>
        public static string GenerarNumeroSerie()
        {
            Guid random= Guid.NewGuid();
            return random.ToString();
        }

        /// <summary>
        /// Genera un número de modelo de serie aleatorio.
        /// </summary>
        /// <returns>
        /// Devuelve un número de modelo de serie aleatorio generado dentro de un rango específico.
        /// </returns>
        public static string GenerarModeloSerie()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(10, 9999999);
            return numeroAleatorio.ToString();
        }

        /// <summary>
        /// Crea un nuevo skate a partir de los materiales disponibles en el control de stock.
        /// Si hay suficientes materiales en stock, se descuentan las cantidades necesarias y se crea el skate.
        /// </summary>
        /// <returns>
        /// Devuelve "true" si se creó el skate con éxito y se descontaron los materiales del stock.
        /// Devuelve "false" si no había suficientes materiales en stock para crear el skate.
        /// </returns>
        public static bool CrearSkate()
        {
            if (controlStock.DescontarMaterial("Ruedas", 4) && controlStock.DescontarMaterial("Trucks", 2) &&
                controlStock.DescontarMaterial("Tornillos", 8) && controlStock.DescontarMaterial("Madera", 1))
            {
                Skate nuevoSkate = new Skate(4, 8, 1, 2);
                ListaDeSkate.Add(nuevoSkate);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Ensambla un skate a partir de la lista de skates disponibles y crea un registro de skate ensamblado.
        /// Si hay al menos un skate en la lista de skates disponibles, se toma el primero de la lista, 
        /// se ensambla y se crea un registro con un número de serie y modelo aleatorios.
        /// </summary>
        /// <returns>
        /// Devuelve "true" si se ensambló con éxito un skate y se creó el registro de skate ensamblado.
        /// Devuelve "false" si la lista de skates disponibles está vacía.
        /// </returns>
        public static bool EnsamblarSkate()
        {
            if (Sistema.ListaDeSkate.Count > 0)
            {
                Skate skateConstruido = Sistema.ListaDeSkate[0];// Tomo el primer skate de la lista de ListaDeSkate
                SkateEnsamblado skateEnsamblado = new SkateEnsamblado(DateTime.Now, Sistema.GenerarNumeroSerie(), "Modelo" + Sistema.GenerarModeloSerie());//Creouna instancia de SkateEnsamblado
                listaDeSkateEnsamblados.Add(skateEnsamblado);
                Sistema.ListaDeSkate.Remove(skateConstruido);
                return true;             
            }
            return false;
        }

        /// <summary>
        /// Empaqueta rollers de un tipo específico y los agrega al inventario de rollers empaquetados.
        /// </summary>
        /// <param name="tipo">El tipo de rollers que se desea empaquetar.</param>
        /// <returns>True si se empaquetaron rollers del tipo especificado, de lo contrario, False.</returns>
        public static bool EmpaquetarRoller(string tipo)
        {
            bool retorno = false;
            if (Sistema.ListaDeRoller.Count > 0)
            {
                for (int i = 0; i < ListaDeRoller.Count(); i++)
                {
                    if (ListaDeRoller[i].Tipo.ToString() == tipo)
                    {
                        RollerEmpaquetado rollerEmpaquetado = new RollerEmpaquetado(DateTime.Now, Sistema.GenerarNumeroSerie(),/*Sistema.GenerarModeloSerie() */ tipo, UsuarioConectado.Apellido);
                        Sistema.listaDeRollerEmpaquetados.Add(rollerEmpaquetado);
                        Sistema.ListaDeRoller.Remove(ListaDeRoller[i]);
                        i = i - 1;
                        retorno = true;
                    }
                }
            }
            return retorno;

        }

        /// <summary>
        /// Crea una cantidad específica de rollers del tipo especificado, descontando los materiales necesarios del control de stock.
        /// </summary>
        /// <param name="tipo">El tipo de roller a crear.</param>
        /// <param name="cantidad">La cantidad de rollers a crear.</param>
        /// <returns>
        /// Devuelve "true" si se crearon los rollers del tipo especificado con éxito y se descontaron los materiales necesarios del stock.
        /// Devuelve "false" si no había suficientes materiales en stock o el tipo de roller no es válido.
        /// </returns>
        public static bool CrearRollers(Roller.TipoDeRoller tipo, int cantidad)
        {
            switch (tipo)
            {
                case Roller.TipoDeRoller.PatinArtistico:
                    if (controlStock.DescontarMaterial("BotaDeCuero", 2 * cantidad) &&
                        controlStock.DescontarMaterial("Aluminio", 4 * cantidad) &&
                        controlStock.DescontarMaterial("TacoDelantero", 2 * cantidad) &&
                        controlStock.DescontarMaterial("Cordones", 2 * cantidad))
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            string numeroSerie = GenerarNumeroSerie(); // Genera un número de serie
                            Roller nuevoRoller = new Roller(tipo, numeroSerie);
                            ListaDeRoller.Add(nuevoRoller); // Agrega el Roller a la lista
                        }
                        return true;
                    }
                    break;
                case Roller.TipoDeRoller.PatinFreeStyle:
                    if (controlStock.DescontarMaterial("BotasDePlastico", 2 * cantidad) &&
                        controlStock.DescontarMaterial("FibraDeCarbono", 2 * cantidad) &&
                        controlStock.DescontarMaterial("Cierre", 2 * cantidad) &&
                        controlStock.DescontarMaterial("Cordones", 2 * cantidad) &&
                        controlStock.DescontarMaterial("Aluminio", 2 * cantidad))
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            string numeroSerie = GenerarNumeroSerie(); // Genera un número de serie
                            Roller nuevoRoller = new Roller(tipo, numeroSerie);
                            ListaDeRoller.Add(nuevoRoller);
                        }
                        return true;
                    }
                    break;
                case Roller.TipoDeRoller.PatinSobreHielo:
                    if (controlStock.DescontarMaterial("Cuchilla", 2 * cantidad) &&
                        controlStock.DescontarMaterial("BotaDeCuero", 2 * cantidad) &&
                        controlStock.DescontarMaterial("Cierre", 2 * cantidad) &&
                        controlStock.DescontarMaterial("Cordones", 2 * cantidad) &&
                        controlStock.DescontarMaterial("FibraDeCarbono", 2 * cantidad)) 
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            string numeroSerie = GenerarNumeroSerie();
                            Roller nuevoRoller = new Roller(tipo, numeroSerie);
                            ListaDeRoller.Add(nuevoRoller);
                        }
                        return true;
                    }
                     break;
            }
            return false;
        }
        /// <summary>
        /// Agrega una cantidad específica de un material al control de stock.
        /// </summary>
        /// <param name="material">El nombre del material a agregar.</param>
        /// <param name="cantidad">La cantidad de material a agregar al stock.</param>
        public static void AgregarMaterial(string material, int cantidad)
        {
            controlStock.AgregarMaterial(material, cantidad);
        }

        /// <summary>
        /// Obtiene la cantidad actual de un material específico en el control de stock.
        /// </summary>
        /// <param name="material">El nombre del material del cual se desea obtener la cantidad.</param>
        /// <returns>
        /// Devuelve la cantidad actual del material en el control de stock.
        /// Si el material no está presente en el stock, retorna 0.
        /// </returns>
        public static int ObtenerCantidadMaterial(string material)
        {
            if (controlStock.StockMateriaPrima.ContainsKey(material))
            {
                return controlStock.StockMateriaPrima[material];
            }
            return 0;
        }
    }
}