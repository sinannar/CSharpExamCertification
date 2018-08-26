using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net.Http;

/*
 
    C# has both, the is operator and the as operator that can be used to check whether a type
can be converted to another type and to do so in a safe way. The is operator returns true or
false, depending on whether the conversion is allowed. The as operator returns the converted
value or null if the conversion is not possible

     */

namespace CSharpLab.Chapter2.Objective2
{
    public static class Listing_2_27
    {
        public static void RunMain()
        {
           
        }

        class MyClass
        {
            void OpenConnection(DbConnection connection)
            {
                if (connection is SqlConnection)
                {
                    // run some special code
                }
            }

            void LogStream(Stream stream)
            {
                MemoryStream memoryStream = stream as MemoryStream;
                if (memoryStream != null)
                {
                    // ...
                }
            }
        }

        class SqlConnection : DbConnection
        {
            public override string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override string Database => throw new NotImplementedException();

            public override string DataSource => throw new NotImplementedException();

            public override string ServerVersion => throw new NotImplementedException();

            public override ConnectionState State => throw new NotImplementedException();

            public override void ChangeDatabase(string databaseName)
            {
                throw new NotImplementedException();
            }

            public override void Close()
            {
                throw new NotImplementedException();
            }

            public override void Open()
            {
                throw new NotImplementedException();
            }

            protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
            {
                throw new NotImplementedException();
            }

            protected override DbCommand CreateDbCommand()
            {
                throw new NotImplementedException();
            }
        }
    }
}
