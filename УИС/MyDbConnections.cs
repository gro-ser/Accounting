using System;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;

abstract class MyDbConnection
{
    DbConnection connection;
    public virtual bool Connected()
    {
        return connection.State == ConnectionState.Connecting;
    }

}