using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace McardsBanco._Infra
{
    public class MSSQLDB : IDB, IDisposable
    {
        private SqlConnection _Con;
        public MSSQLDB()
        {
        }

        public MSSQLDB(string StrCon)
        {
            _Con = new SqlConnection(StrCon);
        }

        public void Dispose()
        {
            _Con.Close();
            _Con.Dispose();
        }

        public IDbConnection getConnection()
        {
            return _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLEXPRESS"].ConnectionString);
        }
    }
}