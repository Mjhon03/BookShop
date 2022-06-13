namespace BookShop.Models.Entities
{
    public class Usuarios
    {
        private int _id;
        public int id { get { return _id; } set { _id = value; } }

        private string _nombres;
        public string nombres { get { return _nombres; } set { _nombres = value; } }

        private string _apellidos;
        public string apellidos { get { return _apellidos; } set { _apellidos = value; } }

        private int _documento;
        public int documento { get { return _documento; } set { _documento = value; } }

        private string _correo;
        public string correo { get { return _correo; } set { _correo = value; } }
        private string _contrasenna;
        public string contrasenna { get { return _contrasenna; } set { _contrasenna = value; } }

        private string _direccion;
        public string direccion { get { return _direccion; } set { _direccion = value; } }

        private string _fechaNacimiento;
        public string fechaNacimento { get { return _fechaNacimiento; }  set { _fechaNacimiento = value; } }

        private int _librosEncargados;
        public int librosEncargados { get { return _librosEncargados; } set{ _librosEncargados = value; } }
    }

}
