using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.ServiceModel;

namespace Chapter4.Obj2
{
    public static class Listing_4_039
    {
        public static void RunMain()
        {

        }

        [ServiceContract]
        public interface IMyService
        {
            [OperationContract]
            string DoWork(string left, string right);
        }

        [ServiceContract]
        public class MyService
        {
            [OperationContract]
            public string DoWork(string left, string right)
            {
                return left + right;
            }
        }
    }
}