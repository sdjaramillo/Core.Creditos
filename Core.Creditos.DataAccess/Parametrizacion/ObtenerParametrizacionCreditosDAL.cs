﻿using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Creditos.DataAccess.General;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Creditos.DataAccess.Parametrizacion
{
    public static class ObtenerParametrizacionCreditosDAL
    {
        public static ObtenerParametrizacionCreditosResult Execute(ParametrizacionCreditos codigoParametrizacion)
        {
            DBConnectionHelper coneccion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("LocalCon"));
            var dynamicParameters = new DynamicParameters();

            var codigo = codigoParametrizacion.ToString();
            dynamicParameters.Add(ConstantesPA.PA_CRE_OBTENER_PARAMETRIZACION.PARAM_CODIGO_PARAMETRIZACION, codigoParametrizacion.ToString(), System.Data.DbType.String);

            var resultado = coneccion.ObtenerListaDatos<ObtenerParametrizacionCreditosResult>(ConstantesPA.PA_CRE_OBTENER_PARAMETRIZACION.PA_NOMBRE, dynamicParameters);
            return resultado.First();
        }

        public class ObtenerParametrizacionCreditosResult
        {
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public string Valor { get; set; }
        }
    }
}