using System;

namespace ProyectoInventarioADM
{
    [Serializable]
    public class Transaccion
    {
        public string NombreItem { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public TipoTransaccion Tipo { get; set; }
        public DateTime Fecha { get; set; }

        public Transaccion(string nombreItem, int cantidad, decimal precioUnitario, TipoTransaccion tipo, DateTime fecha)
        {
            NombreItem = nombreItem;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Tipo = tipo;
            Fecha = fecha;
        }
    }

    public enum TipoTransaccion
    {
        Compra,
        Consumo
    }
}
