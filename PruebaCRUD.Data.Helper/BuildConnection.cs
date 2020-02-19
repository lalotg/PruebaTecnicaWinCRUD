﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.Data.Helper
{
    public class BuildConnection
    {
        public static string GetConnectionString(string m)
        {
            string meta = m;

            string initialCatalog = "Dinamicel";
            string host = "dinamidb.c7nmkzmey2sq.us-east-2.rds.amazonaws.com";
            string user = "admin";
            string password = "&45Hist0r14$";

            return BuildConnection.GetConnectionString(meta, initialCatalog, host, user, password);
        }

        private static string GetConnectionString(string meta, string initialCatalog, string host, string user, string password)
        {


            // building datasource developer or productive
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.InitialCatalog = initialCatalog;
            sqlBuilder.MultipleActiveResultSets = true;
            sqlBuilder.ApplicationName = "EntityFramework";
            sqlBuilder.UserID = user;
            sqlBuilder.Password = password;
            sqlBuilder.DataSource = host;

            // completing entity connection
            EntityConnectionStringBuilder efBuilder = new EntityConnectionStringBuilder();
            efBuilder.Metadata = meta;
            efBuilder.Provider = "System.Data.SqlClient";
            efBuilder.ProviderConnectionString = sqlBuilder.ConnectionString.Replace("\"", "&quot;");

            return efBuilder.ConnectionString;
        }
    }
}
