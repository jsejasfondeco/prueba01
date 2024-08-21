using System;

namespace ProyectoInventarioADM
{
    [Serializable]
    public class Item
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CantidadMesAnterior { get; set; }
        public decimal CostoCompraUnitarioMesAnterior { get; set; }
        public decimal TotalBsCompraMesAnterior { get; set; }
        public int TotalConsumo { get; set; }
        public int CompraMes { get; set; }
        public decimal TotalBs { get; set; }
        public int TotalProductoInventario { get; set; }

        // Propiedad para el Promedio Ponderado con set privado
        public decimal PromedioPonderado { get; private set; }

        // Nueva propiedad para Cantidad Actual
        public int CantidadActual
        {
            get
            {
                return TotalProductoInventario - TotalConsumo;
            }
        }

        public Item(string nombre, int cantidad, decimal precio, DateTime fechaRegistro)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
            FechaRegistro = fechaRegistro;
            AsegurarValoresIniciales();
        }

        public void AsegurarValoresIniciales()
        {
            // Aquí se establecen los valores iniciales según el tipo de ítem
            if (Nombre == "CD's")
            {
                CantidadMesAnterior = 23;
                CostoCompraUnitarioMesAnterior = 1.40m;
                TotalBsCompraMesAnterior = 32.20m;
                TotalConsumo = 2;
                CompraMes = 50;
                Cantidad = CantidadMesAnterior + CompraMes - TotalConsumo;
            }
            else if (Nombre == "DVD's")
            {
                CantidadMesAnterior = 45;
                CostoCompraUnitarioMesAnterior = 1.40m;
                TotalBsCompraMesAnterior = 72m;
                Cantidad = CantidadMesAnterior + CompraMes - TotalConsumo;
            }
            else if (Nombre == "DVD's Doble Capa")
            {
                CantidadMesAnterior = 0;
                CostoCompraUnitarioMesAnterior = 8.80m;
                TotalBsCompraMesAnterior = 0m;
                Cantidad = CompraMes - TotalConsumo;
            }

            if (Cantidad < 0)
            {
                Cantidad = 0; // Prevenir cantidades negativas
            }

            TotalBs = Cantidad * Precio;
            TotalProductoInventario = CantidadMesAnterior + CompraMes;
        }

        // Método para actualizar el Promedio Ponderado
        public void ActualizarPromedioPonderado(decimal nuevoPromedio)
        {
            PromedioPonderado = nuevoPromedio;
        }
    }
}

