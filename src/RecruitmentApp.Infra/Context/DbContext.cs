using Microsoft.Extensions.Options;
using RecruitmentApp.Application.Settings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace RecruitmentApp.Infra.Context
{
    public sealed class DbContext : IDisposable
    {
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }

        public DatabaseSettings _databaseSettings;

        public DbContext(IOptions<DatabaseSettings> databaseSettings)
        {
            _databaseSettings = databaseSettings.Value;
            Connection = new SqlConnection(_databaseSettings.RecruitmentAppDB);
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    }
}
