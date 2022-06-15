namespace BookShop.Models.Entities
{
    public class Libro
    {
        private int _idLibro;
        public int idLibro { get { return _idLibro; } set { _idLibro = value; } }

        private string _nombre;
        public string nombre { get { return _nombre; } set { _nombre = value;} }

        private string _autor;
        public string autor { get { return _autor; } set { _autor = value; } }

        private int _cantPaginas;
        public int cantPaginas { get { return _cantPaginas; } set { _cantPaginas = value; } }

        private string _fechaLanzamiento;
        public string fechaLanzamiento { get { return _fechaLanzamiento; } set { _fechaLanzamiento = value; } }

        private string _genero;
        public string genero { get { return _genero; } set { _genero = value; } }
    }
}
