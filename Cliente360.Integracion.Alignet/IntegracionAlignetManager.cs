using BO.Integracion.Siebel;
using Cliente360.Integracion.Alignet.Entities;
using Release.Helper.Data.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente360.Integracion.Alignet
{
    public class IntegracionAlignetManager
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Start()
        {
            var transacciones_alignet = ObtenerTransaccionesAlignet();
        }

        private List<base_transacciones> ObtenerTransaccionesAlignet()
        {
            _logger.Info("Inicio de la carga de solicitudes de anulaciones...");
            //TODO Pendiente Agregar Parametro opcional al stored de getBaseAnulacion
            // string sql = "dbo.getBaseAnulacionPruebaSiebel @ESTADO_OPERACION = 3;";
            //TODO: Pase a Prod getBaseAnulacion to getBaseAnulacion_Test
            string sql = "dbo.getBaseAnulacion_Test @ESTADO_OPERACION = 3;";
            var dt_data = GetData(sql, CommandType.Text);
            _logger.Info(string.Format("Se obtuvieron {0} anulaciones...", dt_data.Count));
            return dt_data;
        }

        public List<base_transacciones> GetData(string sqlText, CommandType commandType = CommandType.StoredProcedure)
        {
            var dbcon = new SqlConnection();
            using (var dSqlServer = new DataSqlServer<base_transacciones>(new Db(dbcon)))
            {
                var dt = dSqlServer.Get(sqlText, commandType);
                return dt.ToList();
            }
        }

    }
}
