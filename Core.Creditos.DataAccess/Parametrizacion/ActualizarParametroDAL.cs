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
    public class ActualizarParametroDAL
    {
        /// <summary>
        /// SP para actualizar parametrización general del sistema
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static int Execute(string codigo, string valor)
        {
            DBConnectionHelper coneccion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_CREDITOS"));
            var dynamicParameters = new DynamicParameters();

            dynamicParameters.Add("@Codigo", codigo, System.Data.DbType.String);
            dynamicParameters.Add("@Valor", valor, System.Data.DbType.String);
            
            dynamicParameters.Add(ConstantesPA.CodigoRetorno, System.Data.DbType.Int32, direction: System.Data.ParameterDirection.ReturnValue);

            int resultado = coneccion.Ejecutar<int>("PA_CRE_ACTUALIZAR_PARAMETRIZACION", dynamicParameters);
            return resultado;
        }
    }
}
