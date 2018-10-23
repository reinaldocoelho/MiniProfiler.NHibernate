using System;
using System.Data;
using System.Data.Common;
using NHibernate.AdoNet;
using NHibernate.Driver;
using StackExchange.Profiling;
using StackExchange.Profiling4.NHibernate.Infrastructure;

namespace StackExchange.Profiling4.NHibernate.Drivers
{
    public class MiniProfilerSql2008ClientDriver : Sql2008ClientDriver, IEmbeddedBatcherFactoryProvider
    {
        public override IDbCommand CreateCommand()
        {
            var command = base.CreateCommand();

            if (MiniProfiler.Current != null)
                command = new ProfiledSqlDbCommand((DbCommand)command, MiniProfiler.Current);

            return command;
        }

        Type IEmbeddedBatcherFactoryProvider.BatcherFactoryClass 
            => typeof(ProfiledSqlClientBatchingBatcherFactory);
    }
}