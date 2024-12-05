using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace dot_net_intro.Models
{
    public class dotNetContext
    {
        public string ConnectionString { get; set; }

        public dotNetContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}