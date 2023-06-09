﻿using Core.Common.Model.Transaccion;
using Core.Creditos.Model.Entidad.SolicitudCreditos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.Creditos.Model.Transaccion.Transaccional.CambiarEstadoSolicitudCreditos
{
    /// <summary>
    /// Objeto transaccional cambio estado
    /// </summary>
    public class CambiarEstadoSolicitudCreditoTrx : TransaccionBase
    {
        /// <summary>
        /// PARAMETROS CAMBIO ESTADO
        /// </summary>
        public string UsuarioRed { get; set; }
        public string NumeroSolicitudCredito { get; set; }
        public string CredencialCodigoSolicitudCredito { get; set; }
        public int IdEstadoSolicitudCredito { get; set; }
        public string NombreEstadoSolicitud { get; set; } = "";
        public string CodigoEstadoSolicitudCredito { get; set; } = "";
        public DateTime FechaProcesoSolicitud { get; set; }

        /// <summary>
        /// PARAMETROS ORIGEN
        /// </summary>
        public int IdEstadoSolicitudCreditoOrigen { get; set; }
        public string NombreEstadoSolicitudCreditoOrigen { get; set; } = "";
        public string CodigoEstadoSolicitudCreditoOrigen { get; set; } = "";

        /// <summary>
        /// PARAMETROS DESTINO
        /// </summary>
        public int IdEstadoSolicitudCreditoDestino { get; set; }
        public string NombreEstadoSolicitudCreditoDestino { get; set; } = "";
        public string CodigoEstadoSolicitudCreditoDestino { get; set; } = "";
        public string ComentarioCambioEstado { get; set; } = "";
        public string MensajeCambioEstadoSolicitudCredito { get; set; } = "";

        /// <summary>
        /// RESULTADO API EXTERNA
        /// </summary>
        public Dictionary<string, string> ResultadoRespuestaApiExterna { get; set; }
    }
}
