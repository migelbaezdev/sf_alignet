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
        private static string csAlignet;

        public IntegracionAlignetManager(string csalignet)
        {
            csAlignet = csalignet;
        }
        public void Start()
        {
            try
            {
                _logger.Info("Inicio del procesamiento API alignet...");
                var transacciones_alignet = ObtenerTransaccionesAlignet();
                _logger.Info("Fin del procesamiento API alignet...");
            }
            catch (Exception ex )
            {
                _logger.Error(ex);
            }
        }

        private List<base_transacciones> ObtenerTransaccionesAlignet()
        {
            _logger.Info("Inicio de la carga de transacciones alignet...");
            string sql = "dbo.getBaseAlignet @ESTADO_OPERACION = 3;";
            var transacciones = GetData(sql, CommandType.Text);
            _logger.Info(string.Format("Se obtuvieron {0} transacciones...", transacciones.Count));
            return transacciones;
        }

        public List<base_transacciones> GetData(string sqlText, CommandType commandType = CommandType.StoredProcedure)
        {
            var dbcon = new SqlConnection(csAlignet);
            using (var dSqlServer = new DataSqlServer<base_transacciones>(new Db(dbcon)))
            {
                var dt = dSqlServer.Get(sqlText, commandType);
                return dt.ToList();
            }
        }

    }
}
