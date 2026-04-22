using System;

namespace contadorFacturas
{
    class Factura
    {

        // Atributos de la factura
        private static int contadorFactura = 0;
        private int numFactura;
        private string cliente;
        private double importe;
        private DateTime fecha;

        // Constructor
        public Factura(string nom, double imp)
        {
            this.nombre = nom;
            this.importe = imp;
            this.fecha = DateTime.Now;
            contadorFactura++;
            this.numFactura = contadorFactura;
        }

        public string VerDatosFactura()
        {
            string mensaje = $"Número factura: {numFactura}";
            mensaje += $"Nombre: {cliente} -- Importe: {importe}";
            mensaje += $"Fecha de factura: {fecha:d}";
            return mensaje;
        }

    }
}