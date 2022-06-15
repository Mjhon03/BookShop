namespace BookShop.Models.Entities
{
    public class Prestamo
    {
        private int _id;
        public int id { get { return _id; } set { _id = value; } }

        private int _idLibro;
        public int idLibro { get { return _idLibro; } set { _idLibro = value; } }

        private int _idCliente;
        public int idCliente { get { return _idCliente; } set { _idCliente = value; } }

        private string _fechaPrestamo;
        public string fechaPrestamo { get { return _fechaPrestamo; } set { _fechaPrestamo = value; } }

        private string _fechaDevolucion;
        public string fechaDevolucion { get { return _fechaDevolucion; }  set { _fechaDevolucion = value; } }

    }
}
