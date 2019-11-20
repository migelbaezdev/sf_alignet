using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente360.Integracion.Alignet.Entities
{
    public class base_transacciones
    {
        public string NEGOCIO { get; set; }
        public string CANAL { get; set; }
        public string NRO_OC { get; set; }
        public string RUT_CLIENTE { get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public string FECHA_COLOCACION { get; set; }
        public string TARJETA { get; set; }
        public string TIPO_TARJETA { get; set; }
        public string MONTOS { get; set; }
        public string PUNTOS { get; set; }
        public string FECHA_ENVIO_DESDE { get; set; }
        public string FECHA_ENVIO_HASTA { get; set; }
        public string DIRECCION_DESPACHO { get; set; }
        public string ESTADO { get; set; }
        public string NOVIOS { get; set; }
        public string NRO_F12 { get; set; }
        public string FECHA_PICKING { get; set; }
        public string MEDIO_PAGO { get; set; }
        public string METODO_ENVIO { get; set; }
        public string FUENTE_ABAST { get; set; }
        public string NRO_BOLETA_FACTURA { get; set; }
        public string REGION { get; set; }
        public string CIUDAD { get; set; }
        public string COMUNA { get; set; }
        public string NRO_OC_CHILECOMPRA { get; set; }
        public string CODIGO_AUTORIZACION { get; set; }
        public string FECHA_EXPIRACION_EFECTIVO { get; set; }
        public string CODIGO_CIP { get; set; }
        public string CODIGO_PAGO { get; set; }
        public string NRO_RESERVA { get; set; }
        public string RECAUDADOR { get; set; }
        public string LOCAL { get; set; }
        public string CAJA { get; set; }
        public string SECUENCIA { get; set; }
    }
}
