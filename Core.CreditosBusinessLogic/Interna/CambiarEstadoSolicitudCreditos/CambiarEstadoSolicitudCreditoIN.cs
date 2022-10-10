﻿using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Creditos.Model.Transaccion.Response.CambiarEstadoSolicitudCreditos;
using Core.Creditos.Model.Transaccion.Transaccional.CambiarEstadoSolicitudCreditos;
using Core.CreditosBusinessLogic.Ejecucion.EstadoSolicitudCreditos;
using Core.CreditosBusinessLogic.Ejecucion.SolicitudCreditos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CreditosBusinessLogic.Interna.CambiarEstadoSolicitudCreditos
{
    public class CambiarEstadoSolicitudCreditoIN : IActualizar<CambiarEstadoSolicitudCreditoTrx, CambiarEstadoSolicitudCreditoResponse>
    {


        public void AgregarInformacion(CambiarEstadoSolicitudCreditoTrx objetoTransaccional)
        {
            //ObtenerDatosGeneralesSolicitudCredito
            ObtenerSolicitudCreditoBLL.ObtenerSolicitudCreditoPorNumeroSolicitud(objetoTransaccional); ;
        }

        public void HomologarInformacion(CambiarEstadoSolicitudCreditoTrx objetoTransaccional)
        {

        }

        public void ValidarInformacion(CambiarEstadoSolicitudCreditoTrx objetoTransaccional)
        {
            //Valida policitcas de estados
            CambiarEstadoSolicitudCreditoValidarInformacionBLL.ValidarCambioDeEstado(objetoTransaccional);
        }

        public void ActualizarInformacion(CambiarEstadoSolicitudCreditoTrx objetoTransaccional)
        {

        }
    }
}
