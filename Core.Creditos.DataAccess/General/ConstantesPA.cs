﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Creditos.DataAccess.General
{
    public static class ConstantesPA
    {
        public const string CodigoRetorno = "@CodigoRetorno";

        /// <summary>
        /// Procedimiento almacenado para insertar una solicitud de crédito
        /// </summary>
        public static class PA_CRE_INSERTAR_SOLICITUD_CREDITO
        {
            public const string PA_NOMBRE = "PA_CRE_INSERTAR_SOLICITUD_CREDITO";
            public const string PA_FECHA_NEGOCIACION = $"@FechaNegociacion";
            public const string PA_CODIGO_CONCESIONARIO = "@CodigoConcesionario";
            public const string PARAM_CEDULA_VENDEDOR = "@CedulaVendedor";
            public const string PARAM_CODIGO_PRODUCTO = "@CodigoProducto";
            public const string PARAM_VEHICULO_CODIGO_MARCA = "@CodigoMarca";
            public const string PARAM_VEHICULO_CODIGO_MODELOS = "@CodigoModelo";
            public const string PARAM_VEHICULO_CODIGO_TIPO_USO = "@CodigoTipoUso";
            public const string PARAM_VEHICULO_PRECIO_IVA = "@PrecioIva";
            public const string PARAM_DISPOSITIVO_RASTREO_CODIGO = "@CodigoDispositivoRastreo";
            public const string PARAM_DISPOSITIVO_RASTREO_PRECIO = "@DispositivoRastreoPrecio";
            public const string PARAM_CLIENTE_TIPO_IDENTIFICACION = "@ClienteTipoIdentificacion";
            public const string PARAM_CLIENTE_IDENTIFICACION = "@ClienteIdentificacion";
            public const string PARAM_CLIENTE_INSTITUCION_FINANCIERA = "@ClienteInstitucionFinanciera";
            public const string PARAM_CLIENTE_PRIMER_NOMBRE = "@ClientePrimerNombre";
            public const string PARAM_CLIENTE_SEGUNDO_NOMBRE = "@ClienteSegundoNombre";
            public const string PARAM_CLIENTE_APELLIDO_PATERNO = "@ClienteApellidoPaterno";
            public const string PARAM_CLIENTE_APELLIDO_MATERNO = "@ClienteApellidoMaterno";
            public const string PARAM_CLIENTE_NACIONALIDAD = "@ClienteNacionalidad";
            public const string PARAM_CLIENTE_CODIGO_TIPO_VIVIENDA = "@CodigoTipoVivienda";
            public const string PARAM_CLIENTE_CODIGO_ESTADO_CIVIL = "@ClienteCodigoEstadoCivil";
            public const string PARAM_CLIENTE_CODIGO_NIVEL_EDUCACION = "@ClienteCodigoNivelEducacion";
            public const string PARAM_CLIENTE_FECHA_NACIMENTO = "@ClienteFechaNacimiento";
            public const string PARAM_CLIENTE_SEXO = "@ClienteSexo";
            public const string PARAM_CLIENTE_NUMERO_CARGAS = "@ClienteNumeroCargas";
            public const string PARAM_CLIENTE_CODIGO_PROVINCIA = "@ClienteCodigoProvincia";
            public const string PARAM_CLIENTE_CODIGO_CIUDAD = "@ClienteCodigoCiudad";
            public const string PARAM_CLIENTE_DIRECCION = "@ClienteDireccion";
            public const string PARAM_CLIENTE_REFERENCIA_FAMILIAR_NOMBRE = "@ClienteReferenciaFamiliarNombre";
            public const string PARAM_CLIENTE_REFERENCIA_FAMILIAR_TELEFONO = "@ClienteReferenciaFamiliarTelefono";
            public const string PARAM_CLIENTE_EMAIL = "@ClienteEmail";
            public const string PARAM_CLIENTE_CODIGO_OCUPACION = "@ClienteCodigoOcupacion";
            public const string PARAM_CLIENTE_LUGAR_TRABAJO = "@ClienteLugarTrabajo";
            public const string PARAM_CLIENTE_LUGAR_TRABAJO_TELEFONO = "@ClienteLugarTrabajoTelefono";
            public const string PARAM_CLIENTE_LUGAR_TRABAJO_DIRECCION = "@ClienteLugarTrabajoDireccion";
            public const string PARAM_CLIENTE_CODIGO_CALISIFICACION_CARGO = "@ClienteCodigoClasificacionCargo";
            public const string PARAM_CLIENTE_ANTIGUEDAD_ECONOMICA = "@ClienteAntiguedadEconomica";
            public const string PARAM_CLIENTE_TIPO_PERSONA = "@ClienteTipoPersona";
            public const string PARAM_CLIENTE_TRABAJA_SECTOR = "@ClienteTrabajaSector";
            public const string PARAM_CLIENTE_PATRIMONIO = "@ClientePatrimonio";
            public const string PARAM_CLIENTE_DOMICILIO_TELEFONO = "@ClienteDomicilioTelefono";
            public const string PARAM_CLIENTE_CELULAR = "@ClienteCelular";
            public const string PARAM_CLIENTE_CONYUGE_IDENTIFICACION = "@ConyugeIdentificacion";
            public const string PARAM_CLIENTE_CONYUGE_PRIMER_NOMBRE = "@ConyugePrimerNombre";
            public const string PARAM_CLIENTE_CONYUGE_SEGUNDO_NOMBRE = "@ConyugeSegundoNombre";
            public const string PARAM_CLIENTE_CONYUGE_APELLIDO_PATERNO = "@ConyugeApellidoPaterno";
            public const string PARAM_CLIENTE_CONYUGE_APELLIDO_MATERNO = "@ConyugeApellidoMaterno";
            public const string PARAM_CLIENTE_CONYUGE_NACIONALIDAD = "@ConyugeNacionalidad";
            public const string PARAM_CLIENTE_CONYUGE_SEXO = "@ConyugeSexo";
            public const string PARAM_CLIENTE_CONYUGE_EMAIL = "@ConyugeEmail";
            public const string PARAM_CLIENTE_CONYUGE_FECHA_NACIMIENTO = "@ConyugeEmail";
            public const string PARAM_CLIENTE_CONYUGE_PROFESION = "@ConyugeProfesion";
            public const string PARAM_CLIENTE_CONYUGE_ANTIGUEDAD_ECONOMICA = "@ConyugeAntiguedadEconomica";
            public const string PARAM_CLIENTE_CONYUGE_CARGO = "@ConyugeCargo";
            public const string PARAM_CLIENTE_CONYUGE_TELEFONO = "@ConyugeTelefono";
            public const string PARAM_CREDITO_TASA = "@CreditoTasa";
            public const string PARAM_CREDITO_PLAZO_MESES = "@CreditoPlazoMeses";
            public const string PARAM_CREDITO_MONTO = "@CreditoMonto";
            public const string PARAM_CREDITO_VALOR_ENTRADA = "@CreditoValorEntrada";
            public const string PARAM_CREDITO_DIA_PAGO = "@CreditoDiaPago";
            public const string PARAM_CREDITO_TIENE_GARANTE = "@CreditoTieneGarante";
            public const string PARAM_CREDITO_GARATE_IDENTIFICACION = "@CreditoGaranteIDentifcacion";
            public const string PARAM_CREDITO_CONSUMO_TARJETA = "@CreditoConsumoTarjeta";
            public const string PARAM_CREDITO_SALGO_PROMEDIO_CUENTAS = "@CreditoSaldoPromedioCuentas";
            public const string PARAM_CREDITO_INGRESOS_DEUDOR = "@CreditoIngresosDeudor";
            public const string PARAM_CREDITO_INGRESOS_CONYUGE = "@CreditoIngresosConyuge";
            public const string PARAM_CREDITO_OTROS_INGRESOS_DEUDOR = "@CreditoOtrosIngresosDeudor";
            public const string PARAM_CREDITO_OTROS_INGRESOS_CONYUGE = "@CreditoOtrosIngresosConyuge";
            public const string PARAM_CREDITO_EGRESOS_DEUDOR = "@CreditoEgresosDeudor";
            public const string PARAM_CREDITO_EGRESOS_CONYUGE = "@CreditoEgresosConyuge";
            public const string PARAM_CREDITO_OTROS_EGRESOS_DEUDOR = "@CreditoOtrosEgresosDeudor";
            public const string PARAM_CREDITO_OTROS_EGRESOS_CONYUGE = "@CreditoOtrosEgresosConyuge";
            public const string PARAM_CREDITO_FUENTE_INGRESOS = "@CreditoFuenteIngresos";
            public const string PARAM_ASEGURADORA_CODIGO = "@AseguradoraCodigo";
            public const string PARAM_CREDITO_JSON = "@CreditoJSON";
            public const string PARAM_CREDITO_ESTADO_SOLICITUD = @"EstadoSolicitud";
        }

        /// <summary>
        /// Procedimiento almacenado para homologar un código externo
        /// </summary>
        public static class PA_CRE_HOMOLOGAR_CODIGO_EXTERNO
        {
            public const string PA_NOMBRE = "PA_CRE_HOMOLOGAR_CODIGO_EXTERNO";
            public const string PARAM_CODIGO_EXTERNO = "@CodigoExterno";
            public const string PARAM_CODIGO_TABLA = "@CodigoTabla";
        }

        /// <summary>
        /// Procedimiento almacenado para obtener parametrización del sistema
        /// </summary>
        public static class PA_CRE_OBTENER_PARAMETRIZACION
        {
            public const string PA_NOMBRE = "PA_CRE_OBTENER_PARAMETRIZACION";
            public const string PARAM_CODIGO_PARAMETRIZACION = "@CodigoParametrizacion";
            public const string PARAM_CODIGO_CREDENCIAL = "@CodigoCredencial";
        }

        /// <summary>
        /// Procedimiento almacenado para validar politica de edad
        /// </summary>
        public static class PA_CRE_POLITICA_VALIDAD_EDAD
        {
            public const string PA_NOMBRE = "PA_CRE_POLITICA_VALIDAR_EDAD";
            public const string PARAM_CODIGO_EDAD_MINIMA = "@EdadMinima";
            public const string PARAM_CODIGO_EDAD_MAXIMA = "@EdadMaxima";
            public const string PARAM_EDAD_DEUDOR = "@EdadDeudor";
        }

        /// <summary>
        /// Procedimiento almacenado para validar politica de edad
        /// </summary>
        public static class PA_CRE_POLITICA_VALIDAR_INGRESOS
        {
            public const string PA_NOMBRE = "PA_CRE_POLITICA_VALIDAR_INGRESOS";
            public const string PARAM_INGRESOS_DEUDOR = "@IngresosDeudor";
            public const string PARAM_OTROS_INGRESOS_DEUDOR = "@OtrosIngresosDeudor";
            public const string PARAM_INGRESOS_CONYUGE = "@IngresosConyuge";
            public const string PARAM_OTROS_INGRESOS_CONYUGE = "@OtrosIngresosConyuge";
            public const string PARAM_CODIGO_POLITICA_INGRESOS = "CodigoPoliticaIngresos";
        }

        /// <summary>
        /// Procedimiento almacenado para obtner las reglas de cada campo del request
        /// </summary>
        public static class PA_CRE_OBTENER_REGLAS_CAMPOS_REQUEST
        {
            public const string PA_NOMBRE = "PA_CRE_OBTENER_REGLAS_CAMPOS_REQUEST";
            public const string PARMA_CODIGO_ENTIDAD = "@CodigoEntidad";
        }

        public static class PA_CRE_OBTENER_REGLAS_SOLICITUD_CREDITO
        {
            public const string PA_NOMBRE = "PA_CRE_OBTENER_REGLAS_SOLICITUD_CREDITO";
            public const string PARAM_CODIGO_ENTIDAD = "@CodigoEntidad";
        }

        public static class PA_CRE_OBTENER_ESTADO_SOLICITUD_CREDITO
        {
            public const string PA_NOMBRE = "PA_CRE_OBTENER_ESTADO_SOLICITUD_CREDITO";
            public const string PARAM_ID_ESTADO = "@IdEstado";
            public const string PARAM_CODIGO_ESTADO = "@CodigoEstado";
            public const string PARAM_NOMBRE_ESTADO = "@NombreEstado";

        }
    }
}

