// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Types
{
    public class ConnectionString : IConnectionString
    {
        //private Func<String, String> _PasswordDecoder;

        public String Server        { get; private set; }
        public String Database      { get; private set; }
        public String Login         { get; private set; }
        public IPassword Password   { get; private set; }
                
        public ConnectionString
            (String server, String database, String login,IPassword password)
        {
            Server   = server;
            Database = database;
            Login    = login;
            Password = password;
        }
       
        public string ToMSSQL()
        {          
            return String.Format
                (
                    "Data Source={0};" +
                    "Initial Catalog={1};" +
                    "User id={2};" +
                    "Password={3};",
                    Server,
                    Database,
                    Login,
                    Password?.GetValue()??String.Empty
                );
        }

    }
}
