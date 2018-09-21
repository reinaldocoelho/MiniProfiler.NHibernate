using System.Data.Common;
using System.Data.SqlClient;
using StackExchange.Profiling.Data;

namespace StackExchange.Profiling.NHibernate.Infrastructure
{
    public class ProfiledSqlDbCommand : ProfiledDbCommand
    {
        public ProfiledSqlDbCommand(DbCommand command, IDbProfiler profiler) : base(command, null, profiler)
        {
            SqlCommand = (SqlCommand)command;
        }

        public SqlCommand SqlCommand { get; }
    }
}