using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ProyectoInventarioADM
{
    [Serializable]
    public class Inventario
    {
        private List<Item> items;
        private List<Transaccion> transacciones;

        public Inventario()
        {
            items = new List<Item>();
            transacciones = new List<Transaccion>();
            CargarInventario();
        }

        public void AgregarItem(Item item)
        {
            items.Add(item);
            GuardarInventario();
        }

        public void EliminarItem(string nombre)
        {
            Item item = items.Find(i => i.Nombre == nombre);
            if (item != null)
            {
                items.Remove(item);
                GuardarInventario();
            }
        }

        public Item ConsultarItem(string nombre)
        {
            Item item = items.Find(i => i.Nombre == nombre);
            if (item != null)
            {
                item.AsegurarValoresIniciales(); // Asegúrate de que los valores estén correctos
            }
            return item;
        }

        public List<Item> ObtenerItems()
        {
            return new List<Item>(items);
        }

        public List<Transaccion> ObtenerTransacciones()
        {
            return new List<Transaccion>(transacciones);
        }

        public void RegistrarConsumo(string nombreItem, int cantidad)
        {
            Item item = items.Find(i => i.Nombre == nombreItem);
            if (item != null)
            {
                item.Cantidad -= cantidad;
                if (item.Cantidad < 0) item.Cantidad = 0;
                RegistrarTransaccion(new Transaccion(nombreItem, cantidad, item.Precio, TipoTransaccion.Consumo, DateTime.Now));
                GuardarInventario();
            }
        }

        public void RegistrarTransaccion(Transaccion transaccion)
        {
            transacciones.Add(transaccion);
            Item item = items.Find(i => i.Nombre == transaccion.NombreItem);
            if (item != null)
            {
                if (transaccion.Tipo == TipoTransaccion.Compra)
                {
                    // Cálculo del nuevo promedio ponderado
                    if (item.Cantidad > 0)
                    {
                        decimal nuevoPromedio = ((item.Cantidad * item.Precio) + (transaccion.Cantidad * transaccion.PrecioUnitario)) / (item.Cantidad + transaccion.Cantidad);
                        item.ActualizarPromedioPonderado(nuevoPromedio);
                    }
                    else
                    {
                        item.ActualizarPromedioPonderado(transaccion.PrecioUnitario);
                    }

                    item.Cantidad += transaccion.Cantidad;
                    item.Precio = item.PromedioPonderado;
                    item.CompraMes += transaccion.Cantidad;

                    // Actualizar Total Producto Inventario
                    item.TotalProductoInventario = item.CantidadMesAnterior + item.CompraMes;
                }
                else if (transaccion.Tipo == TipoTransaccion.Consumo)
                {
                    item.TotalConsumo += transaccion.Cantidad;

                    // Prevenir cantidades negativas después de restar el consumo
                    if (item.Cantidad >= transaccion.Cantidad)
                    {
                        item.Cantidad -= transaccion.Cantidad;
                    }
                    else
                    {
                        item.Cantidad = 0;
                    }
                }

                // Actualizar Total Bs
                item.TotalBs = item.Cantidad * item.PromedioPonderado;

                // Actualizar Total Bs Compra Mes Anterior
                item.TotalBsCompraMesAnterior = item.CantidadMesAnterior * item.CostoCompraUnitarioMesAnterior;
            }

            GuardarInventario();
        }

        public void GuardarInventario()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            string itemsJson = JsonSerializer.Serialize(items, options);
            File.WriteAllText("inventario.json", itemsJson);

            string transaccionesJson = JsonSerializer.Serialize(transacciones, options);
            File.WriteAllText("transacciones.json", transaccionesJson);
        }

        private void CargarInventario()
        {
            if (File.Exists("inventario.json"))
            {
                string itemsJson = File.ReadAllText("inventario.json");
                items = JsonSerializer.Deserialize<List<Item>>(itemsJson);
            }

            if (File.Exists("transacciones.json"))
            {
                string transaccionesJson = File.ReadAllText("transacciones.json");
                transacciones = JsonSerializer.Deserialize<List<Transaccion>>(transaccionesJson);
            }
        }
    }
}
