MiniProfiler.NHibernate
=======================

NHibernate drivers supporting logging to MiniProfiler version 4.

Usage
-----

`Install-Package MiniProfiler4.NHibernate`

Configure FluentNHibernate to use the provided driver:

    Fluently.Configure().Database(
      MsSqlConfiguration.MsSql2008.ConnectionString(ConnectionString).Driver<MiniProfiler4.NHibernate.MiniProfilerSql2008ClientDriver>()
    );

Or with XML style configuration:

    cfg.SetProperty(Environment.ConnectionDriver, typeof(MiniProfiler4.NHibernate.MiniProfilerSql2008ClientDriver).AssemblyQualifiedName)
