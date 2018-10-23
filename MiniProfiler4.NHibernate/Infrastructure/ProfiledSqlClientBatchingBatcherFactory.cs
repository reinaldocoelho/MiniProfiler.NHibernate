using NHibernate;
using NHibernate.AdoNet;
using NHibernate.Engine;

namespace StackExchange.Profiling4.NHibernate.Infrastructure
{
    internal class ProfiledSqlClientBatchingBatcherFactory : SqlClientBatchingBatcherFactory
    {
        public override IBatcher CreateBatcher(ConnectionManager connectionManager, IInterceptor interceptor) 
            => new ProfiledSqlClientBatchingBatcher(connectionManager, interceptor);
    }
}